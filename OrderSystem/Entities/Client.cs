using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderSystem.Entities
{
    class Client
    {
        public string Name { get; set; }
        public string Email { get; set; }
        public DateOnly BirthDate { get; set; }

        public Client()
        {
        }
        public Client(string name, DateOnly birthDate, string email)
        {
            Name = name;
            BirthDate = birthDate;
            Email = email;
        }
    }
}
