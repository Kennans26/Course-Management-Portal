using System.Data;
using System.Data.SqlClient;
using CourseManagement.Database;

namespace CourseManagement.Models
{
    internal class StudentsInfo
    {
        ConnectionToDB connection = new ConnectionToDB();

        //create a function to add a new students to the database
        public bool InsertStudent(string Identity, string FirstName, string LastName, DateTime Birthdate, string Gender, string Email, string Address, byte[] Photo)
        {
            SqlCommand command = new SqlCommand("INSERT INTO Students (Id, FirstName, LastName, Birthdate, Gender, Email, Address, Photo) VALUES (@sid, @fn, @ln, @bd, @gd, @smail, @adr, @img);", connection.GetConnection);

            //@sid, @fn, @ln, @bd, @gd, @smail, @adr, @img
            command.Parameters.Add("@sid", SqlDbType.VarChar).Value = Identity;
            command.Parameters.Add("@fn", SqlDbType.VarChar).Value = FirstName;
            command.Parameters.Add("@ln", SqlDbType.VarChar).Value = LastName;
            command.Parameters.Add("@bd", SqlDbType.Date).Value = Birthdate;
            command.Parameters.Add("@gd", SqlDbType.VarChar).Value = Gender;
            command.Parameters.Add("@smail", SqlDbType.VarChar).Value = Email;
            command.Parameters.Add("@adr", SqlDbType.VarChar).Value = Address;
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


        //create a function to verify email address
        public bool VerifyStudentEmailRP(TextBox textBox)
        {
            string eMail = textBox.Text;

            if (EmailExistsInDatabaseRP(eMail))
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        //create a function for unique phone number
        public bool EmailExistsInDatabaseRP(string eMail)
        {
            bool exists = false;

            using (SqlConnection connection = new ConnectionToDB().GetConnection)
            {
                try
                {
                    connection.Open();

                    string query = "SELECT COUNT(*) FROM Students WHERE Email = @smail";
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@smail", eMail);

                        int count = Convert.ToInt32(command.ExecuteScalar());

                        exists = count > 0;
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
                finally
                {
                    connection.Close();
                }
            }

            return exists;
        }


        //create a function to verify email address
        public bool VerifyStudentEmailMP(string Identity, TextBox textBox)
        {
            string eMail = textBox.Text;

            if (EmailExistsInDatabaseMP(eMail, Identity))
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        //create a function for unique email address
        public bool EmailExistsInDatabaseMP(string eMail, string Identity)
        {
            bool exists = false;

            using (SqlConnection connection = new ConnectionToDB().GetConnection)
            {
                try
                {
                    connection.Open();

                    string query = "SELECT COUNT(*) FROM Students WHERE Email = @smail AND Id != @sid";
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@smail", eMail);
                        command.Parameters.AddWithValue("@sid", Identity);

                        int count = Convert.ToInt32(command.ExecuteScalar());

                        exists = count > 0;
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
                finally
                {
                    connection.Close();
                }
            }

            return exists;
        }


        //to create a method for verify student's id (it must be a unique!)
        public bool VerifyStudentIdentity(TextBox textBox)
        {
            string Identity = textBox.Text;

            return IdentityExistsInDatabase(Identity);
        }

        //check if a student identity already exists in the database
        public bool IdentityExistsInDatabase(string Identity)
        {
            using (SqlCommand command = new SqlCommand("SELECT COUNT(*) FROM Students WHERE Id = @sid", connection.GetConnection))
            {
                command.Parameters.Add("@sid", SqlDbType.VarChar).Value = Identity;

                connection.OpenConnection();

                int count = (int) command.ExecuteScalar();

                connection.CloseConnection();

                //if count is greater than 0, the course identity already exists
                return count == 0;
            }
        }

        
        //to getting students table
        public DataTable GetStudentsList(SqlCommand command) //"SELECT * FROM Students;"
        {
            command.Connection = connection.GetConnection;

            SqlDataAdapter adapter = new SqlDataAdapter(command);

            DataTable table = new DataTable();
            adapter.Fill(table);

            return table;
        }


        //create a function to execute the count query(total, male, female)
        public string ExecuteCount(string query)
        {
            SqlCommand command = new SqlCommand(query, connection.GetConnection);
            connection.OpenConnection();
            string? count = command.ExecuteScalar().ToString();
            connection.CloseConnection();

            if (count != null)
            {
                return count;
            }
            else
            {
                return string.Empty;
            }
        }

        //to get the total student count
        public string GetTotalStudents()
        {
            return ExecuteCount("SELECT COUNT(*) FROM Students;");
        }

        //to get the male students count
        public string GetMaleStudents()
        {
            return ExecuteCount("SELECT COUNT(*) FROM Students WHERE Gender = 'Male';");
        }

        //to get the female students count
        public string GetFemaleStudents()
        {
            return ExecuteCount("SELECT COUNT(*) FROM Students WHERE Gender = 'Female';");
        }


        //create a function search for student (first name, last name, address)
        public DataTable SearchForStudents(string SearchData)
        {
            SqlCommand command = new SqlCommand("SELECT * FROM Students WHERE CONCAT(FirstName, LastName, Email) LIKE '%" + SearchData + "%';", connection.GetConnection);

            SqlDataAdapter adapter = new SqlDataAdapter(command);

            DataTable table = new DataTable();
            adapter.Fill(table);

            return table;
        }


        //create a function for editing students data
        public bool UpdateForStudents(string Identity, string FirstName, string LastName, DateTime Birthdate, string Gender, string Email, string Address, byte[] Photo)
        {
            SqlCommand command = new SqlCommand("UPDATE Students SET FirstName = @fn, LastName = @ln, Birthdate = @bd, Gender = @gd, Email = @smail, Address = @adr, Photo = @img WHERE Id = @sid;", connection.GetConnection);

            //@sid, @fn, @ln, @bd, @gd, @smail, @adr, @img
            command.Parameters.Add("@sid", SqlDbType.VarChar).Value = Identity;
            command.Parameters.Add("@fn", SqlDbType.VarChar).Value = FirstName;
            command.Parameters.Add("@ln", SqlDbType.VarChar).Value = LastName;
            command.Parameters.Add("@bd", SqlDbType.Date).Value = Birthdate;
            command.Parameters.Add("@gd", SqlDbType.VarChar).Value = Gender;
            command.Parameters.Add("@smail", SqlDbType.VarChar).Value = Email;
            command.Parameters.Add("@adr", SqlDbType.VarChar).Value = Address;
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

        //create a function to delete a student (only need student id)
        public bool DeleteStudent(string Identity)
        {
            SqlCommand command = new SqlCommand("DELETE FROM Students WHERE Id = @sid;", connection.GetConnection);

            //@sid
            command.Parameters.Add("@sid", SqlDbType.VarChar).Value = Identity;

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
