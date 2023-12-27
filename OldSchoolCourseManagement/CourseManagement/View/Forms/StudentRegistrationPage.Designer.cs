namespace CourseManagement.View.Forms
{
    partial class StudentRegistrationPage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StudentRegistrationPage));
            DataGridViewAboutStudent = new Guna.UI2.WinForms.Guna2DataGridView();
            lblFirstName = new Label();
            txtBoxFirstName = new TextBox();
            txtBoxLastName = new TextBox();
            lblLastName = new Label();
            txtBoxEmail = new TextBox();
            lblEmail = new Label();
            lblDateOfBirth = new Label();
            dateTimePickerDOB = new DateTimePicker();
            lblGender = new Label();
            radioButtonGenderM = new RadioButton();
            radioButtonGenderF = new RadioButton();
            lblAddress = new Label();
            txtBoxAddress = new TextBox();
            panelForInfoUP = new Panel();
            lblRegistrationIP = new Label();
            pictureBoxForStudentsImages = new PictureBox();
            btnForUpload = new Button();
            btnForAdd = new Button();
            btnForClear = new Button();
            panelForGenders = new Panel();
            panelForInfoDOWN = new Panel();
            lblForSFN = new Label();
            lblForSLN = new Label();
            lblForSEmail = new Label();
            lblForSDOB = new Label();
            lblForSG = new Label();
            lblForSA = new Label();
            lblStudentImage = new Label();
            lblStudentId = new Label();
            lblForSI = new Label();
            txtBoxStudentId = new TextBox();
            ((System.ComponentModel.ISupportInitialize)DataGridViewAboutStudent).BeginInit();
            panelForInfoUP.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxForStudentsImages).BeginInit();
            panelForGenders.SuspendLayout();
            SuspendLayout();
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
            DataGridViewAboutStudent.TabStop = false;
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
            // 
            // lblFirstName
            // 
            lblFirstName.AutoSize = true;
            lblFirstName.BackColor = Color.Transparent;
            lblFirstName.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            lblFirstName.ForeColor = Color.FromArgb(0, 49, 64);
            lblFirstName.Location = new Point(12, 267);
            lblFirstName.Name = "lblFirstName";
            lblFirstName.Size = new Size(90, 20);
            lblFirstName.TabIndex = 0;
            lblFirstName.Text = "First Name:";
            lblFirstName.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // txtBoxFirstName
            // 
            txtBoxFirstName.BackColor = Color.White;
            txtBoxFirstName.BorderStyle = BorderStyle.FixedSingle;
            txtBoxFirstName.Cursor = Cursors.IBeam;
            txtBoxFirstName.Font = new Font("Calibri", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtBoxFirstName.Location = new Point(120, 264);
            txtBoxFirstName.Name = "txtBoxFirstName";
            txtBoxFirstName.Size = new Size(138, 27);
            txtBoxFirstName.TabIndex = 2;
            txtBoxFirstName.TextAlign = HorizontalAlignment.Center;
            // 
            // txtBoxLastName
            // 
            txtBoxLastName.BorderStyle = BorderStyle.FixedSingle;
            txtBoxLastName.Cursor = Cursors.IBeam;
            txtBoxLastName.Font = new Font("Calibri", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtBoxLastName.Location = new Point(400, 264);
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
            lblLastName.Location = new Point(294, 267);
            lblLastName.Name = "lblLastName";
            lblLastName.Size = new Size(88, 20);
            lblLastName.TabIndex = 0;
            lblLastName.Text = "Last Name:";
            lblLastName.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // txtBoxEmail
            // 
            txtBoxEmail.BorderStyle = BorderStyle.FixedSingle;
            txtBoxEmail.Cursor = Cursors.IBeam;
            txtBoxEmail.Font = new Font("Calibri", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtBoxEmail.Location = new Point(649, 264);
            txtBoxEmail.Name = "txtBoxEmail";
            txtBoxEmail.Size = new Size(208, 27);
            txtBoxEmail.TabIndex = 4;
            txtBoxEmail.TextAlign = HorizontalAlignment.Center;
            // 
            // lblEmail
            // 
            lblEmail.AutoSize = true;
            lblEmail.BackColor = Color.Transparent;
            lblEmail.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            lblEmail.ForeColor = Color.FromArgb(0, 49, 64);
            lblEmail.Location = new Point(581, 267);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(51, 20);
            lblEmail.TabIndex = 0;
            lblEmail.Text = "Email:";
            lblEmail.TextAlign = ContentAlignment.MiddleLeft;
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
            // dateTimePickerDOB
            // 
            dateTimePickerDOB.CalendarForeColor = Color.Black;
            dateTimePickerDOB.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            dateTimePickerDOB.Format = DateTimePickerFormat.Short;
            dateTimePickerDOB.Location = new Point(136, 305);
            dateTimePickerDOB.Name = "dateTimePickerDOB";
            dateTimePickerDOB.Size = new Size(122, 29);
            dateTimePickerDOB.TabIndex = 5;
            dateTimePickerDOB.Value = new DateTime(2023, 12, 12, 0, 0, 0, 0);
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
            // radioButtonGenderM
            // 
            radioButtonGenderM.AutoSize = true;
            radioButtonGenderM.Cursor = Cursors.Hand;
            radioButtonGenderM.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            radioButtonGenderM.ForeColor = Color.FromArgb(0, 49, 64);
            radioButtonGenderM.Location = new Point(25, 6);
            radioButtonGenderM.Name = "radioButtonGenderM";
            radioButtonGenderM.Size = new Size(61, 24);
            radioButtonGenderM.TabIndex = 0;
            radioButtonGenderM.TabStop = true;
            radioButtonGenderM.Text = "Male";
            radioButtonGenderM.UseVisualStyleBackColor = true;
            radioButtonGenderM.CheckedChanged += radioButtonGenderM_CheckedChanged;
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
            radioButtonGenderF.CheckedChanged += radioButtonGenderF_CheckedChanged;
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
            // txtBoxAddress
            // 
            txtBoxAddress.BackColor = Color.White;
            txtBoxAddress.BorderStyle = BorderStyle.FixedSingle;
            txtBoxAddress.Cursor = Cursors.IBeam;
            txtBoxAddress.Font = new Font("Calibri", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtBoxAddress.Location = new Point(94, 355);
            txtBoxAddress.Multiline = true;
            txtBoxAddress.Name = "txtBoxAddress";
            txtBoxAddress.Size = new Size(472, 94);
            txtBoxAddress.TabIndex = 7;
            // 
            // panelForInfoUP
            // 
            panelForInfoUP.BackColor = Color.FromArgb(0, 49, 64);
            panelForInfoUP.Controls.Add(lblRegistrationIP);
            panelForInfoUP.Dock = DockStyle.Top;
            panelForInfoUP.Location = new Point(0, 0);
            panelForInfoUP.Name = "panelForInfoUP";
            panelForInfoUP.Size = new Size(934, 43);
            panelForInfoUP.TabIndex = 0;
            // 
            // lblRegistrationIP
            // 
            lblRegistrationIP.AutoSize = true;
            lblRegistrationIP.BackColor = Color.Transparent;
            lblRegistrationIP.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            lblRegistrationIP.ForeColor = Color.White;
            lblRegistrationIP.Location = new Point(403, 6);
            lblRegistrationIP.Name = "lblRegistrationIP";
            lblRegistrationIP.Size = new Size(128, 30);
            lblRegistrationIP.TabIndex = 0;
            lblRegistrationIP.Text = "Registration";
            // 
            // pictureBoxForStudentsImages
            // 
            pictureBoxForStudentsImages.Cursor = Cursors.WaitCursor;
            pictureBoxForStudentsImages.Location = new Point(719, 309);
            pictureBoxForStudentsImages.Name = "pictureBoxForStudentsImages";
            pictureBoxForStudentsImages.Size = new Size(138, 94);
            pictureBoxForStudentsImages.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBoxForStudentsImages.TabIndex = 8;
            pictureBoxForStudentsImages.TabStop = false;
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
            // btnForAdd
            // 
            btnForAdd.BackColor = Color.FromArgb(0, 71, 160);
            btnForAdd.Cursor = Cursors.Hand;
            btnForAdd.FlatStyle = FlatStyle.Flat;
            btnForAdd.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            btnForAdd.ForeColor = Color.White;
            btnForAdd.Location = new Point(863, 411);
            btnForAdd.Name = "btnForAdd";
            btnForAdd.Size = new Size(59, 38);
            btnForAdd.TabIndex = 9;
            btnForAdd.Text = "Add";
            btnForAdd.UseVisualStyleBackColor = false;
            btnForAdd.Click += btnForAdd_Click;
            // 
            // btnForClear
            // 
            btnForClear.BackColor = Color.Maroon;
            btnForClear.Cursor = Cursors.Hand;
            btnForClear.FlatStyle = FlatStyle.Flat;
            btnForClear.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnForClear.ForeColor = Color.White;
            btnForClear.Location = new Point(863, 365);
            btnForClear.Name = "btnForClear";
            btnForClear.Size = new Size(59, 38);
            btnForClear.TabIndex = 10;
            btnForClear.Text = "Clear";
            btnForClear.UseVisualStyleBackColor = false;
            btnForClear.Click += btnForClear_Click;
            // 
            // panelForGenders
            // 
            panelForGenders.BackColor = Color.Transparent;
            panelForGenders.Controls.Add(radioButtonGenderF);
            panelForGenders.Controls.Add(radioButtonGenderM);
            panelForGenders.Location = new Point(361, 302);
            panelForGenders.Name = "panelForGenders";
            panelForGenders.Size = new Size(200, 36);
            panelForGenders.TabIndex = 6;
            panelForGenders.TabStop = true;
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
            // lblForSFN
            // 
            lblForSFN.AutoSize = true;
            lblForSFN.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            lblForSFN.ForeColor = Color.Red;
            lblForSFN.Location = new Point(98, 263);
            lblForSFN.Name = "lblForSFN";
            lblForSFN.Size = new Size(16, 20);
            lblForSFN.TabIndex = 0;
            lblForSFN.Text = "*";
            // 
            // lblForSLN
            // 
            lblForSLN.AutoSize = true;
            lblForSLN.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            lblForSLN.ForeColor = Color.Red;
            lblForSLN.Location = new Point(378, 263);
            lblForSLN.Name = "lblForSLN";
            lblForSLN.Size = new Size(16, 20);
            lblForSLN.TabIndex = 0;
            lblForSLN.Text = "*";
            // 
            // lblForSEmail
            // 
            lblForSEmail.AutoSize = true;
            lblForSEmail.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            lblForSEmail.ForeColor = Color.Red;
            lblForSEmail.Location = new Point(627, 263);
            lblForSEmail.Name = "lblForSEmail";
            lblForSEmail.Size = new Size(16, 20);
            lblForSEmail.TabIndex = 0;
            lblForSEmail.Text = "*";
            // 
            // lblForSDOB
            // 
            lblForSDOB.AutoSize = true;
            lblForSDOB.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            lblForSDOB.ForeColor = Color.Red;
            lblForSDOB.Location = new Point(114, 305);
            lblForSDOB.Name = "lblForSDOB";
            lblForSDOB.Size = new Size(16, 20);
            lblForSDOB.TabIndex = 0;
            lblForSDOB.Text = "*";
            // 
            // lblForSG
            // 
            lblForSG.AutoSize = true;
            lblForSG.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            lblForSG.ForeColor = Color.Red;
            lblForSG.Location = new Point(343, 305);
            lblForSG.Name = "lblForSG";
            lblForSG.Size = new Size(16, 20);
            lblForSG.TabIndex = 0;
            lblForSG.Text = "*";
            // 
            // lblForSA
            // 
            lblForSA.AutoSize = true;
            lblForSA.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            lblForSA.ForeColor = Color.Red;
            lblForSA.Location = new Point(78, 351);
            lblForSA.Name = "lblForSA";
            lblForSA.Size = new Size(16, 20);
            lblForSA.TabIndex = 0;
            lblForSA.Text = "*";
            // 
            // lblStudentImage
            // 
            lblStudentImage.AutoSize = true;
            lblStudentImage.BackColor = Color.Transparent;
            lblStudentImage.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            lblStudentImage.ForeColor = Color.FromArgb(0, 49, 64);
            lblStudentImage.Location = new Point(585, 309);
            lblStudentImage.Name = "lblStudentImage";
            lblStudentImage.Size = new Size(116, 20);
            lblStudentImage.TabIndex = 0;
            lblStudentImage.Text = "Student Image:";
            lblStudentImage.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblStudentId
            // 
            lblStudentId.AutoSize = true;
            lblStudentId.BackColor = Color.Transparent;
            lblStudentId.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            lblStudentId.ForeColor = Color.FromArgb(0, 49, 64);
            lblStudentId.Location = new Point(597, 398);
            lblStudentId.Name = "lblStudentId";
            lblStudentId.Size = new Size(86, 20);
            lblStudentId.TabIndex = 0;
            lblStudentId.Text = "Student Id:";
            lblStudentId.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblForSI
            // 
            lblForSI.AutoSize = true;
            lblForSI.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            lblForSI.ForeColor = Color.Red;
            lblForSI.Location = new Point(679, 394);
            lblForSI.Name = "lblForSI";
            lblForSI.Size = new Size(16, 20);
            lblForSI.TabIndex = 0;
            lblForSI.Text = "*";
            // 
            // txtBoxStudentId
            // 
            txtBoxStudentId.BackColor = Color.White;
            txtBoxStudentId.BorderStyle = BorderStyle.FixedSingle;
            txtBoxStudentId.Cursor = Cursors.IBeam;
            txtBoxStudentId.Font = new Font("Calibri", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtBoxStudentId.Location = new Point(597, 422);
            txtBoxStudentId.Name = "txtBoxStudentId";
            txtBoxStudentId.Size = new Size(98, 27);
            txtBoxStudentId.TabIndex = 1;
            txtBoxStudentId.TextAlign = HorizontalAlignment.Center;
            // 
            // StudentRegistrationPage
            // 
            AutoScaleDimensions = new SizeF(10F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(934, 461);
            Controls.Add(txtBoxStudentId);
            Controls.Add(lblForSI);
            Controls.Add(lblStudentId);
            Controls.Add(lblStudentImage);
            Controls.Add(lblForSA);
            Controls.Add(lblForSG);
            Controls.Add(lblForSDOB);
            Controls.Add(lblForSEmail);
            Controls.Add(lblForSLN);
            Controls.Add(lblForSFN);
            Controls.Add(panelForInfoDOWN);
            Controls.Add(panelForGenders);
            Controls.Add(btnForClear);
            Controls.Add(btnForAdd);
            Controls.Add(btnForUpload);
            Controls.Add(pictureBoxForStudentsImages);
            Controls.Add(panelForInfoUP);
            Controls.Add(txtBoxAddress);
            Controls.Add(lblAddress);
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
            Name = "StudentRegistrationPage";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Old School Course";
            Load += StudentRegistrationPage_Load;
            ((System.ComponentModel.ISupportInitialize)DataGridViewAboutStudent).EndInit();
            panelForInfoUP.ResumeLayout(false);
            panelForInfoUP.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxForStudentsImages).EndInit();
            panelForGenders.ResumeLayout(false);
            panelForGenders.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Guna.UI2.WinForms.Guna2DataGridView DataGridViewAboutStudent;
        private Label lblFirstName;
        private TextBox txtBoxFirstName;
        private TextBox txtBoxLastName;
        private Label lblLastName;
        private TextBox txtBoxEmail;
        private Label lblEmail;
        private Label lblDateOfBirth;
        private DateTimePicker dateTimePickerDOB;
        private Label lblGender;
        private RadioButton radioButtonGenderM;
        private RadioButton radioButtonGenderF;
        private Label lblAddress;
        private TextBox txtBoxAddress;
        private Panel panelForInfoUP;
        private Label lblRegistrationIP;
        private PictureBox pictureBoxForStudentsImages;
        private Button btnForUpload;
        private Button btnForAdd;
        private Button btnForClear;
        private Panel panelForGenders;
        private Panel panelForInfoDOWN;
        private Label lblForSFN;
        private Label lblForSLN;
        private Label lblForSEmail;
        private Label lblForSDOB;
        private Label lblForSG;
        private Label lblForSA;
        private Label lblStudentImage;
        private Label lblStudentId;
        private Label lblForSI;
        private TextBox txtBoxStudentId;
    }
}