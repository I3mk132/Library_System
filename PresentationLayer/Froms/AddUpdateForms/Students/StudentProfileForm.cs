using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BussinesLayer;
using BussinesLayer.Validators;

namespace PresentationLayer.Froms.AdditionalForms
{
    public partial class StudentProfileForm : Form
    {
        private int _SelectedStudentID = -1;
        public StudentProfileForm(int SelectedID)
        {
            InitializeComponent();
            _InitializeComboBoxes();
            _InitializeDataGridViewStyles();
            _InitializeFonts();
            _SelectedStudentID = SelectedID;
        }

        private void _ApplyStyle(Guna.UI2.WinForms.Guna2DataGridView dgv)
        {
            // Header height
            dgv.ColumnHeadersHeight = 26;

            // Row height
            dgv.RowTemplate.Height = 22;

            // Fonts (assuming your GetFont method is accessible statically)
            dgv.ColumnHeadersDefaultCellStyle.Font = clsAppSettings.GetFont(1, 11);
            dgv.DefaultCellStyle.Font = clsAppSettings.GetFont(0, 10);
            dgv.AlternatingRowsDefaultCellStyle.Font = clsAppSettings.GetFont(0, 10);

            // Colors
            dgv.BackgroundColor = Color.FromArgb(238, 238, 238);
            dgv.DefaultCellStyle.BackColor = Color.FromArgb(238, 238, 238);
            dgv.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(229, 57, 53);
            dgv.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;

            dgv.DefaultCellStyle.SelectionBackColor = Color.FromArgb(255, 128, 128);
            dgv.DefaultCellStyle.SelectionForeColor = Color.Black;

            // Border and appearance
            dgv.EnableHeadersVisualStyles = false;
            dgv.BorderStyle = BorderStyle.None;
            dgv.GridColor = Color.LightGray;

            dgv.AllowUserToAddRows = false;

            dgv.ClearSelection();
        }
        private void _InitializeDataGridViewStyles()
        {
            _ApplyStyle(dgvBorrows);
        }
        private void _InitializeComboBoxes()
        {
            cbGender.Items.AddRange(new object[]
            {
                "Male",
                "Female"
            });
            cbGender.SelectedIndex = 0;
            cbCountrykeys.Items.AddRange(new object[]
            {
                "+1 USA",
                "+44 UK",
                "+49 GER",
                "+33 FRA",
                "+34 ESP",
                "+39 ITA",
                "+81 JPN",
                "+82 KOR",
                "+86 CHN",
                "+91 IND",
                "+92 PAK",
                "+966 KSA",
                "+971 UAE",
                "+964 IRQ",
                "+20 EGY",
                "+90 TUR",
                "+212 MAR",
                "+254 KEN",
                "+27 RSA",
                "+7 RUS",
                "+380 UKR",
                "+61 AUS",
                "+64 NZL",
                "+351 POR",
                "+46 SWE",
                "+47 NOR",
                "+45 DEN",
                "+48 POL",
                "+36 HUN",
                "+30 GRE",
                "+421 SVK",
                "+420 CZE",
                "+963 SYR",
                "+961 LBN",
                "+962 JOR"
            });
            cbCountrykeys.SelectedIndex = 0;

            cbStatus.Items.AddRange(new object[]
            {

                "InLibrary",
                "OutOfLibrary",
                "Blocked"

            });
            cbStatus.SelectedIndex = 0;
        }

        private void _InitializeFonts()
        {
            // Headers
            lblStudantCardNumber.Font = clsAppSettings.GetFont(2, 16);
            lblInfo.Font = 
            lblStatus.Font =
            lblBorrows.Font = clsAppSettings.GetFont(2, 18);

            // text boxes
            txtFirstname.Font =
            txtLastname.Font =
            cbGender.Font =
            dtpDateOfBirth.Font =
            txtIDnumber.Font =
            txtNationality.Font =
            txtEmail.Font =
            txtUsername.Font =
            txtPhone.Font =
            cbCountrykeys.Font = clsAppSettings.GetFont(1, 12);


            // Buttons
            btnSave.Font = clsAppSettings.GetFont(2, 16);
            btnReset.Font = clsAppSettings.GetFont(2, 16);

        }

