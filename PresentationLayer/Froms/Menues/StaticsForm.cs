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
using BussinesLayer.ObjectClasses;
using PresentationLayer.Forms.FiltersForms;
using PresentationLayer.Froms.AdditionalForms;
using PresentationLayer.Froms.AddUpdateForms;
using PresentationLayer.Froms.AddUpdateForms.Employees;

namespace PresentationLayer.Forms
{
    public partial class StaticsForm : UserControl
    {
        public StaticsForm()
        {
            InitializeComponent();
            _InitializeDataGridViewStyles();
            _InitializeFonts();
            _ConfigPbarsAndCounters();
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
            _ApplyStyle(dgvAllStudents);
            _ApplyStyle(dgvAllBooks);
            _ApplyStyle(dgvAllEmployees);
            _ApplyStyle(dgvLogs);
        }
        private void _InitializeFonts()
        {
            lblAllStudentCount.Font = clsAppSettings.GetFont(1, 12);
            pnlpbar.Font = clsAppSettings.GetFont(1, 12);
            lblEmployeesOnShift.Font = clsAppSettings.GetFont(1, 12);
            lblDepartment.Font = clsAppSettings.GetFont(2, 12);
            lblStudentCount.Font = clsAppSettings.GetFont(1, 12);

            lblAllStudentCountN.Font = clsAppSettings.GetFont(2, 15);
            lblBorrowCountN.Font = clsAppSettings.GetFont(2, 15);
            lblinShiftCountN.Font = clsAppSettings.GetFont(2, 15);
            lblStudentCountN.Font = clsAppSettings.GetFont(2, 15);

            cbDepartment.Font = clsAppSettings.GetFont(1, 11);
            cbLogs.Font = clsAppSettings.GetFont(1, 12);
            lblAllEmployees.Font = clsAppSettings.GetFont(2, 14);
            btnAddEmployee.Font = clsAppSettings.GetFont(2, 14);

            lblAllBooks.Font = clsAppSettings.GetFont(2, 16);
            btnFilterBook.Font = clsAppSettings.GetFont(2, 14);
            btnAddBook.Font = clsAppSettings.GetFont(2, 14);
            lblAllStudents.Font = clsAppSettings.GetFont(2, 16);
            btnFilterStudent.Font = clsAppSettings.GetFont(2, 14);
            btnAddStudent.Font = clsAppSettings.GetFont(2, 14);

        }

        private void cmsBook_Opening(object sender, CancelEventArgs e)
        {

        }

        private int _depID = 0;
        private void _Loaddgv()
        {
            dgvAllEmployees.DataSource = clsEmployees.GetAllEmployees();
            dgvAllBooks.DataSource = clsCopys.GetAllCopysAllData();
            dgvAllStudents.DataSource = clsStudents.GetAllStudentsAllData();
        }
        private void _LoadFormData()
        {
            cbDepartment.Items.Clear();

            foreach (DataRow row in clsDepartments.GetAllDepartments().Rows)
            {
                cbDepartment.Items.Add(row["Name"].ToString());
            }
            cbDepartment.SelectedIndex = 0;

            cbLogs.Items.Clear();
            cbLogs.Items.AddRange(new object[]{

                "Borrow Logs",
                "Change Logs",
                "Error Logs",
                "SignUp Logs",
                "Login Logs"
            });
            cbLogs.SelectedIndex = 0;

            _Loaddgv();
        }
        private void StaticsForm_Load(object sender, EventArgs e)
        {
            _LoadFormData();
        }

