USE OldSchoolCourseManagement;
GO

CREATE TABLE Students (
    Id VARCHAR(12) NOT NULL PRIMARY KEY,
    FirstName VARCHAR(15) NOT NULL,
    LastName VARCHAR(15) NOT NULL,
    Birthdate DATE NOT NULL,
	Gender VARCHAR(6) NOT NULL,
    Email VARCHAR(255) NOT NULL,
    Address TEXT NOT NULL,
    Photo VARBINARY(MAX) NOT NULL
);