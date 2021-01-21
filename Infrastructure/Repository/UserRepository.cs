using Core.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Infrastructure.Repository
{
    public class UserRepository
    {
        public User Get(string name, string password)
        {
            var users = new List<User>();

            users.Add(new User { Id = 1, Username = "batman", Password = "batman", Role = "manager" });

            users.Add(new User { Id = 2, Username = "robin", Password = "robin", Role = "employee" });

            return users.Where(x => x.Username.ToLower() == name.ToLower() && x.Password == x.Password).FirstOrDefault();
        }
    }
}
