namespace CourseManagement.Tools.Utility
{
    internal class EmailOptions
    {
        public static string GetSuccessfulLoginEmailSubject = "You're In! Successful Login 🚀";
        public static string GetPasswordVerificationEmailSubject = "Password Update Verification 🔐";
        public static string GetPasswordConfirmationEmailSubject = "Password Change Confirmed ✔️";
        public static string GetStudentWelcomeEmailSubject = "Welcome to the Adventure at Old School Course 🎉";
        public static string GetStudentUpdateConfirmationEmailSubject = "Account Upgrade Successful 🚀";
        public static string GetCourseAddedNotificationEmailSubject = "Exciting News: New Course Added! 🌟";
        public static string GetCourseUpdateNotificationEmailSubject = "Course Transformation Confirmed 🔄";
        public static string GetStudentRemoveVerificationEmailSubject = "Student Removal Verification ⚠️";
        public static string GetStudentRemoveConfirmationEmailSubject = "Farewell! Student Removed 🎓";
        public static string GetCourseRemoveVerificationEmailSubject = "Course Removal Verification ⚠️";
        public static string GetCourseRemoveConfirmationEmailSubject = "Mission Accomplished: Course Removed 🎓";
        public static string GetNewScoreNotificationEmailSubject = "New Score Recorded 🎯";


        public static string GetSuccessfulLoginEmailBody(string loginTime)
        {
            return $@"
            <html>
            <body>
                <p>Dear Admin,</p>
                <p>You have successfully logged into the Old School Course Portal.</p>
                <p>Role: <strong>Course Administrator</strong></p>
                <p>Login Time: <strong>{loginTime}</strong></p>
                <p>If you did not initiate this login, please contact us immediately.</p>
                <p>Thank you for using our services!</p>
                <p>Best regards,<br/>Old School Course</p>
            </body>
            </html>";
        }

        public static string GetPasswordVerificationEmailBody(string verificationCode)
        {
            return $@"
            <html>
            <body>
                <p>Dear Admin,</p>
                <p>Your verification code is: <strong>{verificationCode}</strong></p>
                <p>Please use this code to complete the app password update process.</p>
                <p>Thank you for using our services!</p>
                <p>Best regards,<br/>Old School Course</p>
            </body>
            </html>";
        }

        public static string GetPasswordConfirmationEmailBody(string oldPassword, string newPassword)
        {
            return $@"
            <html>
            <body>
                <p>Dear Admin,</p>
                <p>Your app password has been successfully changed from <strong>{oldPassword}</strong> to <strong>{newPassword}</strong>.</p>
                <p>If you did not make this change, please contact us immediately.</p>
                <p>Thank you for choosing Old School Course!</p>
                <p>Best regards,<br/>Old School Course</p>
            </body>
            </html>";
        }

        public static string GetStudentWelcomeEmailBody(string studentFirstName, string studentLastName)
        {
            return $@"
            <html>
            <body>
                <p>Dear {studentFirstName} {studentLastName},</p>
                <p>Welcome to Old School Course! We are excited to have you as a student.</p>
                <p>If you have any questions or need assistance, feel free to contact us.</p>
                <p>Best regards,<br/>Old School Course</p>
            </body>
            </html>";
        }

        public static string GetStudentUpdateConfirmationEmailBody(string studentFirstName, string studentLastName)
        {
            return $@"
            <html>
            <body>
                <p>Dear {studentFirstName} {studentLastName},</p>
                <p>Your account information at Old School Course has been successfully updated.</p>
                <p>If you have any further questions or need assistance, feel free to contact us.</p>
                <p>Best regards,<br/>Old School Course</p>
            </body>
            </html>";
        }

        public static string GetCourseAddedNotificationEmailBody(string courseName)
        {
            return $@"
            <html>
            <body>
                <p>Dear Admin,</p>
                <p>A new course has been successfully added to Old School Course.</p>
                <p>Course Name: <strong>{courseName}</strong></p>
                <p>Thank you for managing the courses!</p>
                <p>Best regards,<br/>Old School Course</p>
            </body>
            </html>";
        }

