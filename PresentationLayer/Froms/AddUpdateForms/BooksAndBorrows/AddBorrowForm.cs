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

namespace PresentationLayer.Froms.AdditionalForms
{
    public partial class AddBorrowForm : Form
    {
        public AddBorrowForm()
        {
            InitializeComponent();
            _InitializeDataGridViewStyles();
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
            dgv.AlternatingRowsDefaultCellStyle.Font = clsAppSettings.GetFont(0, 8);
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
        private void _InitializeDataGridViewStyles()
        {
            _ApplyStyle(dgv);
        }

        private void guna2Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void txtBookname_Click(object sender, EventArgs e)
        {
            dgv.DataSource = clsCopys.GetAllCopysAllDataFilterd(BookStatus:"Available");
            dgv.Tag = "Book";
        }


        private void txtStudentName_Click(object sender, EventArgs e)
        {
            dgv.DataSource = clsStudents.GetAllStudents();
            dgv.Tag = "Student";
        }

        private void dgv_SelectionChanged(object sender, EventArgs e)
        {

            try
            {

                if (dgv.Tag.ToString() == "Book")
                {
                    txtBookname.Text = dgv.CurrentRow.Cells["Title"].Value.ToString();
                
                }
                else if (dgv.Tag.ToString() == "Student")
                {
                    txtStudentName.Text = dgv.CurrentRow.Cells["Firstname"].Value.ToString();
                }
            }
            catch { }
        }

        private void AddBorrowForm_Load(object sender, EventArgs e)
        {
            dtpReturnDate.MaxDate = DateTime.Now.AddYears(1);
            dtpReturnDate.MinDate = DateTime.Now.AddDays(1);
            dtpReturnDate.Value = DateTime.Now.AddDays(2);
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            clsBorrows borrow = new clsBorrows(
                
                    txtBookname.Text,
                    txtStudentName.Text,
                    dtpReturnDate.Value
                
                );


            if (borrow.Save())
            {
                MessageBox.Show($"Borrow saved Successfully.\n" +
                    $" {txtBookname.Text} <=> {txtStudentName.Text} <=> {dtpReturnDate.Value}");
            }
            else
            {
                MessageBox.Show("Something went wrong while saving borrow");
            }
        }
    }
}
