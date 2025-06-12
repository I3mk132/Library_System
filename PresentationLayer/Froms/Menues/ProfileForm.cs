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

namespace PresentationLayer.Forms.Menues
{
    public partial class ProfileForm : UserControl
    {
        public ProfileForm()
        {
            InitializeComponent();
            _InitializeFonts();
            _InitializeComboBoxes();
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

        private void _InitializeFonts()
        {
            // Headers
            lblEmployeeCardNumber.Font =
            lblInfo.Font = 
            lblPassword.Font = 
            lblSalary .Font = 
            lblRole.Font = 
            lblManager.Font = 
            lblWorkingDays.Font = clsAppSettings.GetFont(2, 18);

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
            cbCountrykeys.Font =
            txtPassword1.Font =
            txtPassword2.Font =
            txtPassword3.Font = clsAppSettings.GetFont(1, 12);

            // Days
            lblMon.Font =
            lblTue.Font =
            lblWed.Font =
            lblThu.Font =
            lblFri.Font =
            lblSat.Font =
            lblSun.Font = clsAppSettings.GetFont(2, 16);

            // Buttons
            btnSave.Font = clsAppSettings.GetFont(2, 16);
            btnReset.Font = clsAppSettings.GetFont(2, 16);
            btnDeleteAccount.Font = clsAppSettings.GetFont(2, 16);

        }
        private void _LoadUserData()
        {

            pbPhoto.Image = clsGlobalVariables.getImage();
            pbPhoto.Tag = clsGlobalVariables.getImagePath();
            pbQR.Image = clsCodeReadWrite.WriteQrCode(clsGlobalVariables.getEmployeeCardNumber(), 200);
            lblEmployeeCardNumber.Text = "Employee card number: " + clsGlobalVariables.getEmployeeCardNumber();
            txtFirstname.Text = clsGlobalVariables.getFirstname();
            txtLastname.Text = clsGlobalVariables.getLastname();
            cbGender.SelectedValue = clsGlobalVariables.getGender();
            dtpDateOfBirth.Value = clsGlobalVariables.getDateOfBirth().Value;
            txtIDnumber.Text = clsGlobalVariables.getIDnumber();
            txtNationality.Text = clsGlobalVariables.getNationality();
            txtEmail.Text = clsGlobalVariables.getEmail();
            txtUsername.Text = clsGlobalVariables.getUsername();
            txtPhone.Text = clsGlobalVariables.getPhone();
            cbCountrykeys.SelectedValue = clsGlobalVariables.getCountryCode();
            lblManager.Text = "Manager: " + clsGlobalVariables.getManagerName();
            lblSalary.Text = "Salary: " + clsGlobalVariables.getSalary().ToString();
            lblRole.Text = "Role: " + clsGlobalVariables.getRole();

            _LoadWorkingDays();

            txtPassword1.Text = "";
            txtPassword2.Text = "";
            txtPassword3.Text = "";

        }
        private void _LoadWorkingDays()
        {
            int WorkingDays = clsGlobalVariables.getWorkingDays();
            Color ColorYes = Color.FromArgb(229, 57, 53);
            Color ColorNo = Color.FromArgb(224, 224, 224);

            pnlMonday.FillColor = (
                ((WorkingDays &
                (int)clsGlobalVariables.enOpenDays.eMon) ==
                (int)clsGlobalVariables.enOpenDays.eMon) ?
                ColorYes : ColorNo
                );

            pnlTuesday.FillColor = (
                ((WorkingDays &
                (int)clsGlobalVariables.enOpenDays.eTue) ==
                (int)clsGlobalVariables.enOpenDays.eTue) ?
                ColorYes : ColorNo
                );

            pnlWednesday.FillColor = (
                ((WorkingDays &
                (int)clsGlobalVariables.enOpenDays.eWed) ==
                (int)clsGlobalVariables.enOpenDays.eWed) ?
                ColorYes : ColorNo
                );

            pnlThursday.FillColor = (
                ((WorkingDays &
                (int)clsGlobalVariables.enOpenDays.eThu) ==
                (int)clsGlobalVariables.enOpenDays.eThu) ?
                ColorYes : ColorNo
                );

            pnlFriday.FillColor = (
                ((WorkingDays &
                (int)clsGlobalVariables.enOpenDays.eFri) ==
                (int)clsGlobalVariables.enOpenDays.eFri) ?
                ColorYes : ColorNo
                );

            pnlSaturday.FillColor = (
                ((WorkingDays &
                (int)clsGlobalVariables.enOpenDays.eSat) ==
                (int)clsGlobalVariables.enOpenDays.eSat) ?
                ColorYes : ColorNo
                );

            pnlSunday.FillColor = (
                ((WorkingDays &
                (int)clsGlobalVariables.enOpenDays.eSun) ==
                (int)clsGlobalVariables.enOpenDays.eSun) ?
                ColorYes : ColorNo
                );
        }

        private void guna2ShadowPanel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void ProfileForm_Load(object sender, EventArgs e)
        {
            _LoadUserData();
        }

        private void btnDeleteAccount_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show(
                "Are you sure you want to DELETE the account?",
                "DELETE",
                MessageBoxButtons.OKCancel,
                MessageBoxIcon.Warning,
                MessageBoxDefaultButton.Button1) ==
                DialogResult.OK)
            {

                if (clsEmployees.DeleteEmployee(clsGlobalVariables.getID()))
                {
                    MessageBox.Show("User deleted successfully. ");
                    Application.Exit();
                }
                else
                    MessageBox.Show("Something went wrong while deleting. ");
            }

        }

