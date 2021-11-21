using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Modul4HW6.DataAccess;

namespace Modul4HW6
{
    public class AppContextFactory : IDesignTimeDbContextFactory<DataAccess.AppContext>
    {
        public DataAccess.AppContext CreateDbContext(string[] args)
        {
            IConfiguration configuration = new ConfigurationBuilder().AddJsonFile("appsettings.json").Build();
            var dbOptionsBuilder = new DbContextOptionsBuilder<DataAccess.AppContext>();
            var connectionString = configuration.GetConnectionString("MusicDatabase");
            dbOptionsBuilder.UseSqlServer(connectionString, i => i.CommandTimeout(120));

            return new DataAccess.AppContext(dbOptionsBuilder.Options);
        }
    }
}
