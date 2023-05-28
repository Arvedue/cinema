using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cinema_project
{
    internal class User
    {
        private int userId;
        private string name;
        private string username;
        private string password;
        private string role;

        public User(int userId, string name, string username, string password, string role)
        {
            this.UserId = userId;
            this.Name = name;
            this.Username = username;
            this.Password = password;
            this.Role = role;
        }

        public int UserId { get => userId; set => userId = value; }
        public string Name { get => name; set => name = value; }
        public string Username { get => username; set => username = value; }
        public string Password { get => password; set => password = value; }
        public string Role { get => role; set => role = value; }
    }
}
