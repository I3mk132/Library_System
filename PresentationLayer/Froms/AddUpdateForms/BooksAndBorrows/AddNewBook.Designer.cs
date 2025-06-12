namespace PresentationLayer.Froms.AddUpdateForms.AddBookPanel
{
    partial class AddNewBook
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.guna2ShadowPanel2 = new Guna.UI2.WinForms.Guna2ShadowPanel();
            this.btnSearch = new Guna.UI2.WinForms.Guna2Button();
            this.pbPhoto = new Guna.UI2.WinForms.Guna2PictureBox();
            this.pbISBNbarcode = new Guna.UI2.WinForms.Guna2PictureBox();
            this.txtDetails = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtGenre = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtAuthor = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtTitle = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtISBN = new Guna.UI2.WinForms.Guna2TextBox();
            this.lblBookInfo = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.dtpPublicationDate = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.guna2ShadowPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbPhoto)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbISBNbarcode)).BeginInit();
            this.SuspendLayout();
            // 
            // guna2ShadowPanel2
            // 
            this.guna2ShadowPanel2.BackColor = System.Drawing.Color.Transparent;
            this.guna2ShadowPanel2.Controls.Add(this.btnSearch);
            this.guna2ShadowPanel2.Controls.Add(this.pbPhoto);
            this.guna2ShadowPanel2.Controls.Add(this.pbISBNbarcode);
            this.guna2ShadowPanel2.Controls.Add(this.txtDetails);
            this.guna2ShadowPanel2.Controls.Add(this.txtGenre);
            this.guna2ShadowPanel2.Controls.Add(this.txtAuthor);
            this.guna2ShadowPanel2.Controls.Add(this.txtTitle);
            this.guna2ShadowPanel2.Controls.Add(this.txtISBN);
            this.guna2ShadowPanel2.Controls.Add(this.lblBookInfo);
            this.guna2ShadowPanel2.Controls.Add(this.dtpPublicationDate);
            this.guna2ShadowPanel2.FillColor = System.Drawing.Color.White;
            this.guna2ShadowPanel2.Location = new System.Drawing.Point(39, 9);
            this.guna2ShadowPanel2.Name = "guna2ShadowPanel2";
            this.guna2ShadowPanel2.Radius = 10;
            this.guna2ShadowPanel2.ShadowColor = System.Drawing.Color.Black;
            this.guna2ShadowPanel2.ShadowShift = 4;
            this.guna2ShadowPanel2.Size = new System.Drawing.Size(552, 283);
            this.guna2ShadowPanel2.TabIndex = 89;
            // 
            // btnSearch
            // 
            this.btnSearch.BorderRadius = 10;
            this.btnSearch.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(57)))), ((int)(((byte)(53)))));
            this.btnSearch.CheckedState.Image = global::PresentationLayer.Properties.Resources.loupeWhite;
            this.btnSearch.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnSearch.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnSearch.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnSearch.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnSearch.FillColor = System.Drawing.SystemColors.Control;
            this.btnSearch.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnSearch.ForeColor = System.Drawing.SystemColors.Control;
            this.btnSearch.Image = global::PresentationLayer.Properties.Resources.loupe;
            this.btnSearch.ImageSize = new System.Drawing.Size(27, 27);
            this.btnSearch.Location = new System.Drawing.Point(186, 135);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(35, 35);
            this.btnSearch.TabIndex = 87;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // pbPhoto
            // 
            this.pbPhoto.FillColor = System.Drawing.SystemColors.Control;
            this.pbPhoto.ImageRotate = 0F;
            this.pbPhoto.Location = new System.Drawing.Point(381, 94);
            this.pbPhoto.Name = "pbPhoto";
            this.pbPhoto.Size = new System.Drawing.Size(142, 165);
            this.pbPhoto.TabIndex = 86;
            this.pbPhoto.TabStop = false;
            this.pbPhoto.Click += new System.EventHandler(this.pbPhoto_Click);
            // 
            // pbISBNbarcode
            // 
            this.pbISBNbarcode.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbISBNbarcode.FillColor = System.Drawing.SystemColors.Control;
            this.pbISBNbarcode.ImageRotate = 0F;
            this.pbISBNbarcode.Location = new System.Drawing.Point(23, 176);
            this.pbISBNbarcode.Name = "pbISBNbarcode";
            this.pbISBNbarcode.Size = new System.Drawing.Size(202, 83);
            this.pbISBNbarcode.TabIndex = 85;
            this.pbISBNbarcode.TabStop = false;
            this.pbISBNbarcode.Click += new System.EventHandler(this.pbISBNbarcode_Click);
            // 
            // txtDetails
            // 
            this.txtDetails.Animated = true;
            this.txtDetails.BorderRadius = 10;
            this.txtDetails.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtDetails.DefaultText = "";
            this.txtDetails.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtDetails.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtDetails.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtDetails.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtDetails.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtDetails.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtDetails.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.txtDetails.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtDetails.Location = new System.Drawing.Point(231, 94);
            this.txtDetails.Multiline = true;
            this.txtDetails.Name = "txtDetails";
            this.txtDetails.PlaceholderText = "Details";
            this.txtDetails.SelectedText = "";
            this.txtDetails.Size = new System.Drawing.Size(144, 165);
            this.txtDetails.TabIndex = 83;
            this.txtDetails.TextChanged += new System.EventHandler(this.txtDetails_TextChanged);
            // 
            // txtGenre
            // 
            this.txtGenre.Animated = true;
            this.txtGenre.BorderRadius = 10;
            this.txtGenre.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtGenre.DefaultText = "";
            this.txtGenre.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtGenre.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtGenre.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtGenre.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtGenre.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtGenre.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtGenre.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.txtGenre.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtGenre.Location = new System.Drawing.Point(23, 94);
            this.txtGenre.Name = "txtGenre";
            this.txtGenre.PlaceholderText = "Genre";
            this.txtGenre.SelectedText = "";
            this.txtGenre.Size = new System.Drawing.Size(202, 35);
            this.txtGenre.TabIndex = 82;
            this.txtGenre.TextChanged += new System.EventHandler(this.txtGenre_TextChanged);
            // 
            // txtAuthor
            // 
            this.txtAuthor.Animated = true;
            this.txtAuthor.BorderRadius = 10;
            this.txtAuthor.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtAuthor.DefaultText = "";
            this.txtAuthor.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtAuthor.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtAuthor.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtAuthor.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtAuthor.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtAuthor.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtAuthor.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.txtAuthor.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtAuthor.Location = new System.Drawing.Point(283, 53);
            this.txtAuthor.Name = "txtAuthor";
            this.txtAuthor.PlaceholderText = "Author";
            this.txtAuthor.SelectedText = "";
            this.txtAuthor.Size = new System.Drawing.Size(205, 35);
            this.txtAuthor.TabIndex = 81;
            this.txtAuthor.TextChanged += new System.EventHandler(this.txtAuthor_TextChanged);
            // 
            // txtTitle
            // 
            this.txtTitle.Animated = true;
            this.txtTitle.BorderRadius = 10;
            this.txtTitle.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtTitle.DefaultText = "";
            this.txtTitle.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtTitle.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtTitle.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtTitle.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtTitle.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtTitle.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.txtTitle.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtTitle.Location = new System.Drawing.Point(23, 53);
            this.txtTitle.Name = "txtTitle";
            this.txtTitle.PlaceholderText = "Title";
            this.txtTitle.SelectedText = "";
            this.txtTitle.Size = new System.Drawing.Size(254, 35);
            this.txtTitle.TabIndex = 80;
            this.txtTitle.TextChanged += new System.EventHandler(this.txtTitle_TextChanged);
            // 
            // txtISBN
            // 
            this.txtISBN.Animated = true;
            this.txtISBN.BorderRadius = 10;
            this.txtISBN.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtISBN.DefaultText = "";
            this.txtISBN.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtISBN.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtISBN.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtISBN.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtISBN.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtISBN.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtISBN.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.txtISBN.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtISBN.Location = new System.Drawing.Point(23, 135);
            this.txtISBN.Name = "txtISBN";
            this.txtISBN.PlaceholderText = "ISBN";
            this.txtISBN.SelectedText = "";
            this.txtISBN.Size = new System.Drawing.Size(157, 35);
            this.txtISBN.TabIndex = 71;
            this.txtISBN.TextChanged += new System.EventHandler(this.txtISBN_TextChanged);
            // 
            // lblBookInfo
            // 
            this.lblBookInfo.BackColor = System.Drawing.Color.Transparent;
            this.lblBookInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F);
            this.lblBookInfo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(57)))), ((int)(((byte)(53)))));
            this.lblBookInfo.Location = new System.Drawing.Point(33, 10);
            this.lblBookInfo.Name = "lblBookInfo";
            this.lblBookInfo.Size = new System.Drawing.Size(124, 33);
            this.lblBookInfo.TabIndex = 78;
            this.lblBookInfo.Text = "Book info: ";
            // 
            // dtpPublicationDate
            // 
            this.dtpPublicationDate.Animated = true;
            this.dtpPublicationDate.BorderRadius = 10;
            this.dtpPublicationDate.Checked = true;
            this.dtpPublicationDate.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dtpPublicationDate.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(57)))), ((int)(((byte)(53)))));
            this.dtpPublicationDate.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.dtpPublicationDate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.dtpPublicationDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpPublicationDate.Location = new System.Drawing.Point(196, 12);
            this.dtpPublicationDate.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.dtpPublicationDate.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.dtpPublicationDate.Name = "dtpPublicationDate";
            this.dtpPublicationDate.Size = new System.Drawing.Size(210, 35);
            this.dtpPublicationDate.TabIndex = 69;
            this.dtpPublicationDate.Value = new System.DateTime(2025, 5, 9, 19, 32, 22, 884);
            this.dtpPublicationDate.ValueChanged += new System.EventHandler(this.dtpPublicationDate_ValueChanged);
            // 
            // AddNewBook
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(229)))), ((int)(((byte)(229)))));
            this.Controls.Add(this.guna2ShadowPanel2);
            this.Name = "AddNewBook";
            this.Size = new System.Drawing.Size(624, 304);
            this.Load += new System.EventHandler(this.AddNewBook_Load);
            this.guna2ShadowPanel2.ResumeLayout(false);
            this.guna2ShadowPanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbPhoto)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbISBNbarcode)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2ShadowPanel guna2ShadowPanel2;
        private Guna.UI2.WinForms.Guna2TextBox txtGenre;
        private Guna.UI2.WinForms.Guna2TextBox txtAuthor;
        private Guna.UI2.WinForms.Guna2TextBox txtTitle;
        private Guna.UI2.WinForms.Guna2TextBox txtISBN;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblBookInfo;
        private Guna.UI2.WinForms.Guna2DateTimePicker dtpPublicationDate;
        private Guna.UI2.WinForms.Guna2TextBox txtDetails;
        private Guna.UI2.WinForms.Guna2PictureBox pbISBNbarcode;
        private Guna.UI2.WinForms.Guna2PictureBox pbPhoto;
        private Guna.UI2.WinForms.Guna2Button btnSearch;
    }
}
