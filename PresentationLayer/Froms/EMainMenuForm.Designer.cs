namespace PresentationLayer
{
    partial class EMainMenuForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EMainMenuForm));
            this.pnlShowMenues = new Guna.UI2.WinForms.Guna2Panel();
            this.guna2ShadowPanel1 = new Guna.UI2.WinForms.Guna2ShadowPanel();
            this.btnStudents = new Guna.UI2.WinForms.Guna2CircleButton();
            this.btnStatistics = new Guna.UI2.WinForms.Guna2CircleButton();
            this.btnProfile = new Guna.UI2.WinForms.Guna2CircleButton();
            this.btnBooks = new Guna.UI2.WinForms.Guna2CircleButton();
            this.btnHome = new Guna.UI2.WinForms.Guna2CircleButton();
            this.guna2ShadowPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlShowMenues
            // 
            this.pnlShowMenues.AutoScroll = true;
            this.pnlShowMenues.Location = new System.Drawing.Point(148, 0);
            this.pnlShowMenues.Name = "pnlShowMenues";
            this.pnlShowMenues.Size = new System.Drawing.Size(648, 519);
            this.pnlShowMenues.TabIndex = 1;
            // 
            // guna2ShadowPanel1
            // 
            this.guna2ShadowPanel1.BackColor = System.Drawing.Color.Transparent;
            this.guna2ShadowPanel1.Controls.Add(this.btnStudents);
            this.guna2ShadowPanel1.Controls.Add(this.btnStatistics);
            this.guna2ShadowPanel1.Controls.Add(this.btnProfile);
            this.guna2ShadowPanel1.Controls.Add(this.btnBooks);
            this.guna2ShadowPanel1.Controls.Add(this.btnHome);
            this.guna2ShadowPanel1.FillColor = System.Drawing.Color.White;
            this.guna2ShadowPanel1.Location = new System.Drawing.Point(33, 46);
            this.guna2ShadowPanel1.Name = "guna2ShadowPanel1";
            this.guna2ShadowPanel1.Radius = 15;
            this.guna2ShadowPanel1.ShadowColor = System.Drawing.Color.Black;
            this.guna2ShadowPanel1.ShadowShift = 3;
            this.guna2ShadowPanel1.Size = new System.Drawing.Size(97, 419);
            this.guna2ShadowPanel1.TabIndex = 2;
            // 
            // btnStudents
            // 
            this.btnStudents.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnStudents.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnStudents.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnStudents.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnStudents.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnStudents.FillColor = System.Drawing.Color.Transparent;
            this.btnStudents.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnStudents.ForeColor = System.Drawing.Color.White;
            this.btnStudents.HoverState.Image = global::PresentationLayer.Properties.Resources.people;
            this.btnStudents.Image = global::PresentationLayer.Properties.Resources.peopleBP;
            this.btnStudents.ImageOffset = new System.Drawing.Point(0, 5);
            this.btnStudents.ImageSize = new System.Drawing.Size(60, 60);
            this.btnStudents.Location = new System.Drawing.Point(12, 85);
            this.btnStudents.Name = "btnStudents";
            this.btnStudents.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.btnStudents.Size = new System.Drawing.Size(74, 70);
            this.btnStudents.TabIndex = 4;
            this.btnStudents.UseTransparentBackground = true;
            this.btnStudents.Click += new System.EventHandler(this.btnStudents_Click);
            // 
            // btnStatistics
            // 
            this.btnStatistics.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnStatistics.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnStatistics.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnStatistics.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnStatistics.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnStatistics.FillColor = System.Drawing.Color.Transparent;
            this.btnStatistics.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnStatistics.ForeColor = System.Drawing.Color.White;
            this.btnStatistics.HoverState.Image = global::PresentationLayer.Properties.Resources.data_analytics;
            this.btnStatistics.Image = global::PresentationLayer.Properties.Resources.data_analyticsBP;
            this.btnStatistics.ImageSize = new System.Drawing.Size(50, 50);
            this.btnStatistics.Location = new System.Drawing.Point(12, 237);
            this.btnStatistics.Name = "btnStatistics";
            this.btnStatistics.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.btnStatistics.Size = new System.Drawing.Size(74, 70);
            this.btnStatistics.TabIndex = 3;
            this.btnStatistics.UseTransparentBackground = true;
            this.btnStatistics.Click += new System.EventHandler(this.btnStatistics_Click);
            // 
            // btnProfile
            // 
            this.btnProfile.BackColor = System.Drawing.Color.Transparent;
            this.btnProfile.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnProfile.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnProfile.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnProfile.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnProfile.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnProfile.FillColor = System.Drawing.Color.Transparent;
            this.btnProfile.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnProfile.ForeColor = System.Drawing.Color.White;
            this.btnProfile.HoverState.Image = global::PresentationLayer.Properties.Resources.user;
            this.btnProfile.Image = global::PresentationLayer.Properties.Resources.userBP;
            this.btnProfile.ImageOffset = new System.Drawing.Point(2, 0);
            this.btnProfile.ImageSize = new System.Drawing.Size(50, 50);
            this.btnProfile.Location = new System.Drawing.Point(12, 313);
            this.btnProfile.Name = "btnProfile";
            this.btnProfile.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.btnProfile.Size = new System.Drawing.Size(74, 70);
            this.btnProfile.TabIndex = 2;
            this.btnProfile.UseTransparentBackground = true;
            this.btnProfile.Click += new System.EventHandler(this.btnProfile_Click);
            // 
            // btnBooks
            // 
            this.btnBooks.BackColor = System.Drawing.Color.Transparent;
            this.btnBooks.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBooks.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnBooks.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnBooks.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnBooks.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnBooks.FillColor = System.Drawing.Color.Transparent;
            this.btnBooks.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnBooks.ForeColor = System.Drawing.Color.White;
            this.btnBooks.HoverState.Image = global::PresentationLayer.Properties.Resources.open_book;
            this.btnBooks.Image = global::PresentationLayer.Properties.Resources.open_bookBP;
            this.btnBooks.ImageSize = new System.Drawing.Size(50, 50);
            this.btnBooks.Location = new System.Drawing.Point(12, 161);
            this.btnBooks.Name = "btnBooks";
            this.btnBooks.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.btnBooks.Size = new System.Drawing.Size(74, 70);
            this.btnBooks.TabIndex = 1;
            this.btnBooks.UseTransparentBackground = true;
            this.btnBooks.Click += new System.EventHandler(this.btnBooks_Click);
            // 
            // btnHome
            // 
            this.btnHome.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnHome.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnHome.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnHome.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnHome.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnHome.FillColor = System.Drawing.Color.Transparent;
            this.btnHome.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnHome.ForeColor = System.Drawing.Color.White;
            this.btnHome.HoverState.Image = global::PresentationLayer.Properties.Resources.home;
            this.btnHome.Image = global::PresentationLayer.Properties.Resources.homeBP;
            this.btnHome.ImageSize = new System.Drawing.Size(50, 50);
            this.btnHome.Location = new System.Drawing.Point(12, 9);
            this.btnHome.Name = "btnHome";
            this.btnHome.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.btnHome.Size = new System.Drawing.Size(74, 70);
            this.btnHome.TabIndex = 0;
            this.btnHome.UseTransparentBackground = true;
            this.btnHome.Click += new System.EventHandler(this.btnHome_Click);
            // 
            // EMainMenuForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(229)))), ((int)(((byte)(229)))));
            this.ClientSize = new System.Drawing.Size(801, 519);
            this.Controls.Add(this.guna2ShadowPanel1);
            this.Controls.Add(this.pnlShowMenues);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(817, 558);
            this.MinimumSize = new System.Drawing.Size(817, 558);
            this.Name = "EMainMenuForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Main Menu";
            this.Load += new System.EventHandler(this.EMainMenuForm_Load);
            this.guna2ShadowPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private Guna.UI2.WinForms.Guna2Panel pnlShowMenues;
        private Guna.UI2.WinForms.Guna2ShadowPanel guna2ShadowPanel1;
        private Guna.UI2.WinForms.Guna2CircleButton btnHome;
        private Guna.UI2.WinForms.Guna2CircleButton btnStudents;
        private Guna.UI2.WinForms.Guna2CircleButton btnStatistics;
        private Guna.UI2.WinForms.Guna2CircleButton btnProfile;
        private Guna.UI2.WinForms.Guna2CircleButton btnBooks;
    }
}