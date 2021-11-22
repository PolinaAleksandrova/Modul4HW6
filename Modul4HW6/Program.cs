using System;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Modul4HW6.DataAccess.Models;

namespace Modul4HW6
{
    public class Program
    {
        public static void Main(string[] args)
        {
            IConfiguration configuration = new ConfigurationBuilder().AddJsonFile("appsettings.json").Build();
            var dbOptionBuilder = new DbContextOptionsBuilder<DataAccess.AppContext>();
            var connectionString = configuration.GetConnectionString("MusicDatabase");
            dbOptionBuilder.UseSqlServer(connectionString, i => i.CommandTimeout(20));

            var appContext = new DataAccess.AppContext(dbOptionBuilder.Options);

            // Query 1
            var appContextFactory = new AppContextFactory();

            using (appContext = appContextFactory.CreateDbContext(args))
            {
                var songsArtistExist = appContext.Song
                    .Where(s => s.ArtistSongs.TrueForAll(a => a.Artist.IsExist == true)).ToList()
                    .Select(s => new
                    {
                        SongTitle = s.Title,
                        SongArtist = s.ArtistSongs.Select(s => s.Artist.Name),
                        Genre = s.Genre.Songs
                    });
            }

            // Query 2
            using (appContext = appContextFactory.CreateDbContext(args))
            {
                var songsQuantity = appContext.Song
                    .GroupBy(i => i.Genre.Title)
                    .Select(s => new
                    {
                        GenreTitle = s.Key,
                        CountSongs = s.Count()
                    })
                    .ToList();
            }
        }
    }
}
