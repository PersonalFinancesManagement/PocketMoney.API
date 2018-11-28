using System;
using System.Collections.Generic;
using System.Text;

namespace PocketMoney.Domain.Entities {
    public class UserModel {
        public int UserId { get; set; }
        public string Name { get; private set; }
        public string Email { get; private set; }
        public ICollection<Account> Accounts { get; private set; }

        //TODO value object later
        public string Password { get; private set; }
        public DateTime LastLogin { get; set; }

        public UserModel (string name, string email, string password) {
            Name = name;
            Email = email;
            Password = password;
            LastLogin = DateTime.Today;
        }
    }
}