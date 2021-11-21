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
            builder.Property(s => s.Id).IsRequired().HasColumnName("SongId");
            builder.Property(s => s.Title).IsRequired().HasMaxLength(20);
            builder.Property(s => s.Duration).IsRequired();
            builder.Property(s => s.ReleasedDate).IsRequired();
            builder.HasOne(s => s.Genre)
                .WithMany(g => g.Songs)
                .HasForeignKey(s => s.GenreId)
                .OnDelete(DeleteBehavior.Cascade);

            builder.HasData(new List<Song>()
            {
                new Song() { Id = 1, Title = "Song1", Duration = 1.21, ReleasedDate = new DateTime(1973, 2, 12) },
                new Song() { Id = 2, Title = "Song2", Duration = 2.05, ReleasedDate = new DateTime(1971, 8, 17) },
                new Song() { Id = 3, Title = "Song3", Duration = 1.88, ReleasedDate = new DateTime(1975, 5, 20) },
                new Song() { Id = 4, Title = "Song4", Duration = 1.35, ReleasedDate = new DateTime(1973, 2, 12) },
                new Song() { Id = 5, Title = "Song5", Duration = 3.05, ReleasedDate = new DateTime(2010, 1, 21) },
                new Song() { Id = 5, Title = "Song6", Duration = 2.21, ReleasedDate = new DateTime(1997, 3, 5) },
            });
        }
    }
}
