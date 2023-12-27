using System.Data;
using System.Data.SqlClient;
using CourseManagement.Database;

namespace CourseManagement.Models
{
    internal class ScoresInfo
    {
        ConnectionToDB connection = new ConnectionToDB();

        //create a function to add a new scores to the database
        public bool InsertScore(string StudentIdentity, string CourseIdentity, double Score, string Description)
        {
            SqlCommand command = new SqlCommand("INSERT INTO Scores (StudentId, CourseId, Score, Description) VALUES (@sid, @cid, @scor, @desc);", connection.GetConnection);

            //@stid, @cn, @scor, @desc
            command.Parameters.Add("@sid", SqlDbType.VarChar).Value = StudentIdentity;
            command.Parameters.Add("@cid", SqlDbType.VarChar).Value = CourseIdentity;
            command.Parameters.Add("@scor", SqlDbType.VarChar).Value = Score;
            command.Parameters.Add("@desc", SqlDbType.NVarChar).Value = Description;

            connection.OpenConnection();

            try
            {
                if (command.ExecuteNonQuery() == 1)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch (Exception exc)
            {
                Console.WriteLine(exc.Message);
                return false;
            }
            finally
            {
                connection.CloseConnection();
            }
        }


        //to getting scores table
        public DataTable GetScoresList(SqlCommand command) //"SELECT * FROM Scores;"
        {
            command.Connection = connection.GetConnection;

            SqlDataAdapter adapter = new SqlDataAdapter(command);

            DataTable table = new DataTable();
            adapter.Fill(table);

            return table;
        }

        //to getting course identity via its name
        public string GetCourseIdentity(string courseName)
        {
            string identity = string.Empty;

            using (SqlCommand command = new SqlCommand("SELECT Id FROM Courses WHERE Name = @cname", connection.GetConnection))
            {
                command.Parameters.Add("@cname", SqlDbType.VarChar).Value = courseName;

                connection.OpenConnection();

                SqlDataReader reader = command.ExecuteReader();

                if (reader.HasRows)
                {
                    int idOrdinal = reader.GetOrdinal("Id");

                    if (reader.Read())
                    {
                        //for checking if the "Id" column is not null before retrieving its value
                        if (!reader.IsDBNull(idOrdinal))
                        {
                            identity = reader.GetString(idOrdinal);
                        }
                    }
                }

                connection.CloseConnection();
            }

            return identity;
        }

        public bool IsStudentAlreadyEnrolled(string studentId, string courseId)
        {
            SqlCommand command = new SqlCommand("SELECT COUNT(*) FROM Scores WHERE StudentId = @sid AND CourseId = @cid;", connection.GetConnection);
            command.Parameters.Add("@sid", SqlDbType.VarChar).Value = studentId;
            command.Parameters.Add("@cid", SqlDbType.VarChar).Value = courseId;

            connection.OpenConnection();

            int count = (int) command.ExecuteScalar();

            connection.CloseConnection();

            //it's mean: if count is greater than 0, the student is already enrolled in the course
            return count > 0;
        }


        //to create a method for verify score's value
        public bool VerifyScoreValue(TextBox textBox)
        {
            if (double.TryParse(textBox.Text, out double score))
            {

                if (score >= 0) //in here the score can equal to 0, but not on CRP and CMP!
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
    }
}
