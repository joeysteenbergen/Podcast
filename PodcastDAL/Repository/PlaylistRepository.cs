using PodcastDAL.Context.ContextInterface;
using PodcastInterfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace PodcastDAL.Repository
{
    public class PlaylistRepository : IPlaylistContext
    {
        private readonly IPlaylistContext _context;

        public PlaylistRepository(IPlaylistContext context)
        {
            _context = context;
        }

        public void AddPlaylist(IPlaylist playlist)
        {
            _context.AddPlaylist(playlist);
        }

        public void EditPlaylist(IPlaylist playlist)
        {
            _context.EditPlaylist(playlist);
        }

        public void DeletePlaylist(IPlaylist playlist)
        {
            _context.DeletePlaylist(playlist);
        }

        public IEnumerable<IPlaylist> GetAllPlaylists()
        {
            return _context.GetAllPlaylists();
        }

        public IPlaylist GetPlaylistByID(int id)
        {
            return _context.GetPlaylistByID(id);
        }

        public IEnumerable<IPlaylist> GetAllPlaylistsByUserID(int id)
        {
            return _context.GetAllPlaylistsByUserID(id);
        }
    }
}
