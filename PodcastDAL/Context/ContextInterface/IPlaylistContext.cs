using PodcastInterfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace PodcastDAL.Context.ContextInterface
{
    public interface IPlaylistContext
    {
        void AddPlaylist(IPlaylist playlist);

        void EditPlaylist(IPlaylist playlist);

        void DeletePlaylist(IPlaylist playlist);

        IEnumerable<IPlaylist> GetAllPlaylists();
        IEnumerable<IPlaylist> GetAllPlaylistsByUserID(int id);

        IPlaylist GetPlaylistByID(int id);
    }
}
