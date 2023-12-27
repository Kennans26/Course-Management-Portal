using System.Data;
using System.Data.SqlClient;
using CourseManagement.Database;

namespace CourseManagement.Models
{
    internal class CoursesInfo
    {
        ConnectionToDB connection = new ConnectionToDB();

        //create a function to add a new courses to the database
        public bool InsertCourse(string Identity, string CourseName, DateTime CreationDate, int Hour, string Description, byte[] Photo)
        {
            SqlCommand command = new SqlCommand("INSERT INTO Courses (Id, Name, CreationDate, Hour, Description, Photo) VALUES (@cid, @cn, @ccd, @ch, @desc, @img)", connection.GetConnection);

            //@cid, @cn, @ch, @desc, @img
            command.Parameters.Add("@cid", SqlDbType.VarChar).Value = Identity;
            command.Parameters.Add("@cn", SqlDbType.VarChar).Value = CourseName;
            command.Parameters.Add("@ccd", SqlDbType.Date).Value = CreationDate;
            command.Parameters.Add("@ch", SqlDbType.Int).Value = Hour;
            command.Parameters.Add("@desc", SqlDbType.Text).Value = Description;
            command.Parameters.Add("@img", SqlDbType.VarBinary).Value = Photo;

            connection.OpenConnection();

            if (command.ExecuteNonQuery() == 1)
            {
                connection.CloseConnection();
                return true;
            }
            else
            {
                connection.CloseConnection();
                return false;
            }
        }


        //to getting courses list...
        public DataTable GetCoursesList(SqlCommand command)
        {
            command.Connection = connection.GetConnection;

            SqlDataAdapter adapter = new SqlDataAdapter(command);

            DataTable table = new DataTable();
            adapter.Fill(table);

            return table;
        }


        //to create a method for verify course's hour
        public bool VerifyCourseHour(TextBox textBox)
        {
            if (int.TryParse(textBox.Text, out int hour))
            {

                if (hour > 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            else
            {
                return false;
            }
        }

        //to create a method for verify course's id (it must be a unique!)
        public bool VerifyCourseIdentityNCP(TextBox textBox)
        {
            string Identity = textBox.Text;

            return DbCheckerForCourseIdentity(Identity);
        }
        
        
        //check if a course identity already exists in the database
        public bool DbCheckerForCourseIdentity(string Identity)
        {
            using (SqlCommand command = new SqlCommand("SELECT COUNT(*) FROM Courses WHERE Id = @cid", connection.GetConnection))
            {
                command.Parameters.Add("@cid", SqlDbType.VarChar).Value = Identity;

                connection.OpenConnection();

                int count = (int) command.ExecuteScalar();

                connection.CloseConnection();

                //if count is greater than 0, the course identity already exists
                return count == 0;
            }
        }


        //create a function search for courses (first name, last name, address)
        public DataTable SearchForCourses(string SearchData)
        {
            SqlCommand command = new SqlCommand("SELECT * FROM Courses WHERE Name LIKE '%" + SearchData + "%';", connection.GetConnection);

            SqlDataAdapter adapter = new SqlDataAdapter(command);

            DataTable table = new DataTable();
            adapter.Fill(table);

            return table;
        }


        //create a function for editing courses data
        public bool UpdateCourse(string Identity, string CourseName, int Hour, string Description, byte[] Photo)
        {
            SqlCommand command = new SqlCommand("UPDATE Courses SET Id = @cid, Name = @cn, Hour = @ch, Description = @desc, Photo = @img WHERE Id = @cid;", connection.GetConnection);

            //@cid, @cn, @ch, @desc, @img
            command.Parameters.Add("@cid", SqlDbType.VarChar).Value = Identity;
            command.Parameters.Add("@cn", SqlDbType.VarChar).Value = CourseName; 
            command.Parameters.Add("@ch", SqlDbType.Int).Value = Hour;
            command.Parameters.Add("@desc", SqlDbType.Text).Value = Description;
            command.Parameters.Add("@img", SqlDbType.VarBinary).Value = Photo;

            connection.OpenConnection();

            if (command.ExecuteNonQuery() == 1)
            {
                connection.CloseConnection();
                return true;
            }
            else
            {
                connection.CloseConnection();
                return false;
            }
        }

        //create a function to delete a course (only need course id)
        public bool DeleteCourse(string Identity)
        {
            SqlCommand command = new SqlCommand("DELETE FROM Courses WHERE Id = @cid;", connection.GetConnection);

            //@cid
            command.Parameters.Add("@cid", SqlDbType.VarChar).Value = Identity;

            connection.OpenConnection();

            if (command.ExecuteNonQuery() == 1)
            {
                connection.CloseConnection();
                return true;
            }
            else
            {
                connection.CloseConnection();
                return false;
            }
        }
    }
}
