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
using Guna.UI2.WinForms;

namespace PresentationLayer.Froms.AddUpdateForms
{
    public partial class AddUpdateDepartmentForm : Form
    {
        private int _SelectedID;
        private enum _enMode { eAdd, eUpdate, eView }
        private _enMode _Mode;
        public AddUpdateDepartmentForm(int SelectedID = -1, bool ViewMode = false)
        {
            InitializeComponent();
            _InitializeFonts();
            
            _SelectedID = SelectedID;

            if (SelectedID == -1)
            {
                _Mode = _enMode.eAdd;
            }
            else if (ViewMode)
            {
                _Mode = _enMode.eView;
            }
            else
            {
                _Mode = _enMode.eUpdate;
            }

        }
        private void _SetToViewMode()
        {
            lblHeader.Text = "View Department";

            pbPhoto.Enabled =
            txtName.Enabled =
            txtDescription.Enabled =
            txtLocation.Enabled =
            dtpOpenHoursFrom.Enabled =
            dtpOpenHoursTo.Enabled =
            nudMinimumAge.Enabled =
            nudSeatCount.Enabled = false;

            pnlMonday.Enabled =
            pnlTuesday.Enabled =
            pnlWednesday.Enabled =
            pnlThursday.Enabled =
            pnlFriday.Enabled =
            pnlSaturday.Enabled =
            pnlSunday.Enabled =
            lblMon.Enabled =
            lblTue.Enabled =
            lblWed.Enabled =
            lblThu.Enabled =
            lblFri.Enabled =
            lblSat.Enabled =
            lblSun.Enabled = false;

            btnAdd.Visible =
            btnCancel.Visible = false;

            
        }
        private void _LoadContent()
        {
            switch (_Mode)
            {
                case _enMode.eAdd:
                    lblHeader.Text = "Add Department";
                    btnAdd.Text = "Add";
                    break;

                case _enMode.eUpdate:
                    lblHeader.Text = "Update Department";
                    btnAdd.Text = "Update";
                    _LoadData();
                    break;
                case _enMode.eView:
                    _LoadData();
                    _SetToViewMode();
                    break ;
            }
        }
        public void _InitializeFonts()
        {
            txtName.Font = clsAppSettings.GetFont(1, 12);
            txtDescription.Font = clsAppSettings.GetFont(1, 12);
            txtLocation.Font = clsAppSettings.GetFont(1, 12);
            dtpOpenHoursFrom.Font = clsAppSettings.GetFont(1, 12);
            dtpOpenHoursTo.Font = clsAppSettings.GetFont(1, 12);
            nudMinimumAge.Font = clsAppSettings.GetFont(1, 12);
            nudSeatCount.Font = clsAppSettings.GetFont(1, 12);

            lblOpenFrom.Font = clsAppSettings.GetFont(1, 12);
            lblOpenTo.Font = clsAppSettings.GetFont(1, 12);
            lblMinimumAge.Font = clsAppSettings.GetFont(1, 12);
            lblOpenDays.Font = clsAppSettings.GetFont(1, 12);
            lblSeatCount.Font = clsAppSettings.GetFont(1, 12);

            

            lblMon.Font = 
            lblTue.Font = 
            lblWed.Font =
            lblThu.Font =
            lblFri.Font =
            lblSat.Font =
            lblSun.Font = clsAppSettings.GetFont(1, 14);

            btnCancel.Font = clsAppSettings.GetFont(2, 12);
            btnAdd.Font = clsAppSettings.GetFont(2, 12);

            

        }
        private void _LoadOpenDays(int OpenDays)
        {
            
            Color ColorYes = Color.FromArgb(229, 57, 53);
            Color ColorNo = Color.FromArgb(224, 224, 224);
            _OpenDays = OpenDays;

            pnlMonday.FillColor = (
                ((OpenDays &
                (int)clsGlobalVariables.enOpenDays.eMon) ==
                (int)clsGlobalVariables.enOpenDays.eMon) ?
                ColorYes : ColorNo
                );

            pnlTuesday.FillColor = (
                ((OpenDays &
                (int)clsGlobalVariables.enOpenDays.eTue) ==
                (int)clsGlobalVariables.enOpenDays.eTue) ?
                ColorYes : ColorNo
                );

            pnlWednesday.FillColor = (
                ((OpenDays &
                (int)clsGlobalVariables.enOpenDays.eWed) ==
                (int)clsGlobalVariables.enOpenDays.eWed) ?
                ColorYes : ColorNo
                );

            pnlThursday.FillColor = (
                ((OpenDays &
                (int)clsGlobalVariables.enOpenDays.eThu) ==
                (int)clsGlobalVariables.enOpenDays.eThu) ?
                ColorYes : ColorNo
                );

            pnlFriday.FillColor = (
                ((OpenDays &
                (int)clsGlobalVariables.enOpenDays.eFri) ==
                (int)clsGlobalVariables.enOpenDays.eFri) ?
                ColorYes : ColorNo
                );

            pnlSaturday.FillColor = (
                ((OpenDays &
                (int)clsGlobalVariables.enOpenDays.eSat) ==
                (int)clsGlobalVariables.enOpenDays.eSat) ?
                ColorYes : ColorNo
                );

            pnlSunday.FillColor = (
                ((OpenDays &
                (int)clsGlobalVariables.enOpenDays.eSun) ==
                (int)clsGlobalVariables.enOpenDays.eSun) ?
                ColorYes : ColorNo
                );

        }
        private void _LoadData()
        {
            clsDepartments department = clsDepartments.Find(ID: _SelectedID);

            _LoadOpenDays((int)department.get(clsDepartments.enDepartment.eOpenDays));
            txtName.Text = (string)department.get(clsDepartments.enDepartment.eName);
            txtDescription.Text = (string)department.get(clsDepartments.enDepartment.eDescription);
            txtLocation.Text = (string)department.get(clsDepartments.enDepartment.eLocation);
            dtpOpenHoursFrom.Value = DateTime.Today.Add((TimeSpan)department.get(clsDepartments.enDepartment.eOpenHoursFrom));
            dtpOpenHoursTo.Value = DateTime.Today.Add((TimeSpan)department.get(clsDepartments.enDepartment.eOpenHoursTo));
            nudMinimumAge.Value = Convert.ToInt16(department.get(clsDepartments.enDepartment.eMinimumAge));
            nudSeatCount.Value = Convert.ToInt16(department.get(clsDepartments.enDepartment.eSeatCount));
            pbPhoto.Image = clsDepartments.GetDepartmentImage(_SelectedID);
            pbPhoto.Tag = clsDepartments.GetDepartmentImagePath(_SelectedID);
        }
        private void AddUpdateDepartmentForm_Load(object sender, EventArgs e)
        {
            _LoadContent();
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

        private bool _ErrorFlag = false;
        ErrorProvider errorName = new ErrorProvider();
        private void txtName_Leave(object sender, EventArgs e)
        {
            string DepartmentName = txtName.Text;
            if (!clsDepartmentValidator.AddName(DepartmentName))
            {
                errorName.SetError(txtName, "DepartmentName is invalid. ");
                _ErrorFlag = true;
            }
            else if (clsDepartments.Find(Name:DepartmentName) != null)
            {
                errorName.SetError(txtName, "Department is already exists.");
                _ErrorFlag = true;
            }
            else
            {
                errorName.SetError(txtName, "");
                _ErrorFlag = false;
                
            }
        }

        ErrorProvider errorDescription = new ErrorProvider();
        private void txtDescription_Leave(object sender, EventArgs e)
        {
            if (!clsDepartmentValidator.AddDescription(txtDescription.Text))
            {
                errorDescription.SetError(txtDescription, "Description is invalid");
                _ErrorFlag = true;
            }
            else
            {
                errorDescription.SetError(txtDescription, "");
                _ErrorFlag = false;
            }

        }
        ErrorProvider errorLocation = new ErrorProvider();
        private void txtLocation_Leave(object sender, EventArgs e)
        {
            if (!clsDepartmentValidator.AddLocation(txtLocation.Text))
            {
                errorLocation.SetError(txtLocation, "Location is invalid");
                _ErrorFlag = true;
            }
            else
            {
                errorLocation.SetError(txtLocation, "");
                _ErrorFlag = false;
            }
        }


        int _OpenDays = 0;
        private void OpenDays_Click(object sender, EventArgs e)
        {
            Color ColorYes = Color.FromArgb(229, 57, 53);
            Color ColorNo = Color.FromArgb(224, 224, 224);
            Guna2Panel pnl = (Guna2Panel)sender;
            bool chkflag = pnl.FillColor == ColorYes;

            if (chkflag)
            {
                pnl.FillColor = ColorNo;

            }
            else
            {
                pnl.FillColor = ColorYes;
            }

            switch (pnl.Tag)
            {
                case "Mon":
                    _OpenDays += (chkflag ? -1 : 1) *
                        (int)clsGlobalVariables.enOpenDays.eMon; 
                    break;

                case "Tue":
                    _OpenDays += (chkflag ? -1 : 1) *
                        (int)clsGlobalVariables.enOpenDays.eTue;
                    break;

                case "Wed":
                    _OpenDays += (chkflag ? -1 : 1) *
                        (int)clsGlobalVariables.enOpenDays.eWed;
                    break;

                case "Thu":
                    _OpenDays += (chkflag ? -1 : 1) *
                        (int)clsGlobalVariables.enOpenDays.eThu;
                    break;

                case "Fri":
                    _OpenDays += (chkflag ? -1 : 1) *
                        (int)clsGlobalVariables.enOpenDays.eFri;
                    break;

                case "Sat":
                    _OpenDays += (chkflag ? -1 : 1) *
                        (int)clsGlobalVariables.enOpenDays.eSat;
                    break;

                case "Sun":
                    _OpenDays += (chkflag ? -1 : 1) *
                        (int)clsGlobalVariables.enOpenDays.eSun;
                    break;
            }
               
        }
        private void lblPressed(object sender, EventArgs e)
        {
            Guna2HtmlLabel lbl = (Guna2HtmlLabel)sender;
            switch (lbl.Text)
            {
                case "Mon": OpenDays_Click(pnlMonday, EventArgs.Empty); break;
                case "Tue": OpenDays_Click(pnlTuesday, EventArgs.Empty); break;
                case "Wed": OpenDays_Click(pnlWednesday, EventArgs.Empty); break;
                case "Thu": OpenDays_Click(pnlThursday, EventArgs.Empty); break;
                case "Fri": OpenDays_Click(pnlFriday, EventArgs.Empty); break;
                case "Sat": OpenDays_Click(pnlSaturday, EventArgs.Empty); break;
                case "Sun": OpenDays_Click(pnlSunday, EventArgs.Empty); break;
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (

                txtName.Text == null ||
                txtDescription.Text == null ||
                txtLocation.Text == null ||
                dtpOpenHoursFrom.Value.Ticks == 0 ||
                dtpOpenHoursTo.Value.Ticks == 0 ||
                nudMinimumAge.Value == 0 ||
                nudSeatCount.Value == 0

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
                clsDepartments dep;

                if (_Mode == _enMode.eAdd)
                    dep = new clsDepartments();
                else
                    dep = clsDepartments.Find(ID: _SelectedID);

                dep.set(
                       Name: txtName.Text,
                       Description: txtDescription.Text,
                       Location: txtLocation.Text,
                       OpenHoursFrom: dtpOpenHoursFrom.Value.TimeOfDay,
                       OpenHoursTo: dtpOpenHoursTo.Value.TimeOfDay,
                       MinimumAge: (int)nudMinimumAge.Value,
                       OpenDays: _OpenDays,
                       ImagePath: (pbPhoto.Tag != null) ? pbPhoto.Tag.ToString() : "",
                       SeatCount: (int)nudSeatCount.Value

                       );

                if (dep.Save())
                {
                    MessageBox.Show($"Department Saved successfully. ");
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Something went wrong while saving");
                }


            }
        }

        private void nudSeatCount_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
