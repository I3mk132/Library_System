namespace PresentationLayer
{
    partial class StartUp
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StartUp));
            this.pnlEnteranceCard = new Guna.UI2.WinForms.Guna2ShadowPanel();
            this.lblForgetPassword = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.chkViewPassword = new Guna.UI2.WinForms.Guna2ImageCheckBox();
            this.lblDescription = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.txtEmail = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtPassword = new Guna.UI2.WinForms.Guna2TextBox();
            this.btnLogin = new Guna.UI2.WinForms.Guna2Button();
            this.btnSignup = new Guna.UI2.WinForms.Guna2Button();
            this.lblWelcome = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.pbIcon = new Guna.UI2.WinForms.Guna2CirclePictureBox();
            this.pnlEnteranceCard.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbIcon)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlEnteranceCard
            // 
            this.pnlEnteranceCard.BackColor = System.Drawing.Color.Transparent;
            this.pnlEnteranceCard.Controls.Add(this.lblForgetPassword);
            this.pnlEnteranceCard.Controls.Add(this.chkViewPassword);
            this.pnlEnteranceCard.Controls.Add(this.lblDescription);
            this.pnlEnteranceCard.Controls.Add(this.txtEmail);
            this.pnlEnteranceCard.Controls.Add(this.txtPassword);
            this.pnlEnteranceCard.Controls.Add(this.btnLogin);
            this.pnlEnteranceCard.Controls.Add(this.btnSignup);
            this.pnlEnteranceCard.Controls.Add(this.lblWelcome);
            this.pnlEnteranceCard.Dock = System.Windows.Forms.DockStyle.Right;
            this.pnlEnteranceCard.FillColor = System.Drawing.Color.White;
            this.pnlEnteranceCard.Location = new System.Drawing.Point(438, 0);
            this.pnlEnteranceCard.Name = "pnlEnteranceCard";
            this.pnlEnteranceCard.Radius = 10;
            this.pnlEnteranceCard.ShadowColor = System.Drawing.Color.Black;
            this.pnlEnteranceCard.Size = new System.Drawing.Size(362, 450);
            this.pnlEnteranceCard.TabIndex = 0;
            // 
            // lblForgetPassword
            // 
            this.lblForgetPassword.BackColor = System.Drawing.Color.Transparent;
            this.lblForgetPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblForgetPassword.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(57)))), ((int)(((byte)(53)))));
            this.lblForgetPassword.Location = new System.Drawing.Point(88, 393);
            this.lblForgetPassword.Name = "lblForgetPassword";
            this.lblForgetPassword.Size = new System.Drawing.Size(197, 26);
            this.lblForgetPassword.TabIndex = 23;
            this.lblForgetPassword.Text = "Forget your Password? ";
            this.lblForgetPassword.Click += new System.EventHandler(this.lblForgetPassword_Click);
            // 
            // chkViewPassword
            // 
            this.chkViewPassword.Checked = true;
            this.chkViewPassword.CheckedState.Image = global::PresentationLayer.Properties.Resources.hideEye;
            this.chkViewPassword.Cursor = System.Windows.Forms.Cursors.Hand;
            this.chkViewPassword.Image = global::PresentationLayer.Properties.Resources.viewEye;
            this.chkViewPassword.ImageOffset = new System.Drawing.Point(0, 0);
            this.chkViewPassword.ImageRotate = 0F;
            this.chkViewPassword.Location = new System.Drawing.Point(312, 204);
            this.chkViewPassword.Name = "chkViewPassword";
            this.chkViewPassword.Size = new System.Drawing.Size(24, 24);
            this.chkViewPassword.TabIndex = 22;
            this.chkViewPassword.CheckedChanged += new System.EventHandler(this.chkViewPassword_CheckedChanged);
            // 
            // lblDescription
            // 
            this.lblDescription.BackColor = System.Drawing.Color.Transparent;
            this.lblDescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescription.Location = new System.Drawing.Point(37, 69);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(282, 26);
            this.lblDescription.TabIndex = 21;
            this.lblDescription.Text = "Login to your account to continue";
            // 
            // txtEmail
            // 
            this.txtEmail.Animated = true;
            this.txtEmail.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.txtEmail.BorderRadius = 10;
            this.txtEmail.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtEmail.DefaultText = "";
            this.txtEmail.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtEmail.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtEmail.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtEmail.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtEmail.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtEmail.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtEmail.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtEmail.Location = new System.Drawing.Point(27, 129);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.PlaceholderText = "Email";
            this.txtEmail.SelectedText = "";
            this.txtEmail.Size = new System.Drawing.Size(305, 52);
            this.txtEmail.TabIndex = 20;
            this.txtEmail.TextChanged += new System.EventHandler(this.txtEmail_TextChanged);
            this.txtEmail.Leave += new System.EventHandler(this.txtEmail_Leave);
            // 
            // txtPassword
            // 
            this.txtPassword.Animated = true;
            this.txtPassword.BorderRadius = 10;
            this.txtPassword.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtPassword.DefaultText = "";
            this.txtPassword.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtPassword.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtPassword.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtPassword.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtPassword.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtPassword.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtPassword.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtPassword.Location = new System.Drawing.Point(27, 187);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PlaceholderText = "Password";
            this.txtPassword.SelectedText = "";
            this.txtPassword.Size = new System.Drawing.Size(279, 52);
            this.txtPassword.TabIndex = 19;
            this.txtPassword.UseSystemPasswordChar = true;
            // 
            // btnLogin
            // 
            this.btnLogin.Animated = true;
            this.btnLogin.BorderRadius = 10;
            this.btnLogin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLogin.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnLogin.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnLogin.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnLogin.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnLogin.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(57)))), ((int)(((byte)(53)))));
            this.btnLogin.Font = new System.Drawing.Font("Segoe UI", 16F);
            this.btnLogin.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.btnLogin.Location = new System.Drawing.Point(46, 269);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(267, 54);
            this.btnLogin.TabIndex = 17;
            this.btnLogin.Text = " Login";
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // btnSignup
            // 
            this.btnSignup.Animated = true;
            this.btnSignup.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(57)))), ((int)(((byte)(53)))));
            this.btnSignup.BorderRadius = 10;
            this.btnSignup.BorderThickness = 3;
            this.btnSignup.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSignup.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnSignup.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnSignup.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnSignup.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnSignup.FillColor = System.Drawing.Color.Transparent;
            this.btnSignup.Font = new System.Drawing.Font("Segoe UI", 16F);
            this.btnSignup.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.btnSignup.Location = new System.Drawing.Point(75, 329);
            this.btnSignup.Name = "btnSignup";
            this.btnSignup.Size = new System.Drawing.Size(205, 54);
            this.btnSignup.TabIndex = 16;
            this.btnSignup.Text = " Signup";
            this.btnSignup.Click += new System.EventHandler(this.btnSignup_Click);
            // 
            // lblWelcome
            // 
            this.lblWelcome.BackColor = System.Drawing.Color.Transparent;
            this.lblWelcome.Font = new System.Drawing.Font("Microsoft Sans Serif", 24.25F);
            this.lblWelcome.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(57)))), ((int)(((byte)(53)))));
            this.lblWelcome.Location = new System.Drawing.Point(110, 31);
            this.lblWelcome.Name = "lblWelcome";
            this.lblWelcome.Size = new System.Drawing.Size(136, 39);
            this.lblWelcome.TabIndex = 18;
            this.lblWelcome.Text = "Welcome";
            // 
            // pbIcon
            // 
            this.pbIcon.BackColor = System.Drawing.Color.Transparent;
            this.pbIcon.FillColor = System.Drawing.Color.Transparent;
            this.pbIcon.Image = global::PresentationLayer.Properties.Resources.icon;
            this.pbIcon.ImageRotate = 0F;
            this.pbIcon.Location = new System.Drawing.Point(0, 0);
            this.pbIcon.Name = "pbIcon";
            this.pbIcon.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.pbIcon.Size = new System.Drawing.Size(432, 450);
            this.pbIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbIcon.TabIndex = 1;
            this.pbIcon.TabStop = false;
            this.pbIcon.UseTransparentBackground = true;
            // 
            // StartUp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(229)))), ((int)(((byte)(229)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pnlEnteranceCard);
            this.Controls.Add(this.pbIcon);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "StartUp";
            this.Text = "Login";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.StartUp_FormClosing);
            this.Load += new System.EventHandler(this.StartUp_Load);
            this.pnlEnteranceCard.ResumeLayout(false);
            this.pnlEnteranceCard.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbIcon)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2ShadowPanel pnlEnteranceCard;
        private Guna.UI2.WinForms.Guna2CirclePictureBox pbIcon;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblForgetPassword;
        private Guna.UI2.WinForms.Guna2ImageCheckBox chkViewPassword;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblDescription;
        private Guna.UI2.WinForms.Guna2TextBox txtEmail;
        private Guna.UI2.WinForms.Guna2TextBox txtPassword;
        private Guna.UI2.WinForms.Guna2Button btnLogin;
        private Guna.UI2.WinForms.Guna2Button btnSignup;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblWelcome;
    }
}

