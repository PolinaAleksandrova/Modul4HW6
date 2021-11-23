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
            builder.ToTable("Genre").HasKey(g => g.Id);
            builder.Property(g => g.Title).IsRequired();
            builder.HasData(
                new Genre { Id = 1, Title = "Genre1" },
                new Genre { Id = 2, Title = "Genre2" },
                new Genre { Id = 3, Title = "Genre3" },
                new Genre { Id = 4, Title = "Genre4" },
                new Genre { Id = 5, Title = "Genre5" });
        }
    }
}
