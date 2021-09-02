using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Museco.Models
{
    public class Playlist
    {
        public int Id { get; set; }
        public string name { get; set; }
        public int UserId { get; set; }
    }
}
