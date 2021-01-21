using System;
using Microsoft.AspNetCore.Mvc;

namespace SpaDay.Models
{
    public class User
    {
        public string Username { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }

        // Bonus Mission
        public DateTime SignUpTime { get; }

        public User()
        {
            SignUpTime = DateTime.Now;
        }

        public User(string username, string email, string password)
        {
            Username = username;
            Email = email;
            Password = password;
            SignUpTime = DateTime.Now;
        }
    }
}
