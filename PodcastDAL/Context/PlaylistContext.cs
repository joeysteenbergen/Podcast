using PodcastDAL.Context.ContextInterface;
using PodcastDAL.DTO;
using PodcastInterfaces;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Text;

namespace PodcastDAL.Context
{
    public class PlaylistContext : IPlaylistContext
    {
        private readonly DatabaseConnection _connection;

        public PlaylistContext(DatabaseConnection connection)
        {
            _connection = connection;
        }

        public void AddPlaylist(IPlaylist playlist)
        {
            _connection.SqlConnection.Open();

            String query = "INSERT INTO Playlist (UserID, Title, Description, Image) VALUES (@UserID, @Title, @Description, @Image)";
            using (SqlCommand command = new SqlCommand(query, _connection.SqlConnection))
            {
                command.Parameters.AddWithValue("@UserID", playlist.UserID);
                command.Parameters.AddWithValue("@Title", playlist.Title);
                command.Parameters.AddWithValue("@Description", playlist.Description);
                command.Parameters.AddWithValue("@Image", playlist.Image);

                command.ExecuteNonQuery();
            }
        }

        public void EditPlaylist(IPlaylist playlist)
        {

        }

        public void DeletePlaylist(IPlaylist playlist)
        {

        }

        public IEnumerable<IPlaylist> GetAllPlaylists()
        {
            _connection.SqlConnection.Open();

            String query = "Select * From Playlist";
            SqlCommand command = new SqlCommand(query, _connection.SqlConnection);
            SqlDataReader reader = command.ExecuteReader();

            var playlistList = new List<IPlaylist>();

            while (reader.Read())
            {
                var playlist = new PlaylistDTO
                {
                    ID = Convert.ToInt32(reader["ID"]),
                    UserID = Convert.ToInt32(reader["PlaylistID"]),
                    Title = reader["Title"].ToString(),
                    Description = reader["Description"].ToString(),
                    Image = (byte[])reader["Image"]
                };

                playlistList.Add(playlist);
            }

            return playlistList;
        }

        public IEnumerable<IPlaylist> GetAllPlaylistsByUserID(int id)
        {
            _connection.SqlConnection.Open();

            String query = "Select * From Playlist WHERE Playlist.UserID = @UserID";
            SqlDataReader reader;
            using (SqlCommand command = new SqlCommand(query, _connection.SqlConnection))
            {
                command.Parameters.AddWithValue("@UserID", id);
                reader = command.ExecuteReader();
            }

            var playlistList = new List<IPlaylist>();

            while (reader.Read())
            {
                var playlist = new PlaylistDTO
                {
                    Title = reader["Title"].ToString(),
                    Description = reader["Description"].ToString(),
                    Image = (byte[])reader["Image"]
                };

                playlistList.Add(playlist);
            }

            return playlistList;
        }

        public IPlaylist GetPlaylistByID(int id)
        {
            return null;
        }
    }
}
