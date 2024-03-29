﻿using PodcastInterfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace PodcastBLL.Models
{
    class User : IUser
    {
        public int ID { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public string Firstname { get; set; }
        public string Lastname { get; set; }
        public DateTime BirthDate { get; set; }
        public string Email { get; set; }
        public DateTime DateCreation { get; set; }
    }
}