        private bool _ErrorFlag = false;
        private void btnSave_Click(object sender, EventArgs e)
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
                txtPassword2.Text == null ||
                txtPassword3.Text == null 
                

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

                clsGlobalVariables.setEmployee(

                    Firstname: txtFirstname.Text,
                    Lastname: txtLastname.Text,
                    Email: txtEmail.Text,
                    Password: clsSecurity.HashPassword(txtPassword2.Text),
                    Username: txtUsername.Text,
                    Phone: cbCountrykeys.Text.Split(' ')[0] + " " + txtPhone.Text,
                    Gender: cbGender.Text,
                    Nationality: txtNationality.Text,
                    IDnumber: txtIDnumber.Text,
                    DateOfBirth: dtpDateOfBirth.Value.Date,
                    ImagePath: pbPhoto.Tag.ToString()
                    
                );
                
                if (clsGlobalVariables.CurrentEmployee.Save())
                {
                    MessageBox.Show("Employee saved successfully. ");
                    _LoadUserData();
                }
                else
                {
                    MessageBox.Show("Something went wrong while saving");
                }

            }
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
                if (txtEmail.Text != clsGlobalVariables.getEmail())
                {
                    error.SetError(txtEmail, "Email is already exists. ");
                    _ErrorFlag = true;
                }
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
        private void chkView3_CheckedChanged(object sender, EventArgs e)
        {
            txtPassword3.UseSystemPasswordChar = chkView3.Checked;
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

        ErrorProvider passerror2 = new ErrorProvider();
        private void txtPassword3_Leave(object sender, EventArgs e)
        {
            if (!clsEmployees.CheckPassword(clsGlobalVariables.CurrentEmployee, txtPassword3.Text))
            {
                passerror2.SetError(txtPassword3, "Old password is wrong! ");
                _ErrorFlag = true;
            }
            else
            {
                passerror2.SetError(txtPassword3, "");
                _ErrorFlag = false;
            }
        }

        ErrorProvider UsernameError = new ErrorProvider();
        private void txtUsername_TextChanged(object sender, EventArgs e)
        {
            if (clsEmployees.Find(Username: txtUsername.Text) != null)
            {
                if (txtUsername.Text != clsGlobalVariables.getUsername())
                {
                    UsernameError.SetError(txtUsername, "Username is already exists. ");
                    _ErrorFlag = true;
                }
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
                if (txtIDnumber.Text != clsGlobalVariables.getIDnumber())
                {
                    IDnumberError.SetError(txtIDnumber, "ID is already exists. ");
                    _ErrorFlag = true;
                }
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
                NationalityError.SetError(txtNationality, "Nationality is inavalid");
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
