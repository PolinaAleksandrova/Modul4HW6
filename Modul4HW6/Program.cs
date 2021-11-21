using System;
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
            appContext.Database.Migrate();
            appContext.SaveChanges();
        }
    }
}
