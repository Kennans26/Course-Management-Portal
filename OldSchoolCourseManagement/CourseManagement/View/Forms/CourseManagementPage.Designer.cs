namespace CourseManagement.View.Forms
{
    partial class CourseManagementPage
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CourseManagementPage));
            btnForUpload = new Button();
            pictureBoxForCourseCoverImage = new PictureBox();
            lblForCourseCoverImage = new Label();
            lblForCreationDate = new Label();
            dateTimePickerCCD = new DateTimePicker();
            txtBoxDescription = new TextBox();
            lblForDescription = new Label();
            txtBoxHour = new TextBox();
            lblForHour = new Label();
            lblManagementIP = new Label();
            panelForInfoDOWN = new Panel();
            btnForClear = new Button();
            btnForDelete = new Button();
            panelForInfoUP = new Panel();
            textBoxForSearch = new TextBox();
            DataGridViewAboutCourse = new Guna.UI2.WinForms.Guna2DataGridView();
            txtBoxCourseName = new TextBox();
            lblForCourseName = new Label();
            lblForCourseId = new Label();
            lblForShowingCourseId = new Label();
            btnForUpdate = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBoxForCourseCoverImage).BeginInit();
            panelForInfoUP.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)DataGridViewAboutCourse).BeginInit();
            SuspendLayout();
            // 
            // btnForUpload
            // 
            btnForUpload.BackColor = Color.DarkGreen;
            btnForUpload.Cursor = Cursors.Hand;
            btnForUpload.FlatStyle = FlatStyle.Flat;
            btnForUpload.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnForUpload.ForeColor = Color.White;
            btnForUpload.Location = new Point(730, 374);
            btnForUpload.Name = "btnForUpload";
            btnForUpload.Size = new Size(138, 35);
            btnForUpload.TabIndex = 5;
            btnForUpload.Text = "Upload";
            btnForUpload.UseVisualStyleBackColor = false;
            btnForUpload.Click += btnForUpload_Click;
            // 
            // pictureBoxForCourseCoverImage
            // 
            pictureBoxForCourseCoverImage.Cursor = Cursors.WaitCursor;
            pictureBoxForCourseCoverImage.Location = new Point(730, 272);
            pictureBoxForCourseCoverImage.Name = "pictureBoxForCourseCoverImage";
            pictureBoxForCourseCoverImage.Size = new Size(138, 94);
            pictureBoxForCourseCoverImage.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBoxForCourseCoverImage.TabIndex = 31;
            pictureBoxForCourseCoverImage.TabStop = false;
            // 
            // lblForCourseCoverImage
            // 
            lblForCourseCoverImage.AutoSize = true;
            lblForCourseCoverImage.BackColor = Color.Transparent;
            lblForCourseCoverImage.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            lblForCourseCoverImage.ForeColor = Color.FromArgb(0, 49, 64);
            lblForCourseCoverImage.Location = new Point(605, 269);
            lblForCourseCoverImage.Name = "lblForCourseCoverImage";
            lblForCourseCoverImage.Size = new Size(101, 20);
            lblForCourseCoverImage.TabIndex = 0;
            lblForCourseCoverImage.Text = "Cover Image:";
            lblForCourseCoverImage.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblForCreationDate
            // 
            lblForCreationDate.AutoSize = true;
            lblForCreationDate.BackColor = Color.Transparent;
            lblForCreationDate.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            lblForCreationDate.ForeColor = Color.Gray;
            lblForCreationDate.Location = new Point(162, 341);
            lblForCreationDate.Name = "lblForCreationDate";
            lblForCreationDate.Size = new Size(109, 20);
            lblForCreationDate.TabIndex = 0;
            lblForCreationDate.Text = "Creation Date:";
            lblForCreationDate.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // dateTimePickerCCD
            // 
            dateTimePickerCCD.CalendarForeColor = Color.Gray;
            dateTimePickerCCD.CalendarMonthBackground = Color.Gray;
            dateTimePickerCCD.CalendarTitleBackColor = Color.Gray;
            dateTimePickerCCD.CalendarTitleForeColor = Color.Gray;
            dateTimePickerCCD.CalendarTrailingForeColor = Color.Gray;
            dateTimePickerCCD.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            dateTimePickerCCD.Format = DateTimePickerFormat.Short;
            dateTimePickerCCD.Location = new Point(277, 337);
            dateTimePickerCCD.Name = "dateTimePickerCCD";
            dateTimePickerCCD.Size = new Size(122, 29);
            dateTimePickerCCD.TabIndex = 0;
            dateTimePickerCCD.TabStop = false;
            dateTimePickerCCD.Value = new DateTime(2023, 11, 30, 14, 46, 12, 0);
            // 
            // txtBoxDescription
            // 
            txtBoxDescription.BackColor = Color.White;
            txtBoxDescription.BorderStyle = BorderStyle.FixedSingle;
            txtBoxDescription.Cursor = Cursors.IBeam;
            txtBoxDescription.Font = new Font("Calibri", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtBoxDescription.Location = new Point(12, 399);
            txtBoxDescription.Multiline = true;
            txtBoxDescription.Name = "txtBoxDescription";
            txtBoxDescription.Size = new Size(600, 50);
            txtBoxDescription.TabIndex = 4;
            txtBoxDescription.TextChanged += TextChangedForDTP;
            // 
            // lblForDescription
            // 
            lblForDescription.AutoSize = true;
            lblForDescription.BackColor = Color.Transparent;
            lblForDescription.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            lblForDescription.ForeColor = Color.FromArgb(0, 49, 64);
            lblForDescription.Location = new Point(12, 376);
            lblForDescription.Name = "lblForDescription";
            lblForDescription.Size = new Size(93, 20);
            lblForDescription.TabIndex = 0;
            lblForDescription.Text = "Description:";
            lblForDescription.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // txtBoxHour
            // 
            txtBoxHour.BorderStyle = BorderStyle.FixedSingle;
            txtBoxHour.Cursor = Cursors.IBeam;
            txtBoxHour.Font = new Font("Calibri", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtBoxHour.Location = new Point(74, 338);
            txtBoxHour.Name = "txtBoxHour";
            txtBoxHour.Size = new Size(56, 27);
            txtBoxHour.TabIndex = 3;
            txtBoxHour.TextAlign = HorizontalAlignment.Center;
            txtBoxHour.TextChanged += TextChangedForDTP;
            // 
            // lblForHour
            // 
            lblForHour.AutoSize = true;
            lblForHour.BackColor = Color.Transparent;
            lblForHour.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            lblForHour.ForeColor = Color.FromArgb(0, 49, 64);
            lblForHour.Location = new Point(12, 341);
            lblForHour.Name = "lblForHour";
            lblForHour.Size = new Size(49, 20);
            lblForHour.TabIndex = 0;
            lblForHour.Text = "Hour:";
            lblForHour.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblManagementIP
            // 
            lblManagementIP.AutoSize = true;
            lblManagementIP.BackColor = Color.Transparent;
            lblManagementIP.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            lblManagementIP.ForeColor = Color.White;
            lblManagementIP.Location = new Point(397, 6);
            lblManagementIP.Name = "lblManagementIP";
            lblManagementIP.Size = new Size(140, 30);
            lblManagementIP.TabIndex = 0;
            lblManagementIP.Text = "Management";
            // 
            // panelForInfoDOWN
            // 
            panelForInfoDOWN.BackColor = Color.FromArgb(0, 49, 64);
            panelForInfoDOWN.Location = new Point(0, 243);
            panelForInfoDOWN.Name = "panelForInfoDOWN";
            panelForInfoDOWN.Size = new Size(934, 15);
            panelForInfoDOWN.TabIndex = 0;
            panelForInfoDOWN.TabStop = true;
            // 
            // btnForClear
            // 
            btnForClear.BackColor = Color.Orange;
            btnForClear.Cursor = Cursors.Hand;
            btnForClear.FlatStyle = FlatStyle.Flat;
            btnForClear.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold, GraphicsUnit.Point);
            btnForClear.ForeColor = Color.White;
            btnForClear.Location = new Point(681, 415);
            btnForClear.Name = "btnForClear";
            btnForClear.Size = new Size(75, 34);
            btnForClear.TabIndex = 8;
            btnForClear.Text = "Clear";
            btnForClear.UseVisualStyleBackColor = false;
            btnForClear.Click += btnForClear_Click;
            // 
            // btnForDelete
            // 
            btnForDelete.BackColor = Color.Maroon;
            btnForDelete.Cursor = Cursors.Hand;
            btnForDelete.FlatStyle = FlatStyle.Flat;
            btnForDelete.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold, GraphicsUnit.Point);
            btnForDelete.ForeColor = Color.White;
            btnForDelete.Location = new Point(843, 415);
            btnForDelete.Name = "btnForDelete";
            btnForDelete.Size = new Size(75, 34);
            btnForDelete.TabIndex = 7;
            btnForDelete.Text = "Delete";
            btnForDelete.UseVisualStyleBackColor = false;
            btnForDelete.Click += btnForDelete_Click;
            // 
            // panelForInfoUP
            // 
            panelForInfoUP.BackColor = Color.FromArgb(0, 49, 64);
            panelForInfoUP.Controls.Add(textBoxForSearch);
            panelForInfoUP.Controls.Add(lblManagementIP);
            panelForInfoUP.Dock = DockStyle.Top;
            panelForInfoUP.Location = new Point(0, 0);
            panelForInfoUP.Name = "panelForInfoUP";
            panelForInfoUP.Size = new Size(934, 43);
            panelForInfoUP.TabIndex = 0;
            panelForInfoUP.TabStop = true;
            // 
            // textBoxForSearch
            // 
            textBoxForSearch.BackColor = Color.FromArgb(0, 49, 64);
            textBoxForSearch.BorderStyle = BorderStyle.FixedSingle;
            textBoxForSearch.Cursor = Cursors.IBeam;
            textBoxForSearch.Font = new Font("Calibri", 12F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxForSearch.ForeColor = SystemColors.Window;
            textBoxForSearch.Location = new Point(784, 9);
            textBoxForSearch.Name = "textBoxForSearch";
            textBoxForSearch.Size = new Size(138, 27);
            textBoxForSearch.TabIndex = 1;
            textBoxForSearch.TextChanged += textBoxForSearch_TextChanged;
            // 
            // DataGridViewAboutCourse
            // 
            DataGridViewAboutCourse.AllowUserToAddRows = false;
            DataGridViewAboutCourse.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = Color.White;
            DataGridViewAboutCourse.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            DataGridViewAboutCourse.BackgroundColor = Color.Gainsboro;
            DataGridViewAboutCourse.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(100, 88, 255);
            dataGridViewCellStyle2.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = Color.White;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            DataGridViewAboutCourse.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            DataGridViewAboutCourse.ColumnHeadersHeight = 22;
            DataGridViewAboutCourse.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.White;
            dataGridViewCellStyle3.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = Color.FromArgb(71, 69, 94);
            dataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(231, 229, 255);
            dataGridViewCellStyle3.SelectionForeColor = Color.FromArgb(71, 69, 94);
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            DataGridViewAboutCourse.DefaultCellStyle = dataGridViewCellStyle3;
            DataGridViewAboutCourse.GridColor = Color.FromArgb(231, 229, 255);
            DataGridViewAboutCourse.Location = new Point(0, 43);
            DataGridViewAboutCourse.Name = "DataGridViewAboutCourse";
            DataGridViewAboutCourse.RowHeadersVisible = false;
            DataGridViewAboutCourse.RowHeadersWidth = 25;
            DataGridViewAboutCourse.RowTemplate.Height = 65;
            DataGridViewAboutCourse.Size = new Size(934, 200);
            DataGridViewAboutCourse.TabIndex = 0;
            DataGridViewAboutCourse.ThemeStyle.AlternatingRowsStyle.BackColor = Color.White;
            DataGridViewAboutCourse.ThemeStyle.AlternatingRowsStyle.Font = null;
            DataGridViewAboutCourse.ThemeStyle.AlternatingRowsStyle.ForeColor = Color.Empty;
            DataGridViewAboutCourse.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = Color.Empty;
            DataGridViewAboutCourse.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = Color.Empty;
            DataGridViewAboutCourse.ThemeStyle.BackColor = Color.Gainsboro;
            DataGridViewAboutCourse.ThemeStyle.GridColor = Color.FromArgb(231, 229, 255);
            DataGridViewAboutCourse.ThemeStyle.HeaderStyle.BackColor = Color.FromArgb(100, 88, 255);
            DataGridViewAboutCourse.ThemeStyle.HeaderStyle.BorderStyle = DataGridViewHeaderBorderStyle.Single;
            DataGridViewAboutCourse.ThemeStyle.HeaderStyle.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            DataGridViewAboutCourse.ThemeStyle.HeaderStyle.ForeColor = Color.White;
            DataGridViewAboutCourse.ThemeStyle.HeaderStyle.HeaightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            DataGridViewAboutCourse.ThemeStyle.HeaderStyle.Height = 22;
            DataGridViewAboutCourse.ThemeStyle.ReadOnly = false;
            DataGridViewAboutCourse.ThemeStyle.RowsStyle.BackColor = Color.White;
            DataGridViewAboutCourse.ThemeStyle.RowsStyle.BorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            DataGridViewAboutCourse.ThemeStyle.RowsStyle.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            DataGridViewAboutCourse.ThemeStyle.RowsStyle.ForeColor = Color.FromArgb(71, 69, 94);
            DataGridViewAboutCourse.ThemeStyle.RowsStyle.Height = 65;
            DataGridViewAboutCourse.ThemeStyle.RowsStyle.SelectionBackColor = Color.FromArgb(231, 229, 255);
            DataGridViewAboutCourse.ThemeStyle.RowsStyle.SelectionForeColor = Color.FromArgb(71, 69, 94);
            DataGridViewAboutCourse.Click += DataGridViewAboutCourse_Click;
            // 
            // txtBoxCourseName
            // 
            txtBoxCourseName.BackColor = Color.White;
            txtBoxCourseName.BorderStyle = BorderStyle.FixedSingle;
            txtBoxCourseName.Cursor = Cursors.IBeam;
            txtBoxCourseName.Font = new Font("Calibri", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtBoxCourseName.Location = new Point(162, 292);
            txtBoxCourseName.Name = "txtBoxCourseName";
            txtBoxCourseName.Size = new Size(300, 27);
            txtBoxCourseName.TabIndex = 2;
            txtBoxCourseName.TextAlign = HorizontalAlignment.Center;
            txtBoxCourseName.TextChanged += TextChangedForDTP;
            // 
            // lblForCourseName
            // 
            lblForCourseName.AutoSize = true;
            lblForCourseName.BackColor = Color.Transparent;
            lblForCourseName.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            lblForCourseName.ForeColor = Color.FromArgb(0, 49, 64);
            lblForCourseName.Location = new Point(162, 269);
            lblForCourseName.Name = "lblForCourseName";
            lblForCourseName.Size = new Size(107, 20);
            lblForCourseName.TabIndex = 0;
            lblForCourseName.Text = "Course Name:";
            lblForCourseName.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblForCourseId
            // 
            lblForCourseId.AutoSize = true;
            lblForCourseId.BackColor = Color.Transparent;
            lblForCourseId.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            lblForCourseId.ForeColor = Color.Gray;
            lblForCourseId.Location = new Point(13, 297);
            lblForCourseId.Name = "lblForCourseId";
            lblForCourseId.Size = new Size(27, 20);
            lblForCourseId.TabIndex = 0;
            lblForCourseId.Text = "Id:";
            lblForCourseId.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblForShowingCourseId
            // 
            lblForShowingCourseId.AutoSize = true;
            lblForShowingCourseId.BackColor = Color.Transparent;
            lblForShowingCourseId.Font = new Font("Calibri", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblForShowingCourseId.ForeColor = Color.Gray;
            lblForShowingCourseId.Location = new Point(46, 298);
            lblForShowingCourseId.Name = "lblForShowingCourseId";
            lblForShowingCourseId.Size = new Size(0, 19);
            lblForShowingCourseId.TabIndex = 0;
            lblForShowingCourseId.TextAlign = ContentAlignment.MiddleLeft;
            lblForShowingCourseId.TextChanged += TextChangedForDTP;
            // 
            // btnForUpdate
            // 
            btnForUpdate.BackColor = Color.OrangeRed;
            btnForUpdate.Cursor = Cursors.Hand;
            btnForUpdate.FlatStyle = FlatStyle.Flat;
            btnForUpdate.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold, GraphicsUnit.Point);
            btnForUpdate.ForeColor = Color.White;
            btnForUpdate.Location = new Point(762, 415);
            btnForUpdate.Name = "btnForUpdate";
            btnForUpdate.Size = new Size(75, 34);
            btnForUpdate.TabIndex = 6;
            btnForUpdate.Text = "Update";
            btnForUpdate.UseVisualStyleBackColor = false;
            btnForUpdate.Click += btnForUpdate_Click;
            // 
            // CourseManagementPage
            // 
            AutoScaleDimensions = new SizeF(10F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(934, 461);
            Controls.Add(btnForUpdate);
            Controls.Add(lblForShowingCourseId);
            Controls.Add(btnForUpload);
            Controls.Add(pictureBoxForCourseCoverImage);
            Controls.Add(lblForCourseCoverImage);
            Controls.Add(lblForCourseId);
            Controls.Add(lblForCreationDate);
            Controls.Add(dateTimePickerCCD);
            Controls.Add(lblForCourseName);
            Controls.Add(txtBoxDescription);
            Controls.Add(lblForDescription);
            Controls.Add(txtBoxHour);
            Controls.Add(lblForHour);
            Controls.Add(txtBoxCourseName);
            Controls.Add(panelForInfoDOWN);
            Controls.Add(btnForClear);
            Controls.Add(btnForDelete);
            Controls.Add(panelForInfoUP);
            Controls.Add(DataGridViewAboutCourse);
            Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(4);
            MinimizeBox = false;
            MinimumSize = new Size(950, 500);
            Name = "CourseManagementPage";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Old School Course";
            Load += CourseManagementPage_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBoxForCourseCoverImage).EndInit();
            panelForInfoUP.ResumeLayout(false);
            panelForInfoUP.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)DataGridViewAboutCourse).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnForUpload;
        private PictureBox pictureBoxForCourseCoverImage;
        private Label lblForCourseCoverImage;
        private Label lblForCreationDate;
        private DateTimePicker dateTimePickerCCD;
        private TextBox txtBoxDescription;
        private Label lblForDescription;
        private TextBox txtBoxHour;
        private Label lblForHour;
        private Label lblManagementIP;
        private Panel panelForInfoDOWN;
        private Button btnForClear;
        private Button btnForDelete;
        private Panel panelForInfoUP;
        private Guna.UI2.WinForms.Guna2DataGridView DataGridViewAboutCourse;
        private TextBox txtBoxCourseName;
        private Label lblForCourseName;
        private Label lblForCourseId;
        private Label lblForShowingCourseId;
        private Button btnForUpdate;
        private TextBox textBoxForSearch;
    }
}