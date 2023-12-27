namespace CourseManagement.View.Forms
{
    partial class AuthenticationPage
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AuthenticationPage));
            timerForAP = new System.Windows.Forms.Timer(components);
            panelForAuthentication = new Panel();
            lblForLogInPasswordUP = new Label();
            lblForLogInEmailorRoleNameUP = new Label();
            lblForLogInPasswordDOWN = new Label();
            lblForLogInEmailorRoleNameDOWN = new Label();
            eyePictureBox = new PictureBox();
            buttonForLogIn = new Button();
            labelShowMeeting = new Label();
            textBoxLogInPassword = new TextBox();
            textBoxLogInEmail = new TextBox();
            panelForAuthentication.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)eyePictureBox).BeginInit();
            SuspendLayout();
            // 
            // timerForAP
            // 
            timerForAP.Tick += timerForAP_Tick;
            // 
            // panelForAuthentication
            // 
            panelForAuthentication.BackColor = Color.FromArgb(175, 169, 169, 169);
            panelForAuthentication.Controls.Add(lblForLogInPasswordUP);
            panelForAuthentication.Controls.Add(lblForLogInEmailorRoleNameUP);
            panelForAuthentication.Controls.Add(lblForLogInPasswordDOWN);
            panelForAuthentication.Controls.Add(lblForLogInEmailorRoleNameDOWN);
            panelForAuthentication.Controls.Add(eyePictureBox);
            panelForAuthentication.Controls.Add(buttonForLogIn);
            panelForAuthentication.Controls.Add(labelShowMeeting);
            panelForAuthentication.Controls.Add(textBoxLogInPassword);
            panelForAuthentication.Controls.Add(textBoxLogInEmail);
            panelForAuthentication.Location = new Point(112, 50);
            panelForAuthentication.Name = "panelForAuthentication";
            panelForAuthentication.Size = new Size(438, 320);
            panelForAuthentication.TabIndex = 0;
            // 
            // lblForLogInPasswordUP
            // 
            lblForLogInPasswordUP.AutoSize = true;
            lblForLogInPasswordUP.BackColor = Color.Transparent;
            lblForLogInPasswordUP.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            lblForLogInPasswordUP.ForeColor = Color.AntiqueWhite;
            lblForLogInPasswordUP.Location = new Point(65, 183);
            lblForLogInPasswordUP.Name = "lblForLogInPasswordUP";
            lblForLogInPasswordUP.Size = new Size(91, 25);
            lblForLogInPasswordUP.TabIndex = 0;
            lblForLogInPasswordUP.Text = "Password";
            // 
            // lblForLogInEmailorRoleNameUP
            // 
            lblForLogInEmailorRoleNameUP.AutoSize = true;
            lblForLogInEmailorRoleNameUP.BackColor = Color.Transparent;
            lblForLogInEmailorRoleNameUP.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            lblForLogInEmailorRoleNameUP.ForeColor = Color.AntiqueWhite;
            lblForLogInEmailorRoleNameUP.Location = new Point(65, 110);
            lblForLogInEmailorRoleNameUP.Name = "lblForLogInEmailorRoleNameUP";
            lblForLogInEmailorRoleNameUP.Size = new Size(173, 25);
            lblForLogInEmailorRoleNameUP.TabIndex = 0;
            lblForLogInEmailorRoleNameUP.Text = "Email or role name";
            // 
            // lblForLogInPasswordDOWN
            // 
            lblForLogInPasswordDOWN.AutoSize = true;
            lblForLogInPasswordDOWN.BackColor = Color.Transparent;
            lblForLogInPasswordDOWN.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lblForLogInPasswordDOWN.ForeColor = Color.DarkRed;
            lblForLogInPasswordDOWN.Location = new Point(70, 240);
            lblForLogInPasswordDOWN.Name = "lblForLogInPasswordDOWN";
            lblForLogInPasswordDOWN.Size = new Size(0, 15);
            lblForLogInPasswordDOWN.TabIndex = 0;
            // 
            // lblForLogInEmailorRoleNameDOWN
            // 
            lblForLogInEmailorRoleNameDOWN.AutoSize = true;
            lblForLogInEmailorRoleNameDOWN.BackColor = Color.Transparent;
            lblForLogInEmailorRoleNameDOWN.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lblForLogInEmailorRoleNameDOWN.ForeColor = Color.DarkRed;
            lblForLogInEmailorRoleNameDOWN.Location = new Point(70, 168);
            lblForLogInEmailorRoleNameDOWN.Name = "lblForLogInEmailorRoleNameDOWN";
            lblForLogInEmailorRoleNameDOWN.Size = new Size(0, 15);
            lblForLogInEmailorRoleNameDOWN.TabIndex = 0;
            // 
            // eyePictureBox
            // 
            eyePictureBox.BackColor = Color.White;
            eyePictureBox.Cursor = Cursors.Hand;
            eyePictureBox.Location = new Point(292, 213);
            eyePictureBox.Name = "eyePictureBox";
            eyePictureBox.Size = new Size(26, 21);
            eyePictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
            eyePictureBox.TabIndex = 3;
            eyePictureBox.TabStop = false;
            eyePictureBox.Visible = false;
            eyePictureBox.Click += eyePictureBox_Click;
            // 
            // buttonForLogIn
            // 
            buttonForLogIn.BackColor = Color.FromArgb(59, 89, 152);
            buttonForLogIn.Cursor = Cursors.Hand;
            buttonForLogIn.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            buttonForLogIn.ForeColor = Color.White;
            buttonForLogIn.Location = new Point(298, 255);
            buttonForLogIn.Name = "buttonForLogIn";
            buttonForLogIn.Size = new Size(113, 43);
            buttonForLogIn.TabIndex = 3;
            buttonForLogIn.Text = "Log In";
            buttonForLogIn.UseVisualStyleBackColor = false;
            buttonForLogIn.Click += buttonForLogIn_Click;
            // 
            // labelShowMeeting
            // 
            labelShowMeeting.AutoSize = true;
            labelShowMeeting.BackColor = Color.Transparent;
            labelShowMeeting.Font = new Font("MV Boli", 35.25F, FontStyle.Bold, GraphicsUnit.Point);
            labelShowMeeting.Location = new Point(110, 23);
            labelShowMeeting.Name = "labelShowMeeting";
            labelShowMeeting.Size = new Size(220, 62);
            labelShowMeeting.TabIndex = 0;
            labelShowMeeting.Text = "Welcome";
            // 
            // textBoxLogInPassword
            // 
            textBoxLogInPassword.Cursor = Cursors.IBeam;
            textBoxLogInPassword.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxLogInPassword.ForeColor = Color.Black;
            textBoxLogInPassword.Location = new Point(70, 210);
            textBoxLogInPassword.Name = "textBoxLogInPassword";
            textBoxLogInPassword.PasswordChar = '•';
            textBoxLogInPassword.Size = new Size(250, 27);
            textBoxLogInPassword.TabIndex = 2;
            textBoxLogInPassword.TextChanged += textBoxLogInPassword_TextChanged;
            // 
            // textBoxLogInEmail
            // 
            textBoxLogInEmail.Cursor = Cursors.IBeam;
            textBoxLogInEmail.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxLogInEmail.ForeColor = Color.Black;
            textBoxLogInEmail.Location = new Point(70, 138);
            textBoxLogInEmail.Name = "textBoxLogInEmail";
            textBoxLogInEmail.Size = new Size(250, 27);
            textBoxLogInEmail.TabIndex = 1;
            // 
            // AuthenticationPage
            // 
            AutoScaleDimensions = new SizeF(10F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(634, 411);
            Controls.Add(panelForAuthentication);
            Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(4);
            MaximizeBox = false;
            Name = "AuthenticationPage";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Old School Course";
            panelForAuthentication.ResumeLayout(false);
            panelForAuthentication.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)eyePictureBox).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Timer timerForAP;
        private Panel panelForAuthentication;
        private TextBox textBoxLogInEmail;
        private Label labelShowMeeting;
        private TextBox textBoxLogInPassword;
        private Button buttonForLogIn;
        private PictureBox eyePictureBox;
        private Label lblForLogInEmailorRoleNameDOWN;
        private Label lblForLogInPasswordDOWN;
        private Label lblForLogInPasswordUP;
        private Label lblForLogInEmailorRoleNameUP;
    }
}