namespace CourseManagement.View.Forms
{
    partial class NewScorePage
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
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle6 = new DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NewScorePage));
            lblStudentListIP = new Label();
            panelForInfoDOWN = new Panel();
            panelForInfoUP = new Panel();
            lblScoretListIP = new Label();
            DataGridViewAboutStudents = new Guna.UI2.WinForms.Guna2DataGridView();
            txtBoxDescription = new TextBox();
            lblForDescription = new Label();
            lblForStudentId = new Label();
            txtBoxScore = new TextBox();
            lblForScore = new Label();
            lblForSelectCourse = new Label();
            comboBoxForCourse = new ComboBox();
            btnForClear = new Button();
            btnForAdd = new Button();
            lblForSC = new Label();
            lblForSId = new Label();
            lblForSS = new Label();
            lblForSD = new Label();
            DataGridViewAboutScores = new Guna.UI2.WinForms.Guna2DataGridView();
            panelOnMiddle = new Panel();
            lblForShowingStdId = new Label();
            panelForInfoUP.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)DataGridViewAboutStudents).BeginInit();
            ((System.ComponentModel.ISupportInitialize)DataGridViewAboutScores).BeginInit();
            SuspendLayout();
            // 
            // lblStudentListIP
            // 
            lblStudentListIP.AutoSize = true;
            lblStudentListIP.BackColor = Color.Transparent;
            lblStudentListIP.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            lblStudentListIP.ForeColor = Color.White;
            lblStudentListIP.Location = new Point(169, 6);
            lblStudentListIP.Name = "lblStudentListIP";
            lblStudentListIP.Size = new Size(120, 30);
            lblStudentListIP.TabIndex = 0;
            lblStudentListIP.Text = "Student list";
            // 
            // panelForInfoDOWN
            // 
            panelForInfoDOWN.BackColor = Color.FromArgb(0, 49, 64);
            panelForInfoDOWN.Location = new Point(0, 273);
            panelForInfoDOWN.Name = "panelForInfoDOWN";
            panelForInfoDOWN.Size = new Size(934, 15);
            panelForInfoDOWN.TabIndex = 0;
            panelForInfoDOWN.TabStop = true;
            // 
            // panelForInfoUP
            // 
            panelForInfoUP.BackColor = Color.FromArgb(0, 49, 64);
            panelForInfoUP.Controls.Add(lblScoretListIP);
            panelForInfoUP.Controls.Add(lblStudentListIP);
            panelForInfoUP.Dock = DockStyle.Top;
            panelForInfoUP.Location = new Point(0, 0);
            panelForInfoUP.Name = "panelForInfoUP";
            panelForInfoUP.Size = new Size(934, 43);
            panelForInfoUP.TabIndex = 0;
            panelForInfoUP.TabStop = true;
            // 
            // lblScoretListIP
            // 
            lblScoretListIP.AutoSize = true;
            lblScoretListIP.BackColor = Color.Transparent;
            lblScoretListIP.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            lblScoretListIP.ForeColor = Color.White;
            lblScoretListIP.Location = new Point(651, 6);
            lblScoretListIP.Name = "lblScoretListIP";
            lblScoretListIP.Size = new Size(99, 30);
            lblScoretListIP.TabIndex = 0;
            lblScoretListIP.Text = "Score list";
            // 
            // DataGridViewAboutStudents
            // 
            DataGridViewAboutStudents.AllowUserToAddRows = false;
            DataGridViewAboutStudents.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = Color.White;
            DataGridViewAboutStudents.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            DataGridViewAboutStudents.BackgroundColor = Color.Gainsboro;
            DataGridViewAboutStudents.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(100, 88, 255);
            dataGridViewCellStyle2.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = Color.White;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            DataGridViewAboutStudents.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            DataGridViewAboutStudents.ColumnHeadersHeight = 22;
            DataGridViewAboutStudents.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.White;
            dataGridViewCellStyle3.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = Color.FromArgb(71, 69, 94);
            dataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(231, 229, 255);
            dataGridViewCellStyle3.SelectionForeColor = Color.FromArgb(71, 69, 94);
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            DataGridViewAboutStudents.DefaultCellStyle = dataGridViewCellStyle3;
            DataGridViewAboutStudents.GridColor = Color.FromArgb(231, 229, 255);
            DataGridViewAboutStudents.Location = new Point(0, 43);
            DataGridViewAboutStudents.Name = "DataGridViewAboutStudents";
            DataGridViewAboutStudents.RowHeadersVisible = false;
            DataGridViewAboutStudents.RowHeadersWidth = 25;
            DataGridViewAboutStudents.RowTemplate.Height = 65;
            DataGridViewAboutStudents.Size = new Size(457, 230);
            DataGridViewAboutStudents.TabIndex = 0;
            DataGridViewAboutStudents.ThemeStyle.AlternatingRowsStyle.BackColor = Color.White;
            DataGridViewAboutStudents.ThemeStyle.AlternatingRowsStyle.Font = null;
            DataGridViewAboutStudents.ThemeStyle.AlternatingRowsStyle.ForeColor = Color.Empty;
            DataGridViewAboutStudents.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = Color.Empty;
            DataGridViewAboutStudents.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = Color.Empty;
            DataGridViewAboutStudents.ThemeStyle.BackColor = Color.Gainsboro;
            DataGridViewAboutStudents.ThemeStyle.GridColor = Color.FromArgb(231, 229, 255);
            DataGridViewAboutStudents.ThemeStyle.HeaderStyle.BackColor = Color.FromArgb(100, 88, 255);
            DataGridViewAboutStudents.ThemeStyle.HeaderStyle.BorderStyle = DataGridViewHeaderBorderStyle.Single;
            DataGridViewAboutStudents.ThemeStyle.HeaderStyle.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            DataGridViewAboutStudents.ThemeStyle.HeaderStyle.ForeColor = Color.White;
            DataGridViewAboutStudents.ThemeStyle.HeaderStyle.HeaightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            DataGridViewAboutStudents.ThemeStyle.HeaderStyle.Height = 22;
            DataGridViewAboutStudents.ThemeStyle.ReadOnly = false;
            DataGridViewAboutStudents.ThemeStyle.RowsStyle.BackColor = Color.White;
            DataGridViewAboutStudents.ThemeStyle.RowsStyle.BorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            DataGridViewAboutStudents.ThemeStyle.RowsStyle.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            DataGridViewAboutStudents.ThemeStyle.RowsStyle.ForeColor = Color.FromArgb(71, 69, 94);
            DataGridViewAboutStudents.ThemeStyle.RowsStyle.Height = 65;
            DataGridViewAboutStudents.ThemeStyle.RowsStyle.SelectionBackColor = Color.FromArgb(231, 229, 255);
            DataGridViewAboutStudents.ThemeStyle.RowsStyle.SelectionForeColor = Color.FromArgb(71, 69, 94);
            DataGridViewAboutStudents.Click += DataGridViewAboutStudents_Click;
            // 
            // txtBoxDescription
            // 
            txtBoxDescription.BackColor = Color.White;
            txtBoxDescription.BorderStyle = BorderStyle.FixedSingle;
            txtBoxDescription.Cursor = Cursors.IBeam;
            txtBoxDescription.Font = new Font("Calibri", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtBoxDescription.Location = new Point(124, 417);
            txtBoxDescription.Multiline = true;
            txtBoxDescription.Name = "txtBoxDescription";
            txtBoxDescription.Size = new Size(65, 27);
            txtBoxDescription.TabIndex = 3;
            txtBoxDescription.TextAlign = HorizontalAlignment.Center;
            // 
            // lblForDescription
            // 
            lblForDescription.AutoSize = true;
            lblForDescription.BackColor = Color.Transparent;
            lblForDescription.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            lblForDescription.ForeColor = Color.FromArgb(0, 49, 64);
            lblForDescription.Location = new Point(13, 421);
            lblForDescription.Name = "lblForDescription";
            lblForDescription.Size = new Size(93, 20);
            lblForDescription.TabIndex = 0;
            lblForDescription.Text = "Description:";
            lblForDescription.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblForStudentId
            // 
            lblForStudentId.AutoSize = true;
            lblForStudentId.BackColor = Color.Transparent;
            lblForStudentId.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            lblForStudentId.ForeColor = Color.FromArgb(0, 49, 64);
            lblForStudentId.Location = new Point(13, 319);
            lblForStudentId.Name = "lblForStudentId";
            lblForStudentId.Size = new Size(86, 20);
            lblForStudentId.TabIndex = 0;
            lblForStudentId.Text = "Student Id:";
            lblForStudentId.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // txtBoxScore
            // 
            txtBoxScore.BorderStyle = BorderStyle.FixedSingle;
            txtBoxScore.Cursor = Cursors.IBeam;
            txtBoxScore.Font = new Font("Calibri", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtBoxScore.Location = new Point(82, 365);
            txtBoxScore.Name = "txtBoxScore";
            txtBoxScore.Size = new Size(65, 27);
            txtBoxScore.TabIndex = 2;
            txtBoxScore.TextAlign = HorizontalAlignment.Center;
            // 
            // lblForScore
            // 
            lblForScore.AutoSize = true;
            lblForScore.BackColor = Color.Transparent;
            lblForScore.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            lblForScore.ForeColor = Color.FromArgb(0, 49, 64);
            lblForScore.Location = new Point(13, 368);
            lblForScore.Name = "lblForScore";
            lblForScore.Size = new Size(51, 20);
            lblForScore.TabIndex = 0;
            lblForScore.Text = "Score:";
            lblForScore.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblForSelectCourse
            // 
            lblForSelectCourse.AutoSize = true;
            lblForSelectCourse.BackColor = Color.Transparent;
            lblForSelectCourse.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            lblForSelectCourse.ForeColor = Color.FromArgb(0, 49, 64);
            lblForSelectCourse.Location = new Point(197, 319);
            lblForSelectCourse.Name = "lblForSelectCourse";
            lblForSelectCourse.Size = new Size(106, 20);
            lblForSelectCourse.TabIndex = 0;
            lblForSelectCourse.Text = "Select Course:";
            lblForSelectCourse.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // comboBoxForCourse
            // 
            comboBoxForCourse.BackColor = Color.White;
            comboBoxForCourse.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxForCourse.FlatStyle = FlatStyle.Flat;
            comboBoxForCourse.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            comboBoxForCourse.FormattingEnabled = true;
            comboBoxForCourse.Location = new Point(321, 315);
            comboBoxForCourse.Name = "comboBoxForCourse";
            comboBoxForCourse.Size = new Size(400, 25);
            comboBoxForCourse.Sorted = true;
            comboBoxForCourse.TabIndex = 1;
            // 
            // btnForClear
            // 
            btnForClear.BackColor = Color.Orange;
            btnForClear.Cursor = Cursors.Hand;
            btnForClear.FlatStyle = FlatStyle.Flat;
            btnForClear.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold, GraphicsUnit.Point);
            btnForClear.ForeColor = Color.White;
            btnForClear.Location = new Point(767, 422);
            btnForClear.Name = "btnForClear";
            btnForClear.Size = new Size(109, 34);
            btnForClear.TabIndex = 5;
            btnForClear.Text = "Clear";
            btnForClear.UseVisualStyleBackColor = false;
            btnForClear.Click += btnForClear_Click;
            // 
            // btnForAdd
            // 
            btnForAdd.BackColor = Color.FromArgb(0, 71, 160);
            btnForAdd.Cursor = Cursors.Hand;
            btnForAdd.FlatStyle = FlatStyle.Flat;
            btnForAdd.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold, GraphicsUnit.Point);
            btnForAdd.ForeColor = Color.White;
            btnForAdd.Location = new Point(813, 383);
            btnForAdd.Name = "btnForAdd";
            btnForAdd.Size = new Size(109, 34);
            btnForAdd.TabIndex = 4;
            btnForAdd.Text = "Add";
            btnForAdd.UseVisualStyleBackColor = false;
            btnForAdd.Click += btnForAdd_Click;
            // 
            // lblForSC
            // 
            lblForSC.AutoSize = true;
            lblForSC.BackColor = Color.Transparent;
            lblForSC.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            lblForSC.ForeColor = Color.Red;
            lblForSC.Location = new Point(299, 315);
            lblForSC.Name = "lblForSC";
            lblForSC.Size = new Size(16, 20);
            lblForSC.TabIndex = 0;
            lblForSC.Text = "*";
            // 
            // lblForSId
            // 
            lblForSId.AutoSize = true;
            lblForSId.BackColor = Color.Transparent;
            lblForSId.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            lblForSId.ForeColor = Color.Red;
            lblForSId.Location = new Point(95, 313);
            lblForSId.Name = "lblForSId";
            lblForSId.Size = new Size(16, 20);
            lblForSId.TabIndex = 0;
            lblForSId.Text = "*";
            // 
            // lblForSS
            // 
            lblForSS.AutoSize = true;
            lblForSS.BackColor = Color.Transparent;
            lblForSS.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            lblForSS.ForeColor = Color.Red;
            lblForSS.Location = new Point(60, 365);
            lblForSS.Name = "lblForSS";
            lblForSS.Size = new Size(16, 20);
            lblForSS.TabIndex = 0;
            lblForSS.Text = "*";
            // 
            // lblForSD
            // 
            lblForSD.AutoSize = true;
            lblForSD.BackColor = Color.Transparent;
            lblForSD.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            lblForSD.ForeColor = Color.Red;
            lblForSD.Location = new Point(102, 418);
            lblForSD.Name = "lblForSD";
            lblForSD.Size = new Size(16, 20);
            lblForSD.TabIndex = 0;
            lblForSD.Text = "*";
            // 
            // DataGridViewAboutScores
            // 
            DataGridViewAboutScores.AllowUserToAddRows = false;
            DataGridViewAboutScores.AllowUserToDeleteRows = false;
            dataGridViewCellStyle4.BackColor = Color.White;
            DataGridViewAboutScores.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            DataGridViewAboutScores.BackgroundColor = Color.Gainsboro;
            DataGridViewAboutScores.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle5.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = Color.FromArgb(100, 88, 255);
            dataGridViewCellStyle5.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle5.ForeColor = Color.White;
            dataGridViewCellStyle5.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = DataGridViewTriState.True;
            DataGridViewAboutScores.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            DataGridViewAboutScores.ColumnHeadersHeight = 22;
            DataGridViewAboutScores.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dataGridViewCellStyle6.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = Color.White;
            dataGridViewCellStyle6.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle6.ForeColor = Color.FromArgb(71, 69, 94);
            dataGridViewCellStyle6.SelectionBackColor = Color.FromArgb(231, 229, 255);
            dataGridViewCellStyle6.SelectionForeColor = Color.FromArgb(71, 69, 94);
            dataGridViewCellStyle6.WrapMode = DataGridViewTriState.False;
            DataGridViewAboutScores.DefaultCellStyle = dataGridViewCellStyle6;
            DataGridViewAboutScores.GridColor = Color.FromArgb(231, 229, 255);
            DataGridViewAboutScores.Location = new Point(477, 43);
            DataGridViewAboutScores.Name = "DataGridViewAboutScores";
            DataGridViewAboutScores.RowHeadersVisible = false;
            DataGridViewAboutScores.RowHeadersWidth = 25;
            DataGridViewAboutScores.RowTemplate.Height = 65;
            DataGridViewAboutScores.Size = new Size(457, 230);
            DataGridViewAboutScores.TabIndex = 0;
            DataGridViewAboutScores.ThemeStyle.AlternatingRowsStyle.BackColor = Color.White;
            DataGridViewAboutScores.ThemeStyle.AlternatingRowsStyle.Font = null;
            DataGridViewAboutScores.ThemeStyle.AlternatingRowsStyle.ForeColor = Color.Empty;
            DataGridViewAboutScores.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = Color.Empty;
            DataGridViewAboutScores.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = Color.Empty;
            DataGridViewAboutScores.ThemeStyle.BackColor = Color.Gainsboro;
            DataGridViewAboutScores.ThemeStyle.GridColor = Color.FromArgb(231, 229, 255);
            DataGridViewAboutScores.ThemeStyle.HeaderStyle.BackColor = Color.FromArgb(100, 88, 255);
            DataGridViewAboutScores.ThemeStyle.HeaderStyle.BorderStyle = DataGridViewHeaderBorderStyle.Single;
            DataGridViewAboutScores.ThemeStyle.HeaderStyle.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            DataGridViewAboutScores.ThemeStyle.HeaderStyle.ForeColor = Color.White;
            DataGridViewAboutScores.ThemeStyle.HeaderStyle.HeaightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            DataGridViewAboutScores.ThemeStyle.HeaderStyle.Height = 22;
            DataGridViewAboutScores.ThemeStyle.ReadOnly = false;
            DataGridViewAboutScores.ThemeStyle.RowsStyle.BackColor = Color.White;
            DataGridViewAboutScores.ThemeStyle.RowsStyle.BorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            DataGridViewAboutScores.ThemeStyle.RowsStyle.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            DataGridViewAboutScores.ThemeStyle.RowsStyle.ForeColor = Color.FromArgb(71, 69, 94);
            DataGridViewAboutScores.ThemeStyle.RowsStyle.Height = 65;
            DataGridViewAboutScores.ThemeStyle.RowsStyle.SelectionBackColor = Color.FromArgb(231, 229, 255);
            DataGridViewAboutScores.ThemeStyle.RowsStyle.SelectionForeColor = Color.FromArgb(71, 69, 94);
            DataGridViewAboutScores.CellDoubleClick += DataGridViewAboutScores_CellDoubleClick;
            // 
            // panelOnMiddle
            // 
            panelOnMiddle.BackColor = Color.FromArgb(0, 49, 64);
            panelOnMiddle.Location = new Point(457, 43);
            panelOnMiddle.Name = "panelOnMiddle";
            panelOnMiddle.Size = new Size(20, 230);
            panelOnMiddle.TabIndex = 0;
            // 
            // lblForShowingStdId
            // 
            lblForShowingStdId.AutoSize = true;
            lblForShowingStdId.BackColor = Color.Transparent;
            lblForShowingStdId.Font = new Font("Calibri", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblForShowingStdId.ForeColor = Color.Gray;
            lblForShowingStdId.Location = new Point(117, 320);
            lblForShowingStdId.Name = "lblForShowingStdId";
            lblForShowingStdId.Size = new Size(0, 19);
            lblForShowingStdId.TabIndex = 0;
            lblForShowingStdId.TextAlign = ContentAlignment.MiddleLeft;
            lblForShowingStdId.TextChanged += lblForShowingStdId_TextChanged;
            // 
            // NewScorePage
            // 
            AutoScaleDimensions = new SizeF(10F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(934, 461);
            Controls.Add(lblForShowingStdId);
            Controls.Add(panelOnMiddle);
            Controls.Add(DataGridViewAboutScores);
            Controls.Add(lblForSD);
            Controls.Add(lblForSS);
            Controls.Add(lblForSId);
            Controls.Add(lblForSC);
            Controls.Add(btnForAdd);
            Controls.Add(btnForClear);
            Controls.Add(comboBoxForCourse);
            Controls.Add(lblForSelectCourse);
            Controls.Add(txtBoxScore);
            Controls.Add(lblForScore);
            Controls.Add(lblForStudentId);
            Controls.Add(txtBoxDescription);
            Controls.Add(lblForDescription);
            Controls.Add(panelForInfoDOWN);
            Controls.Add(panelForInfoUP);
            Controls.Add(DataGridViewAboutStudents);
            Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(4);
            MaximizeBox = false;
            MinimumSize = new Size(950, 500);
            Name = "NewScorePage";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Old School Course";
            Load += NewScorePage_Load;
            panelForInfoUP.ResumeLayout(false);
            panelForInfoUP.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)DataGridViewAboutStudents).EndInit();
            ((System.ComponentModel.ISupportInitialize)DataGridViewAboutScores).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label lblStudentListIP;
        private Panel panelForInfoDOWN;
        private Panel panelForInfoUP;
        private Guna.UI2.WinForms.Guna2DataGridView DataGridViewAboutStudents;
        private TextBox txtBoxDescription;
        private Label lblForDescription;
        private Label lblForStudentId;
        private TextBox txtBoxScore;
        private Label lblForScore;
        private Label lblForSelectCourse;
        private ComboBox comboBoxForCourse;
        private Button btnForClear;
        private Button btnForAdd;
        private Label lblForSC;
        private Label lblForSId;
        private Label lblForSS;
        private Label lblForSD;
        private Guna.UI2.WinForms.Guna2DataGridView DataGridViewAboutScores;
        private Panel panelOnMiddle;
        private Label lblScoretListIP;
        private Label lblForShowingStdId;
    }
}