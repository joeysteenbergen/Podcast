using System;
using System.Collections.Generic;
using System.Text;

namespace PodcastInterfaces
{
    public interface IPodcast
    {
        int ID { get; set; }
        int PlaylistID { get; set; }
        string Title { get; set; }
        string Description { get; set; }
        string AudioPath { get; set; }
        byte[] Image { get; set; }
        DateTime CreationDate { get; set; }
        int AgeRestriction { get; set; }
    }
}
