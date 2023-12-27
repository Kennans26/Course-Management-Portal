USE OldSchoolCourseManagement;
GO

CREATE TABLE Courses (
    Id VARCHAR(12) NOT NULL PRIMARY KEY,
    Name VARCHAR(50) NOT NULL,
    CreationDate DATE NOT NULL,
    Hour INT NOT NULL,
    Description TEXT NOT NULL,
	Photo VARBINARY(MAX) NOT NULL
);