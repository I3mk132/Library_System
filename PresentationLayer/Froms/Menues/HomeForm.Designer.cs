namespace PresentationLayer.Forms
{
    partial class HomeForm
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
            this.guna2ShadowPanel1 = new Guna.UI2.WinForms.Guna2ShadowPanel();
            this.dgvTasks = new Guna.UI2.WinForms.Guna2DataGridView();
            this.cmsTasks = new Guna.UI2.WinForms.Guna2ContextMenuStrip();
            this.cmsTasksFinishTask = new System.Windows.Forms.ToolStripMenuItem();
            this.lblYourTasks = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2ShadowPanel2 = new Guna.UI2.WinForms.Guna2ShadowPanel();
            this.lblNearOrOutdateBorrows = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.dgvBorrows = new Guna.UI2.WinForms.Guna2DataGridView();
            this.guna2ShadowPanel3 = new Guna.UI2.WinForms.Guna2ShadowPanel();
            this.lblShiftRemainingTime = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.lblCurrentShiftRemainingTime = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.pbarCurrentShift = new Guna.UI2.WinForms.Guna2CircleProgressBar();
            this.guna2ShadowPanel4 = new Guna.UI2.WinForms.Guna2ShadowPanel();
            this.lblEmployeeName = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.lblWelcome = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.pbEmployee = new Guna.UI2.WinForms.Guna2CirclePictureBox();
            this.guna2ShadowPanel5 = new Guna.UI2.WinForms.Guna2ShadowPanel();
            this.pbDepartmentMinimumAge = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.lblDepartmentName = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.pbDepartmentImage = new Guna.UI2.WinForms.Guna2PictureBox();
            this.lblCurrentDepartment = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2ShadowPanel6 = new Guna.UI2.WinForms.Guna2ShadowPanel();
            this.lblCurrentTime = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.Clock = new System.Windows.Forms.Timer(this.components);
            this.ClockMin = new System.Windows.Forms.Timer(this.components);
            this.guna2ShadowPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTasks)).BeginInit();
            this.cmsTasks.SuspendLayout();
            this.guna2ShadowPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBorrows)).BeginInit();
            this.guna2ShadowPanel3.SuspendLayout();
            this.guna2ShadowPanel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbEmployee)).BeginInit();
            this.guna2ShadowPanel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbDepartmentImage)).BeginInit();
            this.guna2ShadowPanel6.SuspendLayout();
            this.SuspendLayout();
            // 
            // guna2ShadowPanel1
            // 
            this.guna2ShadowPanel1.BackColor = System.Drawing.Color.Transparent;
            this.guna2ShadowPanel1.Controls.Add(this.dgvTasks);
            this.guna2ShadowPanel1.Controls.Add(this.lblYourTasks);
            this.guna2ShadowPanel1.FillColor = System.Drawing.Color.White;
            this.guna2ShadowPanel1.Location = new System.Drawing.Point(338, 87);
            this.guna2ShadowPanel1.Name = "guna2ShadowPanel1";
            this.guna2ShadowPanel1.Radius = 10;
            this.guna2ShadowPanel1.ShadowColor = System.Drawing.Color.Black;
            this.guna2ShadowPanel1.Size = new System.Drawing.Size(284, 321);
            this.guna2ShadowPanel1.TabIndex = 0;
            // 
            // dgvTasks
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.dgvTasks.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvTasks.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvTasks.BackgroundColor = System.Drawing.Color.Gray;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(57)))), ((int)(((byte)(53)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(57)))), ((int)(((byte)(53)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvTasks.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvTasks.ColumnHeadersHeight = 4;
            this.dgvTasks.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dgvTasks.ContextMenuStrip = this.cmsTasks;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvTasks.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvTasks.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvTasks.Location = new System.Drawing.Point(25, 52);
            this.dgvTasks.MultiSelect = false;
            this.dgvTasks.Name = "dgvTasks";
            this.dgvTasks.ReadOnly = true;
            this.dgvTasks.RowHeadersVisible = false;
            this.dgvTasks.Size = new System.Drawing.Size(239, 242);
            this.dgvTasks.TabIndex = 4;
            this.dgvTasks.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvTasks.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dgvTasks.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dgvTasks.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dgvTasks.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dgvTasks.ThemeStyle.BackColor = System.Drawing.Color.Gray;
            this.dgvTasks.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvTasks.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(57)))), ((int)(((byte)(53)))));
            this.dgvTasks.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvTasks.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvTasks.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dgvTasks.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dgvTasks.ThemeStyle.HeaderStyle.Height = 4;
            this.dgvTasks.ThemeStyle.ReadOnly = true;
            this.dgvTasks.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvTasks.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvTasks.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvTasks.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dgvTasks.ThemeStyle.RowsStyle.Height = 22;
            this.dgvTasks.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvTasks.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            // 
            // cmsTasks
            // 
            this.cmsTasks.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cmsTasksFinishTask});
            this.cmsTasks.Name = "cmsTasks";
            this.cmsTasks.RenderStyle.ArrowColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.cmsTasks.RenderStyle.BorderColor = System.Drawing.Color.Gainsboro;
            this.cmsTasks.RenderStyle.ColorTable = null;
            this.cmsTasks.RenderStyle.RoundedEdges = true;
            this.cmsTasks.RenderStyle.SelectionArrowColor = System.Drawing.Color.White;
            this.cmsTasks.RenderStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.cmsTasks.RenderStyle.SelectionForeColor = System.Drawing.Color.White;
            this.cmsTasks.RenderStyle.SeparatorColor = System.Drawing.Color.Gainsboro;
            this.cmsTasks.RenderStyle.TextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault;
            this.cmsTasks.Size = new System.Drawing.Size(130, 26);
            // 
            // cmsTasksFinishTask
            // 
            this.cmsTasksFinishTask.Name = "cmsTasksFinishTask";
            this.cmsTasksFinishTask.Size = new System.Drawing.Size(129, 22);
            this.cmsTasksFinishTask.Text = "Finish task";
            this.cmsTasksFinishTask.Click += new System.EventHandler(this.cmsTasksFinishTask_Click);
            // 
            // lblYourTasks
            // 
            this.lblYourTasks.AutoSize = false;
            this.lblYourTasks.AutoSizeHeightOnly = true;
            this.lblYourTasks.BackColor = System.Drawing.Color.Transparent;
            this.lblYourTasks.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblYourTasks.Location = new System.Drawing.Point(25, 21);
            this.lblYourTasks.Name = "lblYourTasks";
            this.lblYourTasks.Size = new System.Drawing.Size(111, 25);
            this.lblYourTasks.TabIndex = 3;
            this.lblYourTasks.Text = "Your Tasks: ";
            this.lblYourTasks.TextAlignment = System.Drawing.ContentAlignment.TopCenter;
            // 
            // guna2ShadowPanel2
            // 
            this.guna2ShadowPanel2.BackColor = System.Drawing.Color.Transparent;
            this.guna2ShadowPanel2.Controls.Add(this.lblNearOrOutdateBorrows);
            this.guna2ShadowPanel2.Controls.Add(this.dgvBorrows);
            this.guna2ShadowPanel2.FillColor = System.Drawing.Color.White;
            this.guna2ShadowPanel2.Location = new System.Drawing.Point(338, 416);
            this.guna2ShadowPanel2.Name = "guna2ShadowPanel2";
            this.guna2ShadowPanel2.Radius = 10;
            this.guna2ShadowPanel2.ShadowColor = System.Drawing.Color.Black;
            this.guna2ShadowPanel2.Size = new System.Drawing.Size(284, 238);
            this.guna2ShadowPanel2.TabIndex = 1;
            // 
            // lblNearOrOutdateBorrows
            // 
            this.lblNearOrOutdateBorrows.AutoSize = false;
            this.lblNearOrOutdateBorrows.AutoSizeHeightOnly = true;
            this.lblNearOrOutdateBorrows.BackColor = System.Drawing.Color.Transparent;
            this.lblNearOrOutdateBorrows.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNearOrOutdateBorrows.Location = new System.Drawing.Point(27, 16);
            this.lblNearOrOutdateBorrows.Name = "lblNearOrOutdateBorrows";
            this.lblNearOrOutdateBorrows.Size = new System.Drawing.Size(227, 25);
            this.lblNearOrOutdateBorrows.TabIndex = 3;
            this.lblNearOrOutdateBorrows.Text = "Near or Outdate Borrows:";
            this.lblNearOrOutdateBorrows.TextAlignment = System.Drawing.ContentAlignment.TopCenter;
            // 
            // dgvBorrows
            // 
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
            this.dgvBorrows.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvBorrows.BackgroundColor = System.Drawing.Color.Gray;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvBorrows.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.dgvBorrows.ColumnHeadersHeight = 4;
            this.dgvBorrows.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvBorrows.DefaultCellStyle = dataGridViewCellStyle6;
            this.dgvBorrows.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvBorrows.Location = new System.Drawing.Point(27, 53);
            this.dgvBorrows.MultiSelect = false;
            this.dgvBorrows.Name = "dgvBorrows";
            this.dgvBorrows.ReadOnly = true;
            this.dgvBorrows.RowHeadersVisible = false;
            this.dgvBorrows.Size = new System.Drawing.Size(227, 155);
            this.dgvBorrows.TabIndex = 0;
            this.dgvBorrows.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvBorrows.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dgvBorrows.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dgvBorrows.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dgvBorrows.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dgvBorrows.ThemeStyle.BackColor = System.Drawing.Color.Gray;
            this.dgvBorrows.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvBorrows.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(57)))), ((int)(((byte)(53)))));
            this.dgvBorrows.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvBorrows.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvBorrows.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dgvBorrows.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dgvBorrows.ThemeStyle.HeaderStyle.Height = 4;
            this.dgvBorrows.ThemeStyle.ReadOnly = true;
            this.dgvBorrows.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvBorrows.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvBorrows.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvBorrows.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dgvBorrows.ThemeStyle.RowsStyle.Height = 22;
            this.dgvBorrows.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvBorrows.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            // 
            // guna2ShadowPanel3
            // 
            this.guna2ShadowPanel3.BackColor = System.Drawing.Color.Transparent;
            this.guna2ShadowPanel3.Controls.Add(this.lblShiftRemainingTime);
            this.guna2ShadowPanel3.Controls.Add(this.lblCurrentShiftRemainingTime);
            this.guna2ShadowPanel3.Controls.Add(this.pbarCurrentShift);
            this.guna2ShadowPanel3.FillColor = System.Drawing.Color.White;
            this.guna2ShadowPanel3.Location = new System.Drawing.Point(43, 489);
            this.guna2ShadowPanel3.Name = "guna2ShadowPanel3";
            this.guna2ShadowPanel3.Radius = 10;
            this.guna2ShadowPanel3.ShadowColor = System.Drawing.Color.Black;
            this.guna2ShadowPanel3.Size = new System.Drawing.Size(289, 156);
            this.guna2ShadowPanel3.TabIndex = 1;
            // 
            // lblShiftRemainingTime
            // 
            this.lblShiftRemainingTime.AutoSize = false;
            this.lblShiftRemainingTime.AutoSizeHeightOnly = true;
            this.lblShiftRemainingTime.BackColor = System.Drawing.Color.Transparent;
            this.lblShiftRemainingTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblShiftRemainingTime.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(57)))), ((int)(((byte)(53)))));
            this.lblShiftRemainingTime.Location = new System.Drawing.Point(20, 104);
            this.lblShiftRemainingTime.Name = "lblShiftRemainingTime";
            this.lblShiftRemainingTime.Size = new System.Drawing.Size(111, 25);
            this.lblShiftRemainingTime.TabIndex = 2;
            this.lblShiftRemainingTime.Text = "02:04:32";
            this.lblShiftRemainingTime.TextAlignment = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblCurrentShiftRemainingTime
            // 
            this.lblCurrentShiftRemainingTime.AutoSize = false;
            this.lblCurrentShiftRemainingTime.AutoSizeHeightOnly = true;
            this.lblCurrentShiftRemainingTime.BackColor = System.Drawing.Color.Transparent;
            this.lblCurrentShiftRemainingTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCurrentShiftRemainingTime.Location = new System.Drawing.Point(20, 25);
            this.lblCurrentShiftRemainingTime.Name = "lblCurrentShiftRemainingTime";
            this.lblCurrentShiftRemainingTime.Size = new System.Drawing.Size(111, 73);
            this.lblCurrentShiftRemainingTime.TabIndex = 1;
            this.lblCurrentShiftRemainingTime.Text = "Current Shift Remaining Time:";
            this.lblCurrentShiftRemainingTime.TextAlignment = System.Drawing.ContentAlignment.TopCenter;
            // 
            // pbarCurrentShift
            // 
            this.pbarCurrentShift.Animated = true;
            this.pbarCurrentShift.AnimationSpeed = 0.1F;
            this.pbarCurrentShift.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(213)))), ((int)(((byte)(218)))), ((int)(((byte)(223)))));
            this.pbarCurrentShift.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.pbarCurrentShift.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(57)))), ((int)(((byte)(53)))));
            this.pbarCurrentShift.Location = new System.Drawing.Point(149, 17);
            this.pbarCurrentShift.Minimum = 0;
            this.pbarCurrentShift.Name = "pbarCurrentShift";
            this.pbarCurrentShift.ProgressColor = System.Drawing.Color.Red;
            this.pbarCurrentShift.ProgressColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.pbarCurrentShift.ProgressEndCap = System.Drawing.Drawing2D.LineCap.Round;
            this.pbarCurrentShift.ProgressStartCap = System.Drawing.Drawing2D.LineCap.Round;
            this.pbarCurrentShift.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.pbarCurrentShift.Size = new System.Drawing.Size(111, 111);
            this.pbarCurrentShift.TabIndex = 0;
            this.pbarCurrentShift.Text = "3H";
            this.pbarCurrentShift.TextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault;
            this.pbarCurrentShift.Value = 70;
            // 
            // guna2ShadowPanel4
            // 
            this.guna2ShadowPanel4.BackColor = System.Drawing.Color.Transparent;
            this.guna2ShadowPanel4.Controls.Add(this.lblEmployeeName);
            this.guna2ShadowPanel4.Controls.Add(this.lblWelcome);
            this.guna2ShadowPanel4.Controls.Add(this.pbEmployee);
            this.guna2ShadowPanel4.FillColor = System.Drawing.Color.White;
            this.guna2ShadowPanel4.Location = new System.Drawing.Point(43, 22);
            this.guna2ShadowPanel4.Name = "guna2ShadowPanel4";
            this.guna2ShadowPanel4.Radius = 10;
            this.guna2ShadowPanel4.ShadowColor = System.Drawing.Color.Black;
            this.guna2ShadowPanel4.Size = new System.Drawing.Size(289, 257);
            this.guna2ShadowPanel4.TabIndex = 1;
            // 
            // lblEmployeeName
            // 
            this.lblEmployeeName.AutoSize = false;
            this.lblEmployeeName.AutoSizeHeightOnly = true;
            this.lblEmployeeName.BackColor = System.Drawing.Color.Transparent;
            this.lblEmployeeName.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.lblEmployeeName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(57)))), ((int)(((byte)(53)))));
            this.lblEmployeeName.Location = new System.Drawing.Point(35, 209);
            this.lblEmployeeName.Name = "lblEmployeeName";
            this.lblEmployeeName.Size = new System.Drawing.Size(225, 32);
            this.lblEmployeeName.TabIndex = 4;
            this.lblEmployeeName.Text = "User";
            this.lblEmployeeName.TextAlignment = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblWelcome
            // 
            this.lblWelcome.AutoSize = false;
            this.lblWelcome.AutoSizeHeightOnly = true;
            this.lblWelcome.BackColor = System.Drawing.Color.Transparent;
            this.lblWelcome.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold);
            this.lblWelcome.ForeColor = System.Drawing.Color.Black;
            this.lblWelcome.Location = new System.Drawing.Point(67, 15);
            this.lblWelcome.Name = "lblWelcome";
            this.lblWelcome.Size = new System.Drawing.Size(140, 32);
            this.lblWelcome.TabIndex = 3;
            this.lblWelcome.Text = "Welcome,";
            this.lblWelcome.TextAlignment = System.Drawing.ContentAlignment.TopCenter;
            // 
            // pbEmployee
            // 
            this.pbEmployee.BackColor = System.Drawing.Color.Transparent;
            this.pbEmployee.FillColor = System.Drawing.SystemColors.Control;
            this.pbEmployee.Image = global::PresentationLayer.Properties.Resources.user;
            this.pbEmployee.ImageRotate = 0F;
            this.pbEmployee.Location = new System.Drawing.Point(67, 53);
            this.pbEmployee.Name = "pbEmployee";
            this.pbEmployee.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.pbEmployee.Size = new System.Drawing.Size(150, 150);
            this.pbEmployee.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbEmployee.TabIndex = 0;
            this.pbEmployee.TabStop = false;
            this.pbEmployee.Click += new System.EventHandler(this.pbEmployee_Click);
            // 
            // guna2ShadowPanel5
            // 
            this.guna2ShadowPanel5.BackColor = System.Drawing.Color.Transparent;
            this.guna2ShadowPanel5.Controls.Add(this.pbDepartmentMinimumAge);
            this.guna2ShadowPanel5.Controls.Add(this.lblDepartmentName);
            this.guna2ShadowPanel5.Controls.Add(this.pbDepartmentImage);
            this.guna2ShadowPanel5.Controls.Add(this.lblCurrentDepartment);
            this.guna2ShadowPanel5.FillColor = System.Drawing.Color.White;
            this.guna2ShadowPanel5.Location = new System.Drawing.Point(43, 285);
            this.guna2ShadowPanel5.Name = "guna2ShadowPanel5";
            this.guna2ShadowPanel5.Radius = 10;
            this.guna2ShadowPanel5.ShadowColor = System.Drawing.Color.Black;
            this.guna2ShadowPanel5.Size = new System.Drawing.Size(289, 194);
            this.guna2ShadowPanel5.TabIndex = 3;
            // 
            // pbDepartmentMinimumAge
            // 
            this.pbDepartmentMinimumAge.AutoSize = false;
            this.pbDepartmentMinimumAge.AutoSizeHeightOnly = true;
            this.pbDepartmentMinimumAge.BackColor = System.Drawing.Color.Transparent;
            this.pbDepartmentMinimumAge.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.pbDepartmentMinimumAge.ForeColor = System.Drawing.Color.Black;
            this.pbDepartmentMinimumAge.Location = new System.Drawing.Point(144, 122);
            this.pbDepartmentMinimumAge.Name = "pbDepartmentMinimumAge";
            this.pbDepartmentMinimumAge.Size = new System.Drawing.Size(111, 21);
            this.pbDepartmentMinimumAge.TabIndex = 4;
            this.pbDepartmentMinimumAge.Text = "Min Age: __";
            this.pbDepartmentMinimumAge.TextAlignment = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblDepartmentName
            // 
            this.lblDepartmentName.AutoSize = false;
            this.lblDepartmentName.AutoSizeHeightOnly = true;
            this.lblDepartmentName.BackColor = System.Drawing.Color.Transparent;
            this.lblDepartmentName.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDepartmentName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(57)))), ((int)(((byte)(53)))));
            this.lblDepartmentName.Location = new System.Drawing.Point(136, 60);
            this.lblDepartmentName.Name = "lblDepartmentName";
            this.lblDepartmentName.Size = new System.Drawing.Size(111, 25);
            this.lblDepartmentName.TabIndex = 3;
            this.lblDepartmentName.Text = "~Name~";
            this.lblDepartmentName.TextAlignment = System.Drawing.ContentAlignment.TopCenter;
            // 
            // pbDepartmentImage
            // 
            this.pbDepartmentImage.BorderRadius = 5;
            this.pbDepartmentImage.Image = global::PresentationLayer.Properties.Resources.home;
            this.pbDepartmentImage.ImageRotate = 0F;
            this.pbDepartmentImage.Location = new System.Drawing.Point(20, 56);
            this.pbDepartmentImage.Name = "pbDepartmentImage";
            this.pbDepartmentImage.Size = new System.Drawing.Size(105, 99);
            this.pbDepartmentImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbDepartmentImage.TabIndex = 2;
            this.pbDepartmentImage.TabStop = false;
            this.pbDepartmentImage.Click += new System.EventHandler(this.pbDepartmentImage_Click);
            // 
            // lblCurrentDepartment
            // 
            this.lblCurrentDepartment.AutoSize = false;
            this.lblCurrentDepartment.AutoSizeHeightOnly = true;
            this.lblCurrentDepartment.BackColor = System.Drawing.Color.Transparent;
            this.lblCurrentDepartment.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCurrentDepartment.Location = new System.Drawing.Point(20, 25);
            this.lblCurrentDepartment.Name = "lblCurrentDepartment";
            this.lblCurrentDepartment.Size = new System.Drawing.Size(187, 25);
            this.lblCurrentDepartment.TabIndex = 1;
            this.lblCurrentDepartment.Text = "Current Department: ";
            this.lblCurrentDepartment.TextAlignment = System.Drawing.ContentAlignment.TopCenter;
            // 
            // guna2ShadowPanel6
            // 
            this.guna2ShadowPanel6.BackColor = System.Drawing.Color.Transparent;
            this.guna2ShadowPanel6.Controls.Add(this.lblCurrentTime);
            this.guna2ShadowPanel6.FillColor = System.Drawing.Color.White;
            this.guna2ShadowPanel6.Location = new System.Drawing.Point(339, 19);
            this.guna2ShadowPanel6.Name = "guna2ShadowPanel6";
            this.guna2ShadowPanel6.Radius = 10;
            this.guna2ShadowPanel6.ShadowColor = System.Drawing.Color.Black;
            this.guna2ShadowPanel6.ShadowShift = 4;
            this.guna2ShadowPanel6.Size = new System.Drawing.Size(283, 66);
            this.guna2ShadowPanel6.TabIndex = 4;
            // 
            // lblCurrentTime
            // 
            this.lblCurrentTime.AutoSize = false;
            this.lblCurrentTime.AutoSizeHeightOnly = true;
            this.lblCurrentTime.BackColor = System.Drawing.Color.Transparent;
            this.lblCurrentTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCurrentTime.Location = new System.Drawing.Point(20, 22);
            this.lblCurrentTime.Name = "lblCurrentTime";
            this.lblCurrentTime.Size = new System.Drawing.Size(232, 25);
            this.lblCurrentTime.TabIndex = 1;
            this.lblCurrentTime.Text = "12:06:29, 26 Feb 2007";
            this.lblCurrentTime.TextAlignment = System.Drawing.ContentAlignment.TopCenter;
            // 
            // Clock
            // 
            this.Clock.Enabled = true;
            this.Clock.Interval = 1000;
            this.Clock.Tick += new System.EventHandler(this.Clock_Tick);
            // 
            // ClockMin
            // 
            this.ClockMin.Enabled = true;
            this.ClockMin.Interval = 100000;
            this.ClockMin.Tick += new System.EventHandler(this.ClockMin_Tick);
            // 
            // HomeForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(229)))), ((int)(((byte)(229)))));
            this.Controls.Add(this.guna2ShadowPanel6);
            this.Controls.Add(this.guna2ShadowPanel5);
            this.Controls.Add(this.guna2ShadowPanel4);
            this.Controls.Add(this.guna2ShadowPanel3);
            this.Controls.Add(this.guna2ShadowPanel2);
            this.Controls.Add(this.guna2ShadowPanel1);
            this.Name = "HomeForm";
            this.Size = new System.Drawing.Size(648, 687);
            this.Load += new System.EventHandler(this.HomeForm_Load);
            this.guna2ShadowPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTasks)).EndInit();
            this.cmsTasks.ResumeLayout(false);
            this.guna2ShadowPanel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvBorrows)).EndInit();
            this.guna2ShadowPanel3.ResumeLayout(false);
            this.guna2ShadowPanel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbEmployee)).EndInit();
            this.guna2ShadowPanel5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbDepartmentImage)).EndInit();
            this.guna2ShadowPanel6.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2ShadowPanel guna2ShadowPanel1;
        private Guna.UI2.WinForms.Guna2ShadowPanel guna2ShadowPanel2;
        private Guna.UI2.WinForms.Guna2ShadowPanel guna2ShadowPanel3;
        private Guna.UI2.WinForms.Guna2ShadowPanel guna2ShadowPanel4;
        private Guna.UI2.WinForms.Guna2CircleProgressBar pbarCurrentShift;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblCurrentShiftRemainingTime;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblShiftRemainingTime;
        private Guna.UI2.WinForms.Guna2DataGridView dgvBorrows;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblNearOrOutdateBorrows;
        private Guna.UI2.WinForms.Guna2CirclePictureBox pbEmployee;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblEmployeeName;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblWelcome;
        private Guna.UI2.WinForms.Guna2ShadowPanel guna2ShadowPanel5;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblCurrentDepartment;
        private Guna.UI2.WinForms.Guna2ShadowPanel guna2ShadowPanel6;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblCurrentTime;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblYourTasks;
        private Guna.UI2.WinForms.Guna2DataGridView dgvTasks;
        private Guna.UI2.WinForms.Guna2HtmlLabel pbDepartmentMinimumAge;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblDepartmentName;
        private Guna.UI2.WinForms.Guna2PictureBox pbDepartmentImage;
        private Guna.UI2.WinForms.Guna2ContextMenuStrip cmsTasks;
        private System.Windows.Forms.ToolStripMenuItem cmsTasksFinishTask;
        private System.Windows.Forms.Timer Clock;
        private System.Windows.Forms.Timer ClockMin;
    }
}