        private void _ConfigPbarsAndCounters()
        {
            int BorrowCount = clsBorrows.GetBorrowsCount();
            int StudentCount = clsStudents.GetUnblockedStudentCount();
            int EmployeeInShiftCount = clsEmployees.GetAllEmployeesInShift().Rows.Count;
            int StudentsInDepCount = clsStudents.GetStudentsInDepartment(_depID).Rows.Count;
            int MaxBorrowCount = clsCopys.GetCopysCount();
            int MaxStudentCount = clsStudents.GetStudentCount();
            int MaxEmployees = clsEmployees.GetAllEmployees().Rows.Count;
            int MaxDepartmentSeatCount = clsDepartments.GetSeatCount(_depID);


            pbarAllBorrows.Maximum = MaxBorrowCount;
            pbarAllStudents.Maximum = MaxStudentCount;
            pbarEmployeesInShift.Maximum = MaxEmployees;
            pbarStudentsInDepartment.Maximum = MaxDepartmentSeatCount;

            pbarAllBorrows.Value = BorrowCount;
            pbarAllStudents.Value = StudentCount;
            pbarEmployeesInShift.Value = EmployeeInShiftCount;
            pbarStudentsInDepartment.Value = StudentsInDepCount;

            pbarAllBorrows.Text = $"{BorrowCount}/{MaxBorrowCount}";
            pbarAllStudents.Text = $"{StudentCount}/{MaxStudentCount}";
            pbarEmployeesInShift.Text = $"{EmployeeInShiftCount}/{MaxEmployees}";

            lblAllStudentCountN.Text = StudentCount.ToString();
            lblBorrowCountN.Text = BorrowCount.ToString();
            lblinShiftCountN.Text = EmployeeInShiftCount.ToString();
            lblStudentCountN.Text = $"{StudentsInDepCount}/{MaxDepartmentSeatCount}";


        }

        private void timer_Tick(object sender, EventArgs e)
        {
            _ConfigPbarsAndCounters();
        }

        private void btnAddEmployee_Click(object sender, EventArgs e)
        {
            SignupForm frm = new SignupForm(1);
            frm.ShowDialog();
            _Loaddgv();
        }

        private void btnAddBook_Click(object sender, EventArgs e)
        {
            AddBookForm frm = new AddBookForm();
            frm.ShowDialog();
            _Loaddgv();
        }

        private void btnAddStudent_Click(object sender, EventArgs e)
        {
            AddStudentForm frm = new AddStudentForm();
            frm.ShowDialog();
            _Loaddgv();
        }

        private void btnFilterBook_Click(object sender, EventArgs e)
        {
            BookFilter frm = new BookFilter();
            frm.ShowDialog();
            dgvAllBooks.DataSource = frm.dt;
            
        }

        private void btnFilterStudent_Click(object sender, EventArgs e)
        {
            StudentFilter frm = new StudentFilter(2);
            frm.ShowDialog();
            dgvAllStudents.DataSource = frm.dt;
        }

        private void cbDepartment_SelectedIndexChanged(object sender, EventArgs e)
        {
            _depID = clsDepartments.GetIDByName(cbDepartment.Text);
            lblDepartment.Text = cbDepartment.Text;
            pbarStudentsInDepartment.Image = clsDepartments.GetDepartmentImage(_depID);
            _ConfigPbarsAndCounters();
        }

        private void cbLogs_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (cbLogs.Text)
            {
                case "Borrow Logs": dgvLogs.DataSource = clsLogs.getAllBorrowLogs(); break;
                case "Change Logs": dgvLogs.DataSource = clsLogs.getAllChangeLogs(); break;
                case "Error Logs":  dgvLogs.DataSource = clsLogs.getAllErrorLogs(); break;
                case "SignUp Logs": dgvLogs.DataSource = clsLogs.getAllSignupLogs(); break;
                case "Login Logs":  dgvLogs.DataSource = clsLogs.GetAllLoginLogs(); break;
            }
        }

        private void cmsEmployeeProperities_Click(object sender, EventArgs e)
        {
            DataGridViewRow currentRow = dgvAllEmployees.CurrentRow;
            if (currentRow != null)
            {
                int cell = Convert.ToInt16(currentRow.Cells[0].Value);
                EditEmployeeForm frm = new EditEmployeeForm(cell);
                frm.ShowDialog();
            }
            _Loaddgv();
        }

        private void cmsEmployeeDelete_Click(object sender, EventArgs e)
        {
            DataGridViewRow currentRow = dgvAllEmployees.CurrentRow;
            if (currentRow != null)
            {
                int cell = Convert.ToInt16(currentRow.Cells[0].Value);
                if (MessageBox.Show($"Are you sure you want to delete [{cell}]?", "Delete", MessageBoxButtons.OKCancel) == DialogResult.OK)
                {
                    
                    if (clsEmployees.DeleteEmployee(cell))
                    {
                        MessageBox.Show($"Employee {cell} Deleted Successfully. ");
                    }
                    else
                    {
                        MessageBox.Show("Something went wrong while deleting. ");
                    }
                }
                
            }
            _Loaddgv();
        }

