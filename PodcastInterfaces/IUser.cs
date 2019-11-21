using System;

namespace PodcastInterfaces
{
    public interface IUser
    {
        int ID { get; set; }
        string Username { get; set; }
        string Password { get; set; }
        string Firstname { get; set; }
        string Lastname { get; set; }
        DateTime BirthDate { get; set; }
        string Email { get; set; }
        
        DateTime DateCreation { get; set; }
    }
}
