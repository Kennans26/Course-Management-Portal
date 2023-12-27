using System.Data.SqlClient;

namespace CourseManagement.Database
{

    internal class ConnectionToDB
    {
        //to create a connection, "FIRSTSQL" is my server name, "26062004" is my server authentication password!
        SqlConnection connection = new SqlConnection(@"Server=localhost\FIRSTSQL;Database=OldSchoolCourseManagement;User Id=sa;Password=26062004;");

        //to get connection
        public SqlConnection GetConnection
        {
            get
            {
                return connection;
            }
        }

        //create a function to open connection
        public void OpenConnection()
        {
            if (connection.State == System.Data.ConnectionState.Closed)
            {
                connection.Open();
            }
        }

        //create a function to close connection
        public void CloseConnection()
        {
            if (connection.State == System.Data.ConnectionState.Open)
            {
                connection.Close();
            }
        }
    }
}
