using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BussinesLayer;
using PresentationLayer.Froms.AddUpdateForms;
using PresentationLayer.Froms.AddUpdateForms.Employees;

namespace PresentationLayer.Forms
{
    public partial class HomeForm : UserControl
    {
        public HomeForm()
        {
            InitializeComponent();
            _InitializeUserData();
            _InitializeFonts();
            _Loaddgv();
            _InitializeDataGridViewStyles();
            _UpdateShiftRemainingTime();
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
            lblWelcome.Font = clsAppSettings.GetFont(2, 18);
            lblEmployeeName.Font = clsAppSettings.GetFont(1, 18);
            lblCurrentTime.Font = clsAppSettings.GetFont(1, 14);
            lblYourTasks.Font = clsAppSettings.GetFont(1,14);
            lblCurrentDepartment.Font = clsAppSettings.GetFont(2, 14);
            lblDepartmentName.Font = clsAppSettings.GetFont(1, 12);
            pbDepartmentMinimumAge.Font = clsAppSettings.GetFont(0, 12);
            lblCurrentShiftRemainingTime.Font = clsAppSettings.GetFont(1, 14);
            lblShiftRemainingTime.Font = clsAppSettings.GetFont(1, 12);
            lblNearOrOutdateBorrows.Font = clsAppSettings.GetFont(1, 14);
        }
        private void _Loaddgv()
        {
            dgvTasks.DataSource = clsTasks.GetTasksSimpledWith(EmployeeID:clsGlobalVariables.getID());
            dgvBorrows.DataSource =
                clsBorrows.GetNearBorrowIn(
                    10,
                    (int)clsGlobalVariables.getDepartment(
                        clsGlobalVariables.enDepartment.eID)
                    );
        }
        private void _InitializeDataGridViewStyles()
        {
            _ApplyStyle(dgvBorrows);
            _ApplyStyle(dgvTasks);
        }
        private void _InitializeUserData()
        {
            string basePath = AppDomain.CurrentDomain.BaseDirectory;
            string ImagePath =
                (string)clsGlobalVariables.getDepartment(
                    clsGlobalVariables.enDepartment.eImagePath);
            string FullPath = Path.Combine(basePath, $@"..\..\..{ImagePath}");
            pbDepartmentImage.Image = 
                Image.FromFile(FullPath);

            lblDepartmentName.Text =
                (string)clsGlobalVariables.getDepartment(
                    clsGlobalVariables.enDepartment.eName
                    );

            pbDepartmentMinimumAge.Text = "Min Age: " +
                (string)clsGlobalVariables.getDepartment(
                    clsGlobalVariables.enDepartment.eMinimumAge
                    );

            string basePath2 = AppDomain.CurrentDomain.BaseDirectory;
            string ImagePath2 = clsGlobalVariables.getImagePath();
            string FullPath2 = Path.Combine(basePath2, $@"..\..\..{ImagePath2}");
            pbEmployee.Image = (ImagePath2 != "") ?
                Image.FromFile(FullPath2) : null;


            lblEmployeeName.Text =
                clsGlobalVariables.getUsername();




        }
        private void _UpdateShiftRemainingTime()
        {
            TimeSpan remaining =
                clsGlobalVariables.GetShift().To
                - DateTime.Now.TimeOfDay;
            TimeSpan maxDuration = clsGlobalVariables.GetShift().To - clsGlobalVariables.GetShift().From;

            if (remaining < TimeSpan.Zero)
            {
                remaining = TimeSpan.Zero;
            }
            else if (remaining > TimeSpan.FromHours(8))
            {
                remaining = TimeSpan.Zero;
            }
                double percentage = (remaining.TotalSeconds / maxDuration.TotalSeconds) * 100;
            int percentageInt = (int)Math.Round(percentage);
            
            pbarCurrentShift.Value = percentageInt;
        }

        private void HomeForm_Load(object sender, EventArgs e)
        {

        }

        private void Clock_Tick(object sender, EventArgs e)
        {
            lblCurrentTime.Text = DateTime.Now.ToString("hh:mm:ss  <-->  (dd MMM yyyy)");

            TimeSpan remaining = 
                clsGlobalVariables.GetShift().To
                - DateTime.Now.TimeOfDay;

            if (remaining < TimeSpan.Zero)
                lblShiftRemainingTime.Text = "00:00:00";
            else if (remaining > TimeSpan.FromHours(8))
                lblShiftRemainingTime.Text = "Shift starts at: " + clsGlobalVariables.GetShift().From;
            else
                lblShiftRemainingTime.Text =
                    remaining.ToString(@"hh\:mm\:ss");
        }

        private void ClockMin_Tick(object sender, EventArgs e)
        {
            _UpdateShiftRemainingTime(); 
        }

        private void cmsTasksFinishTask_Click(object sender, EventArgs e)
        {
            DataGridViewRow currentRow = dgvTasks.CurrentRow;
            if (currentRow != null)
            {

                if (clsTasks.DeleteTask(Convert.ToInt32(currentRow.Cells[0].Value)))
                {
                    MessageBox.Show($"Task {(int)currentRow.Cells[0].Value} Removed Successfully");
                }
                else
                {
                    MessageBox.Show("Something went wrong while trying to remove task.");
                }
                _Loaddgv();
            }
        }

        private void pbEmployee_Click(object sender, EventArgs e)
        {

        }

        private void pbDepartmentImage_Click(object sender, EventArgs e)
        {
            AddUpdateDepartmentForm frm = new AddUpdateDepartmentForm(
                (int)clsGlobalVariables.getDepartment(clsGlobalVariables.enDepartment.eID), true);
            frm.ShowDialog();
        }
    }
}
