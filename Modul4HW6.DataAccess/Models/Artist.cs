using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modul4HW6.DataAccess.Models
{
    public class Artist
    {
        public Artist()
        {
            ArtistSongs = new List<ArtistSong>();
        }

        public int ArtistId { get; set; }
        public string Name { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public string InstagramUrl { get; set; }
        public List<ArtistSong> ArtistSongs { get; set; }
    }
}
