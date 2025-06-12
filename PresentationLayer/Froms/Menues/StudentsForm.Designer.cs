namespace PresentationLayer.Forms
{
    partial class StudentsForm
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgvStudentsIN = new Guna.UI2.WinForms.Guna2DataGridView();
            this.cmsStudent = new Guna.UI2.WinForms.Guna2ContextMenuStrip();
            this.cmsStudentUpdate = new System.Windows.Forms.ToolStripMenuItem();
            this.cmsStudentDelete = new System.Windows.Forms.ToolStripMenuItem();
            this.guna2ShadowPanel1 = new Guna.UI2.WinForms.Guna2ShadowPanel();
            this.btnFilter = new Guna.UI2.WinForms.Guna2Button();
            this.lblStudentsInsideLibrary = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2ShadowPanel2 = new Guna.UI2.WinForms.Guna2ShadowPanel();
            this.btnAddStudent = new Guna.UI2.WinForms.Guna2Button();
            this.btnFilter2 = new Guna.UI2.WinForms.Guna2Button();
            this.dgvAllStudents = new Guna.UI2.WinForms.Guna2DataGridView();
            this.lblAllStudents = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2ShadowPanel3 = new Guna.UI2.WinForms.Guna2ShadowPanel();
            this.dgvBlockedStudents = new Guna.UI2.WinForms.Guna2DataGridView();
            this.lblBlockedStudents = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2ShadowPanel4 = new Guna.UI2.WinForms.Guna2ShadowPanel();
            this.lblAllLibraries = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.pbarStudentCountAllLib = new Guna.UI2.WinForms.Guna2CircleProgressBar();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dgvStudentsIN)).BeginInit();
            this.cmsStudent.SuspendLayout();
            this.guna2ShadowPanel1.SuspendLayout();
            this.guna2ShadowPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAllStudents)).BeginInit();
            this.guna2ShadowPanel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBlockedStudents)).BeginInit();
            this.guna2ShadowPanel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvStudentsIN
            // 
            this.dgvStudentsIN.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dgvStudentsIN.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvStudentsIN.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvStudentsIN.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(57)))), ((int)(((byte)(53)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(57)))), ((int)(((byte)(53)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvStudentsIN.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvStudentsIN.ColumnHeadersHeight = 26;
            this.dgvStudentsIN.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dgvStudentsIN.ContextMenuStrip = this.cmsStudent;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvStudentsIN.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvStudentsIN.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvStudentsIN.Location = new System.Drawing.Point(30, 81);
            this.dgvStudentsIN.MultiSelect = false;
            this.dgvStudentsIN.Name = "dgvStudentsIN";
            this.dgvStudentsIN.ReadOnly = true;
            this.dgvStudentsIN.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvStudentsIN.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvStudentsIN.RowHeadersVisible = false;
            this.dgvStudentsIN.Size = new System.Drawing.Size(254, 299);
            this.dgvStudentsIN.TabIndex = 0;
            this.dgvStudentsIN.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvStudentsIN.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dgvStudentsIN.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dgvStudentsIN.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dgvStudentsIN.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dgvStudentsIN.ThemeStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.dgvStudentsIN.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvStudentsIN.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.dgvStudentsIN.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvStudentsIN.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvStudentsIN.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dgvStudentsIN.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dgvStudentsIN.ThemeStyle.HeaderStyle.Height = 26;
            this.dgvStudentsIN.ThemeStyle.ReadOnly = true;
            this.dgvStudentsIN.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvStudentsIN.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvStudentsIN.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvStudentsIN.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dgvStudentsIN.ThemeStyle.RowsStyle.Height = 22;
            this.dgvStudentsIN.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvStudentsIN.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            // 
            // cmsStudent
            // 
            this.cmsStudent.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cmsStudentUpdate,
            this.cmsStudentDelete});
            this.cmsStudent.Name = "cmsStudent";
            this.cmsStudent.RenderStyle.ArrowColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.cmsStudent.RenderStyle.BorderColor = System.Drawing.Color.Gainsboro;
            this.cmsStudent.RenderStyle.ColorTable = null;
            this.cmsStudent.RenderStyle.RoundedEdges = true;
            this.cmsStudent.RenderStyle.SelectionArrowColor = System.Drawing.Color.White;
            this.cmsStudent.RenderStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.cmsStudent.RenderStyle.SelectionForeColor = System.Drawing.Color.White;
            this.cmsStudent.RenderStyle.SeparatorColor = System.Drawing.Color.Gainsboro;
            this.cmsStudent.RenderStyle.TextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault;
            this.cmsStudent.Size = new System.Drawing.Size(113, 48);
            // 
            // cmsStudentUpdate
            // 
            this.cmsStudentUpdate.Name = "cmsStudentUpdate";
            this.cmsStudentUpdate.Size = new System.Drawing.Size(112, 22);
            this.cmsStudentUpdate.Text = "Update";
            this.cmsStudentUpdate.Click += new System.EventHandler(this.cmsStudentUpdate_Click);
            // 
            // cmsStudentDelete
            // 
            this.cmsStudentDelete.Name = "cmsStudentDelete";
            this.cmsStudentDelete.Size = new System.Drawing.Size(112, 22);
            this.cmsStudentDelete.Text = "Delete";
            this.cmsStudentDelete.Click += new System.EventHandler(this.cmsStudentDelete_Click);
            // 
            // guna2ShadowPanel1
            // 
            this.guna2ShadowPanel1.BackColor = System.Drawing.Color.Transparent;
            this.guna2ShadowPanel1.Controls.Add(this.btnFilter);
            this.guna2ShadowPanel1.Controls.Add(this.dgvStudentsIN);
            this.guna2ShadowPanel1.Controls.Add(this.lblStudentsInsideLibrary);
            this.guna2ShadowPanel1.FillColor = System.Drawing.Color.White;
            this.guna2ShadowPanel1.Location = new System.Drawing.Point(13, 16);
            this.guna2ShadowPanel1.Name = "guna2ShadowPanel1";
            this.guna2ShadowPanel1.Radius = 15;
            this.guna2ShadowPanel1.ShadowColor = System.Drawing.Color.Black;
            this.guna2ShadowPanel1.Size = new System.Drawing.Size(306, 411);
            this.guna2ShadowPanel1.TabIndex = 2;
            // 
            // btnFilter
            // 
            this.btnFilter.Animated = true;
            this.btnFilter.BorderRadius = 10;
            this.btnFilter.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnFilter.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnFilter.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnFilter.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnFilter.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnFilter.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(57)))), ((int)(((byte)(53)))));
            this.btnFilter.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFilter.ForeColor = System.Drawing.Color.White;
            this.btnFilter.Location = new System.Drawing.Point(184, 11);
            this.btnFilter.Name = "btnFilter";
            this.btnFilter.Size = new System.Drawing.Size(100, 64);
            this.btnFilter.TabIndex = 2;
            this.btnFilter.Text = "Add Filter";
            this.btnFilter.Click += new System.EventHandler(this.btnFilter_Click);
            // 
            // lblStudentsInsideLibrary
            // 
            this.lblStudentsInsideLibrary.AutoSize = false;
            this.lblStudentsInsideLibrary.AutoSizeHeightOnly = true;
            this.lblStudentsInsideLibrary.BackColor = System.Drawing.Color.Transparent;
            this.lblStudentsInsideLibrary.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.lblStudentsInsideLibrary.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(57)))), ((int)(((byte)(53)))));
            this.lblStudentsInsideLibrary.Location = new System.Drawing.Point(30, 20);
            this.lblStudentsInsideLibrary.Name = "lblStudentsInsideLibrary";
            this.lblStudentsInsideLibrary.Size = new System.Drawing.Size(166, 51);
            this.lblStudentsInsideLibrary.TabIndex = 1;
            this.lblStudentsInsideLibrary.Text = "Students inside library:";
            // 
            // guna2ShadowPanel2
            // 
            this.guna2ShadowPanel2.BackColor = System.Drawing.Color.Transparent;
            this.guna2ShadowPanel2.Controls.Add(this.btnAddStudent);
            this.guna2ShadowPanel2.Controls.Add(this.btnFilter2);
            this.guna2ShadowPanel2.Controls.Add(this.dgvAllStudents);
            this.guna2ShadowPanel2.Controls.Add(this.lblAllStudents);
            this.guna2ShadowPanel2.FillColor = System.Drawing.Color.White;
            this.guna2ShadowPanel2.Location = new System.Drawing.Point(13, 433);
            this.guna2ShadowPanel2.Name = "guna2ShadowPanel2";
            this.guna2ShadowPanel2.Radius = 15;
            this.guna2ShadowPanel2.ShadowColor = System.Drawing.Color.Black;
            this.guna2ShadowPanel2.Size = new System.Drawing.Size(601, 411);
            this.guna2ShadowPanel2.TabIndex = 3;
            // 
            // btnAddStudent
            // 
            this.btnAddStudent.Animated = true;
            this.btnAddStudent.BorderRadius = 10;
            this.btnAddStudent.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAddStudent.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnAddStudent.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnAddStudent.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnAddStudent.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnAddStudent.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(57)))), ((int)(((byte)(53)))));
            this.btnAddStudent.Font = new System.Drawing.Font("Segoe UI", 14.25F);
            this.btnAddStudent.ForeColor = System.Drawing.Color.White;
            this.btnAddStudent.Location = new System.Drawing.Point(250, 29);
            this.btnAddStudent.Name = "btnAddStudent";
            this.btnAddStudent.Size = new System.Drawing.Size(162, 33);
            this.btnAddStudent.TabIndex = 4;
            this.btnAddStudent.Text = "Add student";
            this.btnAddStudent.Click += new System.EventHandler(this.btnAddStudent_Click);
            // 
            // btnFilter2
            // 
            this.btnFilter2.Animated = true;
            this.btnFilter2.BorderRadius = 10;
            this.btnFilter2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnFilter2.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnFilter2.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnFilter2.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnFilter2.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnFilter2.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(57)))), ((int)(((byte)(53)))));
            this.btnFilter2.Font = new System.Drawing.Font("Segoe UI", 14.25F);
            this.btnFilter2.ForeColor = System.Drawing.Color.White;
            this.btnFilter2.Location = new System.Drawing.Point(418, 29);
            this.btnFilter2.Name = "btnFilter2";
            this.btnFilter2.Size = new System.Drawing.Size(162, 33);
            this.btnFilter2.TabIndex = 3;
            this.btnFilter2.Text = "Add Filter";
            this.btnFilter2.Click += new System.EventHandler(this.btnFilter2_Click);
            // 
            // dgvAllStudents
            // 
            this.dgvAllStudents.AllowUserToResizeRows = false;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dgvAllStudents.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle5;
            this.dgvAllStudents.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvAllStudents.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(57)))), ((int)(((byte)(53)))));
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(57)))), ((int)(((byte)(53)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvAllStudents.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.dgvAllStudents.ColumnHeadersHeight = 26;
            this.dgvAllStudents.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dgvAllStudents.ContextMenuStrip = this.cmsStudent;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvAllStudents.DefaultCellStyle = dataGridViewCellStyle7;
            this.dgvAllStudents.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvAllStudents.Location = new System.Drawing.Point(30, 81);
            this.dgvAllStudents.MultiSelect = false;
            this.dgvAllStudents.Name = "dgvAllStudents";
            this.dgvAllStudents.ReadOnly = true;
            this.dgvAllStudents.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvAllStudents.RowHeadersDefaultCellStyle = dataGridViewCellStyle8;
            this.dgvAllStudents.RowHeadersVisible = false;
            this.dgvAllStudents.Size = new System.Drawing.Size(542, 299);
            this.dgvAllStudents.TabIndex = 0;
            this.dgvAllStudents.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvAllStudents.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dgvAllStudents.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dgvAllStudents.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dgvAllStudents.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dgvAllStudents.ThemeStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.dgvAllStudents.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvAllStudents.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.dgvAllStudents.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvAllStudents.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvAllStudents.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dgvAllStudents.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dgvAllStudents.ThemeStyle.HeaderStyle.Height = 26;
            this.dgvAllStudents.ThemeStyle.ReadOnly = true;
            this.dgvAllStudents.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvAllStudents.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvAllStudents.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvAllStudents.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dgvAllStudents.ThemeStyle.RowsStyle.Height = 22;
            this.dgvAllStudents.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvAllStudents.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            // 
            // lblAllStudents
            // 
            this.lblAllStudents.BackColor = System.Drawing.Color.Transparent;
            this.lblAllStudents.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.lblAllStudents.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(57)))), ((int)(((byte)(53)))));
            this.lblAllStudents.Location = new System.Drawing.Point(50, 35);
            this.lblAllStudents.Name = "lblAllStudents";
            this.lblAllStudents.Size = new System.Drawing.Size(121, 27);
            this.lblAllStudents.TabIndex = 1;
            this.lblAllStudents.Text = "All students:";
            // 
            // guna2ShadowPanel3
            // 
            this.guna2ShadowPanel3.BackColor = System.Drawing.Color.Transparent;
            this.guna2ShadowPanel3.Controls.Add(this.dgvBlockedStudents);
            this.guna2ShadowPanel3.Controls.Add(this.lblBlockedStudents);
            this.guna2ShadowPanel3.FillColor = System.Drawing.Color.White;
            this.guna2ShadowPanel3.Location = new System.Drawing.Point(327, 16);
            this.guna2ShadowPanel3.Name = "guna2ShadowPanel3";
            this.guna2ShadowPanel3.Radius = 15;
            this.guna2ShadowPanel3.ShadowColor = System.Drawing.Color.Black;
            this.guna2ShadowPanel3.Size = new System.Drawing.Size(287, 239);
            this.guna2ShadowPanel3.TabIndex = 3;
            // 
            // dgvBlockedStudents
            // 
            this.dgvBlockedStudents.AllowUserToResizeRows = false;
            dataGridViewCellStyle9.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle9.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dgvBlockedStudents.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle9;
            this.dgvBlockedStudents.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvBlockedStudents.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(57)))), ((int)(((byte)(53)))));
            dataGridViewCellStyle10.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle10.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle10.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(57)))), ((int)(((byte)(53)))));
            dataGridViewCellStyle10.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvBlockedStudents.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle10;
            this.dgvBlockedStudents.ColumnHeadersHeight = 26;
            this.dgvBlockedStudents.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dgvBlockedStudents.ContextMenuStrip = this.cmsStudent;
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle11.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle11.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle11.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle11.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            dataGridViewCellStyle11.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvBlockedStudents.DefaultCellStyle = dataGridViewCellStyle11;
            this.dgvBlockedStudents.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvBlockedStudents.Location = new System.Drawing.Point(30, 52);
            this.dgvBlockedStudents.MultiSelect = false;
            this.dgvBlockedStudents.Name = "dgvBlockedStudents";
            this.dgvBlockedStudents.ReadOnly = true;
            this.dgvBlockedStudents.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle12.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle12.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle12.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle12.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle12.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle12.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvBlockedStudents.RowHeadersDefaultCellStyle = dataGridViewCellStyle12;
            this.dgvBlockedStudents.RowHeadersVisible = false;
            this.dgvBlockedStudents.Size = new System.Drawing.Size(228, 164);
            this.dgvBlockedStudents.TabIndex = 0;
            this.dgvBlockedStudents.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvBlockedStudents.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dgvBlockedStudents.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dgvBlockedStudents.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dgvBlockedStudents.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dgvBlockedStudents.ThemeStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.dgvBlockedStudents.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvBlockedStudents.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.dgvBlockedStudents.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvBlockedStudents.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvBlockedStudents.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dgvBlockedStudents.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dgvBlockedStudents.ThemeStyle.HeaderStyle.Height = 26;
            this.dgvBlockedStudents.ThemeStyle.ReadOnly = true;
            this.dgvBlockedStudents.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvBlockedStudents.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvBlockedStudents.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvBlockedStudents.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dgvBlockedStudents.ThemeStyle.RowsStyle.Height = 22;
            this.dgvBlockedStudents.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvBlockedStudents.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            // 
            // lblBlockedStudents
            // 
            this.lblBlockedStudents.AutoSize = false;
            this.lblBlockedStudents.AutoSizeHeightOnly = true;
            this.lblBlockedStudents.BackColor = System.Drawing.Color.Transparent;
            this.lblBlockedStudents.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.lblBlockedStudents.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(57)))), ((int)(((byte)(53)))));
            this.lblBlockedStudents.Location = new System.Drawing.Point(30, 20);
            this.lblBlockedStudents.Name = "lblBlockedStudents";
            this.lblBlockedStudents.Size = new System.Drawing.Size(187, 26);
            this.lblBlockedStudents.TabIndex = 1;
            this.lblBlockedStudents.Text = "Blocked Students:";
            // 
            // guna2ShadowPanel4
            // 
            this.guna2ShadowPanel4.BackColor = System.Drawing.Color.Transparent;
            this.guna2ShadowPanel4.Controls.Add(this.lblAllLibraries);
            this.guna2ShadowPanel4.Controls.Add(this.pbarStudentCountAllLib);
            this.guna2ShadowPanel4.FillColor = System.Drawing.Color.White;
            this.guna2ShadowPanel4.Location = new System.Drawing.Point(327, 261);
            this.guna2ShadowPanel4.Name = "guna2ShadowPanel4";
            this.guna2ShadowPanel4.Radius = 15;
            this.guna2ShadowPanel4.ShadowColor = System.Drawing.Color.Black;
            this.guna2ShadowPanel4.Size = new System.Drawing.Size(287, 166);
            this.guna2ShadowPanel4.TabIndex = 4;
            // 
            // lblAllLibraries
            // 
            this.lblAllLibraries.AutoSize = false;
            this.lblAllLibraries.AutoSizeHeightOnly = true;
            this.lblAllLibraries.BackColor = System.Drawing.Color.Transparent;
            this.lblAllLibraries.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.lblAllLibraries.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(57)))), ((int)(((byte)(53)))));
            this.lblAllLibraries.Location = new System.Drawing.Point(86, 10);
            this.lblAllLibraries.Name = "lblAllLibraries";
            this.lblAllLibraries.Size = new System.Drawing.Size(126, 26);
            this.lblAllLibraries.TabIndex = 4;
            this.lblAllLibraries.Text = "All Libraries:";
            // 
            // pbarStudentCountAllLib
            // 
            this.pbarStudentCountAllLib.Animated = true;
            this.pbarStudentCountAllLib.AnimationSpeed = 0.1F;
            this.pbarStudentCountAllLib.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(213)))), ((int)(((byte)(218)))), ((int)(((byte)(223)))));
            this.pbarStudentCountAllLib.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.pbarStudentCountAllLib.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(57)))), ((int)(((byte)(53)))));
            this.pbarStudentCountAllLib.Location = new System.Drawing.Point(88, 43);
            this.pbarStudentCountAllLib.Minimum = 0;
            this.pbarStudentCountAllLib.Name = "pbarStudentCountAllLib";
            this.pbarStudentCountAllLib.ProgressColor = System.Drawing.Color.Red;
            this.pbarStudentCountAllLib.ProgressColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.pbarStudentCountAllLib.ProgressEndCap = System.Drawing.Drawing2D.LineCap.Round;
            this.pbarStudentCountAllLib.ProgressStartCap = System.Drawing.Drawing2D.LineCap.Round;
            this.pbarStudentCountAllLib.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.pbarStudentCountAllLib.ShowText = true;
            this.pbarStudentCountAllLib.Size = new System.Drawing.Size(111, 111);
            this.pbarStudentCountAllLib.TabIndex = 1;
            this.pbarStudentCountAllLib.Text = "xxx/100";
            this.pbarStudentCountAllLib.TextMode = Guna.UI2.WinForms.Enums.ProgressBarTextMode.Custom;
            this.pbarStudentCountAllLib.Value = 60;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 10000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // StudentsForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(229)))), ((int)(((byte)(229)))));
            this.Controls.Add(this.guna2ShadowPanel4);
            this.Controls.Add(this.guna2ShadowPanel3);
            this.Controls.Add(this.guna2ShadowPanel2);
            this.Controls.Add(this.guna2ShadowPanel1);
            this.Name = "StudentsForm";
            this.Size = new System.Drawing.Size(648, 897);
            this.Load += new System.EventHandler(this.StudentsForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvStudentsIN)).EndInit();
            this.cmsStudent.ResumeLayout(false);
            this.guna2ShadowPanel1.ResumeLayout(false);
            this.guna2ShadowPanel2.ResumeLayout(false);
            this.guna2ShadowPanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAllStudents)).EndInit();
            this.guna2ShadowPanel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvBlockedStudents)).EndInit();
            this.guna2ShadowPanel4.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2DataGridView dgvStudentsIN;
        private Guna.UI2.WinForms.Guna2ShadowPanel guna2ShadowPanel1;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblStudentsInsideLibrary;
        private Guna.UI2.WinForms.Guna2ShadowPanel guna2ShadowPanel2;
        private Guna.UI2.WinForms.Guna2DataGridView dgvAllStudents;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblAllStudents;
        private Guna.UI2.WinForms.Guna2Button btnFilter;
        private Guna.UI2.WinForms.Guna2Button btnFilter2;
        private Guna.UI2.WinForms.Guna2Button btnAddStudent;
        private Guna.UI2.WinForms.Guna2ShadowPanel guna2ShadowPanel3;
        private Guna.UI2.WinForms.Guna2DataGridView dgvBlockedStudents;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblBlockedStudents;
        private Guna.UI2.WinForms.Guna2ShadowPanel guna2ShadowPanel4;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblAllLibraries;
        private Guna.UI2.WinForms.Guna2CircleProgressBar pbarStudentCountAllLib;
        private Guna.UI2.WinForms.Guna2ContextMenuStrip cmsStudent;
        private System.Windows.Forms.ToolStripMenuItem cmsStudentUpdate;
        private System.Windows.Forms.ToolStripMenuItem cmsStudentDelete;
        private System.Windows.Forms.Timer timer1;
    }
}
