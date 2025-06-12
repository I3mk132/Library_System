using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BussinesLayer;

namespace PresentationLayer.Froms.AddUpdateForms.Employees
{
    public partial class EditEmployeeForm : Form
    {
        private int _SelectedEmployeeID = -1;
        public EditEmployeeForm(int SelectedEmployeeID)
        {
            InitializeComponent();
            _InitializeFonts();
            _InitializeComboboxes();
            _SelectedEmployeeID = SelectedEmployeeID;
        }
        private void _InitializeFonts()
        {
            lblRole.Font =
            lblShift.Font =
            lblPermissions.Font =
            lblManagerID.Font =
            lblSalary.Font = clsAppSettings.GetFont(1, 14);

            cbDepartment.Font = clsAppSettings.GetFont(1, 12);
            cbRole.Font =
            cbShift.Font =
            nudManagerID.Font =
            txtSalary.Font = clsAppSettings.GetFont(1, 12);

            btnCancel.Font = clsAppSettings.GetFont(2, 12);
            btnSave.Font = clsAppSettings.GetFont(2, 12);

        }
        private void _InitializeComboboxes()
        {
            cbRole.Items.Clear();
            cbRole.Items.AddRange(new object[]{
                "Admin",
                "Employee",
                "Worker"
            });
            cbRole.SelectedIndex = 1;

            cbShift.Items.Clear();
            cbShift.Items.AddRange(new object[]
            {
                "08:00:00-15:59:59",
                "16:00:00-23:59:59",
                "00:00:00-07:59:59"
            });
            cbShift.SelectedIndex = 1;

            cbDepartment.Items.Clear();

            foreach (DataRow row in clsDepartments.GetAllDepartments().Rows)
            {
                cbDepartment.Items.Add(row["Name"].ToString());
            }
            cbDepartment.SelectedIndex = 0;
        }
        private void _LoadPermissions(int Permissions)
        {

            chkHome.Checked = (Permissions & (int)clsSecurity.enPermissions.MainMenu) != 0;
            chkStudents.Checked = (Permissions & (int)clsSecurity.enPermissions.Students) != 0;
            chkBooks.Checked = (Permissions & (int)clsSecurity.enPermissions.Books) != 0;
            chkStatics.Checked = (Permissions & (int)clsSecurity.enPermissions.Statics) != 0;
            chkProfile.Checked = (Permissions & (int)clsSecurity.enPermissions.Profile) != 0;

        }
        private void EditEmployeeForm_Load(object sender, EventArgs e)
        {
            clsEmployees employee = clsEmployees.Find(_SelectedEmployeeID);
            if (employee == null)
            {
                MessageBox.Show("Select an employee");
                this.Close();
            }
            txtSalary.Text = ((double)employee.get(clsEmployees.enEmployee.eSalary)).ToString();
            cbRole.SelectedIndex = (int)employee.get(clsEmployees.enEmployee.eRoleID) - 1;
            cbShift.SelectedIndex = (int)employee.get(clsEmployees.enEmployee.eShiftID) - 1;
            nudManagerID.Value = (int)employee.get(clsEmployees.enEmployee.eManagerID);
            cbDepartment.SelectedIndex = (int)employee.get(clsEmployees.enEmployee.eDepartmentID) - 1;

            _LoadPermissions((int)employee.get(clsEmployees.enEmployee.ePermissions));

        }

        private void chkHome_CheckedChanged(object sender, EventArgs e)
        {
            
        }

        private void chkStudents_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void chkBooks_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void chkStatics_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void chkProfile_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private int _CalculatePermissions()
        {
            int Num = 0;

            if (chkHome.Checked) Num += Convert.ToInt16(chkHome.Tag);
            if (chkStudents.Checked) Num += Convert.ToInt16(chkStudents.Tag);
            if (chkBooks.Checked) Num += Convert.ToInt16(chkBooks.Tag);
            if (chkStatics.Checked) Num += Convert.ToInt16(chkStatics.Tag);
            if (chkProfile.Checked) Num += Convert.ToInt16(chkProfile.Tag);

            return Num;
        }
        private void btnSave_Click(object sender, EventArgs e)
        {

            clsEmployees Employee = clsEmployees.Find(ID: _SelectedEmployeeID);

            Employee.setEmployee(
                Salary: Convert.ToDouble(txtSalary.Text),
                RoleID: clsEmployees.GetRoleIDByRole(cbRole.Text),
                ShiftID: cbShift.SelectedIndex + 1,
                ManagersID: Convert.ToInt16(nudManagerID.Value),
                Permissions: _CalculatePermissions(),
                DepartmentID: cbDepartment.SelectedIndex + 1

            );

            if (Employee.Save())
            {

                MessageBox.Show("Properities saved successfully.");
                this.Close();
            }
            else
                MessageBox.Show("Something went wrong while saving. ");
        }
    }
}
