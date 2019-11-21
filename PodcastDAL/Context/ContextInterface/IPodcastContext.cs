using PodcastInterfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace PodcastDAL.Context.ContextInterface
{
    public interface IPodcastContext
    {
        void AddPodcast(IPodcast podcast);
        void EditPodcast(IPodcast podcast);
        void DeletePodcast(IPodcast podcast);
        IEnumerable<IPodcast> GetAllPodcasts();
        IEnumerable<IPodcast> GetAllPodcastsByUserID(int id);
        IEnumerable<IPodcast> GetPodcastsByPlaylistID(int id);
        IPodcast GetPodcastByID(int id);
    }
}
