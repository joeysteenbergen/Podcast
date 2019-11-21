using PodcastBLL.Models;
using PodcastDAL;
using PodcastInterfaces;
using System;
using System.Collections.Generic;

namespace PodcastBLL
{
    public class Userlogic
    {
        public Userlogic(IUserContext context)
        {
            Repository = new UserRepository(context);
        }

        private UserRepository Repository { get; }

        public void AddUser(string username, string password, string firstname, string lastname, DateTime dateOfBirth, string email, DateTime creationDate)
        {
            var person = new User
            { Username = username, Password = password, Firstname = firstname, Lastname = lastname, BirthDate = dateOfBirth, Email = email, DateCreation = creationDate };
            Repository.Add(person);
        }

        public IEnumerable<IUser> GetAllUsers()
        {
            return Repository.GetAll();
        }
    }
}
