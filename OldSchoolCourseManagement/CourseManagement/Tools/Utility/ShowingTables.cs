using System.Data.SqlClient;
using CourseManagement.Models;

namespace CourseManagement.Tools.Utility
{
    public class ShowingTables
    {
        //to show students list in DataGridView
        public void SRP(DataGridView dataGridView)
        {
            StudentsInfo student = new();

            dataGridView.DataSource = student.GetStudentsList(new SqlCommand("SELECT * FROM Students;"));
            DataGridViewImageColumn ImageColumn = new DataGridViewImageColumn();
            ImageColumn = (DataGridViewImageColumn)dataGridView.Columns[7];
            ImageColumn.ImageLayout = DataGridViewImageCellLayout.Stretch;

            dataGridView.Columns[0].Visible = false; //hide the first column (Id)

            dataGridView.Columns[1].Width = 120;
            dataGridView.Columns[1].DefaultCellStyle.Font = new Font(dataGridView.Font.FontFamily, 11);
            dataGridView.Columns[1].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridView.Columns[1].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridView.Columns[1].HeaderText = "Name";

            dataGridView.Columns[2].Width = 120;
            dataGridView.Columns[2].DefaultCellStyle.Font = new Font(dataGridView.Font.FontFamily, 11);
            dataGridView.Columns[2].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridView.Columns[2].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridView.Columns[2].HeaderText = "Surname";

            dataGridView.Columns[3].Width = 115;
            dataGridView.Columns[3].DefaultCellStyle.Font = new Font(dataGridView.Font.FontFamily, 11);
            dataGridView.Columns[3].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridView.Columns[3].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridView.Columns[3].HeaderText = "Birthdate";

            dataGridView.Columns[4].Width = 100;
            dataGridView.Columns[4].DefaultCellStyle.Font = new Font(dataGridView.Font.FontFamily, 11);
            dataGridView.Columns[4].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridView.Columns[4].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridView.Columns[4].HeaderText = "Gender";

            dataGridView.Columns[5].Width = 210;
            dataGridView.Columns[5].DefaultCellStyle.Font = new Font(dataGridView.Font.FontFamily, 10);
            dataGridView.Columns[5].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridView.Columns[5].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridView.Columns[5].HeaderText = "Email";

            dataGridView.Columns[6].Width = 200;
            dataGridView.Columns[6].DefaultCellStyle.Font = new Font(dataGridView.Font.FontFamily, 10); //for showing more text in address option
            dataGridView.Columns[6].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridView.Columns[6].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridView.Columns[6].HeaderText = "Address";

            dataGridView.Columns[7].Width = 85;
            dataGridView.Columns[7].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridView.Columns[7].HeaderText = "Photo";
        }

        //to show courses list in DataGridView
        public void NCP(DataGridView dataGridView)
        {
            CoursesInfo course = new();

            dataGridView.DataSource = course.GetCoursesList(new SqlCommand("Select * FROM Courses;"));
            DataGridViewImageColumn ImageColumn = new DataGridViewImageColumn();
            ImageColumn = (DataGridViewImageColumn)dataGridView.Columns[5];
            ImageColumn.ImageLayout = DataGridViewImageCellLayout.Stretch;

            //set column properties
            dataGridView.Columns[0].Visible = false; //hide the first column (Id)

            dataGridView.Columns[1].Width = 150;
            dataGridView.Columns[1].DefaultCellStyle.Font = new Font(dataGridView.Font.FontFamily, 11);
            dataGridView.Columns[1].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridView.Columns[1].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridView.Columns[1].HeaderText = "Course Name";

            dataGridView.Columns[2].Width = 90;
            dataGridView.Columns[2].DefaultCellStyle.Font = new Font(dataGridView.Font.FontFamily, 11);
            dataGridView.Columns[2].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridView.Columns[2].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridView.Columns[2].HeaderText = "Creation Date";

            dataGridView.Columns[3].Width = 50;
            dataGridView.Columns[3].DefaultCellStyle.Font = new Font(dataGridView.Font.FontFamily, 11);
            dataGridView.Columns[3].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridView.Columns[3].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridView.Columns[3].HeaderText = "Hour(s)";

            dataGridView.Columns[4].Width = 200;
            dataGridView.Columns[4].DefaultCellStyle.Font = new Font(dataGridView.Font.FontFamily, 10); //for showing more text in description option
            dataGridView.Columns[4].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridView.Columns[4].HeaderText = "Course Description";

            dataGridView.Columns[5].Width = 100;
            dataGridView.Columns[5].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridView.Columns[5].HeaderText = "Photo";
        }

