using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Modul4HW6.DataAccess.Models;

namespace Modul4HW6.DataAccess.Configurations
{
    public class ArtistConfiguration : IEntityTypeConfiguration<Artist>
    {
        public void Configure(EntityTypeBuilder<Artist> builder)
        {
            builder.ToTable("Artist").HasKey(a => a.Id);
            builder.Property(a => a.Name).IsRequired();
            builder.Property(a => a.DateOfBirth).IsRequired();

            builder.HasData(
                new Artist { Id = 1, Name = "David", DateOfBirth = new DateTime(1947, 1, 8), Phone = "+447458148918", Email = "david.bowie@gmail.com", InstagramUrl = "https://www.instagram.com/someUrl1", IsExist = false },
                new Artist { Id = 2, Name = "Brian", DateOfBirth = new DateTime(1947, 7, 19), Phone = "+445550178788", Email = "brian.may@gmail.com", InstagramUrl = "https://www.instagram.com/someUrl2", IsExist = false },
                new Artist { Id = 3, Name = "John", DateOfBirth = new DateTime(1951, 8, 19), Phone = "+443421172121", Email = "john.deacon@gmail.com", InstagramUrl = "https://www.instagram.com/someUrl3", IsExist = false },
                new Artist { Id = 4, Name = "Roger", DateOfBirth = new DateTime(1949, 7, 26), Phone = "+444317343411", Email = "roger.taylor@gmail.com", InstagramUrl = "https://www.instagram.com/someUrl4", IsExist = false },
                new Artist { Id = 5, Name = "Freddie", DateOfBirth = new DateTime(1946, 9, 5), Phone = "+447468168966", Email = "freddie.mercury@gmail.com", InstagramUrl = "https://www.instagram.com/someUrl5", IsExist = false },
                new Artist { Id = 6, Name = "Jesse", DateOfBirth = new DateTime(1991, 8, 21), Phone = "+447356168793", Email = "jesse.rutherford@gmail.com", InstagramUrl = "https://www.instagram.com/someUrl6", IsExist = true },
                new Artist { Id = 7, Name = "Sufjan", DateOfBirth = new DateTime(1975, 7, 1), Phone = "+447888834347", Email = "sufjan.stevens@gmail.com", InstagramUrl = "https://www.instagram.com/someUrl7", IsExist = true },
                new Artist { Id = 8, Name = "Jaleel", DateOfBirth = new DateTime(1974, 10, 24), Phone = "+447212134179", Email = "jaleel.bunton@gmail.com", InstagramUrl = "https://www.instagram.com/someUrl8", IsExist = true });
        }
    }
}
