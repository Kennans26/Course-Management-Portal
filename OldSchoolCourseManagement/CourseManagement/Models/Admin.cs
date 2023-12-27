using System.Data;
using System.Data.SqlClient;
using CourseManagement.Database;

namespace CourseManagement.Models
{
    internal class Admin
    {
        public string? Role { get; set; }
        public DateTime RegistrationDate { get; set; }
        public string? RoleName { get; set; }
        public string? Email {  get; set; }
        public string? AppPass { get; set; }
        public string? EmailPass { get; set; }


        ConnectionToDB connection = new ConnectionToDB();

        public static Admin? GetAdminData()
        {
            string query = "SELECT * FROM Admin";

            using (var connection = new ConnectionToDB().GetConnection)
            {
                using (var command = new SqlCommand(query, connection))
                {
                    connection.Open();

                    using (var reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            return new Admin
                            {
                                Role = reader["Role"] as string,
                                RegistrationDate = Convert.ToDateTime(reader["RegistrationDate"]),
                                RoleName = reader["RoleName"] as string,
                                Email = reader["Email"] as string,
                                AppPass = reader["AppPass"] as string,
                                EmailPass = reader["EmailPass"] as string
                            };
                        }
                    }
                }
            }

            return null; //it must not be a need anywhere, that's why we can declare all prop. to default!
        }

        //create a function to update the app password
        public bool UpdatePassword(string NewPassword)
        {
            SqlCommand command = new SqlCommand("UPDATE Admin SET AppPass = @apassword;", connection.GetConnection);

            //@apassword
            command.Parameters.Add("@apassword", SqlDbType.VarChar).Value = NewPassword;

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