        //to show courses list in DataGridView
        public void CMP(DataGridView dataGridView)
        {
            CoursesInfo course = new();

            dataGridView.DataSource = course.GetCoursesList(new SqlCommand("Select * FROM Courses;"));
            DataGridViewImageColumn ImageColumn = new DataGridViewImageColumn();
            ImageColumn = (DataGridViewImageColumn)dataGridView.Columns[5];
            ImageColumn.ImageLayout = DataGridViewImageCellLayout.Stretch;

            //set column properties
            dataGridView.Columns[0].Visible = false; //hide the first column (Id)

            dataGridView.Columns[1].Width = 150;
            dataGridView.Columns[1].DefaultCellStyle.Font = new Font(dataGridView.Font.FontFamily, 10);
            dataGridView.Columns[1].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridView.Columns[1].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridView.Columns[1].HeaderText = "Course Name";

            dataGridView.Columns[2].Width = 90;
            dataGridView.Columns[2].DefaultCellStyle.Font = new Font(dataGridView.Font.FontFamily, 11);
            dataGridView.Columns[2].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridView.Columns[2].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridView.Columns[2].HeaderText = "Creation Date";

            dataGridView.Columns[3].Width = 50;
            dataGridView.Columns[3].DefaultCellStyle.Font = new Font(dataGridView.Font.FontFamily, 11);
            dataGridView.Columns[3].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridView.Columns[3].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridView.Columns[3].HeaderText = "Hour(s)";

            dataGridView.Columns[4].Width = 200;
            dataGridView.Columns[4].DefaultCellStyle.Font = new Font(dataGridView.Font.FontFamily, 10); //for showing more text in description option
            dataGridView.Columns[4].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridView.Columns[4].HeaderText = "Course Description";

            dataGridView.Columns[5].Width = 100;
            dataGridView.Columns[5].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridView.Columns[5].HeaderText = "Photo";
        }

        //to show courses list in DataGridView
        public void ACD(DataGridView dataGridView)
        {
            CoursesInfo course = new();

            dataGridView.DataSource = course.GetCoursesList(new SqlCommand("Select * FROM Courses;"));
            DataGridViewImageColumn ImageColumn = new DataGridViewImageColumn();
            ImageColumn = (DataGridViewImageColumn)dataGridView.Columns[5];
            ImageColumn.ImageLayout = DataGridViewImageCellLayout.Stretch;

            //set column properties
            dataGridView.Columns[0].Width = 80;
            dataGridView.Columns[0].DefaultCellStyle.Font = new Font(dataGridView.Font.FontFamily, 11);
            dataGridView.Columns[0].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridView.Columns[0].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridView.Columns[0].Visible = true; //in here we need to show it!

            dataGridView.Columns[1].Width = 150;
            dataGridView.Columns[1].DefaultCellStyle.Font = new Font(dataGridView.Font.FontFamily, 10);
            dataGridView.Columns[1].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridView.Columns[1].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridView.Columns[1].HeaderText = "Course Name";

            dataGridView.Columns[2].Width = 90;
            dataGridView.Columns[2].DefaultCellStyle.Font = new Font(dataGridView.Font.FontFamily, 11);
            dataGridView.Columns[2].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridView.Columns[2].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridView.Columns[2].HeaderText = "Creation Date";

            dataGridView.Columns[3].Width = 50;
            dataGridView.Columns[3].DefaultCellStyle.Font = new Font(dataGridView.Font.FontFamily, 11);
            dataGridView.Columns[3].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridView.Columns[3].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridView.Columns[3].HeaderText = "Hour(s)";

            dataGridView.Columns[4].Width = 250;
            dataGridView.Columns[4].DefaultCellStyle.Font = new Font(dataGridView.Font.FontFamily, 10); //for showing more text in description option
            dataGridView.Columns[4].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridView.Columns[4].HeaderText = "Course Description";

            dataGridView.Columns[5].Width = 100;
            dataGridView.Columns[5].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridView.Columns[5].HeaderText = "Photo";
        }

