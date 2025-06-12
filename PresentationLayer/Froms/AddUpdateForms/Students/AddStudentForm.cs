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

namespace PresentationLayer.Froms.AddUpdateForms
{
    public partial class AddStudentForm : Form
    {
        public AddStudentForm()
        {
            InitializeComponent();
            _InitializeComboBoxes();
            _InitializeFonts();
        }
        private bool _ErrorFlag = false;
        private void _InitializeFonts()
        {
            txtFirstname.Font = clsAppSettings.GetFont(1, 9);
            txtLastname.Font = clsAppSettings.GetFont(1, 9);
            cbGender.Font = clsAppSettings.GetFont(1, 9);
            txtEmail.Font = clsAppSettings.GetFont(1, 9);
            txtNationality.Font = clsAppSettings.GetFont(1, 9);
            dtpDateOfBirth.Font = clsAppSettings.GetFont(1, 9);
            txtUsername.Font = clsAppSettings.GetFont(1, 9);
            txtIDnumber.Font = clsAppSettings.GetFont(1, 9);
            txtPhone.Font = clsAppSettings.GetFont(1, 9);
            cbCountrykeys.Font = clsAppSettings.GetFont(1, 9);
            txtPassword1.Font = clsAppSettings.GetFont(1, 9);
            txtPassword2.Font = clsAppSettings.GetFont(1, 9);
            btnCancel.Font = clsAppSettings.GetFont(2, 16);
            btnAdd.Font = clsAppSettings.GetFont(2, 16);
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
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (

                txtFirstname.Text == null ||
                txtLastname.Text == null ||
                txtEmail.Text == null ||
                txtNationality.Text == null ||
                txtUsername.Text == null ||
                txtIDnumber.Text == null ||
                txtPhone.Text == null ||
                txtPassword1.Text == null ||
                txtPassword2.Text == null 
 

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
                clsStudents emp;

                emp = new clsStudents
                    (

                        txtFirstname.Text,
                        txtLastname.Text,
                        txtEmail.Text,
                        txtUsername.Text,
                        cbCountrykeys.Text.Split(' ')[0] + " " + txtPhone.Text,
                        cbGender.Text,
                        txtNationality.Text,
                        txtIDnumber.Text,
                        dtpDateOfBirth.Value.Date,
                        pbPhoto.Tag.ToString(),
                        2,
                        clsSecurity.RandomCardNumber(),
                        clsSecurity.HashPassword(txtPassword1.Text)

                    );

                if (emp.Save())
                {
                    MessageBox.Show("Student created successfully. ");
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Something went wrong while saving");
                }
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void AddStudentForm_Load(object sender, EventArgs e)
        {
            cbCountrykeys.DropDownStyle = ComboBoxStyle.DropDownList; 
            pbPhoto.Tag = "";
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


        ErrorProvider error = new ErrorProvider();
        private void txtEmail_Leave(object sender, EventArgs e)
        {
            if (clsEmployees.Find(Email: txtEmail.Text) != null)
            {
                error.SetError(txtEmail, "Email is already exists. ");
                _ErrorFlag = true;
            }
            else if (!clsEmployeeValidator.EnterEmail(txtEmail.Text))
            {
                error.SetError(txtEmail, "Email is invalid. ");
                _ErrorFlag = true;
            }
            else
            {
                error.SetError(txtEmail, "");
                _ErrorFlag = false;
            }
        }

        ErrorProvider PhoneError = new ErrorProvider();
        private void txtPhone_Leave(object sender, EventArgs e)
        {
            if (!clsEmployeeValidator.AddPhone(txtPhone.Text))
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

        private void chkView1_CheckedChanged(object sender, EventArgs e)
        {
            if (chkView1.Checked)
            {
                txtPassword1.UseSystemPasswordChar = true;
            }
            else
            {
                txtPassword1.UseSystemPasswordChar = false;
            }
        }

        private void chkView2_CheckedChanged(object sender, EventArgs e)
        {
            if (chkView2.Checked)
            {
                txtPassword2.UseSystemPasswordChar = true;
            }
            else
            {
                txtPassword2.UseSystemPasswordChar = false;
            }
        }

        ErrorProvider passerror = new ErrorProvider();
        private void txtPassword2_Leave(object sender, EventArgs e)
        {
            if (!clsEmployeeValidator.isPasswordMatch(txtPassword1.Text, txtPassword2.Text))
            {
                passerror.SetError(txtPassword2, "Passwords are not match.");
                _ErrorFlag = true;
            }
            else
            {
                passerror.SetError(txtPassword2, "");
                _ErrorFlag = false;
            }
        }

        ErrorProvider UsernameError = new ErrorProvider();
        private void txtUsername_TextChanged(object sender, EventArgs e)
        {
            if (clsEmployees.Find(Username: txtUsername.Text) != null)
            {
                UsernameError.SetError(txtUsername, "Username is already exists. ");
                _ErrorFlag = true;
            }
            else if (!clsEmployeeValidator.AddUsername(txtUsername.Text))
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
            if (clsEmployees.Find(IDnumber: txtIDnumber.Text) != null)
            {
                IDnumberError.SetError(txtIDnumber, "ID is already exists. ");
                _ErrorFlag = true;
            }
            else if (!clsEmployeeValidator.AddIDnumber(txtIDnumber.Text))
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
                NationalityError.SetError(txtNationality, "ID is inavalid");
                _ErrorFlag = true;
            }
            else
            {
                NationalityError.SetError(txtNationality, "");
                _ErrorFlag = false;
            }
        }

        ErrorProvider DateOfBirthEror = new ErrorProvider();
        private void dtpDateOfBirth_Leave(object sender, EventArgs e)
        {
            if (!clsEmployeeValidator.AddDateOfBirth(dtpDateOfBirth.Value))
            {
                DateOfBirthEror.SetError(dtpDateOfBirth, "You should be at least 7 years old");
                _ErrorFlag = true;
            }
            else
            {
                DateOfBirthEror.SetError(dtpDateOfBirth, "");
                _ErrorFlag = false;
            }
        }

    }
}
