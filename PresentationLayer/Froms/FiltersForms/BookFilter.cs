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
    public partial class BookFilter : Form
    {
        public BookFilter()
        {
            InitializeComponent();
            _InitializeFonts();
        }

        public DataTable dt = new DataTable();

        private void _InitializeFonts()
        {
            lblID.Font = clsAppSettings.GetFont(1, 14);
            lblTitle.Font = clsAppSettings.GetFont(1, 14);
            lblAuthor.Font = clsAppSettings.GetFont(1, 14);
            lblISBN.Font = clsAppSettings.GetFont(1, 14);
            lblGenre.Font = clsAppSettings.GetFont(1, 14);
            lblDetails.Font = clsAppSettings.GetFont(1, 14);
        }

        private void chkID_CheckedChanged(object sender, EventArgs e)
        {
            Guna2CheckBox Opt = (Guna2CheckBox)sender;

            switch (Opt.Tag.ToString())
            {
                case "ID":nudID.Enabled = Opt.Checked;break;
                case "Title":txtTitle.Enabled = Opt.Checked;break;
                case "Author":txtAuthor.Enabled = Opt.Checked;break;
                case "ISBN":txtISBN.Enabled = Opt.Checked;break;
                case "Genre":txtGenre.Enabled = Opt.Checked;break;
                case "Details":txtDetails.Enabled=Opt.Checked;break;  
            }

        }

        private void btnFilter_Click(object sender, EventArgs e)
        {
            dt = clsCopys.GetAllCopysAllDataFilterd(
                    (chkID.Checked) ? Convert.ToInt16(nudID.Value) : -1,
                    (chkTitle.Checked) ? txtTitle.Text : "",
                    (chkAuthor.Checked) ? txtAuthor.Text : "",
                    (chkISBN.Checked) ? txtISBN.Text : "",
                    (chkGenre.Checked) ? txtGenre.Text : "",
                    (chkDetails.Checked) ? txtDetails.Text : ""
                    );

            this.Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            dt = clsCopys.GetAllCopysAllData();
            this.Close();
        }

        private void BookFilter_Load(object sender, EventArgs e)
        {

        }
    }
}
