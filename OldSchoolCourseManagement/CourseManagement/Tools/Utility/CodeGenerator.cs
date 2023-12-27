namespace CourseManagement.Tools.Utility
{
    internal class CodeGenerator
    {
        public static string GenerateVerificationCode()
        {
            //generate a random 6-digit verification code
            Random random = new Random();
            int verificationCode = random.Next(100000, 999999);

            return verificationCode.ToString();
        }
    }
}