        public static string GetCourseUpdateNotificationEmailBody(string courseId, string updatedCourseName)
        {
            return $@"
            <html>
            <body>
                <p>Dear Admin,</p>
                <p>The data for the course with ID: <strong>{courseId}</strong> has been successfully updated.</p>
                <p>Updated Course Name: <strong>{updatedCourseName}</strong></p>
                <p>Thank you for managing the courses!</p>
                <p>Best regards,<br/>Old School Course</p>
            </body>
            </html>";
        }

        public static string GetStudentRemoveVerificationEmailBody(string studentId, string verificationCode)
        {
            return $@"
            <html>
            <body>
                <p>Dear Admin,</p>
                <p>A request has been received to remove the student with ID: <strong>{studentId}</strong> from Old School Course.</p>
                <p>To confirm the removal, please use the following verification code:</p>
                <p><strong>{verificationCode}</strong></p>
                <p>If you did not initiate this request, please contact us immediately.</p>
                <p>Thank you for managing the student records!</p>
                <p>Best regards,<br/>Old School Course</p>
            </body>
            </html>";
        }

        public static string GetStudentRemoveConfirmationEmailBody(string studentId)
        {
            return $@"
            <html>
            <body>
                <p>Dear Admin,</p>
                <p>The student with ID: <strong>{studentId}</strong> has been successfully removed from Old School Course.</p>
                <p>If you did not initiate this removal, please contact us immediately.</p>
                <p>Thank you for managing the student records!</p>
                <p>Best regards,<br/>Old School Course</p>
            </body>
            </html>";
        }

        public static string GetStudentRemoveConfirmationEmailBody(string studentFirstName, string studentLastName, string studentId)
        {
            return $@"
            <html>
            <body>
                <p>Dear {studentFirstName} {studentLastName},</p>
                <p>We regret to inform you that your enrollment with Old School Course, identified by student ID: <strong>{studentId}</strong>, has been terminated.</p>
                <p>If you believe this is an error or if you have any concerns, please reach out to us immediately.</p>
                <p>We appreciate your understanding and cooperation in managing student records.</p>
                <p>Best regards,<br/>Old School Course</p>
            </body>
            </html>";
        }


        public static string GetCourseRemoveVerificationEmailBody(string courseId, string verificationCode)
        {
            return $@"
            <html>
            <body>
                <p>Dear Admin,</p>
                <p>A request has been received to remove the course with ID: <strong>{courseId}</strong> from Old School Course.</p>
                <p>To confirm the removal, please use the following verification code:</p>
                <p><strong>{verificationCode}</strong></p>
                <p>If you did not initiate this request, please contact us immediately.</p>
                <p>Thank you for managing the course records!</p>
                <p>Best regards,<br/>Old School Course</p>
            </body>
            </html>";
        }

        public static string GetCourseRemoveConfirmationEmailBody(string courseId)
        {
            return $@"
            <html>
            <body>
                <p>Dear Admin,</p>
                <p>The course with ID: <strong>{courseId}</strong> has been successfully removed from Old School Course.</p>
                <p>If you did not initiate this removal, please contact us immediately.</p>
                <p>Thank you for managing the course records!</p>
                <p>Best regards,<br/>Old School Course</p>
            </body>
            </html>";
        }

        public static string GetNewScoreNotificationEmailBody(string studentId, string courseId, double score, string description)
        {
            return $@"
            <html>
            <body>
                <p>Dear Admin,</p>
                <p>A new score has been recorded:</p>
                <p>Student: <strong>ID: {studentId}</strong></p>
                <p>Course: <strong>ID: {courseId}</strong></p>
                <p>Score: <strong>{score}</strong></p>
                <p>Description: <strong>{description}</strong></p>
                <p>Thank you for managing the scores!</p>
                <p>Best regards,<br/>Old School Course</p>
            </body>
            </html>";
        }
    }
}
