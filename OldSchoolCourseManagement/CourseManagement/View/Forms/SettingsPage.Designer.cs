namespace CourseManagement.View.Forms
{
    partial class SettingsPage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SettingsPage));
            panelForPasswordSettings = new Panel();
            lblNSPassInfo = new Label();
            lblNFPassInfo = new Label();
            lblCurrentPassInfo = new Label();
            lblForNSPass = new Label();
            lblForNFPass = new Label();
            lblForCurrentPass = new Label();
            eyePictureBox = new PictureBox();
            textBoxNSPass = new TextBox();
            buttonForSubmit = new Button();
            textBoxNFPass = new TextBox();
            textBoxCurrentPass = new TextBox();
            labelShowMeeting = new Label();
            panelForPasswordSettings.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)eyePictureBox).BeginInit();
            SuspendLayout();
            // 
            // panelForPasswordSettings
            // 
            panelForPasswordSettings.BackColor = Color.FromArgb(75, 100, 100, 100);
            panelForPasswordSettings.Controls.Add(lblNSPassInfo);
            panelForPasswordSettings.Controls.Add(lblNFPassInfo);
            panelForPasswordSettings.Controls.Add(lblCurrentPassInfo);
            panelForPasswordSettings.Controls.Add(lblForNSPass);
            panelForPasswordSettings.Controls.Add(lblForNFPass);
            panelForPasswordSettings.Controls.Add(lblForCurrentPass);
            panelForPasswordSettings.Controls.Add(eyePictureBox);
            panelForPasswordSettings.Controls.Add(textBoxNSPass);
            panelForPasswordSettings.Controls.Add(buttonForSubmit);
            panelForPasswordSettings.Controls.Add(textBoxNFPass);
            panelForPasswordSettings.Controls.Add(textBoxCurrentPass);
            panelForPasswordSettings.Location = new Point(34, 81);
            panelForPasswordSettings.Name = "panelForPasswordSettings";
            panelForPasswordSettings.Size = new Size(426, 318);
            panelForPasswordSettings.TabIndex = 0;
            // 
            // lblNSPassInfo
            // 
            lblNSPassInfo.AutoSize = true;
            lblNSPassInfo.BackColor = Color.Transparent;
            lblNSPassInfo.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lblNSPassInfo.ForeColor = Color.Red;
            lblNSPassInfo.Location = new Point(162, 234);
            lblNSPassInfo.Name = "lblNSPassInfo";
            lblNSPassInfo.Size = new Size(0, 15);
            lblNSPassInfo.TabIndex = 0;
            lblNSPassInfo.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblNFPassInfo
            // 
            lblNFPassInfo.AutoSize = true;
            lblNFPassInfo.BackColor = Color.Transparent;
            lblNFPassInfo.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lblNFPassInfo.ForeColor = Color.Red;
            lblNFPassInfo.Location = new Point(162, 155);
            lblNFPassInfo.Name = "lblNFPassInfo";
            lblNFPassInfo.Size = new Size(0, 15);
            lblNFPassInfo.TabIndex = 0;
            lblNFPassInfo.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblCurrentPassInfo
            // 
            lblCurrentPassInfo.AutoSize = true;
            lblCurrentPassInfo.BackColor = Color.Transparent;
            lblCurrentPassInfo.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lblCurrentPassInfo.ForeColor = Color.Red;
            lblCurrentPassInfo.Location = new Point(162, 76);
            lblCurrentPassInfo.Name = "lblCurrentPassInfo";
            lblCurrentPassInfo.Size = new Size(0, 15);
            lblCurrentPassInfo.TabIndex = 0;
            lblCurrentPassInfo.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblForNSPass
            // 
            lblForNSPass.AutoSize = true;
            lblForNSPass.BackColor = Color.Transparent;
            lblForNSPass.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            lblForNSPass.ForeColor = Color.MediumBlue;
            lblForNSPass.Location = new Point(42, 203);
            lblForNSPass.Name = "lblForNSPass";
            lblForNSPass.Size = new Size(116, 25);
            lblForNSPass.TabIndex = 0;
            lblForNSPass.Text = "Retype new:";
            // 
            // lblForNFPass
            // 
            lblForNFPass.AutoSize = true;
            lblForNFPass.BackColor = Color.Transparent;
            lblForNFPass.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            lblForNFPass.ForeColor = Color.MediumBlue;
            lblForNFPass.Location = new Point(102, 124);
            lblForNFPass.Name = "lblForNFPass";
            lblForNFPass.Size = new Size(56, 25);
            lblForNFPass.TabIndex = 0;
            lblForNFPass.Text = "New:";
            // 
            // lblForCurrentPass
            // 
            lblForCurrentPass.AutoSize = true;
            lblForCurrentPass.BackColor = Color.Transparent;
            lblForCurrentPass.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            lblForCurrentPass.ForeColor = Color.MediumBlue;
            lblForCurrentPass.Location = new Point(69, 45);
            lblForCurrentPass.Name = "lblForCurrentPass";
            lblForCurrentPass.Size = new Size(89, 25);
            lblForCurrentPass.TabIndex = 0;
            lblForCurrentPass.Text = "Currrent:";
            // 
            // eyePictureBox
            // 
            eyePictureBox.BackColor = SystemColors.Window;
            eyePictureBox.Cursor = Cursors.Hand;
            eyePictureBox.Location = new Point(332, 207);
            eyePictureBox.Name = "eyePictureBox";
            eyePictureBox.Size = new Size(26, 21);
            eyePictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
            eyePictureBox.TabIndex = 5;
            eyePictureBox.TabStop = false;
            eyePictureBox.Visible = false;
            eyePictureBox.Click += eyePictureBox_Click;
            // 
            // textBoxNSPass
            // 
            textBoxNSPass.Cursor = Cursors.IBeam;
            textBoxNSPass.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxNSPass.ForeColor = Color.Black;
            textBoxNSPass.Location = new Point(162, 204);
            textBoxNSPass.Name = "textBoxNSPass";
            textBoxNSPass.PasswordChar = '•';
            textBoxNSPass.Size = new Size(200, 27);
            textBoxNSPass.TabIndex = 3;
            textBoxNSPass.TextChanged += TextBoxsForPassword_TextChanged;
            // 
            // buttonForSubmit
            // 
            buttonForSubmit.BackColor = Color.FromArgb(0, 49, 64);
            buttonForSubmit.Cursor = Cursors.Hand;
            buttonForSubmit.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            buttonForSubmit.ForeColor = Color.White;
            buttonForSubmit.Location = new Point(304, 268);
            buttonForSubmit.Name = "buttonForSubmit";
            buttonForSubmit.Size = new Size(113, 43);
            buttonForSubmit.TabIndex = 4;
            buttonForSubmit.Text = "Submit";
            buttonForSubmit.UseVisualStyleBackColor = false;
            buttonForSubmit.Click += buttonForSubmit_Click;
            // 
            // textBoxNFPass
            // 
            textBoxNFPass.Cursor = Cursors.IBeam;
            textBoxNFPass.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxNFPass.ForeColor = Color.Black;
            textBoxNFPass.Location = new Point(162, 125);
            textBoxNFPass.Name = "textBoxNFPass";
            textBoxNFPass.PasswordChar = '•';
            textBoxNFPass.Size = new Size(200, 27);
            textBoxNFPass.TabIndex = 2;
            textBoxNFPass.TextChanged += TextBoxsForPassword_TextChanged;
            // 
            // textBoxCurrentPass
            // 
            textBoxCurrentPass.Cursor = Cursors.IBeam;
            textBoxCurrentPass.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxCurrentPass.ForeColor = Color.Black;
            textBoxCurrentPass.Location = new Point(162, 46);
            textBoxCurrentPass.Name = "textBoxCurrentPass";
            textBoxCurrentPass.PasswordChar = '•';
            textBoxCurrentPass.Size = new Size(200, 27);
            textBoxCurrentPass.TabIndex = 1;
            textBoxCurrentPass.TextChanged += TextBoxsForPassword_TextChanged;
            // 
            // labelShowMeeting
            // 
            labelShowMeeting.AutoSize = true;
            labelShowMeeting.BackColor = Color.Transparent;
            labelShowMeeting.Font = new Font("MV Boli", 25F, FontStyle.Bold, GraphicsUnit.Point);
            labelShowMeeting.ForeColor = Color.MediumBlue;
            labelShowMeeting.Location = new Point(79, 18);
            labelShowMeeting.Name = "labelShowMeeting";
            labelShowMeeting.Size = new Size(328, 45);
            labelShowMeeting.TabIndex = 0;
            labelShowMeeting.Text = "Password Settings";
            // 
            // SettingsPage
            // 
            AutoScaleDimensions = new SizeF(10F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(0, 49, 64);
            ClientSize = new Size(484, 411);
            Controls.Add(labelShowMeeting);
            Controls.Add(panelForPasswordSettings);
            Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(4);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "SettingsPage";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Old School Course";
            Load += SettingsPage_Load;
            panelForPasswordSettings.ResumeLayout(false);
            panelForPasswordSettings.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)eyePictureBox).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panelForPasswordSettings;
        private PictureBox eyePictureBoxUP;
        private Button buttonForSubmit;
        private TextBox textBoxNFPass;
        private TextBox textBoxCurrentPass;
        private Label labelShowMeeting;
        private PictureBox eyePictureBox;
        private TextBox textBoxNSPass;
        private Label lblForCurrentPass;
        private Label lblForNSPass;
        private Label lblForNFPass;
        private Label lblNSPassInfo;
        private Label lblNFPassInfo;
        private Label lblCurrentPassInfo;
    }
}