        private void _Loaddgv()
        {
            dgvBorrows.DataSource = clsBorrows.GetBorrowsWith(StudentID: _SelectedStudentID);
        }
        private void _LoadData()
        {
            clsStudents student = clsStudents.Find(_SelectedStudentID);

            pbPhoto.Image = clsStudents.GetStudenttImage(
                _SelectedStudentID);
            pbPhoto.Tag = clsStudents.GetStudentImagePath(
                _SelectedStudentID);
            pbQR.Image = clsCodeReadWrite.WriteQrCode(
                (string)student.get(clsStudents.enStudent.eStudentCardNumber),
                195);
            lblStudantCardNumber.Text = "Student card number: " +
                (string)student.get(
                    clsStudents.enStudent.eStudentCardNumber);
            txtFirstname.Text = (string)student.get(
                clsStudents.enStudent.eFirstname);
            txtLastname.Text = (string)student.get(
                clsStudents.enStudent.eLastname);
            cbGender.SelectedValue = (string)student.get(
                clsStudents.enStudent.eGender);
            dtpDateOfBirth.Value = ((DateTime?)student.get(
                clsStudents.enStudent.eDateOfBirth)).Value;
            txtIDnumber.Text = (string)student.get(
                clsStudents.enStudent.eIDnumber);
            txtNationality.Text = (string)student.get(
                clsStudents.enStudent.eNationality);
            txtEmail.Text = (string)student.get(
                clsStudents.enStudent.eEmail);
            txtUsername.Text = (string)student.get(
                clsStudents.enStudent.eUsername);
            txtPhone.Text = ((string)student.get(
                clsStudents.enStudent.ePhone)).Split(' ')[1];
            cbCountrykeys.SelectedValue = ((string)student.get(
                clsStudents.enStudent.ePhone)).Split(' ')[0];
            cbStatus.SelectedIndex = (int) student.get(
                    clsStudents.enStudent.eStatus) - 1;

            _Loaddgv();
        }
        private void StudentProfileForm_Load(object sender, EventArgs e)
        {
            _LoadData();
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
                pbPhoto.Image = Image.FromFile(ImagePath);
                pbPhoto.SizeMode = PictureBoxSizeMode.StretchImage;
                ImagePath = ImagePath.Substring(ImagePath.IndexOf(@"\ExampleImages"));
                pbPhoto.Tag = ImagePath;
            }
        }

