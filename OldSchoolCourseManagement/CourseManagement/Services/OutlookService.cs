using System.Net;
using System.Net.Mail;
using CourseManagement.Models;

namespace CourseManagement.Services
{
    public class OutlookService : IEmailService
    {
        public string PersonalEmail = "info.kennans26@gmail.com";
        //for SettingsPage we'll need it,
        //i want to use here my personal email
        //cause it's more relaxable to check on time!

        public string AdminEmail = "courseoldschool.main@outlook.com";

        public void SendEmail(string recipientEmail, string emailSubject, string emailBody)
        {
            //i am using outlook mail server to sending email
            Admin? admin = Admin.GetAdminData();

            if (admin != null)
            {
                if (admin.Email != null && admin.EmailPass != null)
                {
                    string senderDisplayName = "Old School Course";

                    using (MailMessage message = new MailMessage(new MailAddress(admin.Email, senderDisplayName), new MailAddress(recipientEmail)))
                    {
                        message.Subject = emailSubject;
                        message.Body = emailBody;
                        message.IsBodyHtml = true; //for EmailBodies.cs (html bodies)...

                        using (SmtpClient smtpClient = new SmtpClient("smtp-mail.outlook.com", 587))
                        {
                            smtpClient.UseDefaultCredentials = false;
                            smtpClient.Credentials = new NetworkCredential(admin.Email, admin.EmailPass);
                            smtpClient.EnableSsl = true;

                            try
                            {
                                smtpClient.Send(message);
                                Console.WriteLine($"Information email sent successfully to {recipientEmail}.");
                            }
                            catch (SmtpException smtpEx)
                            {
                                Console.WriteLine($"Error sending information email to {recipientEmail}: SMTP error - {smtpEx.Message}");
                            }
                            catch (Exception exc)
                            {
                                Console.WriteLine($"Error sending information email to {recipientEmail}: {exc.Message}");
                            }
                        }
                    }
                }
            }
        }
    }
}
