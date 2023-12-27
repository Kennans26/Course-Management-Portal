using CourseManagement.Models;
using CourseManagement.Services;
using CourseManagement.Tools.Utility;

namespace CourseManagement.View.Forms
{
    public partial class AuthenticationPage : Form
    {
        //we'll need it on 1 time in this page...
        OutlookService service = new OutlookService();

        public AuthenticationPage()
        {
            InitializeComponent();

            InitializeFadeInTimer();
        }

        //for some visual changes, i mean opacity view
        private void InitializeFadeInTimer()
        {
            timerForAP.Interval = 20;
            this.Opacity = 0;
            timerForAP.Start();
        }

        private void timerForAP_Tick(object sender, EventArgs e)
        {
            if (this.Opacity < 1)
            {
                this.Opacity += 0.025;
            }
            else
            {
                timerForAP.Stop();

                //Information for timerForAP: it work!
                //MessageBox.Show("timerForAP was stop now!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }


        //for some view changes and password option with this char -> "•"...
        private void textBoxLogInPassword_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(textBoxLogInPassword.Text) &&
                textBoxLogInPassword.Text.Length >= 1)
            {
                eyePictureBox.Visible = true;

                if (textBoxLogInPassword.PasswordChar == '•')
                {                   
                    eyePictureBox.Image = Properties.Resources.eye_hide;
                }
                else
                {
                    eyePictureBox.Image = Properties.Resources.eye_show;
                }
            }
            else
            {
                eyePictureBox.Visible = false;
                eyePictureBox.Image = null;
            }
        }

        private void eyePictureBox_Click(object sender, EventArgs e)
        {
            if (textBoxLogInPassword.PasswordChar == '\0')
            {
                textBoxLogInPassword.PasswordChar = '•';
                eyePictureBox.Image = Properties.Resources.eye_hide;
            }
            else
            {
                textBoxLogInPassword.PasswordChar = '\0';
                eyePictureBox.Image = Properties.Resources.eye_show;
            }
        }


        //it need for also close app from back (task manager)
        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            base.OnFormClosing(e);

            if (e.CloseReason == CloseReason.UserClosing)
            {
                Application.Exit();
            }
        }


        //for admin's log in data
        private void buttonForLogIn_Click(object sender, EventArgs e)
        {
            lblForLogInEmailorRoleNameDOWN.Text = string.Empty;
            lblForLogInPasswordDOWN.Text = string.Empty;

            Admin? admin = Admin.GetAdminData();

            if (admin != null)
            {
                if (textBoxLogInEmail.Text == admin.RoleName || textBoxLogInEmail.Text == admin.Email)
                {
                    lblForLogInEmailorRoleNameDOWN.Enabled = false;
                    lblForLogInEmailorRoleNameDOWN.Visible = false;

                    if (textBoxLogInPassword.Text == admin.AppPass)
                    {
                        lblForLogInPasswordDOWN.Enabled = false;
                        lblForLogInPasswordDOWN.Visible = false;

                        //successfully logged in message
                        //messageBox.Show("You are logged into the Portal as an administrator!", "Successful login", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        service.SendEmail(service.AdminEmail, EmailOptions.GetSuccessfulLoginEmailSubject, EmailOptions.GetSuccessfulLoginEmailBody(DateTime.Now.ToString("MM/dd/yyyy")));

                        //new form's instance must be created here!
                        MainAdministratorPage mainAdministratorPage = new MainAdministratorPage();

                        //then hide the current form
                        this.Hide();
                        //new form's instance must be started from here!
                        mainAdministratorPage.Show();
                    }
                    else
                    {
                        //incorrect password message
                        lblForLogInPasswordDOWN.Enabled = true;
                        lblForLogInPasswordDOWN.Visible = true;
                        lblForLogInPasswordDOWN.Text = "The password you entered isn’t correct.";
                    }
                }
                else
                {
                    //incorrect role name or email message
                    lblForLogInEmailorRoleNameDOWN.Enabled = true;
                    lblForLogInEmailorRoleNameDOWN.Visible = true;
                    lblForLogInEmailorRoleNameDOWN.Text = "The role name or email isn't connected.";
                }
            }
            else
            {
                //admin information is unavailable message
                MessageBox.Show("Admin's information is unavailable!", "Aa! You can't log in!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
