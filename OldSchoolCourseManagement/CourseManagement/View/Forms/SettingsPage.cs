using CourseManagement.Models;
using CourseManagement.Services;
using CourseManagement.Tools.Utility;

namespace CourseManagement.View.Forms
{
    public partial class SettingsPage : Form
    {
        //we'll need it on 2 time in this page...
        OutlookService service = new OutlookService();

        public SettingsPage()
        {
            InitializeComponent();
        }

        private void SettingsPage_Load(object sender, EventArgs e)
        {
            MessageBox.Show("Welcome to the Settings Page!\n\nIn this form, you can customize only the admin password.",
                "Settings Page", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }


        private void buttonForSubmit_Click(object sender, EventArgs e)
        {
            //for admin's log in data
            Admin? admin = Admin.GetAdminData();

            lblCurrentPassInfo.Text = string.Empty;
            lblNFPassInfo.Text = string.Empty;
            lblNSPassInfo.Text = string.Empty;

            if (admin != null)
            {
                if (VerifyInputsForNotNull())
                {
                    string oldPassword = textBoxCurrentPass.Text;
                    string newPassword = textBoxNFPass.Text;

                    if (textBoxCurrentPass.Text == admin.AppPass)
                    {
                        if (IsStrongPassword(textBoxNFPass.Text))
                        {
                            if (textBoxNSPass.Text == textBoxNFPass.Text)
                            {
                                if (newPassword != oldPassword) //check if the new password is not the same as the old password
                                {
                                    //generate a 6-digit verification code
                                    string verificationCode = CodeGenerator.GenerateVerificationCode();

                                    service.SendEmail(service.AdminEmail, EmailOptions.GetPasswordVerificationEmailSubject, EmailOptions.GetPasswordVerificationEmailBody(verificationCode));

                                    //prompt the user to enter the verification code
                                    string userEnteredCode = Microsoft.VisualBasic.Interaction.InputBox("Enter the 6-digit verification code sent to admin email:", "Verification Code");

                                    //verify the entered code
                                    if (userEnteredCode == verificationCode)
                                    {
                                        //code is correct, proceed with password update logic
                                        if (admin.UpdatePassword(newPassword))
                                        {
                                            service.SendEmail(service.AdminEmail, EmailOptions.GetPasswordConfirmationEmailSubject, EmailOptions.GetPasswordConfirmationEmailBody(oldPassword, newPassword));

                                            this.Close();
                                        }
                                        else
                                        {
                                            MessageBox.Show("Failed to update the password. Please try again.", "Password Change Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                        }
                                    }
                                    else
                                    {
                                        MessageBox.Show("Incorrect verification code. Password change aborted.", "Verification Failed", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                    }
                                }
                                else
                                {
                                    //inform the user that the new password is equal to the old password
                                    lblNFPassInfo.Text = "The new password cannot be the\n" +
                                        "same as the old password.";
                                    lblNSPassInfo.Text = "The new password cannot be the\n" +
                                        "same as the old password.";
                                }
                            }
                            else
                            {
                                lblNSPassInfo.Text = "The passwords are not match,\n" +
                                    "check them again!";
                            }
                        }
                        else
                        {
                            //password doesn't meet the criteria
                            lblNFPassInfo.Text = "Password must be at least 6 characters\n" +
                                "long and include at least 1 uppercase\n" +
                                "letter, 1 lowercase letter, and 1 number.";
                        }
                    }
                    else
                    {
                        //incorrect current password information
                        lblCurrentPassInfo.Text = "The current password you entered\n" +
                            "isn’t correct.";
                    }
                }
                else
                {
                    //for inform to admin
                    MessageBox.Show("Please enter all the password options completely!", "Empty fields", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                //admin information is unavailable message
                MessageBox.Show("Admin's information is unavailable!", "Aa! You can't reach to the admin data!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }


        private bool IsStrongPassword(string password)
        {
            //use a regular expression to check if the password meets the specified criteria
            string pattern = @"^(?=.*[a-z])(?=.*[A-Z])(?=.*\d).{6,}$";
            return System.Text.RegularExpressions.Regex.IsMatch(password, pattern);
        }

        private bool VerifyInputsForNotNull()
        {
            if (!string.IsNullOrWhiteSpace(textBoxCurrentPass.Text) || !string.IsNullOrWhiteSpace(textBoxNFPass.Text) ||
                !string.IsNullOrWhiteSpace(textBoxNSPass.Text))
            {
                return true;
            }
            else
            {
                return false;
            }
        }


        private void TextBoxsForPassword_TextChanged(object sender, EventArgs e)
        {
            if ((!string.IsNullOrWhiteSpace(textBoxCurrentPass.Text) && textBoxCurrentPass.Text.Length >= 1) &&
                (!string.IsNullOrWhiteSpace(textBoxNFPass.Text) && textBoxNFPass.Text.Length >= 1) &&
                (!string.IsNullOrWhiteSpace(textBoxNSPass.Text) && textBoxNSPass.Text.Length >= 1))
            {
                eyePictureBox.Visible = true;

                if (textBoxCurrentPass.PasswordChar == '•' && textBoxNFPass.PasswordChar == '•' &&
                    textBoxNSPass.PasswordChar == '•')
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
            if (textBoxCurrentPass.PasswordChar == '\0' && textBoxNFPass.PasswordChar == '\0' &&
                textBoxNSPass.PasswordChar == '\0')
            {
                textBoxCurrentPass.PasswordChar = '•';
                textBoxNFPass.PasswordChar = '•';
                textBoxNSPass.PasswordChar = '•';

                eyePictureBox.Image = Properties.Resources.eye_hide;
            }
            else
            {
                textBoxCurrentPass.PasswordChar = '\0';
                textBoxNFPass.PasswordChar = '\0';
                textBoxNSPass.PasswordChar = '\0';

                eyePictureBox.Image = Properties.Resources.eye_show;
            }
        }
    }
}
