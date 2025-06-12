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
using static PresentationLayer.clsAppSettings;

namespace PresentationLayer.Froms.AdditionalForms
{
    public partial class AddTaskForm : Form
    {
        private int _SelectedEmployeeID = -1;
        public AddTaskForm(int SelectedEmployeeID)
        {
            InitializeComponent();
            _InitializeFonts();
            _InitializeDataGridViewStyles();
            _SelectedEmployeeID = SelectedEmployeeID;
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
            _ApplyStyle(dgvTasks);

        }
        private void _InitializeFonts()
        {
            lblEmployeeName.Font = clsAppSettings.GetFont(1, 12);
            lblFinishDate.Font = clsAppSettings.GetFont(1, 12);
            lblTask.Font = clsAppSettings.GetFont(1, 12);

            txtEmployeeName.Font = clsAppSettings.GetFont(1, 12);
            txtTask.Font = clsAppSettings.GetFont(1, 12);
            dtpFinishDate.Font = clsAppSettings.GetFont(1, 12);


            btnSave.Font = clsAppSettings.GetFont(2, 12);
            btnCancel.Font = clsAppSettings.GetFont(2, 12);

        }
        private void _Loaddgv()
        {
            dgvTasks.DataSource = clsTasks.GetTasksWith(EmployeeID:_SelectedEmployeeID);
        }


        private void AddTaskForm_Load(object sender, EventArgs e)
        {
            _Loaddgv();
            dtpFinishDate.MinDate = DateTime.Now;
            dtpFinishDate.Value = DateTime.Now.AddDays(1);
        }

        private void guna2ShadowPanel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            clsTasks task = new clsTasks();

            task.set(
                EmployeeID: _SelectedEmployeeID,
                Task: txtTask.Text,
                FinishDate: dtpFinishDate.Value.Date
                );
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cmsTasksDelete_Click(object sender, EventArgs e)
        {
            DataGridViewRow currentRow = dgvTasks.CurrentRow;
            if (currentRow != null)
            {
                int cell = Convert.ToInt16(currentRow.Cells[0].Value);
                if (clsTasks.DeleteTask(cell))
                {
                    MessageBox.Show($"Task {cell} Deleted Successfully. ");
                }
                else
                {
                    MessageBox.Show("Something went wrong while deleting. ");
                }

            }
            _Loaddgv();
        }

        private void dgvTasks_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
