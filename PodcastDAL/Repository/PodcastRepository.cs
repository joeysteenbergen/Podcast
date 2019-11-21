using PodcastDAL.Context.ContextInterface;
using PodcastInterfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace PodcastDAL.Repository
{
    public class PodcastRepository : IPodcastContext
    {
        private readonly IPodcastContext _context;

        public PodcastRepository(IPodcastContext context)
        {
            _context = context;
        }
        public void AddPodcast(IPodcast podcast)
        {
            _context.AddPodcast(podcast);
        }

        public void EditPodcast(IPodcast podcast)
        {
            _context.AddPodcast(podcast);
        }

        public void DeletePodcast(IPodcast podcast)
        {
            _context.DeletePodcast(podcast);
        }

        public IEnumerable<IPodcast> GetAllPodcasts()
        {
            return _context.GetAllPodcasts();
        }

        public IPodcast GetPodcastByID(int id)
        {
            return _context.GetPodcastByID(id);
        }

        public IEnumerable<IPodcast> GetAllPodcastsByUserID(int id)
        {
            return _context.GetAllPodcastsByUserID(id);
        }

        public IEnumerable<IPodcast> GetPodcastsByPlaylistID(int id)
        {
            return _context.GetPodcastsByPlaylistID(id);
        }
    }
}
