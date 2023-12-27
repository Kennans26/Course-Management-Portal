USE OldSchoolCourseManagement;
GO

CREATE TABLE Scores (
    StudentId VARCHAR(12) NOT NULL,
    CourseId VARCHAR(12) NOT NULL,
    Score DOUBLE PRECISION NOT NULL,
    Description NVARCHAR(MAX)
);
