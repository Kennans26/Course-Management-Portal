-- Create the OldSchoolCourseManagement database
CREATE DATABASE OldSchoolCourseManagement;
GO

-- Use the OldSchoolCourseManagement database
USE OldSchoolCourseManagement;
GO

-- Create the Admin table
CREATE TABLE Admin (
    Role NVARCHAR(50) NOT NULL,
    RegistrationDate DATE NOT NULL,
    RoleName NVARCHAR(50) NOT NULL,
    Email NVARCHAR(100) NOT NULL,
    AppPass NVARCHAR(50) NOT NULL,
	EmailPass NVARCHAR(50) NOT NULL
);
GO

-- Insert data into the Admin table
INSERT INTO Admin (Role, RegistrationDate, RoleName, Email, AppPass, EmailPass)
VALUES ('Course Administrator', '2023-11-23', 'Admin', 'courseoldschool.main@outlook.com', 'Admin', 'Admin2023');
GO