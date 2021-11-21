using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modul4HW6.DataAccess.Models
{
    public class Genre
    {
        public Genre()
        {
            Songs = new List<Song>();
        }

        public int GenreId { get; set; }
        public string Title { get; set; }
        public List<Song> Songs { get; set; } = new List<Song>();
    }
}
