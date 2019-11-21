using PodcastDAL.Context.ContextInterface;
using PodcastDAL.DTO;
using PodcastInterfaces;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Text;

namespace PodcastDAL.Context
{
    public class PodcastContext : IPodcastContext
    {
        private readonly DatabaseConnection _connection;

        public PodcastContext(DatabaseConnection connection)
        {
            _connection = connection;
        }

        public void AddPodcast(IPodcast podcast)
        {

        }

        public void EditPodcast(IPodcast podcast)
        {

        }

        public void DeletePodcast(IPodcast podcast)
        {

        }

        public IEnumerable<IPodcast> GetAllPodcasts()
        {
            _connection.SqlConnection.Open();

            String query = "Select * From Podcast";
            SqlCommand command = new SqlCommand(query, _connection.SqlConnection);
            SqlDataReader reader = command.ExecuteReader();

            var podcastList = new List<IPodcast>();

            while (reader.Read())
            {
                var podcast = new PodcastDTO
                {
                    ID = Convert.ToInt32(reader["ID"]),
                    PlaylistID = Convert.ToInt32(reader["PlaylistID"]),
                    Title = reader["Title"].ToString(),
                    Description = reader["Description"].ToString(),
                    Image = (byte[])reader["PodcastPicture"],
                    CreationDate = Convert.ToDateTime(reader["CreationDate"]),
                    AgeRestriction = Convert.ToInt32(reader["AgeRestriction"]),
                    AudioPath = reader["PodcastAudioPath"].ToString()
                };

                podcastList.Add(podcast);
            }

            return podcastList;
        }

        public IPodcast GetPodcastByID(int id)
        {
            return null;
        }

        public IEnumerable<IPodcast> GetAllPodcastsByUserID(int id)
        {
            _connection.SqlConnection.Open();

            String query = "Select * From Podcast, Playlist, Users WHERE Podcast.PlaylistID = Playlist.ID AND Playlist.UserID = @UserID";
            SqlDataReader reader;
            using (SqlCommand command = new SqlCommand(query, _connection.SqlConnection))
            {
                command.Parameters.AddWithValue("@UserID", id);
                reader = command.ExecuteReader();
            }

            var podcastList = new List<IPodcast>();

            while (reader.Read())
            {
                var podcast = new PodcastDTO
                {
                    Title = reader["Title"].ToString(),
                    Description = reader["Description"].ToString(),
                    Image = (byte[])reader["Image"],
                    CreationDate = Convert.ToDateTime(reader["CreationDate"]),
                    AgeRestriction = Convert.ToInt32(reader["AgeRestriction"]),
                    AudioPath = reader["AudioPath"].ToString()
                };

                podcastList.Add(podcast);
            }

            return podcastList;
        }

        public IEnumerable<IPodcast> GetAllPodcastByUserID(int id)
        {
            _connection.SqlConnection.Open();

            String query = "SELECT * FROM Podcast WHERE PlaylistID = (SELECT ID FROM Playlist WHERE UserID = @UserID)";
            SqlDataReader reader;
            using (SqlCommand command = new SqlCommand(query, _connection.SqlConnection))
            {
                command.Parameters.AddWithValue("@UserID", id);
                reader = command.ExecuteReader();
            }

            var podcastList = new List<IPodcast>();

            while (reader.Read())
            {
                var podcast = new PodcastDTO
                {
                    Title = reader["Title"].ToString(),
                    Description = reader["Description"].ToString(),
                    Image = (byte[])reader["Image"],
                    CreationDate = Convert.ToDateTime(reader["CreationDate"]),
                    AgeRestriction = Convert.ToInt32(reader["AgeRestriction"])
                };

                podcastList.Add(podcast);
            }

            return podcastList;
        }

        public IEnumerable<IPodcast> GetPodcastsByPlaylistID(int id)
        {
            return null;
        }
    }
}
