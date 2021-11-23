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
    public class ArtistSongConfiguration : IEntityTypeConfiguration<ArtistSong>
    {
        public void Configure(EntityTypeBuilder<ArtistSong> builder)
        {
            builder.ToTable("ArtistSong").HasKey(a => a.Id);
            builder.Property(a => a.ArtistId).IsRequired();
            builder.Property(a => a.SongId).IsRequired();

            builder.HasOne(a => a.Artist)
                .WithMany(x => x.ArtistSongs)
                .HasForeignKey(a => a.ArtistId)
                .OnDelete(DeleteBehavior.Cascade);
            builder.HasOne(s => s.Song)
                .WithMany(x => x.ArtistSongs)
                .HasForeignKey(s => s.SongId)
                .OnDelete(DeleteBehavior.Cascade);

            
            builder.HasData(
                new ArtistSong { Id = 1, ArtistId = 1,  SongId = 1 },
                new ArtistSong { Id = 2, ArtistId = 4,  SongId = 2 },
                new ArtistSong { Id = 3, ArtistId = 3,  SongId = 3 },
                new ArtistSong { Id = 4, ArtistId = 7,  SongId = 4 },
                new ArtistSong { Id = 5, ArtistId = 8,  SongId = 5 },
                new ArtistSong { Id = 6, ArtistId = 1,  SongId = 5 });
        }
    }
}
