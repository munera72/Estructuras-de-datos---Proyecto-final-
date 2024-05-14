using System.Data.SqlClient;

namespace Calculator.util
{
    internal class ConnectionFactory
    {
        private static string connectionString = "Server=DESKTOP-7BP02NM;Database=pdf_editor_db;Integrated Security=true;";

        private static SqlConnection? connection;

        public static SqlConnection GetInstance()
        {
            if (connection == null || connection.State == System.Data.ConnectionState.Closed)
            {
                connection = new SqlConnection(connectionString);
            }

            return connection;
        }

    }
}
