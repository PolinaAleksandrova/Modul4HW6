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
    public class SongConfiguration : IEntityTypeConfiguration<Song>
    {
        public void Configure(EntityTypeBuilder<Song> builder)
        {
            builder.ToTable("Song").HasKey(s => s.Id);
            builder.Property(s => s.Title).IsRequired();
            builder.Property(s => s.Duration).IsRequired();
            builder.Property(s => s.ReleasedDate).IsRequired();

            builder.HasOne(s => s.Genre)
                .WithMany(g => g.Songs)
                .HasForeignKey(s => s.GenreId)
                .OnDelete(DeleteBehavior.Cascade);

            builder.HasData(
                new Song { Id = 1, Title = "Song1", Duration = 1.21, ReleasedDate = new DateTime(1973, 2, 12), GenreId = 2 },
                new Song { Id = 2, Title = "Song2", Duration = 2.05, ReleasedDate = new DateTime(1971, 8, 17), GenreId = 3 },
                new Song { Id = 3, Title = "Song3", Duration = 1.88, ReleasedDate = new DateTime(1975, 5, 20), GenreId = 1 },
                new Song { Id = 4, Title = "Song4", Duration = 1.35, ReleasedDate = new DateTime(1973, 2, 12), GenreId = 5 },
                new Song { Id = 5, Title = "Song5", Duration = 3.05, ReleasedDate = new DateTime(2010, 1, 21), GenreId = 4 },
                new Song { Id = 6, Title = "Song6", Duration = 2.21, ReleasedDate = new DateTime(1997, 3, 5), GenreId = 3 },
                new Song { Id = 7, Title = "Song7", Duration = 2.34, ReleasedDate = new DateTime(1999, 2, 1), GenreId = 1 },
                new Song { Id = 8, Title = "Song8", Duration = 2.17, ReleasedDate = new DateTime(1986, 1, 2), GenreId = 3 });
        }
    }
}
