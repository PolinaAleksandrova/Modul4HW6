using System;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;

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
                var songs = appContext.Songs.Select(s => new
                {
                    Name = s.Title,
                    Genre = s.Genre
                });
            }
        }
    }
}
