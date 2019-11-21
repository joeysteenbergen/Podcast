using System;
using System.Collections.Generic;
using System.Text;
using PodcastInterfaces;

namespace PodcastDAL
{
    public interface IUserContext
    {
        void Add(IUser person);
        IEnumerable<IUser> GetAll();
        IUser GetByID(int id);

    }
}
