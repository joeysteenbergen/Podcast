using PodcastInterfaces;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using PodcastDAL.DTO;
using System.Text;

namespace PodcastDAL
{
    public class UserContext : IUserContext
    {
        private readonly DatabaseConnection _connection;

        public UserContext(DatabaseConnection connection)
        {
            _connection = connection;
        }

        public void Add(IUser user)
        {
            _connection.SqlConnection.Open();

            String query = "INSERT INTO Users (Username, Password, Firstname, Lastname, BirthDate, Email, CreationDate) VALUES (@Username, @Password, @Firstname, @Lastname, @BirthDate, @Email, @CreationDate)";
            using (SqlCommand command = new SqlCommand(query, _connection.SqlConnection))
            {
                command.Parameters.AddWithValue("@Username", user.Username);
                command.Parameters.AddWithValue("@Password", user.Password);
                command.Parameters.AddWithValue("@Firstname", user.Firstname);
                command.Parameters.AddWithValue("@Lastname", user.Lastname);
                command.Parameters.AddWithValue("@BirthDate", user.BirthDate);
                command.Parameters.AddWithValue("@Email", user.Email);
                command.Parameters.AddWithValue("@CreationDate", user.DateCreation);

                command.ExecuteNonQuery();
            }
        }

        public IEnumerable<IUser> GetAll()
        {
            _connection.SqlConnection.Open();

            String query = "Select * From Users";
            SqlCommand command = new SqlCommand(query, _connection.SqlConnection);
            SqlDataReader reader = command.ExecuteReader();

            var personList = new List<IUser>();

            while(reader.Read())
            {
                var user = new UserDTO
                {
                    ID = Convert.ToInt32(reader["ID"]),
                    Username = reader["Username"].ToString(),
                    Password = reader["Password"].ToString(),
                    Firstname = reader["Firstname"].ToString(),
                    Lastname = reader["Lastname"].ToString(),
                    BirthDate = Convert.ToDateTime(reader["BirthDate"]),
                    Email = reader["Email"].ToString(),
                    DateCreation = Convert.ToDateTime(reader["CreationDate"])
                };

                personList.Add(user);
            }

            return personList;
        }

        public IUser GetByID(int id)
        {
            return null;
        }

    }
}
