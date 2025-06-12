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
using PresentationLayer.Forms;
using PresentationLayer.Forms.Menues;
using PresentationLayer.Properties;
using System.IO;

namespace PresentationLayer
{
    public partial class EMainMenuForm : Form
    {
        public EMainMenuForm()
        {
            InitializeComponent();
            _InitializeFonts();
        }
        private void _InitializeFonts()
        {
            this.Font = clsAppSettings.GetFont(2, 14);
        }
        private void _LoadForm(UserControl userControl)
        {
            // Clear existing controls
            pnlShowMenues.Controls.Clear();

            // Dock the UserControl to fill the panel
            userControl.Dock = DockStyle.Fill;

            // Add the UserControl to the panel
            pnlShowMenues.Controls.Add(userControl);
        }
        private void _LoadPermissions()
        {
            if (
               (clsGlobalVariables.getPermissions()
               &
               (int)clsSecurity.enPermissions.MainMenu)
               !=
               (int)clsSecurity.enPermissions.MainMenu
               )
            {
                btnHome.Enabled = false;
            }
            if (
                (clsGlobalVariables.getPermissions()
                &
                (int)clsSecurity.enPermissions.Students)
                !=
                (int)clsSecurity.enPermissions.Students
                )
            {
                btnStudents.Enabled = false;
            }
            if (
                (clsGlobalVariables.getPermissions()
                &
                (int)clsSecurity.enPermissions.Books)
                !=
                (int)clsSecurity.enPermissions.Books
                )
            {
                btnBooks.Enabled = false;
            }
            if (
                (clsGlobalVariables.getPermissions()
                &
                (int)clsSecurity.enPermissions.Statics)
                !=
                (int)clsSecurity.enPermissions.Statics
                )
            {
                btnStatistics.Enabled = false;
            }
            if (
                (clsGlobalVariables.getPermissions()
                &
                (int)clsSecurity.enPermissions.Profile)
                !=
                (int)clsSecurity.enPermissions.Profile
                )
            {
                btnProfile.Enabled = false;
            }
        }
        private void _LoadUserData()
        {
            _LoadPermissions();
            clsGlobalVariables.SetDepartment();
            clsGlobalVariables.SetShift();
        }
        private void _LoadMainMenuForm()
        {
            _SetIconsImagesToDefault();
            btnHome.Image = Resources.home;
            HomeForm frm = new HomeForm();
            _LoadForm(frm);
        }
        private void _LoadStudentsForm()
        {
            _SetIconsImagesToDefault();
            btnStudents.Image = Resources.people;
            StudentsForm frm = new StudentsForm();
            _LoadForm(frm);
        }
        private void _LoadBooksForm()
        {
            _SetIconsImagesToDefault();
            btnBooks.Image = Resources.open_book;
            BooksForm frm = new BooksForm();
            _LoadForm(frm);
        }
        private void _LoadStaticsForm()
        {
            _SetIconsImagesToDefault();
            btnStatistics.Image = Resources.data_analytics;
            StaticsForm frm = new StaticsForm();
            _LoadForm(frm);
        }
        private void _LoadProfileForm()
        {
            _SetIconsImagesToDefault();
            btnProfile.Image = Resources.user;
            ProfileForm frm = new ProfileForm();
            _LoadForm(frm);
        }
        private void _SetIconsImagesToDefault()
        {
            btnBooks.Image = Resources.open_bookBP;
            btnHome.Image = Resources.homeBP;
            btnStatistics.Image = Resources.data_analyticsBP;
            btnProfile.Image = Resources.userBP;
            btnStudents.Image = Resources.peopleBP;
        }
        private void btnHome_Click(object sender, EventArgs e)
        {
            
            _LoadMainMenuForm();
        }

        private void btnStudents_Click(object sender, EventArgs e)
        {
            
            _LoadStudentsForm();
        }

        private void btnBooks_Click(object sender, EventArgs e)
        {
            
            _LoadBooksForm();
        }

        private void btnStatistics_Click(object sender, EventArgs e)
        {
            
            _LoadStaticsForm();
        }

        private void btnProfile_Click(object sender, EventArgs e)
        {
            _LoadProfileForm();
        }

        private void EMainMenuForm_Load(object sender, EventArgs e)
        {
            _LoadUserData();
            _LoadMainMenuForm();
        }
    }
}
