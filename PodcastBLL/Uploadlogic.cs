using PodcastBLL.Models;
using PodcastDAL.Context.ContextInterface;
using PodcastDAL.Repository;
using PodcastInterfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace PodcastBLL
{
    public class Uploadlogic
    {
        public Uploadlogic(IPodcastContext podcastContext, IPlaylistContext playlistContext)
        {
            PodcastRepository = new PodcastRepository(podcastContext);
            PlaylistRepository = new PlaylistRepository(playlistContext);
        }

        private PodcastRepository PodcastRepository { get; }
        private PlaylistRepository PlaylistRepository { get; }

        public void AddPodcast(int playlistID, string title, string description, string audio, byte[] image, DateTime creationDate, int ageRestriction)
        {
            var person = new Podcast
            { PlaylistID = playlistID, Title = title, Description = description, AudioPath = audio, Image = image, CreationDate = creationDate, AgeRestriction = ageRestriction };
            PodcastRepository.AddPodcast(person);
        }

        public void AddPlaylist(int userID, string title, string description, byte[] image)
        {
            var playlist = new Playlist
            {
                UserID = userID,
                Title = title,
                Description = description,
                Image = image
            };

            PlaylistRepository.AddPlaylist(playlist);
        }

        public IEnumerable<IPlaylist> GetAllPlaylistByUserID(int id)
        {
            return PlaylistRepository.GetAllPlaylistsByUserID(id);
        }

        public IEnumerable<IPodcast> GetAllPodcastByUserID(int id)
        {
            return PodcastRepository.GetAllPodcastsByUserID(id);
        }
    }
}
