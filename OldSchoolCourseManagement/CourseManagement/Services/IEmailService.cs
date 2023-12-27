namespace CourseManagement.Services
{
    public interface IEmailService
    {
        void SendEmail(string recipientEmail, string emailSubject, string emailBody);
    }
}
