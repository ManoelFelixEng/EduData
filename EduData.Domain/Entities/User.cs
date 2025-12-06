using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using EduData.Domain.Base;

namespace EduData.Domain.Entities
{
    public class User : BaseEntity<int>
    {
        public User()
        {

        }
        public User(int id, string username, string password, string role ) : base(id)
        {
            Username = username;
            Password = password;
            Role = role;
        }


        public string Username { get; set; }
        public string Password { get; set; }
        public string Role { get; set; }
    }
}
