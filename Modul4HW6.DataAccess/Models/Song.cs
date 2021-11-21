using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modul4HW6.DataAccess.Models
{
    public class Song
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public double Duration { get; set; }
        public DateTime ReleasedDate { get; set; }
        public Genre Genre { get; set; }
        public int GenreId { get; set; }
        public List<ArtistSong> ArtistSongs { get; set; } = new List<ArtistSong>();
    }
}