        //to show students list in DataGridView
        public void SMP(DataGridView dataGridView)
        {
            StudentsInfo student = new();

            dataGridView.DataSource = student.GetStudentsList(new SqlCommand("SELECT * FROM Students;"));
            DataGridViewImageColumn ImageColumn = new DataGridViewImageColumn();
            ImageColumn = (DataGridViewImageColumn)dataGridView.Columns[7];
            ImageColumn.DefaultCellStyle.BackColor = Color.White;
            ImageColumn.DefaultCellStyle.ForeColor = Color.White;
            ImageColumn.ImageLayout = DataGridViewImageCellLayout.Stretch;

            dataGridView.Columns[0].Visible = false; //hide the first column (Id)

            dataGridView.Columns[1].Width = 120;
            dataGridView.Columns[1].DefaultCellStyle.Font = new Font(dataGridView.Font.FontFamily, 11);
            dataGridView.Columns[1].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridView.Columns[1].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridView.Columns[1].HeaderText = "Name";

            dataGridView.Columns[2].Width = 120;
            dataGridView.Columns[2].DefaultCellStyle.Font = new Font(dataGridView.Font.FontFamily, 11);
            dataGridView.Columns[2].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridView.Columns[2].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridView.Columns[2].HeaderText = "Surname";

            dataGridView.Columns[3].Width = 115;
            dataGridView.Columns[3].DefaultCellStyle.Font = new Font(dataGridView.Font.FontFamily, 11);
            dataGridView.Columns[3].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridView.Columns[3].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridView.Columns[3].HeaderText = "Birthdate";

            dataGridView.Columns[4].Width = 100;
            dataGridView.Columns[4].DefaultCellStyle.Font = new Font(dataGridView.Font.FontFamily, 11);
            dataGridView.Columns[4].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridView.Columns[4].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridView.Columns[4].HeaderText = "Gender";

            dataGridView.Columns[5].Width = 210;
            dataGridView.Columns[5].DefaultCellStyle.Font = new Font(dataGridView.Font.FontFamily, 10);
            dataGridView.Columns[5].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridView.Columns[5].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridView.Columns[5].HeaderText = "Email";

            dataGridView.Columns[6].Width = 200;
            dataGridView.Columns[6].DefaultCellStyle.Font = new Font(dataGridView.Font.FontFamily, 10); //for showing more text in address option
            dataGridView.Columns[6].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridView.Columns[6].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridView.Columns[6].HeaderText = "Address";

            dataGridView.Columns[7].Width = 85;
            dataGridView.Columns[7].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridView.Columns[7].HeaderText = "Photo";
        }

        //to show students list in DataGridView
        public void NSPLeft(DataGridView dataGridView)
        {
            StudentsInfo student = new();

            dataGridView.DataSource = student.GetStudentsList(new SqlCommand("SELECT Id, FirstName, LastName, Email FROM Students"));
            dataGridView.RowTemplate.Height = 35;

            for (int i = 0; i < dataGridView.Columns.Count; i++)
            {
                dataGridView.Columns[i].DefaultCellStyle.Font = new Font(dataGridView.Font.FontFamily, 10);
                dataGridView.Columns[i].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
                dataGridView.Columns[i].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            }

            dataGridView.Columns[0].Visible = false; //hide the first column (Id)

            dataGridView.Columns[1].Width = 100;
            dataGridView.Columns[1].HeaderText = "Name";

            dataGridView.Columns[2].Width = 100;
            dataGridView.Columns[2].HeaderText = "Surname";

            dataGridView.Columns[3].HeaderText = "Email";
        }

        public void NSPRight(DataGridView dataGridView)
        {
            ScoresInfo score = new();

            dataGridView.DataSource = score.GetScoresList(new SqlCommand("SELECT * FROM Scores;"));
            dataGridView.ScrollBars = ScrollBars.Both;
            dataGridView.RowTemplate.Height = 35;

            for (int i = 0; i < dataGridView.Columns.Count; i++)
            {
                dataGridView.Columns[i].DefaultCellStyle.Font = new Font(dataGridView.Font.FontFamily, 10);
                dataGridView.Columns[i].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
                dataGridView.Columns[i].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            }

            dataGridView.Columns[0].Width = 100;
            dataGridView.Columns[0].HeaderText = "Student";

            dataGridView.Columns[1].Width = 100;
            dataGridView.Columns[1].HeaderText = "Course";

            dataGridView.Columns[2].Width = 65;
            dataGridView.Columns[2].HeaderText = "Score";

            dataGridView.Columns[3].HeaderText = "Description";
        }


