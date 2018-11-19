using System;
using System.Collections.Generic;
using System.Text;

namespace PocketMoney.Domain.Entities
{
    public class User
    {
        public int Id { get; set; }
        public string Name { get; private set; }
        public string Email { get; private set; }
        public string Password { get; private set; }
        public DateTime LastLogin { get; set; }

        public User(string name, string email, string password, DateTime lastlogin)
        {
            Name = name;
            Email = email;
            Password = password;
            LastLogin = lastlogin != null ? lastlogin : DateTime.Today;
        }
    }
}
