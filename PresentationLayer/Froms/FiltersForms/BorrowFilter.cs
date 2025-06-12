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
    public partial class BorrowFilter : Form
    {
        public BorrowFilter()
        {
            InitializeComponent();
            _InitializeFonts();
        }
        public DataTable dt = new DataTable();
        
        private void _InitializeFonts()
        {
            lblID.Font = clsAppSettings.GetFont(1, 14);
            lblStudentName.Font = clsAppSettings.GetFont(1, 14);
            lblBookTilte.Font = clsAppSettings.GetFont(1, 14);
        }
        private void chkID_CheckedChanged(object sender, EventArgs e)
        {
            Guna2CheckBox chk = (Guna2CheckBox)sender;
            switch (chk.Tag.ToString())
            {
                case "ID":

                    nudID.Enabled = (chk.Checked);
                    break;

                case "Student name":

                    txtStudentName.Enabled = (chk.Checked);
                    break;

                case "Book title":

                    txtBookTitle.Enabled = (chk.Checked);
                    break;

                default:
                    return;
            }
        }

        private void btnFilter_Click(object sender, EventArgs e)
        {
            dt = clsBorrows.GetBorrowsWith(

                (chkID.Checked) ? Convert.ToInt16(nudID.Value) : -1,
                (chkStudentName.Checked) ? txtStudentName.Text : "",
                (chkBookTitle.Checked) ? txtBookTitle.Text : ""
                );

            this.Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            dt = null;
            this.Close();
        }

        private void BorrowFilter_Load(object sender, EventArgs e)
        {

        }
    }
}
