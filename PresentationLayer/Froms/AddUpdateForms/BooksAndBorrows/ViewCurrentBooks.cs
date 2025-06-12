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

namespace PresentationLayer.Froms.AddUpdateForms.AddBookPanel
{
    public partial class ViewCurrentBooks : UserControl
    {
        public event EventHandler<int> BookSelected;

        public ViewCurrentBooks()
        {
            InitializeComponent();
            _InitializeDataGridViewStyles();
            
        }
        public int BookID = -1;
        private void _ApplyStyle(Guna.UI2.WinForms.Guna2DataGridView dgv)
        {
            // Header height
            dgv.ColumnHeadersHeight = 26;

            // Row height
            dgv.RowTemplate.Height = 22;

            // Fonts (assuming your GetFont method is accessible statically)
            dgv.ColumnHeadersDefaultCellStyle.Font = clsAppSettings.GetFont(1, 14);
            dgv.DefaultCellStyle.Font = clsAppSettings.GetFont(0, 12);
            dgv.AlternatingRowsDefaultCellStyle.Font = clsAppSettings.GetFont(0, 12);

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

            dgv.ClearSelection();
        }
        private void _InitializeDataGridViewStyles()
        {
            _ApplyStyle(dgvBooks);
        }

        private void ViewCurrentBooks_Load(object sender, EventArgs e)
        {
            dgvBooks.DataSource = clsBooks.GetAllBooks();
        }

        private void dgvBooks_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            if (e.RowIndex >= 0)
            {
                var cellValue = dgvBooks.Rows[e.RowIndex].Cells["BookID"].Value;
                if (cellValue != null && int.TryParse(cellValue.ToString(), out int id))
                {
                    BookID = id;
                    BookSelected?.Invoke(this, BookID);
                }
            }
        }
    }
}
