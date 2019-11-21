using PodcastInterfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace PodcastDAL
{
    public class UserRepository
    {
        private readonly IUserContext _context;

        public UserRepository(IUserContext context)
        {
            _context = context;
        }

        public void Add(IUser user)
        {
            _context.Add(user);
        }

        public IEnumerable<IUser> GetAll()
        {
            return _context.GetAll();
        }

        public IUser GetByID(int id)
        {
            return _context.GetByID(id);
        }
    }
}
