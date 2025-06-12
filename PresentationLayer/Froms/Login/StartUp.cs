using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BussinesLayer;
using BussinesLayer.Validators;
using PresentationLayer.Forms;

namespace PresentationLayer
{
    public partial class StartUp : Form
    {
        public StartUp()
        {
            InitializeComponent();
            _InitializeFonts();
        }
        private void _InitializeFonts()
        {
            lblWelcome.Font = clsAppSettings.GetFont(2, 24);
            lblDescription.Font = clsAppSettings.GetFont(0, 14);
            lblForgetPassword.Font = clsAppSettings.GetFont(1, 14);
            btnLogin.Font = clsAppSettings.GetFont(2, 16);
            btnSignup.Font = clsAppSettings.GetFont(2, 16);
            txtEmail.Font = clsAppSettings.GetFont(1, 10);
            txtPassword.Font = clsAppSettings.GetFont(1, 10);
        }


        public bool found = false;
        private void btnLogin_Click(object sender, EventArgs e)
        { 
            

            clsEmployees employee = clsEmployees.Find(Email: txtEmail.Text);
            if (employee == null)
            {
                error.SetError(txtEmail, "Account is not found. ");
                return;
            }
            if (!clsEmployees.CheckPassword(employee, txtPassword.Text))
            {
                MessageBox.Show("Email or password is not wrong or not exists. ");
                return;
            }
                
            clsGlobalVariables.CurrentEmployee = employee;
            found = true;
            this.Close();
        }

        private void btnSignup_Click(object sender, EventArgs e)
        {
            SignupForm frm = new SignupForm();
            frm.ShowDialog();
        }

        private void lblForgetPassword_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Comming Soon!");
        }

        private void txtEmail_TextChanged(object sender, EventArgs e)
        {
            
        }

        ErrorProvider error = new ErrorProvider();
        private void txtEmail_Leave(object sender, EventArgs e)
        {
            
            if (!clsEmployeeValidator.EnterEmail(txtEmail.Text))
            {
                
                error.SetError(txtEmail, "Email is not valid!, Please enter another email.");
            }
            else
            {
                error.SetError(txtEmail, "");
            }
        }

        private void chkViewPassword_CheckedChanged(object sender, EventArgs e)
        {
            if (chkViewPassword.Checked == true)
            {
                txtPassword.UseSystemPasswordChar = true;
            }
            else
            {
                txtPassword.UseSystemPasswordChar = false;
            }
        }

        private void StartUp_Load(object sender, EventArgs e)
        {

        }

        private void StartUp_FormClosing(object sender, FormClosingEventArgs e)
        {
            
        }
    }
}
