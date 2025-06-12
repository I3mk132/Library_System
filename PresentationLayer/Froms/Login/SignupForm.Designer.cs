namespace PresentationLayer.Forms
{
    partial class SignupForm
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
            this.guna2ShadowPanel1 = new Guna.UI2.WinForms.Guna2ShadowPanel();
            this.pbPhoto = new Guna.UI2.WinForms.Guna2CirclePictureBox();
            this.txtNationality = new Guna.UI2.WinForms.Guna2TextBox();
            this.cbGender = new Guna.UI2.WinForms.Guna2ComboBox();
            this.guna2Shapes1 = new Guna.UI2.WinForms.Guna2Shapes();
            this.cbCountrykeys = new Guna.UI2.WinForms.Guna2ComboBox();
            this.txtPhone = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtIDnumber = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtUsername = new Guna.UI2.WinForms.Guna2TextBox();
            this.dtpDateOfBirth = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.chkView2 = new Guna.UI2.WinForms.Guna2ImageCheckBox();
            this.txtLastname = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtFirstname = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtPassword2 = new Guna.UI2.WinForms.Guna2TextBox();
            this.chkView1 = new Guna.UI2.WinForms.Guna2ImageCheckBox();
            this.lblDescription = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.txtEmail = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtPassword1 = new Guna.UI2.WinForms.Guna2TextBox();
            this.btnCreate = new Guna.UI2.WinForms.Guna2Button();
            this.btnBack = new Guna.UI2.WinForms.Guna2Button();
            this.lblWelcome = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2ShadowPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbPhoto)).BeginInit();
            this.SuspendLayout();
            // 
            // guna2ShadowPanel1
            // 
            this.guna2ShadowPanel1.BackColor = System.Drawing.Color.Transparent;
            this.guna2ShadowPanel1.Controls.Add(this.pbPhoto);
            this.guna2ShadowPanel1.Controls.Add(this.txtNationality);
            this.guna2ShadowPanel1.Controls.Add(this.cbGender);
            this.guna2ShadowPanel1.Controls.Add(this.guna2Shapes1);
            this.guna2ShadowPanel1.Controls.Add(this.cbCountrykeys);
            this.guna2ShadowPanel1.Controls.Add(this.txtPhone);
            this.guna2ShadowPanel1.Controls.Add(this.txtIDnumber);
            this.guna2ShadowPanel1.Controls.Add(this.txtUsername);
            this.guna2ShadowPanel1.Controls.Add(this.dtpDateOfBirth);
            this.guna2ShadowPanel1.Controls.Add(this.chkView2);
            this.guna2ShadowPanel1.Controls.Add(this.txtLastname);
            this.guna2ShadowPanel1.Controls.Add(this.txtFirstname);
            this.guna2ShadowPanel1.Controls.Add(this.txtPassword2);
            this.guna2ShadowPanel1.Controls.Add(this.chkView1);
            this.guna2ShadowPanel1.Controls.Add(this.lblDescription);
            this.guna2ShadowPanel1.Controls.Add(this.txtEmail);
            this.guna2ShadowPanel1.Controls.Add(this.txtPassword1);
            this.guna2ShadowPanel1.Controls.Add(this.btnCreate);
            this.guna2ShadowPanel1.Controls.Add(this.btnBack);
            this.guna2ShadowPanel1.Controls.Add(this.lblWelcome);
            this.guna2ShadowPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.guna2ShadowPanel1.FillColor = System.Drawing.SystemColors.Control;
            this.guna2ShadowPanel1.Location = new System.Drawing.Point(0, 0);
            this.guna2ShadowPanel1.Name = "guna2ShadowPanel1";
            this.guna2ShadowPanel1.Radius = 10;
            this.guna2ShadowPanel1.ShadowColor = System.Drawing.Color.Black;
            this.guna2ShadowPanel1.Size = new System.Drawing.Size(543, 436);
            this.guna2ShadowPanel1.TabIndex = 0;
            this.guna2ShadowPanel1.Paint += new System.Windows.Forms.PaintEventHandler(this.guna2ShadowPanel1_Paint);
            // 
            // pbPhoto
            // 
            this.pbPhoto.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbPhoto.ImageRotate = 0F;
            this.pbPhoto.Location = new System.Drawing.Point(339, 162);
            this.pbPhoto.Name = "pbPhoto";
            this.pbPhoto.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.pbPhoto.Size = new System.Drawing.Size(189, 181);
            this.pbPhoto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbPhoto.TabIndex = 77;
            this.pbPhoto.TabStop = false;
            this.pbPhoto.UseTransparentBackground = true;
            this.pbPhoto.Click += new System.EventHandler(this.pbPhoto_Click);
            // 
            // txtNationality
            // 
            this.txtNationality.Animated = true;
            this.txtNationality.BorderRadius = 10;
            this.txtNationality.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtNationality.DefaultText = "";
            this.txtNationality.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtNationality.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtNationality.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtNationality.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtNationality.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtNationality.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtNationality.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.txtNationality.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtNationality.Location = new System.Drawing.Point(217, 121);
            this.txtNationality.MaxLength = 50;
            this.txtNationality.Name = "txtNationality";
            this.txtNationality.PlaceholderText = "Nationality";
            this.txtNationality.SelectedText = "";
            this.txtNationality.Size = new System.Drawing.Size(123, 35);
            this.txtNationality.TabIndex = 4;
            this.txtNationality.Leave += new System.EventHandler(this.txtNationality_Leave);
            // 
            // cbGender
            // 
            this.cbGender.BackColor = System.Drawing.Color.Transparent;
            this.cbGender.BorderRadius = 10;
            this.cbGender.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cbGender.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbGender.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbGender.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(57)))), ((int)(((byte)(53)))));
            this.cbGender.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(57)))), ((int)(((byte)(53)))));
            this.cbGender.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cbGender.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cbGender.ItemHeight = 30;
            this.cbGender.Location = new System.Drawing.Point(393, 79);
            this.cbGender.Name = "cbGender";
            this.cbGender.Size = new System.Drawing.Size(104, 36);
            this.cbGender.TabIndex = 2;
            // 
            // guna2Shapes1
            // 
            this.guna2Shapes1.BorderThickness = 1;
            this.guna2Shapes1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(57)))), ((int)(((byte)(53)))));
            this.guna2Shapes1.LineEndCap = System.Drawing.Drawing2D.LineCap.Round;
            this.guna2Shapes1.LineStartCap = System.Drawing.Drawing2D.LineCap.Round;
            this.guna2Shapes1.Location = new System.Drawing.Point(42, 249);
            this.guna2Shapes1.Name = "guna2Shapes1";
            this.guna2Shapes1.PolygonSkip = 1;
            this.guna2Shapes1.Rotate = 0F;
            this.guna2Shapes1.Shape = Guna.UI2.WinForms.Enums.ShapeType.Line;
            this.guna2Shapes1.Size = new System.Drawing.Size(255, 10);
            this.guna2Shapes1.TabIndex = 74;
            this.guna2Shapes1.Text = "guna2Shapes1";
            this.guna2Shapes1.Zoom = 80;
            // 
            // cbCountrykeys
            // 
            this.cbCountrykeys.BackColor = System.Drawing.Color.Transparent;
            this.cbCountrykeys.BorderRadius = 10;
            this.cbCountrykeys.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cbCountrykeys.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbCountrykeys.DropDownHeight = 150;
            this.cbCountrykeys.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbCountrykeys.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(57)))), ((int)(((byte)(53)))));
            this.cbCountrykeys.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(57)))), ((int)(((byte)(53)))));
            this.cbCountrykeys.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cbCountrykeys.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cbCountrykeys.IntegralHeight = false;
            this.cbCountrykeys.ItemHeight = 30;
            this.cbCountrykeys.Location = new System.Drawing.Point(21, 202);
            this.cbCountrykeys.MaxDropDownItems = 5;
            this.cbCountrykeys.Name = "cbCountrykeys";
            this.cbCountrykeys.Size = new System.Drawing.Size(126, 36);
            this.cbCountrykeys.TabIndex = 8;
            // 
            // txtPhone
            // 
            this.txtPhone.Animated = true;
            this.txtPhone.BorderRadius = 10;
            this.txtPhone.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtPhone.DefaultText = "";
            this.txtPhone.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtPhone.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtPhone.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtPhone.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtPhone.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtPhone.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtPhone.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.txtPhone.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtPhone.Location = new System.Drawing.Point(153, 203);
            this.txtPhone.MaxLength = 20;
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.PlaceholderText = "Phone";
            this.txtPhone.SelectedText = "";
            this.txtPhone.Size = new System.Drawing.Size(180, 35);
            this.txtPhone.TabIndex = 9;
            this.txtPhone.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPhone_KeyPress);
            this.txtPhone.Leave += new System.EventHandler(this.txtPhone_Leave);
            // 
            // txtIDnumber
            // 
            this.txtIDnumber.Animated = true;
            this.txtIDnumber.BorderRadius = 10;
            this.txtIDnumber.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtIDnumber.DefaultText = "";
            this.txtIDnumber.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtIDnumber.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtIDnumber.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtIDnumber.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtIDnumber.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtIDnumber.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtIDnumber.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.txtIDnumber.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtIDnumber.Location = new System.Drawing.Point(170, 161);
            this.txtIDnumber.MaxLength = 15;
            this.txtIDnumber.Name = "txtIDnumber";
            this.txtIDnumber.PlaceholderText = "ID number";
            this.txtIDnumber.SelectedText = "";
            this.txtIDnumber.Size = new System.Drawing.Size(143, 35);
            this.txtIDnumber.TabIndex = 7;
            this.txtIDnumber.Leave += new System.EventHandler(this.txtIDnumber_Leave);
            // 
            // txtUsername
            // 
            this.txtUsername.Animated = true;
            this.txtUsername.BorderRadius = 10;
            this.txtUsername.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtUsername.DefaultText = "";
            this.txtUsername.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtUsername.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtUsername.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtUsername.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtUsername.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtUsername.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtUsername.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.txtUsername.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtUsername.Location = new System.Drawing.Point(21, 161);
            this.txtUsername.MaxLength = 50;
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.PlaceholderText = "Username";
            this.txtUsername.SelectedText = "";
            this.txtUsername.Size = new System.Drawing.Size(143, 35);
            this.txtUsername.TabIndex = 6;
            this.txtUsername.TextChanged += new System.EventHandler(this.txtUsername_TextChanged);
            // 
            // dtpDateOfBirth
            // 
            this.dtpDateOfBirth.Animated = true;
            this.dtpDateOfBirth.BorderRadius = 10;
            this.dtpDateOfBirth.Checked = true;
            this.dtpDateOfBirth.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dtpDateOfBirth.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(57)))), ((int)(((byte)(53)))));
            this.dtpDateOfBirth.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.dtpDateOfBirth.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.dtpDateOfBirth.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDateOfBirth.Location = new System.Drawing.Point(346, 120);
            this.dtpDateOfBirth.MaxDate = new System.DateTime(2018, 12, 31, 0, 0, 0, 0);
            this.dtpDateOfBirth.MinDate = new System.DateTime(1900, 1, 1, 0, 0, 0, 0);
            this.dtpDateOfBirth.Name = "dtpDateOfBirth";
            this.dtpDateOfBirth.Size = new System.Drawing.Size(168, 35);
            this.dtpDateOfBirth.TabIndex = 5;
            this.dtpDateOfBirth.Value = new System.DateTime(2018, 12, 31, 0, 0, 0, 0);
            this.dtpDateOfBirth.Leave += new System.EventHandler(this.dtpDateOfBirth_Leave);
            // 
            // chkView2
            // 
            this.chkView2.Checked = true;
            this.chkView2.CheckedState.Image = global::PresentationLayer.Properties.Resources.hideEye;
            this.chkView2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.chkView2.Image = global::PresentationLayer.Properties.Resources.viewEye;
            this.chkView2.ImageOffset = new System.Drawing.Point(0, 0);
            this.chkView2.ImageRotate = 0F;
            this.chkView2.Location = new System.Drawing.Point(283, 319);
            this.chkView2.Name = "chkView2";
            this.chkView2.Size = new System.Drawing.Size(24, 24);
            this.chkView2.TabIndex = 68;
            this.chkView2.CheckedChanged += new System.EventHandler(this.chkView2_CheckedChanged);
            // 
            // txtLastname
            // 
            this.txtLastname.Animated = true;
            this.txtLastname.BorderRadius = 10;
            this.txtLastname.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtLastname.DefaultText = "";
            this.txtLastname.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtLastname.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtLastname.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtLastname.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtLastname.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtLastname.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtLastname.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.txtLastname.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtLastname.Location = new System.Drawing.Point(207, 79);
            this.txtLastname.MaxLength = 50;
            this.txtLastname.Name = "txtLastname";
            this.txtLastname.PlaceholderText = "Last name";
            this.txtLastname.SelectedText = "";
            this.txtLastname.Size = new System.Drawing.Size(180, 35);
            this.txtLastname.TabIndex = 1;
            this.txtLastname.Leave += new System.EventHandler(this.txtLastname_Leave);
            // 
            // txtFirstname
            // 
            this.txtFirstname.Animated = true;
            this.txtFirstname.BorderRadius = 10;
            this.txtFirstname.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtFirstname.DefaultText = "";
            this.txtFirstname.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtFirstname.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtFirstname.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtFirstname.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtFirstname.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtFirstname.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtFirstname.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.txtFirstname.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtFirstname.Location = new System.Drawing.Point(21, 79);
            this.txtFirstname.MaxLength = 50;
            this.txtFirstname.Name = "txtFirstname";
            this.txtFirstname.PlaceholderText = "First name";
            this.txtFirstname.SelectedText = "";
            this.txtFirstname.Size = new System.Drawing.Size(180, 35);
            this.txtFirstname.TabIndex = 0;
            this.txtFirstname.Leave += new System.EventHandler(this.txtFirstname_Leave);
            // 
            // txtPassword2
            // 
            this.txtPassword2.Animated = true;
            this.txtPassword2.BorderRadius = 10;
            this.txtPassword2.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtPassword2.DefaultText = "";
            this.txtPassword2.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtPassword2.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtPassword2.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtPassword2.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtPassword2.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtPassword2.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtPassword2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.txtPassword2.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtPassword2.Location = new System.Drawing.Point(21, 316);
            this.txtPassword2.MaxLength = 255;
            this.txtPassword2.Name = "txtPassword2";
            this.txtPassword2.PlaceholderText = "Password Again";
            this.txtPassword2.SelectedText = "";
            this.txtPassword2.Size = new System.Drawing.Size(256, 35);
            this.txtPassword2.TabIndex = 11;
            this.txtPassword2.UseSystemPasswordChar = true;
            this.txtPassword2.Leave += new System.EventHandler(this.txtPassword2_Leave);
            // 
            // chkView1
            // 
            this.chkView1.Checked = true;
            this.chkView1.CheckedState.Image = global::PresentationLayer.Properties.Resources.hideEye;
            this.chkView1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.chkView1.Image = global::PresentationLayer.Properties.Resources.viewEye;
            this.chkView1.ImageOffset = new System.Drawing.Point(0, 0);
            this.chkView1.ImageRotate = 0F;
            this.chkView1.Location = new System.Drawing.Point(283, 281);
            this.chkView1.Name = "chkView1";
            this.chkView1.Size = new System.Drawing.Size(24, 24);
            this.chkView1.TabIndex = 64;
            this.chkView1.CheckedChanged += new System.EventHandler(this.chkView1_CheckedChanged);
            // 
            // lblDescription
            // 
            this.lblDescription.BackColor = System.Drawing.Color.Transparent;
            this.lblDescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescription.Location = new System.Drawing.Point(146, 48);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(254, 26);
            this.lblDescription.TabIndex = 63;
            this.lblDescription.Text = "Create an account to continue";
            // 
            // txtEmail
            // 
            this.txtEmail.Animated = true;
            this.txtEmail.BorderRadius = 10;
            this.txtEmail.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtEmail.DefaultText = "";
            this.txtEmail.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtEmail.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtEmail.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtEmail.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtEmail.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtEmail.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtEmail.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.txtEmail.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtEmail.Location = new System.Drawing.Point(21, 120);
            this.txtEmail.MaxLength = 255;
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.PlaceholderText = "Email";
            this.txtEmail.SelectedText = "";
            this.txtEmail.Size = new System.Drawing.Size(190, 35);
            this.txtEmail.TabIndex = 3;
            this.txtEmail.Leave += new System.EventHandler(this.txtEmail_Leave);
            // 
            // txtPassword1
            // 
            this.txtPassword1.Animated = true;
            this.txtPassword1.BorderRadius = 10;
            this.txtPassword1.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtPassword1.DefaultText = "";
            this.txtPassword1.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtPassword1.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtPassword1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtPassword1.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtPassword1.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtPassword1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtPassword1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.txtPassword1.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtPassword1.Location = new System.Drawing.Point(21, 275);
            this.txtPassword1.MaxLength = 255;
            this.txtPassword1.Name = "txtPassword1";
            this.txtPassword1.PlaceholderText = "Password";
            this.txtPassword1.SelectedText = "";
            this.txtPassword1.Size = new System.Drawing.Size(256, 35);
            this.txtPassword1.TabIndex = 10;
            this.txtPassword1.UseSystemPasswordChar = true;
            // 
            // btnCreate
            // 
            this.btnCreate.Animated = true;
            this.btnCreate.BorderRadius = 10;
            this.btnCreate.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCreate.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnCreate.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnCreate.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnCreate.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnCreate.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(57)))), ((int)(((byte)(53)))));
            this.btnCreate.Font = new System.Drawing.Font("Segoe UI", 16F);
            this.btnCreate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.btnCreate.Location = new System.Drawing.Point(353, 365);
            this.btnCreate.Name = "btnCreate";
            this.btnCreate.Size = new System.Drawing.Size(173, 54);
            this.btnCreate.TabIndex = 12;
            this.btnCreate.Text = "Create";
            this.btnCreate.Click += new System.EventHandler(this.btnCreate_Click);
            // 
            // btnBack
            // 
            this.btnBack.Animated = true;
            this.btnBack.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(57)))), ((int)(((byte)(53)))));
            this.btnBack.BorderRadius = 10;
            this.btnBack.BorderThickness = 3;
            this.btnBack.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBack.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnBack.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnBack.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnBack.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnBack.FillColor = System.Drawing.Color.Transparent;
            this.btnBack.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.btnBack.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.btnBack.Location = new System.Drawing.Point(157, 365);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(190, 54);
            this.btnBack.TabIndex = 13;
            this.btnBack.Text = "Back to login";
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // lblWelcome
            // 
            this.lblWelcome.BackColor = System.Drawing.Color.Transparent;
            this.lblWelcome.Font = new System.Drawing.Font("Microsoft Sans Serif", 24.25F);
            this.lblWelcome.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(57)))), ((int)(((byte)(53)))));
            this.lblWelcome.Location = new System.Drawing.Point(202, 10);
            this.lblWelcome.Name = "lblWelcome";
            this.lblWelcome.Size = new System.Drawing.Size(136, 39);
            this.lblWelcome.TabIndex = 60;
            this.lblWelcome.Text = "Welcome";
            // 
            // SignupForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(229)))), ((int)(((byte)(229)))));
            this.ClientSize = new System.Drawing.Size(543, 436);
            this.Controls.Add(this.guna2ShadowPanel1);
            this.Name = "SignupForm";
            this.Text = "SignupForm";
            this.Load += new System.EventHandler(this.SignupForm_Load);
            this.guna2ShadowPanel1.ResumeLayout(false);
            this.guna2ShadowPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbPhoto)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2ShadowPanel guna2ShadowPanel1;
        private Guna.UI2.WinForms.Guna2CirclePictureBox pbPhoto;
        private Guna.UI2.WinForms.Guna2TextBox txtNationality;
        private Guna.UI2.WinForms.Guna2ComboBox cbGender;
        private Guna.UI2.WinForms.Guna2Shapes guna2Shapes1;
        private Guna.UI2.WinForms.Guna2TextBox txtPhone;
        private Guna.UI2.WinForms.Guna2TextBox txtIDnumber;
        private Guna.UI2.WinForms.Guna2TextBox txtUsername;
        private Guna.UI2.WinForms.Guna2DateTimePicker dtpDateOfBirth;
        private Guna.UI2.WinForms.Guna2ImageCheckBox chkView2;
        private Guna.UI2.WinForms.Guna2TextBox txtLastname;
        private Guna.UI2.WinForms.Guna2TextBox txtFirstname;
        private Guna.UI2.WinForms.Guna2TextBox txtPassword2;
        private Guna.UI2.WinForms.Guna2ImageCheckBox chkView1;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblDescription;
        private Guna.UI2.WinForms.Guna2TextBox txtEmail;
        private Guna.UI2.WinForms.Guna2TextBox txtPassword1;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblWelcome;
        private Guna.UI2.WinForms.Guna2Button btnCreate;
        private Guna.UI2.WinForms.Guna2Button btnBack;
        private Guna.UI2.WinForms.Guna2ComboBox cbCountrykeys;
    }
}