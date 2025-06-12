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
using Guna.UI2.WinForms;

namespace PresentationLayer.Forms.FiltersForms
{
    public partial class StudentFilter : Form
    {
        public StudentFilter(int who)
        {
            InitializeComponent();
            _InitializeComboBoxes();
            _InitializeFonts();
            this.who = who;
        }

        public DataTable dt = new DataTable();
        public int who = -1;
        private void _InitializeFonts()
        {
            lblFirstname.Font = clsAppSettings.GetFont(1, 14);
            lblLastname.Font = clsAppSettings.GetFont(1, 14);
            lblEmail.Font = clsAppSettings.GetFont(1, 14);
            lblUsername.Font = clsAppSettings.GetFont(1, 14);
            lblIDnumber.Font = clsAppSettings.GetFont(1, 14);
            lblGender.Font = clsAppSettings.GetFont(1, 14);
            lblPhone.Font = clsAppSettings.GetFont(1, 14);
            lblID.Font = clsAppSettings.GetFont(1, 14);
            lblNationality.Font = clsAppSettings.GetFont(1, 14);
            lblStatus.Font = clsAppSettings.GetFont(1, 14);
            lblStudentCardNumber.Font = clsAppSettings.GetFont(1, 14);
            txtFirstname.Font = clsAppSettings.GetFont(1, 10);
            txtLastname.Font = clsAppSettings.GetFont(1, 10);
            txtEmail.Font = clsAppSettings.GetFont(1, 10);
            txtUsername.Font = clsAppSettings.GetFont(1, 10);
            txtIDnumber.Font = clsAppSettings.GetFont(1, 10);
            cbGender.Font = clsAppSettings.GetFont(1, 10);
            txtPhone.Font = clsAppSettings.GetFont(1, 10);
            nudID.Font = clsAppSettings.GetFont(1, 10);
            txtNationality.Font = clsAppSettings.GetFont(1, 10);
            cbStatus.Font = clsAppSettings.GetFont(1, 10);
            txtStudentCardNumber.Font = clsAppSettings.GetFont(1, 10);

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
        private void btnFilter_Click(object sender, EventArgs e)
        {

            dt = (who == 1) ?
                clsStudents.GetStudentsWitihSimple(
                (chkID.Checked) ? Convert.ToInt16(nudID.Value) : -1,
                (chkFirstname.Checked) ? txtFirstname.Text : "",
                (chkLastname.Checked) ? txtLastname.Text : "",
                (chkEmail.Checked) ? txtEmail.Text : "",
                (chkUsername.Checked) ? txtUsername.Text : "",
                (chkPhone.Checked) ? (cbCountrykeys.Text + " " + txtPhone.Text) : "",
                (chkGender.Checked) ? cbGender.Text : "",
                (chkNationality.Checked) ? txtNationality.Text : "",
                (chkIDnumber.Checked) ? txtIDnumber.Text : "",
                (chkStatus.Checked) ? cbStatus.SelectedIndex + 1 : -1,
                (chkStudentCardNumber.Checked) ? txtStudentCardNumber.Text : ""
                ):
                clsStudents.GetAllStudentsAllDataFilterd(

                    (chkID.Checked) ? Convert.ToInt16(nudID.Value) : -1,
                    (chkFirstname.Checked) ? txtFirstname.Text : "",
                    (chkLastname.Checked) ? txtLastname.Text : "",
                    (chkEmail.Checked) ? txtEmail.Text : "",
                    (chkUsername.Checked) ? txtUsername.Text : "",
                    (chkPhone.Checked) ? (cbCountrykeys.Text + " " + txtPhone.Text) : "",
                    (chkGender.Checked) ? cbGender.Text : "",
                    (chkNationality.Checked) ? txtNationality.Text : "",
                    (chkIDnumber.Checked) ? txtIDnumber.Text : "",
                    (chkStatus.Checked) ? cbStatus.SelectedIndex + 1 : -1,
                    (chkStudentCardNumber.Checked) ? txtStudentCardNumber.Text : ""

                    )
                ;

            this.Close();
        }

        private void cbChecked(object sender, EventArgs e)
        {
            Guna2CheckBox chk = (Guna2CheckBox)sender;
            switch (chk.Tag.ToString())
            {
                case "Firstname":

                    txtFirstname.Enabled = (chk.Checked);
                    break;

                case "Lastname":

                    txtLastname.Enabled = (chk.Checked);
                    break;

                case "Email":

                    txtEmail.Enabled = (chk.Checked);
                    break;

                case "Username":

                    txtUsername.Enabled = (chk.Checked);
                    break;

                case "IDnumber":

                    txtIDnumber.Enabled = (chk.Checked);
                    break;

                case "Gender":

                    cbGender.Enabled = (chk.Checked);
                    break;

                case "Phone":

                    txtPhone.Enabled = (chk.Checked);
                    cbCountrykeys.Enabled = (chk.Checked);
                    break;

                case "ID":
                    nudID.Enabled = (chk.Checked);
                    break;

                case "Nationality":
                    txtNationality.Enabled = (chk.Checked);
                    break;

                case "Status":
                    cbStatus.Enabled = (chk.Checked);
                    break;

                case "StudentCardNumber":

                    txtStudentCardNumber.Enabled = chk.Checked;
                    break;

                default:
                    return;
            }
        }

        private void StudentFilter_Load(object sender, EventArgs e)
        {
            
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            dt = (who == 1) ?
             clsStudents.GetStudentsWitihSimple(StatusID: 1) :
             clsStudents.GetAllStudentsAllData();

            this.Close();
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            dt = (who == 1) ?
             clsStudents.GetStudentsWitihSimple(StatusID: 1):
             clsStudents.GetAllStudentsAllData();

            this.Close();
        }

        private void guna2ControlBox1_Click(object sender, EventArgs e)
        {
            dt = (who == 1) ? 
                clsStudents.GetStudentsWitihSimple(StatusID: 1):
                clsStudents.GetAllStudentsAllData();
            this.Close();
        }

        private void guna2Panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
