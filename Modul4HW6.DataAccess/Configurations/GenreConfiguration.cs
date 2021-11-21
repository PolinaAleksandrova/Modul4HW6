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
    public class GenreConfiguration : IEntityTypeConfiguration<Genre>
    {
        public void Configure(EntityTypeBuilder<Genre> builder)
        {
            builder.ToTable("Genre").HasKey(g => g.GenreId);
            builder.Property(g => g.GenreId).IsRequired().ValueGeneratedOnAdd().HasColumnName("GenreId");
            builder.Property(g => g.Title).IsRequired().HasMaxLength(20);
            builder.HasData(new List<Genre>()
            {
                new Genre() { GenreId = 1, Title = "Genre1" },
                new Genre() { GenreId = 2, Title = "Genre2" },
                new Genre() { GenreId = 3, Title = "Genre3" },
                new Genre() { GenreId = 4, Title = "Genre4" },
                new Genre() { GenreId = 5, Title = "Genre5" }
            });
        }
    }
}
