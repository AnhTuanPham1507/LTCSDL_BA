using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Museco.Models
{
    public class User
    {
        public int Id { get; set; }
        public string Fullname { get; set; }
        public string Lastname { get; set; }
        public string Gender { get; set; }
        public int Phone { get; set; }
        public int Adress { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public bool Active { get; set; }
    }
}
