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
            builder.ToTable("ArtistSong").HasKey(a => a.ArtistSongId);
            builder.Property(a => a.ArtistSongId).ValueGeneratedOnAdd().HasColumnName("ArtistSongId");
            builder.HasOne(a => a.Song)
                .WithMany(a => a.ArtistSongs)
                .HasForeignKey(a => a.SongId)
                .OnDelete(DeleteBehavior.Cascade);

            builder.HasOne(a => a.Artist)
                .WithMany(a => a.ArtistSongs)
                .HasForeignKey(a => a.ArtistId)
                .OnDelete(DeleteBehavior.Cascade);
            builder.HasData(new List<ArtistSong>()
            {
                new ArtistSong() { ArtistSongId = 1,  SongId = 1, ArtistId = 1, },
                new ArtistSong() { ArtistSongId = 2,  SongId = 2, ArtistId = 2, },
                new ArtistSong() { ArtistSongId = 3,  SongId = 3, ArtistId = 3, },
                new ArtistSong() { ArtistSongId = 4,  SongId = 4, ArtistId = 2, },
                new ArtistSong() { ArtistSongId = 5,  SongId = 5, ArtistId = 5, }
            });
        }
    }
}
