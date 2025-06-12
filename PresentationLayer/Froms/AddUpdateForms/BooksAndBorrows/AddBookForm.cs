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
using PresentationLayer.Froms.AddUpdateForms.AddBookPanel;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace PresentationLayer.Froms.AddUpdateForms
{
    public partial class AddBookForm : Form
    {
        public AddBookForm()
        {
            InitializeComponent();
            _InitializeComboboxes();
            _LoadViewCurrent();
            _InitializeFonts();


        }
        private clsBooks book;
        private void _InitializeComboboxes()
        {
            cbDepartment.Items.Clear();
            
            foreach(DataRow row in clsDepartments.GetAllDepartments().Rows)
            {
                cbDepartment.Items.Add(row["Name"].ToString());
            }

            cbDepartment.SelectedIndex = 0;
        }
        private void _InitializeFonts()
        {
            lblDepartment.Font = clsAppSettings.GetFont(2, 16);
            cbDepartment.Font = clsAppSettings.GetFont(1, 8);
            lblIsNewBook.Font = clsAppSettings.GetFont(2, 16);
            rbYes.Font = rbNo.Font = clsAppSettings.GetFont(1, 13);
        }
        private void _LoadForm(UserControl userControl)
        {
            // Clear existing controls
            pnlBook.Controls.Clear();

            // Dock the UserControl to fill the panel
            userControl.Dock = DockStyle.Fill;

            // Add the UserControl to the panel
            pnlBook.Controls.Add(userControl);
        }

        private AddNewBook _addNewBookControl;
        private void OnDataEntered(object sender, clsBooks Book)
        {
            book = Book;
        }
        private void _LoadNew()
        {
            _addNewBookControl = new AddNewBook();
            _addNewBookControl.DataEntered += OnDataEntered;
            _LoadForm(_addNewBookControl);

        }

        private ViewCurrentBooks _viewCurrentBooks;
        private void OnBookSelected(object sender, int selectedBookID)
        {
            book = clsBooks.Find(selectedBookID);
            
        }

        private void _LoadViewCurrent()
        {
            _viewCurrentBooks = new ViewCurrentBooks();
            _viewCurrentBooks.BookSelected += OnBookSelected;
            _LoadForm(_viewCurrentBooks);
        }


        private void cbDepartment_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void rbYes_CheckedChanged(object sender, EventArgs e)
        {
            if (rbYes.Checked)
            {
                _LoadNew();
            }
        }

        private void rbNo_CheckedChanged(object sender, EventArgs e)
        {
            if (rbNo.Checked)
            {
                _LoadViewCurrent();
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (rbYes.Checked)
            {
                if (_addNewBookControl == null)
                {
                    MessageBox.Show("No book info entered.");
                    return;
                }


                if (book.Save())
                {
                    clsCopys copy = new clsCopys(
                        (int)book.getBookData(clsBooks.enBook.eID),
                        "Available",
                        clsDepartments.GetIDByName(cbDepartment.Text)
                    );

                    if (copy.Save())
                    {
                        MessageBox.Show("Book and Copy saved successfully.");
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("Book saved, but Copy failed.");
                    }
                }
                else
                {
                    MessageBox.Show("Failed to save Book.");
                }
            }
            else
            {
                if (book == null)
                {
                    MessageBox.Show("No existing book selected.");
                    return;
                }

                clsCopys copy = new clsCopys(
                    (int)book.getBookData(clsBooks.enBook.eID),
                    "Available",
                    clsDepartments.GetIDByName(cbDepartment.Text)
                );

                if (copy.Save())
                {
                    MessageBox.Show("Copy saved successfully.");
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Failed to save Copy.");
                }
            }
        }

        private void AddBookForm_Load(object sender, EventArgs e)
        {

        }
    }
}
