using System;
using System.Data.SqlClient;

namespace PodcastDAL
{
    public class DatabaseConnection
    {
        public DatabaseConnection(string connectionString)
        {
            SqlConnection = new SqlConnection(connectionString);
        }

        internal SqlConnection SqlConnection { get; }
    }
}
