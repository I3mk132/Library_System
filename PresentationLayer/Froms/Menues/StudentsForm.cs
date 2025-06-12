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
using PresentationLayer.Froms.AdditionalForms;
using PresentationLayer.Froms.AddUpdateForms;
using PresentationLayer.Froms.AddUpdateForms.Employees;

namespace PresentationLayer.Forms
{
    public partial class StudentsForm : UserControl
    {
        public StudentsForm()
        {
            InitializeComponent();
            _InitializeFonts();
            _Loaddgv();
            _InitializeDatagridviewStyles();
        }
        private void _ApplyStyle(Guna.UI2.WinForms.Guna2DataGridView dgv)
        {
            // Header height
            dgv.ColumnHeadersHeight = 26;

            // Row height
            dgv.RowTemplate.Height = 22;

            // Fonts (assuming your GetFont method is accessible statically)
            dgv.ColumnHeadersDefaultCellStyle.Font = clsAppSettings.GetFont(1, 8);
            dgv.DefaultCellStyle.Font = clsAppSettings.GetFont(0, 8);

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
            dgv.AllowUserToResizeRows = false;


            // Make first column(s) smaller
            if (dgv.Columns.Count > 0)
            {
                dgv.Columns[0].Width = 30;
                // dgv.Columns[1].Width = 100; // Optional
            }


        }

        private void _InitializeFonts()
        {
            lblStudentsInsideLibrary.Font = clsAppSettings.GetFont(2, 16);
            lblBlockedStudents.Font = clsAppSettings.GetFont(2, 16);
            btnFilter.Font = clsAppSettings.GetFont(1, 11);
            lblAllLibraries.Font = clsAppSettings.GetFont(2, 16);
            pbarStudentCountAllLib.Font = clsAppSettings.GetFont(1, 10);
            lblAllStudents.Font = clsAppSettings.GetFont(2, 16);
            btnAddStudent.Font = clsAppSettings.GetFont(1, 14);
            btnFilter2.Font = clsAppSettings.GetFont(1, 14);
            dgvStudentsIN.Font = clsAppSettings.GetFont(1, 12);
            dgvAllStudents.Font = clsAppSettings.GetFont(1, 12);
            dgvAllStudents.Font = clsAppSettings.GetFont(1, 12);
        }

        private void _InitializeDatagridviewStyles()
        {
            _ApplyStyle(dgvAllStudents);
            _ApplyStyle(dgvBlockedStudents);
            _ApplyStyle(dgvStudentsIN);
        }
        private void _Loaddgv()
        {
            dgvStudentsIN.DataSource = clsStudents.GetStudentsWitihSimple(StatusID: 1);
            dgvAllStudents.DataSource = clsStudents.GetAllStudentsAllData();
            dgvBlockedStudents.DataSource = clsStudents.GetBlockedStudents();
                
        }
        private void _pbar()
        {
            int Max = clsStudents.GetAllStudents().Rows.Count;
            int IN = clsStudents.GetStudentsWitih(StatusID: 1).Rows.Count;
            pbarStudentCountAllLib.Maximum = Max;
            pbarStudentCountAllLib.Value = IN;
            pbarStudentCountAllLib.Text = IN.ToString() + "/" + Max.ToString();
        }
        private void _AddFilter1()
        {
            FiltersForms.StudentFilter frm = new FiltersForms.StudentFilter(1);
            frm.ShowDialog();
            dgvStudentsIN.DataSource = frm.dt;
            
        }
        private void _AddFilter2()
        {
            FiltersForms.StudentFilter frm = new FiltersForms.StudentFilter(2);
            frm.ShowDialog();
            dgvAllStudents.DataSource= frm.dt;

            
        }
        private void _AddStudent()
        {
            AddStudentForm frm = new AddStudentForm();
            frm.ShowDialog();

            dgvAllStudents.DataSource = clsStudents.GetAllStudentsAllData();
        }

        private void StudentsForm_Load(object sender, EventArgs e)
        {
            _pbar();
        }

        private void btnFilter_Click(object sender, EventArgs e)
        {
            _AddFilter1();
        }

        private void btnAddStudent_Click(object sender, EventArgs e)
        {
            _AddStudent();
        }

        private void btnFilter2_Click(object sender, EventArgs e)
        {
            _AddFilter2();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            _pbar();
        }

        private void cmsStudentUpdate_Click(object sender, EventArgs e)
        {
            DataGridViewRow currentRow = dgvAllStudents.CurrentRow;
            if (currentRow != null)
            {
                StudentProfileForm frm = new StudentProfileForm((int)currentRow.Cells[0].Value);
                frm.ShowDialog();
            }
            _Loaddgv();
        }

        private void cmsStudentDelete_Click(object sender, EventArgs e)
        {
            DataGridViewRow currentRow = dgvAllStudents.CurrentRow;
            if (currentRow != null)
            {
                if (clsStudents.DeleteStudent((int)currentRow.Cells[0].Value))
                {
                    MessageBox.Show($"Student {(int)currentRow.Cells[0].Value} Deleted Successfully");
                }
                else
                {
                    MessageBox.Show("Something went wrong while trying to delete student.");
                }
            }
            _Loaddgv();
        }
    }
}
