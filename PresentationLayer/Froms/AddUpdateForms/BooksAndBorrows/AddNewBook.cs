using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Web.UI.WebControls;
using System.Windows.Forms;
using BussinesLayer;
using BussinesLayer.Validators;
using Guna.UI2.WinForms;
using PresentationLayer.Froms.AddUpdateForms.BooksAndBorrows;

namespace PresentationLayer.Froms.AddUpdateForms.AddBookPanel
{
    public partial class AddNewBook : UserControl
    {
        public event EventHandler<clsBooks> DataEntered;
        public AddNewBook()
        {
            InitializeComponent();
            _InitializeFonts();
        }
        public clsBooks book = new clsBooks();


        private void _InitializeFonts()
        {
            lblBookInfo.Font = clsAppSettings.GetFont(2, 14);
            dtpPublicationDate.Font = clsAppSettings.GetFont(1, 10);
            txtTitle.Font = clsAppSettings.GetFont(1, 10);
            txtAuthor.Font = clsAppSettings.GetFont(1, 10);
            txtGenre.Font = clsAppSettings.GetFont(1, 10);
            txtISBN.Font = clsAppSettings.GetFont(1, 10);
            txtDetails.Font = clsAppSettings.GetFont(1, 10);

        }
        private void _SearchBook()
        {
            book = clsBooks.SearchBook(txtISBN.Text);

            txtTitle.Text =
                book.getBookData(clsBooks.enBook.eTitle).ToString();

            txtAuthor.Text =
                book.getBookData(clsBooks.enBook.eAuthor).ToString();

            txtGenre.Text =
                book.getBookData(clsBooks.enBook.eGenre).ToString();

            txtDetails.Text =
                book.getBookData(clsBooks.enBook.eDetails).ToString();

            DateTime dt = (DateTime)book.getBookData(clsBooks.enBook.ePublicationDate);
            try
            {
                dtpPublicationDate.Value = dt;
            }
            catch
            {
                dtpPublicationDate.Value = dtpPublicationDate.MaxDate.AddDays(-20).Date;
            }



            pbISBNbarcode.Image = clsCodeReadWrite.WriteBarcode(txtISBN.Text, 202, 83);


        }

        private void AddNewBook_Load(object sender, EventArgs e)
        {
            dtpPublicationDate.MaxDate = DateTime.Now.Date;
            dtpPublicationDate.MinDate = dtpPublicationDate.MaxDate.AddYears(-100).Date;
            book.setBook(PublicationDate: dtpPublicationDate.Value.Date);
            DataEntered?.Invoke(this, book);

        }

        private void pbPhoto_Click(object sender, EventArgs e)
        {
            if (pbPhoto.Image != null)
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
                    pbPhoto.Image = null;
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
                pbPhoto.Image = System.Drawing.Image.FromFile(ImagePath);
                pbPhoto.SizeMode = PictureBoxSizeMode.StretchImage;
                ImagePath = ImagePath.Substring(ImagePath.IndexOf(@"\ExampleImages"));
                pbPhoto.Tag = ImagePath;
            }

            book.setBook(ImagePath: ImagePath);
            DataEntered?.Invoke(this, book);
        }


        ErrorProvider TitleError = new ErrorProvider();
        private void txtTitle_TextChanged(object sender, EventArgs e)
        {
            if (!clsBookValidator.AddTitle(txtTitle.Text))
            {

                TitleError.SetError(txtTitle, "Title is Invalid.");
            }
            else if (clsBooks.isBookExists(txtTitle.Text))
            {
                TitleError.SetError(txtTitle, "Title is already exists.");
            }
            else
            {
                TitleError.SetError(txtTitle, "");
                book.setBook(Title: txtTitle.Text);
                DataEntered?.Invoke(this, book);

            }

        }

        ErrorProvider AuthorError = new ErrorProvider();
        private void txtAuthor_TextChanged(object sender, EventArgs e)
        {
            if (!clsBookValidator.AddAuthor(txtAuthor.Text))
            {
                AuthorError.SetError(txtAuthor, "Author is invalid.");
            }
            else
            {
                AuthorError.SetError(txtAuthor, "");
                book.setBook(Author: txtAuthor.Text);
                DataEntered?.Invoke(this, book);
            }
        }

        ErrorProvider GenreError = new ErrorProvider();

        private void txtGenre_TextChanged(object sender, EventArgs e)
        {
            if (!clsBookValidator.AddGenre(txtGenre.Text))
            {
                GenreError.SetError(txtGenre, "Genre is invalid.");
            }
            else
            {
                GenreError.SetError(txtGenre, "");
                book.setBook(Genre: txtGenre.Text);
                DataEntered?.Invoke(this, book);
            }
        }

        ReadBarcodeForm frm = new ReadBarcodeForm();
        private void pbISBNbarcode_Click(object sender, EventArgs e)
        {
            
            frm.ShowDialog();

            if (frm.bitmap != null && frm.code != "")
            {
                txtISBN.Text = frm.code;
                _SearchBook();
                DataEntered?.Invoke(this, book);
            }
        }

        ErrorProvider DetailsError = new ErrorProvider();
        private void txtDetails_TextChanged(object sender, EventArgs e)
        {
            if (!clsBookValidator.AddDetails(txtDetails.Text))
            {
                DetailsError.SetError(txtDetails, "Details is invalid.");
            }
            else
            {
                DetailsError.SetError(txtDetails, "");
                book.setBook(Details: txtDetails.Text);
                DataEntered?.Invoke(this, book);
            }
        }

        ErrorProvider ISBNError = new ErrorProvider();

        private void txtISBN_TextChanged(object sender, EventArgs e)
        {
            if (!clsBookValidator.AddISBN(txtISBN.Text))
            {
                ISBNError.SetError(txtISBN, "ISBN is invalid");
            }
            else if (clsBooks.isBookExists(txtISBN.Text))
            {
                ISBNError.SetError(txtISBN, "ISBN is already exists");
            }
            else
            {
                ISBNError.SetError(txtISBN, "");
                book.setBook(ISBN: txtISBN.Text);
                DataEntered?.Invoke(this, book);
            }

        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            _SearchBook();
            DataEntered?.Invoke(this, book);
        }



        private void dtpPublicationDate_ValueChanged(object sender, EventArgs e)
        {
            book.setBook(PublicationDate: dtpPublicationDate.Value.Date);
            DataEntered?.Invoke(this, book);

        }
    }
}
