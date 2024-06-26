﻿using System.Data.SqlClient;

namespace Calculator.util
{
    internal class ConnectionFactory
    {
        private static string connectionString = "server=DESKTOP-E998LP5;Database=pdf_editor_db;User Id=sa;Password=root"/*"Server=DESKTOP-9B6RR8Q;Database=pdf_editor_db;Integrated Security=true;"*/;

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