        //a helper method for search operation, it was be a dangerous, but there button version is so basic v.
        public void ForSearchSMP(DataGridView dataGridView, TextBox textBox)
        {
            StudentsInfo student = new();

            dataGridView.DataSource = student.SearchForStudents(textBox.Text);
            DataGridViewImageColumn ImageColumn = new DataGridViewImageColumn();
            ImageColumn = (DataGridViewImageColumn)dataGridView.Columns[7];
            ImageColumn.ImageLayout = DataGridViewImageCellLayout.Stretch;

            dataGridView.Columns[0].Visible = false; //hide the first column (Id)

            dataGridView.Columns[1].Width = 120;
            dataGridView.Columns[1].DefaultCellStyle.Font = new Font(dataGridView.Font.FontFamily, 11);
            dataGridView.Columns[1].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridView.Columns[1].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridView.Columns[1].HeaderText = "Name";

            dataGridView.Columns[2].Width = 120;
            dataGridView.Columns[2].DefaultCellStyle.Font = new Font(dataGridView.Font.FontFamily, 11);
            dataGridView.Columns[2].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridView.Columns[2].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridView.Columns[2].HeaderText = "Surname";

            dataGridView.Columns[3].Width = 115;
            dataGridView.Columns[3].DefaultCellStyle.Font = new Font(dataGridView.Font.FontFamily, 11);
            dataGridView.Columns[3].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridView.Columns[3].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridView.Columns[3].HeaderText = "Birthdate";

            dataGridView.Columns[4].Width = 100;
            dataGridView.Columns[4].DefaultCellStyle.Font = new Font(dataGridView.Font.FontFamily, 11);
            dataGridView.Columns[4].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridView.Columns[4].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridView.Columns[4].HeaderText = "Gender";

            dataGridView.Columns[5].Width = 210;
            dataGridView.Columns[5].DefaultCellStyle.Font = new Font(dataGridView.Font.FontFamily, 10);
            dataGridView.Columns[5].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridView.Columns[5].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridView.Columns[5].HeaderText = "Email";

            dataGridView.Columns[6].Width = 200;
            dataGridView.Columns[6].DefaultCellStyle.Font = new Font(dataGridView.Font.FontFamily, 10); //for showing more text in address option
            dataGridView.Columns[6].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridView.Columns[6].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridView.Columns[6].HeaderText = "Address";

            dataGridView.Columns[7].Width = 85;
            dataGridView.Columns[7].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridView.Columns[7].HeaderText = "Photo";
        }

        //a helper method for search operation, it was be a dangerous, but there button version is so basic v.
        public void ForSearchCMP(DataGridView dataGridView, TextBox textBox)
        {
            CoursesInfo course = new();

            dataGridView.DataSource = course.SearchForCourses(textBox.Text);
            DataGridViewImageColumn ImageColumn = new DataGridViewImageColumn();
            ImageColumn = (DataGridViewImageColumn)dataGridView.Columns[5];
            ImageColumn.ImageLayout = DataGridViewImageCellLayout.Stretch;

            //set column properties
            dataGridView.Columns[0].Visible = false; //hide the first column (Id)

            dataGridView.Columns[1].Width = 150;
            dataGridView.Columns[1].DefaultCellStyle.Font = new Font(dataGridView.Font.FontFamily, 11);
            dataGridView.Columns[1].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridView.Columns[1].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridView.Columns[1].HeaderText = "Course Name";

            dataGridView.Columns[2].Width = 90;
            dataGridView.Columns[2].DefaultCellStyle.Font = new Font(dataGridView.Font.FontFamily, 11);
            dataGridView.Columns[2].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridView.Columns[2].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridView.Columns[2].HeaderText = "Creation Date";

            dataGridView.Columns[3].Width = 50;
            dataGridView.Columns[3].DefaultCellStyle.Font = new Font(dataGridView.Font.FontFamily, 11);
            dataGridView.Columns[3].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridView.Columns[3].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridView.Columns[3].HeaderText = "Hour(s)";

            dataGridView.Columns[4].Width = 200;
            dataGridView.Columns[4].DefaultCellStyle.Font = new Font(dataGridView.Font.FontFamily, 10); //for showing more text in description option
            dataGridView.Columns[4].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridView.Columns[4].HeaderText = "Course Description";

            dataGridView.Columns[5].Width = 100;
            dataGridView.Columns[5].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridView.Columns[5].HeaderText = "Photo";
        }
    }
}