        private void cmsEmployeeViewTasks_Click(object sender, EventArgs e)
        {
            DataGridViewRow currentRow = dgvAllEmployees.CurrentRow;
            if (currentRow != null)
            {
                int cell = Convert.ToInt16(currentRow.Cells[0].Value);
                AddTaskForm frm = new AddTaskForm(cell);
                frm.ShowDialog();
            }
            _Loaddgv();
        }

        private void cmsStudentUpdate_Click(object sender, EventArgs e)
        {
            DataGridViewRow currentRow = dgvAllStudents.CurrentRow;
            if (currentRow != null)
            {
                int cell = Convert.ToInt16(currentRow.Cells[0].Value);
                StudentProfileForm frm = new StudentProfileForm(cell);
                frm.ShowDialog();
            }
            _Loaddgv();
        }

        private void cmsStudentDelete_Click(object sender, EventArgs e)
        {
            DataGridViewRow currentRow = dgvAllEmployees.CurrentRow;
            if (currentRow != null)
            {
                int cell = Convert.ToInt16(currentRow.Cells[0].Value);
                if (MessageBox.Show($"Are you sure you want to delete [{cell}]?", "Delete", MessageBoxButtons.OKCancel) == DialogResult.OK)
                {
                    if (clsStudents.DeleteStudent(cell))
                    {
                        MessageBox.Show($"Student {cell} Deleted Successfully. ");
                    }
                    else
                    {
                        MessageBox.Show("Something went wrong while deleting. ");
                    }
                }

            }
            _Loaddgv();
        }

        private void cmsBookDelete_Click(object sender, EventArgs e)
        {
            DataGridViewRow currentRow = dgvAllEmployees.CurrentRow;
            if (currentRow != null)
            {
                int cell = Convert.ToInt16(currentRow.Cells[0].Value);
                if (MessageBox.Show($"Are you sure you want to delete [{cell}]?","Delete", MessageBoxButtons.OKCancel) == DialogResult.OK)
                {
                    if (clsCopys.DeleteCopy(cell))
                    {
                        MessageBox.Show($"Copy {cell} Deleted Successfully. ");
                    }
                    else
                    {
                        MessageBox.Show("Something went wrong while deleting. ");
                    }
                }

            }
            _Loaddgv();
        }

        private void cmsDepartmentUpdate_Click(object sender, EventArgs e)
        {
            
            clsDepartments dep = clsDepartments.Find(Name: cbDepartment.Text);
            if (dep != null)
            {
                int ID = Convert.ToInt16(dep.get(clsDepartments.enDepartment.eID));
                AddUpdateDepartmentForm frm = new AddUpdateDepartmentForm(ID);
                frm.ShowDialog();
            }
            _Loaddgv();
        }

        private void cmsDepartmentDelete_Click(object sender, EventArgs e)
        {
            clsDepartments dep = clsDepartments.Find(Name: cbDepartment.Text);
            if (dep != null)
            {
                int ID = Convert.ToInt16(dep.get(clsDepartments.enDepartment.eID));
                if (MessageBox.Show($"Are you sure you want to delete [{dep.get(clsDepartments.enDepartment.eName)}]?",
                    "Delete", MessageBoxButtons.OKCancel) == DialogResult.OK)
                {
                    if (clsDepartments.DeleteDepartment(ID))
                    {
                        MessageBox.Show($"Department {ID} Deleted Successfully. ");
                    }
                    else
                    {
                        MessageBox.Show("Something went wrong while deleting. ");
                    }
                }

            }
            _LoadFormData();
        }

        private void cmsDepartmentAdd_Click(object sender, EventArgs e)
        {

            AddUpdateDepartmentForm frm = new AddUpdateDepartmentForm();
            frm.ShowDialog();

            _LoadFormData();
        }

        private void pbarStudentsInDepartment_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