        bool _ErrorFlag = false;
        private void btnSave_Click(object sender, EventArgs e)
        {
            if (

                txtFirstname.Text == null ||
                txtLastname.Text == null ||
                txtEmail.Text == null ||
                txtNationality.Text == null ||
                txtUsername.Text == null ||
                txtIDnumber.Text == null ||
                txtPhone.Text == null 

                )
            {
                MessageBox.Show("Fill all Data Please. ");
                return;
            }
            else if (_ErrorFlag)
            {
                MessageBox.Show("Fix the provided errors please. ");
                return;
            }
            else
            {
                clsStudents student = clsStudents.Find(ID: _SelectedStudentID);
                student.setStudent(

                    Firstname: txtFirstname.Text,
                    Lastname: txtLastname.Text,
                    Email: txtEmail.Text,
                    Username: txtUsername.Text,
                    Phone: cbCountrykeys.Text.Split(' ')[0] + " " + txtPhone.Text,
                    Gender: cbGender.Text,
                    Nationality: txtNationality.Text,
                    IDnumber: txtIDnumber.Text,
                    DateOfBirth: dtpDateOfBirth.Value.Date,
                    ImagePath: pbPhoto.Tag.ToString(),
                    StatusID: cbStatus.SelectedIndex + 1

                );

                if (student.Save())
                {
                    MessageBox.Show("Student saved successfully. ");
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Something went wrong while saving");
                }

            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            _LoadData();
        }

        ErrorProvider errorEmail = new ErrorProvider();
        private void txtEmail_Leave(object sender, EventArgs e)
        {
            if (clsStudents.Find(Email: txtEmail.Text) != null)
            {
                if (txtEmail.Text != clsStudents.GetEmail(_SelectedStudentID))
                {
                    errorEmail.SetError(txtEmail, "Email is already exists. ");
                    _ErrorFlag = true;
                }
            }
            else if (!clsStudentValidator.AddEmail(txtEmail.Text))
            {
                errorEmail.SetError(txtEmail, "Email is invalid. ");
                _ErrorFlag = true;
            }
            else
            {
                errorEmail.SetError(txtEmail, "");
                _ErrorFlag = false;
            }
        }

        ErrorProvider PhoneError = new ErrorProvider();
        private void txtPhone_Leave(object sender, EventArgs e)
        {
            if (!clsStudentValidator.AddPhone(txtPhone.Text))
            {
                PhoneError.SetError(txtPhone, "This option is manditory");
                _ErrorFlag = true;
            }
            else
            {
                PhoneError.SetError(txtPhone, "");
                _ErrorFlag = false;
            }

        }
        private void txtPhone_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        ErrorProvider UsernameError = new ErrorProvider();
        private void txtUsername_TextChanged(object sender, EventArgs e)
        {
            if (clsStudents.Find(Username: txtUsername.Text) != null)
            {
                if (txtUsername.Text != clsStudents.GetUsername(_SelectedStudentID))
                {
                    UsernameError.SetError(txtUsername, "Username is already exists. ");
                    _ErrorFlag = true;
                }
            }
            else if (!clsStudentValidator.AddUsername(txtUsername.Text))
            {
                UsernameError.SetError(txtUsername, "Username is invalid");
                _ErrorFlag = true;
            }
            else
            {
                UsernameError.SetError(txtUsername, "");
                _ErrorFlag = false;
            }
        }

        ErrorProvider FirstnameError = new ErrorProvider();
        private void txtFirstname_Leave(object sender, EventArgs e)
        {
            if (txtFirstname.Text.Length < 3)
            {
                FirstnameError.SetError(txtFirstname, "This Option is manditory. ");
                _ErrorFlag = true;
            }
            else
            {
                FirstnameError.SetError(txtFirstname, "");
                _ErrorFlag = false;
            }
        }

        ErrorProvider LastnameError = new ErrorProvider();
        private void txtLastname_Leave(object sender, EventArgs e)
        {
            if (txtLastname.Text.Length < 3)
            {
                LastnameError.SetError(txtLastname, "This Option is manditory. ");
                _ErrorFlag = true;
            }
            else
            {
                LastnameError.SetError(txtLastname, "");
                _ErrorFlag = false;
            }
        }

        ErrorProvider IDnumberError = new ErrorProvider();
        private void txtIDnumber_Leave(object sender, EventArgs e)
        {
            if (clsStudents.Find(IDnumber: txtIDnumber.Text) != null)
            {
                if (txtIDnumber.Text != clsStudents.GetIDnumber(_SelectedStudentID))
                {
                    IDnumberError.SetError(txtIDnumber, "ID is already exists. ");
                    _ErrorFlag = true;
                }
            }
            else if (!clsStudentValidator.AddIDnumber(txtIDnumber.Text))
            {
                IDnumberError.SetError(txtIDnumber, "ID is inavalid");
                _ErrorFlag = true;
            }
            else
            {
                IDnumberError.SetError(txtIDnumber, "");
                _ErrorFlag = false;
            }

        }

        ErrorProvider NationalityError = new ErrorProvider();
        private void txtNationality_Leave(object sender, EventArgs e)
        {
            if (!clsEmployeeValidator.AddNationality(txtNationality.Text))
            {
                NationalityError.SetError(txtNationality, "Nationality is inavalid");
                _ErrorFlag = true;
            }
            else
            {
                NationalityError.SetError(txtNationality, "");
                _ErrorFlag = false;
            }
        }

    }
}
