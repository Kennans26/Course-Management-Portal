namespace CourseManagement.View.Forms
{
    partial class StudentManagementPage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StudentManagementPage));
            panelForInfoDOWN = new Panel();
            btnForUpdate = new Button();
            btnForDelete = new Button();
            btnForUpload = new Button();
            pictureBoxForStudentsImages = new PictureBox();
            lblManagementIP = new Label();
            panelForInfoUP = new Panel();
            textBoxForSearch = new TextBox();
            txtBoxAddress = new TextBox();
            lblAddress = new Label();
            radioButtonGenderF = new RadioButton();
            radioButtonGenderM = new RadioButton();
            panelForGenders = new Panel();
            lblGender = new Label();
            dateTimePickerDOB = new DateTimePicker();
            lblDateOfBirth = new Label();
            txtBoxEmail = new TextBox();
            lblEmail = new Label();
            txtBoxLastName = new TextBox();
            lblLastName = new Label();
            txtBoxFirstName = new TextBox();
            lblFirstName = new Label();
            DataGridViewAboutStudent = new Guna.UI2.WinForms.Guna2DataGridView();
            btnForClear = new Button();
            lblStudentId = new Label();
            lblForShowingStdId = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBoxForStudentsImages).BeginInit();
            panelForInfoUP.SuspendLayout();
            panelForGenders.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)DataGridViewAboutStudent).BeginInit();
            SuspendLayout();
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
            // btnForUpdate
            // 
            btnForUpdate.BackColor = Color.OrangeRed;
            btnForUpdate.Cursor = Cursors.Hand;
            btnForUpdate.FlatStyle = FlatStyle.Flat;
            btnForUpdate.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnForUpdate.ForeColor = Color.White;
            btnForUpdate.Location = new Point(863, 367);
            btnForUpdate.Name = "btnForUpdate";
            btnForUpdate.Size = new Size(59, 38);
            btnForUpdate.TabIndex = 9;
            btnForUpdate.Text = "Update";
            btnForUpdate.UseVisualStyleBackColor = false;
            btnForUpdate.Click += btnForUpdate_Click;
            // 
            // btnForDelete
            // 
            btnForDelete.BackColor = Color.Maroon;
            btnForDelete.Cursor = Cursors.Hand;
            btnForDelete.FlatStyle = FlatStyle.Flat;
            btnForDelete.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnForDelete.ForeColor = Color.White;
            btnForDelete.Location = new Point(863, 323);
            btnForDelete.Name = "btnForDelete";
            btnForDelete.Size = new Size(59, 38);
            btnForDelete.TabIndex = 10;
            btnForDelete.Text = "Delete";
            btnForDelete.UseVisualStyleBackColor = false;
            btnForDelete.Click += btnForDelete_Click;
            // 
            // btnForUpload
            // 
            btnForUpload.BackColor = Color.DarkGreen;
            btnForUpload.Cursor = Cursors.Hand;
            btnForUpload.FlatStyle = FlatStyle.Flat;
            btnForUpload.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            btnForUpload.ForeColor = Color.White;
            btnForUpload.Location = new Point(719, 411);
            btnForUpload.Name = "btnForUpload";
            btnForUpload.Size = new Size(138, 38);
            btnForUpload.TabIndex = 8;
            btnForUpload.Text = "Upload";
            btnForUpload.UseVisualStyleBackColor = false;
            btnForUpload.Click += btnForUpload_Click;
            // 
            // pictureBoxForStudentsImages
            // 
            pictureBoxForStudentsImages.Cursor = Cursors.WaitCursor;
            pictureBoxForStudentsImages.Location = new Point(719, 309);
            pictureBoxForStudentsImages.Name = "pictureBoxForStudentsImages";
            pictureBoxForStudentsImages.Size = new Size(138, 94);
            pictureBoxForStudentsImages.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBoxForStudentsImages.TabIndex = 26;
            pictureBoxForStudentsImages.TabStop = false;
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
            // txtBoxAddress
            // 
            txtBoxAddress.BackColor = Color.White;
            txtBoxAddress.BorderStyle = BorderStyle.FixedSingle;
            txtBoxAddress.Cursor = Cursors.IBeam;
            txtBoxAddress.Font = new Font("Calibri", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtBoxAddress.Location = new Point(88, 355);
            txtBoxAddress.Multiline = true;
            txtBoxAddress.Name = "txtBoxAddress";
            txtBoxAddress.Size = new Size(597, 94);
            txtBoxAddress.TabIndex = 7;
            // 
            // lblAddress
            // 
            lblAddress.AutoSize = true;
            lblAddress.BackColor = Color.Transparent;
            lblAddress.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            lblAddress.ForeColor = Color.FromArgb(0, 49, 64);
            lblAddress.Location = new Point(12, 355);
            lblAddress.Name = "lblAddress";
            lblAddress.Size = new Size(70, 20);
            lblAddress.TabIndex = 0;
            lblAddress.Text = "Address:";
            lblAddress.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // radioButtonGenderF
            // 
            radioButtonGenderF.AutoSize = true;
            radioButtonGenderF.BackColor = Color.Transparent;
            radioButtonGenderF.Cursor = Cursors.Hand;
            radioButtonGenderF.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            radioButtonGenderF.ForeColor = Color.FromArgb(0, 49, 64);
            radioButtonGenderF.Location = new Point(98, 6);
            radioButtonGenderF.Name = "radioButtonGenderF";
            radioButtonGenderF.Size = new Size(76, 24);
            radioButtonGenderF.TabIndex = 1;
            radioButtonGenderF.TabStop = true;
            radioButtonGenderF.Text = "Female";
            radioButtonGenderF.UseVisualStyleBackColor = false;
            // 
            // radioButtonGenderM
            // 
            radioButtonGenderM.AutoSize = true;
            radioButtonGenderM.BackColor = Color.Transparent;
            radioButtonGenderM.Cursor = Cursors.Hand;
            radioButtonGenderM.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            radioButtonGenderM.ForeColor = Color.FromArgb(0, 49, 64);
            radioButtonGenderM.Location = new Point(25, 6);
            radioButtonGenderM.Name = "radioButtonGenderM";
            radioButtonGenderM.Size = new Size(61, 24);
            radioButtonGenderM.TabIndex = 0;
            radioButtonGenderM.TabStop = true;
            radioButtonGenderM.Text = "Male";
            radioButtonGenderM.UseVisualStyleBackColor = false;
            // 
            // panelForGenders
            // 
            panelForGenders.Controls.Add(radioButtonGenderF);
            panelForGenders.Controls.Add(radioButtonGenderM);
            panelForGenders.Location = new Point(361, 302);
            panelForGenders.Name = "panelForGenders";
            panelForGenders.Size = new Size(200, 36);
            panelForGenders.TabIndex = 6;
            panelForGenders.TabStop = true;
            // 
            // lblGender
            // 
            lblGender.AutoSize = true;
            lblGender.BackColor = Color.Transparent;
            lblGender.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            lblGender.ForeColor = Color.FromArgb(0, 49, 64);
            lblGender.Location = new Point(282, 309);
            lblGender.Name = "lblGender";
            lblGender.Size = new Size(65, 20);
            lblGender.TabIndex = 0;
            lblGender.Text = "Gender:";
            lblGender.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // dateTimePickerDOB
            // 
            dateTimePickerDOB.CalendarForeColor = Color.Black;
            dateTimePickerDOB.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            dateTimePickerDOB.Format = DateTimePickerFormat.Short;
            dateTimePickerDOB.Location = new Point(124, 305);
            dateTimePickerDOB.Name = "dateTimePickerDOB";
            dateTimePickerDOB.Size = new Size(122, 29);
            dateTimePickerDOB.TabIndex = 5;
            dateTimePickerDOB.Value = new DateTime(2023, 11, 30, 14, 46, 12, 0);
            // 
            // lblDateOfBirth
            // 
            lblDateOfBirth.AutoSize = true;
            lblDateOfBirth.BackColor = Color.Transparent;
            lblDateOfBirth.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            lblDateOfBirth.ForeColor = Color.FromArgb(0, 49, 64);
            lblDateOfBirth.Location = new Point(12, 309);
            lblDateOfBirth.Name = "lblDateOfBirth";
            lblDateOfBirth.Size = new Size(106, 20);
            lblDateOfBirth.TabIndex = 0;
            lblDateOfBirth.Text = "Date Of Birth:";
            lblDateOfBirth.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // txtBoxEmail
            // 
            txtBoxEmail.BorderStyle = BorderStyle.FixedSingle;
            txtBoxEmail.Cursor = Cursors.IBeam;
            txtBoxEmail.Font = new Font("Calibri", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtBoxEmail.Location = new Point(718, 264);
            txtBoxEmail.Name = "txtBoxEmail";
            txtBoxEmail.Size = new Size(204, 27);
            txtBoxEmail.TabIndex = 4;
            txtBoxEmail.TextAlign = HorizontalAlignment.Center;
            // 
            // lblEmail
            // 
            lblEmail.AutoSize = true;
            lblEmail.BackColor = Color.Transparent;
            lblEmail.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            lblEmail.ForeColor = Color.FromArgb(0, 49, 64);
            lblEmail.Location = new Point(661, 267);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(51, 20);
            lblEmail.TabIndex = 0;
            lblEmail.Text = "Email:";
            lblEmail.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // txtBoxLastName
            // 
            txtBoxLastName.BorderStyle = BorderStyle.FixedSingle;
            txtBoxLastName.Cursor = Cursors.IBeam;
            txtBoxLastName.Font = new Font("Calibri", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtBoxLastName.Location = new Point(489, 264);
            txtBoxLastName.Name = "txtBoxLastName";
            txtBoxLastName.Size = new Size(138, 27);
            txtBoxLastName.TabIndex = 3;
            txtBoxLastName.TextAlign = HorizontalAlignment.Center;
            // 
            // lblLastName
            // 
            lblLastName.AutoSize = true;
            lblLastName.BackColor = Color.Transparent;
            lblLastName.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            lblLastName.ForeColor = Color.FromArgb(0, 49, 64);
            lblLastName.Location = new Point(393, 267);
            lblLastName.Name = "lblLastName";
            lblLastName.Size = new Size(88, 20);
            lblLastName.TabIndex = 0;
            lblLastName.Text = "Last Name:";
            lblLastName.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // txtBoxFirstName
            // 
            txtBoxFirstName.BackColor = Color.White;
            txtBoxFirstName.BorderStyle = BorderStyle.FixedSingle;
            txtBoxFirstName.Cursor = Cursors.IBeam;
            txtBoxFirstName.Font = new Font("Calibri", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtBoxFirstName.Location = new Point(218, 264);
            txtBoxFirstName.Name = "txtBoxFirstName";
            txtBoxFirstName.Size = new Size(138, 27);
            txtBoxFirstName.TabIndex = 2;
            txtBoxFirstName.TextAlign = HorizontalAlignment.Center;
            // 
            // lblFirstName
            // 
            lblFirstName.AutoSize = true;
            lblFirstName.BackColor = Color.Transparent;
            lblFirstName.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            lblFirstName.ForeColor = Color.FromArgb(0, 49, 64);
            lblFirstName.Location = new Point(122, 267);
            lblFirstName.Name = "lblFirstName";
            lblFirstName.Size = new Size(90, 20);
            lblFirstName.TabIndex = 0;
            lblFirstName.Text = "First Name:";
            lblFirstName.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // DataGridViewAboutStudent
            // 
            DataGridViewAboutStudent.AllowUserToAddRows = false;
            DataGridViewAboutStudent.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = Color.White;
            DataGridViewAboutStudent.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            DataGridViewAboutStudent.BackgroundColor = Color.Gainsboro;
            DataGridViewAboutStudent.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(100, 88, 255);
            dataGridViewCellStyle2.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = Color.White;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            DataGridViewAboutStudent.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            DataGridViewAboutStudent.ColumnHeadersHeight = 22;
            DataGridViewAboutStudent.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.White;
            dataGridViewCellStyle3.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = Color.FromArgb(71, 69, 94);
            dataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(231, 229, 255);
            dataGridViewCellStyle3.SelectionForeColor = Color.FromArgb(71, 69, 94);
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            DataGridViewAboutStudent.DefaultCellStyle = dataGridViewCellStyle3;
            DataGridViewAboutStudent.GridColor = Color.FromArgb(231, 229, 255);
            DataGridViewAboutStudent.Location = new Point(0, 43);
            DataGridViewAboutStudent.Name = "DataGridViewAboutStudent";
            DataGridViewAboutStudent.RowHeadersVisible = false;
            DataGridViewAboutStudent.RowHeadersWidth = 35;
            DataGridViewAboutStudent.RowTemplate.Height = 65;
            DataGridViewAboutStudent.Size = new Size(934, 200);
            DataGridViewAboutStudent.TabIndex = 0;
            DataGridViewAboutStudent.ThemeStyle.AlternatingRowsStyle.BackColor = Color.White;
            DataGridViewAboutStudent.ThemeStyle.AlternatingRowsStyle.Font = null;
            DataGridViewAboutStudent.ThemeStyle.AlternatingRowsStyle.ForeColor = Color.Empty;
            DataGridViewAboutStudent.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = Color.Empty;
            DataGridViewAboutStudent.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = Color.Empty;
            DataGridViewAboutStudent.ThemeStyle.BackColor = Color.Gainsboro;
            DataGridViewAboutStudent.ThemeStyle.GridColor = Color.FromArgb(231, 229, 255);
            DataGridViewAboutStudent.ThemeStyle.HeaderStyle.BackColor = Color.FromArgb(100, 88, 255);
            DataGridViewAboutStudent.ThemeStyle.HeaderStyle.BorderStyle = DataGridViewHeaderBorderStyle.Single;
            DataGridViewAboutStudent.ThemeStyle.HeaderStyle.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            DataGridViewAboutStudent.ThemeStyle.HeaderStyle.ForeColor = Color.White;
            DataGridViewAboutStudent.ThemeStyle.HeaderStyle.HeaightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            DataGridViewAboutStudent.ThemeStyle.HeaderStyle.Height = 22;
            DataGridViewAboutStudent.ThemeStyle.ReadOnly = false;
            DataGridViewAboutStudent.ThemeStyle.RowsStyle.BackColor = Color.White;
            DataGridViewAboutStudent.ThemeStyle.RowsStyle.BorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            DataGridViewAboutStudent.ThemeStyle.RowsStyle.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            DataGridViewAboutStudent.ThemeStyle.RowsStyle.ForeColor = Color.FromArgb(71, 69, 94);
            DataGridViewAboutStudent.ThemeStyle.RowsStyle.Height = 65;
            DataGridViewAboutStudent.ThemeStyle.RowsStyle.SelectionBackColor = Color.FromArgb(231, 229, 255);
            DataGridViewAboutStudent.ThemeStyle.RowsStyle.SelectionForeColor = Color.FromArgb(71, 69, 94);
            DataGridViewAboutStudent.Click += DataGridViewAboutStudent_Click;
            // 
            // btnForClear
            // 
            btnForClear.BackColor = Color.Orange;
            btnForClear.Cursor = Cursors.Hand;
            btnForClear.FlatStyle = FlatStyle.Flat;
            btnForClear.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnForClear.ForeColor = Color.White;
            btnForClear.Location = new Point(863, 411);
            btnForClear.Name = "btnForClear";
            btnForClear.Size = new Size(59, 38);
            btnForClear.TabIndex = 11;
            btnForClear.Text = "Clear";
            btnForClear.UseVisualStyleBackColor = false;
            btnForClear.Click += btnForClear_Click;
            // 
            // lblStudentId
            // 
            lblStudentId.AutoSize = true;
            lblStudentId.BackColor = Color.Transparent;
            lblStudentId.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            lblStudentId.ForeColor = Color.Gray;
            lblStudentId.Location = new Point(12, 267);
            lblStudentId.Name = "lblStudentId";
            lblStudentId.Size = new Size(27, 20);
            lblStudentId.TabIndex = 0;
            lblStudentId.Text = "Id:";
            lblStudentId.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblForShowingStdId
            // 
            lblForShowingStdId.AutoSize = true;
            lblForShowingStdId.BackColor = Color.Transparent;
            lblForShowingStdId.Font = new Font("Calibri", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblForShowingStdId.ForeColor = Color.Gray;
            lblForShowingStdId.Location = new Point(45, 268);
            lblForShowingStdId.Name = "lblForShowingStdId";
            lblForShowingStdId.Size = new Size(0, 19);
            lblForShowingStdId.TabIndex = 0;
            lblForShowingStdId.TextAlign = ContentAlignment.MiddleLeft;
            lblForShowingStdId.TextChanged += lblForShowingStdId_TextChanged;
            // 
            // StudentManagementPage
            // 
            AutoScaleDimensions = new SizeF(10F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(934, 461);
            Controls.Add(lblForShowingStdId);
            Controls.Add(lblStudentId);
            Controls.Add(btnForClear);
            Controls.Add(panelForInfoDOWN);
            Controls.Add(btnForUpdate);
            Controls.Add(btnForDelete);
            Controls.Add(btnForUpload);
            Controls.Add(pictureBoxForStudentsImages);
            Controls.Add(panelForInfoUP);
            Controls.Add(txtBoxAddress);
            Controls.Add(lblAddress);
            Controls.Add(panelForGenders);
            Controls.Add(lblGender);
            Controls.Add(dateTimePickerDOB);
            Controls.Add(lblDateOfBirth);
            Controls.Add(txtBoxEmail);
            Controls.Add(lblEmail);
            Controls.Add(txtBoxLastName);
            Controls.Add(lblLastName);
            Controls.Add(txtBoxFirstName);
            Controls.Add(lblFirstName);
            Controls.Add(DataGridViewAboutStudent);
            Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(4);
            MaximizeBox = false;
            MinimumSize = new Size(950, 500);
            Name = "StudentManagementPage";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Old School Course";
            Load += StudentManagementPage_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBoxForStudentsImages).EndInit();
            panelForInfoUP.ResumeLayout(false);
            panelForInfoUP.PerformLayout();
            panelForGenders.ResumeLayout(false);
            panelForGenders.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)DataGridViewAboutStudent).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panelForInfoDOWN;
        private Button btnForUpdate;
        private Button btnForDelete;
        private Button btnForUpload;
        private PictureBox pictureBoxForStudentsImages;
        private Label lblManagementIP;
        private Panel panelForInfoUP;
        private TextBox txtBoxAddress;
        private Label lblAddress;
        private RadioButton radioButtonGenderF;
        private RadioButton radioButtonGenderM;
        private Panel panelForGenders;
        private Label lblGender;
        private DateTimePicker dateTimePickerDOB;
        private Label lblDateOfBirth;
        private TextBox txtBoxEmail;
        private Label lblEmail;
        private TextBox txtBoxLastName;
        private Label lblLastName;
        private TextBox txtBoxFirstName;
        private Label lblFirstName;
        private Guna.UI2.WinForms.Guna2DataGridView DataGridViewAboutStudent;
        private Button btnForClear;
        private TextBox textBoxForSearch;
        private Label lblStudentId;
        private Label lblForShowingStdId;
    }
}