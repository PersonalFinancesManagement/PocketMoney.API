using System;

namespace PocketMoney.Domain.Entities {
    public class User {
        public int id { get; set; }
        public string Name { get; }
        public string Email { get; }

        //TODO value object later
        public string Password { get; }
        public DateTime LastLogin { get; private set; }

        public User (string name, string email, string password) {
            Name = name;
            Email = email;
            Password = password;
            LastLogin = DateTime.Today;
        }
    }
}