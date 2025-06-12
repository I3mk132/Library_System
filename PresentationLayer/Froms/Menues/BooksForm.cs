using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BussinesLayer;
using PresentationLayer.Forms.FiltersForms;
using PresentationLayer.Froms.AdditionalForms;
using PresentationLayer.Froms.AddUpdateForms;
using PresentationLayer.Froms.AddUpdateForms.Employees;

namespace PresentationLayer.Forms
{
    public partial class BooksForm : UserControl
    {
        public BooksForm()
        {
            InitializeComponent();
            _InitializeFonts();
            _Loaddgv();
            _InitializeDataGridViewStyles();
            _InitializeDepartment();
            _Updatepbars();

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
        private void _InitializeFonts()
        {
            lblBorrows.Font = clsAppSettings.GetFont(2, 16);
            btnAddBorrow.Font = clsAppSettings.GetFont(1, 14);
            btnFilterBorrows.Font = clsAppSettings.GetFont(1, 14);
            dgvBorrows.Font = clsAppSettings.GetFont(0, 9);
            lblTotalBorrows.Font = clsAppSettings.GetFont(2, 16);
            lblStudentBorrowd.Font = clsAppSettings.GetFont(2, 16);
            lblCurrentDepartment.Font = clsAppSettings.GetFont(2, 14);
            lblLateBorrows.Font = clsAppSettings.GetFont(2, 16);
            lblAllBooks.Font = clsAppSettings.GetFont(2, 16);
            btnFilterBook.Font = clsAppSettings.GetFont(1, 14);
            btnAddBook.Font = clsAppSettings.GetFont(1, 14);
            dgvAllBooks.Font = clsAppSettings.GetFont(0, 9);
        }
        private void _InitializeDataGridViewStyles()
        {
             _ApplyStyle(dgvAllBooks);
             _ApplyStyle(dgvBorrows);
             _ApplyStyle(dgvLateBorrows);
            
        }
        private void _InitializeDepartment()
        {
            string basePath = AppDomain.CurrentDomain.BaseDirectory;
            string ImagePath =
                (string)clsGlobalVariables.getDepartment(
                    clsGlobalVariables.enDepartment.eImagePath);
            string FullPath = Path.Combine(basePath, $@"..\..\..{ImagePath}");
            pbDepartmentImage.Image = Image.FromFile(FullPath);
            lblDepartmentName.Text =
                (string)clsGlobalVariables.getDepartment(
                    clsGlobalVariables.enDepartment.eName);
        }

        private void _Loaddgv()
        {
            dgvBorrows.DataSource = clsBorrows.GetAllBorrows();

            dgvLateBorrows.DataSource = clsBorrows.GetNearBorrows(0);
            if (dgvLateBorrows.Rows.Count == 0)
            {
                lblLate.Visible = true;
            }
            else
            {
                lblLate.Visible = false;
            }


            dgvAllBooks.DataSource = clsCopys.GetAllCopysAllData();

        }


        
        private void _Updatepbars()
        {
            int MaxBorrows = clsCopys.GetCopysCount();
            int TotalBorrows = clsBorrows.GetBorrowsCount();
            int MaxStudents = clsStudents.GetStudentCount();
            int StudentsWithBorrow = clsStudents.GetStudentWithBorrowsCount();
            pbarTotalBorrows.Maximum = MaxBorrows;
            pbarTotalBorrows.Value = TotalBorrows;
            pbarTotalBorrows.Text = $"{TotalBorrows}/{MaxBorrows}";
            pbarTotalStudentBorrowd.Maximum = MaxStudents;
            pbarTotalStudentBorrowd.Value = TotalBorrows;
            pbarTotalStudentBorrowd.Text = $"{StudentsWithBorrow}/{MaxStudents}"; (TotalBorrows / MaxBorrows).ToString();
        }

        private void BooksForm_Load(object sender, EventArgs e)
        {

        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            _Updatepbars();

        }

        private void btnAddBorrow_Click(object sender, EventArgs e)
        {
            AddBorrowForm frm = new AddBorrowForm();
            frm.ShowDialog();
            _Loaddgv();
        }

        private void btnAddBook_Click(object sender, EventArgs e)
        {
            AddBookForm frm = new AddBookForm();
            frm.ShowDialog();
            _Loaddgv();
        }

        private void btnFilterBorrows_Click(object sender, EventArgs e)
        {
            BorrowFilter frm = new BorrowFilter();
            frm.ShowDialog();
            if (frm.dt == null)
                dgvBorrows.DataSource = clsBorrows.GetAllBorrows();
            else
                dgvBorrows.DataSource = frm.dt;
        }

        private void btnFilterBook_Click(object sender, EventArgs e)
        {
            BookFilter frm = new BookFilter();
            frm.ShowDialog();
            if (frm.dt == null)
                dgvAllBooks.DataSource = clsCopys.GetAllCopysAllData();
            else
                dgvAllBooks.DataSource = frm.dt;
        }

        private void cmsBookDelete_Click(object sender, EventArgs e)
        {
            DataGridViewRow currentRow = dgvAllBooks.CurrentRow;
            if (currentRow != null)
            {
                int cell = (int)currentRow.Cells[0].Value;


                clsBorrows borrow = clsBorrows.Find(CopyID:  cell);
                if (borrow != null)
                {
                    string msg = $@"
                            Cant delete copy because book is borrowed by StudentID: {borrow.get(clsBorrows.enBorrow.eStudentID)}
                        ";
                    MessageBox.Show(msg);
                    return;
                }

                if (clsCopys.DeleteCopy(cell))
                {
                    MessageBox.Show("Copy deleted Successfully. ");
                }
                else
                {
                    MessageBox.Show("Something went wrong while deleting");
                }

            }
            _Loaddgv();
        }

        private void cmsBorrowUpdate_Click(object sender, EventArgs e)
        {
            DataGridViewRow currentRow = dgvBorrows.CurrentRow;
            if (currentRow != null)
            {
                int cell = (int)currentRow.Cells[0].Value;
                UpdateBorrowForm frm = new UpdateBorrowForm(cell);
                frm.ShowDialog();
            }
            _Loaddgv();
        }

        private void cmsBorrowDelete_Click(object sender, EventArgs e)
        {
            DataGridViewRow currentRow = dgvBorrows.CurrentRow;
            if (currentRow != null)
            {
                int cell = (int)currentRow.Cells[0].Value;
                if (clsBorrows.DeleteBorrow(cell))
                {
                    MessageBox.Show($"Borrow {cell} deleted successfully. ");
                }
                else
                {
                    MessageBox.Show($"Something wendt wrong while deleting. ");
                }
            }
            _Loaddgv();
        }

        private void pbDepartmentImage_Click(object sender, EventArgs e)
        {
            AddUpdateDepartmentForm frm = new AddUpdateDepartmentForm(
                (int)clsGlobalVariables.getDepartment(clsGlobalVariables.enDepartment.eID), true);
            frm.ShowDialog();
        }
    }
}
