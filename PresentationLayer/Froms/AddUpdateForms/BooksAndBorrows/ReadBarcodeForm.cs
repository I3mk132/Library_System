using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using AForge.Video;
using AForge.Video.DirectShow;
using System.Threading.Tasks;
using System.Windows.Forms;
using ZXing;
using BussinesLayer;



namespace PresentationLayer.Froms.AddUpdateForms.BooksAndBorrows
{
    public partial class ReadBarcodeForm : Form
    {
        public ReadBarcodeForm()
        {
            InitializeComponent();
            _InitializeFonts();
            _StartCamera();
        }

        private FilterInfoCollection videoDevices;
        private VideoCaptureDevice videoSource;
        public Bitmap bitmap = null;
        public string code = "";

        private void _InitializeFonts()
        {
            txtClickToAddManually.Font = clsAppSettings.GetFont(1, 16);
            btnConfirm.Font = clsAppSettings.GetFont(2, 20);
        }

        private void _StartCamera()
        {
            videoDevices = new FilterInfoCollection(FilterCategory.VideoInputDevice);
            if (videoDevices.Count == 0)
            {
                MessageBox.Show("No camera found");
                return;
            }

            videoSource =
                new VideoCaptureDevice(
                    videoDevices[videoDevices.Count - 1].MonikerString
                    );
            videoSource.NewFrame += new NewFrameEventHandler(Video_NewFrame);
            videoSource.Start();
        }


        private void Video_NewFrame(object sender, NewFrameEventArgs eventArgs)
        {

            try
            {
                // Clone the frame immediately
                Bitmap frame = (Bitmap)eventArgs.Frame.Clone();

                // Use a clone for UI display to avoid cross-thread access issues
                Bitmap uiFrame = (Bitmap)frame.Clone();
                pbVideo.Invoke((MethodInvoker)delegate
                {
                    // Dispose old image to prevent memory leaks
                    if (pbVideo.Image != null)
                        pbVideo.Image.Dispose();

                    pbVideo.Image = uiFrame;
                });

                // Set up the reader
                BarcodeReader reader = new BarcodeReader
                {
                    AutoRotate = true,
                    TryInverted = true,
                    Options = new ZXing.Common.DecodingOptions
                    {
                        PossibleFormats = new List<BarcodeFormat> { BarcodeFormat.EAN_13 },
                        TryHarder = true
                    }
                };

                // Decode the frame
                var result = reader.Decode(frame);

                if (result != null)
                {
                    // Save result
                    this.bitmap = (Bitmap)frame.Clone();
                    this.code = result.Text;

                    // Show detected barcode image safely
                    pbBarcode.Invoke((MethodInvoker)delegate
                    {
                        if (pbBarcode.Image != null)
                            pbBarcode.Image.Dispose();

                        pbBarcode.Image =
                        clsCodeReadWrite.WriteBarcode(this.code, 221, 95);
                    });

                    // Stop the camera
                    if (videoSource != null && videoSource.IsRunning)
                    {
                        videoSource.SignalToStop();
                        videoSource.NewFrame -= Video_NewFrame;
                        pbVideo.Image = null;
                    }
                }

                // Clean up
                frame.Dispose();
            }
            catch
            {

            }
        }

        private void pbVideo_Click(object sender, EventArgs e)
        {
            if (videoSource != null && videoSource.IsRunning)
                return;
            _StartCamera();
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            if (videoSource != null && videoSource.IsRunning)
                videoSource.SignalToStop();
            this.Close();
        }

        private void pbBarcode_Click(object sender, EventArgs e)
        {
            if (pbBarcode.Image != null)
            {
                if (
                    MessageBox.Show(
                    " Are you sure you want to remove the Photo?  ",
                    "Remove Photo",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question,
                    MessageBoxDefaultButton.Button1) == DialogResult.Yes
                    )
                {
                    pbBarcode.Image = null;

                }
                else
                {
                    return;
                }
            }
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Title = "Select a photo: ";
            dialog.Filter = "Image Files (*.jpg;*.jpeg;*.png;*.bmp)|*.jpg;*.jpeg;*.png;*.bmp";
            dialog.Multiselect = false;

            string ImagePath = "";
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                ImagePath = dialog.FileName;
                pbBarcode.Image = Image.FromFile(ImagePath);
                pbBarcode.SizeMode = PictureBoxSizeMode.StretchImage;
                pbBarcode.Tag = ImagePath;

                if (videoSource != null && videoSource.IsRunning)
                    videoSource.SignalToStop();
            }
        }

        private void ReadBarcodeForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (videoSource != null)
            {
                if (videoSource.IsRunning)
                {
                    videoSource.SignalToStop();
                    videoSource.WaitForStop(); // Wait for the camera to fully stop
                }

                videoSource.NewFrame -= Video_NewFrame;
                videoSource = null;
            }

            if (pbVideo.Image != null)
            {
                pbVideo.Image.Dispose();
                pbVideo.Image = null;
            }

            if (pbBarcode.Image != null)
            {
                pbBarcode.Image.Dispose();
                pbBarcode.Image = null;
            }
        }

        private void ReadBarcodeForm_Load(object sender, EventArgs e)
        {

        }
    }
}
    