﻿using System;
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
            builder.ToTable("Artist").HasKey(a => a.ArtistId);
            builder.Property(p => p.ArtistId).ValueGeneratedOnAdd();
            builder.Property(p => p.Name).IsRequired().HasMaxLength(70);
            builder.Property(p => p.DateOfBirth).IsRequired();
            builder.Property(p => p.Phone).HasMaxLength(20);
            builder.Property(p => p.Email).HasMaxLength(50);
            builder.Property(p => p.InstagramUrl).HasMaxLength(100);
            builder.HasData(new List<Artist>()
            {
                new Artist() { ArtistId = 1, Name = "David", DateOfBirth = new DateTime(1947, 1, 8), Phone = "+447458148918", Email = "david.bowie@gmail.com", InstagramUrl = "https://www.instagram.com/someUrl1" },
                new Artist() { ArtistId = 2, Name = "Brian", DateOfBirth = new DateTime(1947, 7, 19), Phone = "+445550178788", Email = "brian.may@gmail.com", InstagramUrl = "https://www.instagram.com/someUrl2" },
                new Artist() { ArtistId = 3, Name = "John", DateOfBirth = new DateTime(1951, 8, 19), Phone = "+443421172121", Email = "john.deacon@gmail.com", InstagramUrl = "https://www.instagram.com/someUrl3" },
                new Artist() { ArtistId = 4, Name = "Roger", DateOfBirth = new DateTime(1949, 7, 26), Phone = "+444317343411", Email = "roger.taylor@gmail.com", InstagramUrl = "https://www.instagram.com/someUrl4" },
                new Artist() { ArtistId = 5, Name = "Freddie", DateOfBirth = new DateTime(1946, 9, 5), Phone = "+447468168966", Email = "freddie.mercury@gmail.com", InstagramUrl = "https://www.instagram.com/someUrl5" },
                new Artist() { ArtistId = 6, Name = "Jesse", DateOfBirth = new DateTime(1991, 8, 21), Phone = "+447356168793", Email = "jesse.rutherford@gmail.com", InstagramUrl = "https://www.instagram.com/someUrl6" },
                new Artist() { ArtistId = 7, Name = "Sufjan", DateOfBirth = new DateTime(1975, 7, 1), Phone = "+447888834347", Email = "sufjan.stevens@gmail.com", InstagramUrl = "https://www.instagram.com/someUrl7" },
                new Artist() { ArtistId = 8, Name = "Jaleel", DateOfBirth = new DateTime(1974, 10, 24), Phone = "+447212134179", Email = "jaleel.bunton@gmail.com", InstagramUrl = "https://www.instagram.com/someUrl8" }
            });
        }
    }
}
