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
    public partial class UpdateBorrowForm : Form
    {
        private int _SelectedBorrowID;
        public UpdateBorrowForm(int Selected)
        {
            InitializeComponent();
            _InitializeFonts();
            _SelectedBorrowID = Selected;
        }
        private void _InitializeFonts()
        {
            txtBookname.Font = clsAppSettings.GetFont(1, 12);
            txtStudentName.Font = clsAppSettings.GetFont(1, 12);
            dtpReturnDate.Font = clsAppSettings.GetFont(1, 10);

            lblBookName.Font = clsAppSettings.GetFont(1, 12);
            lblStudentName.Font = clsAppSettings.GetFont(1, 12);
            lblBorrowDate.Font = clsAppSettings.GetFont(1, 12);
            lblReturnDate.Font = clsAppSettings.GetFont(1, 12);

            btnCancel.Font = clsAppSettings.GetFont(2, 12);
            btnSave.Font = clsAppSettings.GetFont(2, 12);
        }

        private void UpdateBorrowForm_Load(object sender, EventArgs e)
        {
            clsBorrows borrow = clsBorrows.Find(ID: _SelectedBorrowID);
            txtBookname.Text = clsCopys.getBookTitle((int)borrow.get(clsBorrows.enBorrow.eCopyID));
            txtStudentName.Text = clsStudents.GetStudentFullName((int)borrow.get(clsBorrows.enBorrow.eStudentID));
            lblBorrowDate.Text = "Borrow date: " + ((DateTime)borrow.get(clsBorrows.enBorrow.eBorrowDate)).ToString("dd-MM-yyyy");
            dtpReturnDate.Value = (DateTime)borrow.get(clsBorrows.enBorrow.eReturnDate);
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            clsBorrows borrow = clsBorrows.Find(ID: _SelectedBorrowID);

            borrow.set(ReturnDate:dtpReturnDate.Value.Date);

            if (borrow.Save())
            {
                MessageBox.Show("Borrow updated successfully. ");
                this.Close();
            }
            else
            {
                MessageBox.Show("Something went wrong while updating.");
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
