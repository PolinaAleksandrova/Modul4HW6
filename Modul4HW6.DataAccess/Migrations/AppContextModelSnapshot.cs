﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Modul4HW6.DataAccess;

namespace Modul4HW6.DataAccess.Migrations
{
    [DbContext(typeof(AppContext))]
    partial class AppContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.12")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Modul4HW6.DataAccess.Models.Artist", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("DateOfBirth")
                        .HasColumnType("datetime2");

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("InstagramUrl")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("IsExist")
                        .HasColumnType("bit");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Phone")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Artist");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            DateOfBirth = new DateTime(1947, 1, 8, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Email = "david.bowie@gmail.com",
                            InstagramUrl = "https://www.instagram.com/someUrl1",
                            IsExist = false,
                            Name = "David",
                            Phone = "+447458148918"
                        },
                        new
                        {
                            Id = 2,
                            DateOfBirth = new DateTime(1947, 7, 19, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Email = "brian.may@gmail.com",
                            InstagramUrl = "https://www.instagram.com/someUrl2",
                            IsExist = false,
                            Name = "Brian",
                            Phone = "+445550178788"
                        },
                        new
                        {
                            Id = 3,
                            DateOfBirth = new DateTime(1951, 8, 19, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Email = "john.deacon@gmail.com",
                            InstagramUrl = "https://www.instagram.com/someUrl3",
                            IsExist = false,
                            Name = "John",
                            Phone = "+443421172121"
                        },
                        new
                        {
                            Id = 4,
                            DateOfBirth = new DateTime(1949, 7, 26, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Email = "roger.taylor@gmail.com",
                            InstagramUrl = "https://www.instagram.com/someUrl4",
                            IsExist = false,
                            Name = "Roger",
                            Phone = "+444317343411"
                        },
                        new
                        {
                            Id = 5,
                            DateOfBirth = new DateTime(1946, 9, 5, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Email = "freddie.mercury@gmail.com",
                            InstagramUrl = "https://www.instagram.com/someUrl5",
                            IsExist = false,
                            Name = "Freddie",
                            Phone = "+447468168966"
                        },
                        new
                        {
                            Id = 6,
                            DateOfBirth = new DateTime(1991, 8, 21, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Email = "jesse.rutherford@gmail.com",
                            InstagramUrl = "https://www.instagram.com/someUrl6",
                            IsExist = true,
                            Name = "Jesse",
                            Phone = "+447356168793"
                        },
                        new
                        {
                            Id = 7,
                            DateOfBirth = new DateTime(1975, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Email = "sufjan.stevens@gmail.com",
                            InstagramUrl = "https://www.instagram.com/someUrl7",
                            IsExist = true,
                            Name = "Sufjan",
                            Phone = "+447888834347"
                        },
                        new
                        {
                            Id = 8,
                            DateOfBirth = new DateTime(1974, 10, 24, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Email = "jaleel.bunton@gmail.com",
                            InstagramUrl = "https://www.instagram.com/someUrl8",
                            IsExist = true,
                            Name = "Jaleel",
                            Phone = "+447212134179"
                        });
                });

            modelBuilder.Entity("Modul4HW6.DataAccess.Models.ArtistSong", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("ArtistId")
                        .HasColumnType("int");

                    b.Property<int>("SongId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("ArtistId");

                    b.HasIndex("SongId");

                    b.ToTable("ArtistSong");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            ArtistId = 1,
                            SongId = 1
                        },
                        new
                        {
                            Id = 2,
                            ArtistId = 4,
                            SongId = 2
                        },
                        new
                        {
                            Id = 3,
                            ArtistId = 3,
                            SongId = 3
                        },
                        new
                        {
                            Id = 4,
                            ArtistId = 7,
                            SongId = 4
                        },
                        new
                        {
                            Id = 5,
                            ArtistId = 8,
                            SongId = 5
                        },
                        new
                        {
                            Id = 6,
                            ArtistId = 1,
                            SongId = 5
                        });
                });

            modelBuilder.Entity("Modul4HW6.DataAccess.Models.Genre", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Genre");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Title = "Genre1"
                        },
                        new
                        {
                            Id = 2,
                            Title = "Genre2"
                        },
                        new
                        {
                            Id = 3,
                            Title = "Genre3"
                        },
                        new
                        {
                            Id = 4,
                            Title = "Genre4"
                        },
                        new
                        {
                            Id = 5,
                            Title = "Genre5"
                        });
                });

            modelBuilder.Entity("Modul4HW6.DataAccess.Models.Song", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<double>("Duration")
                        .HasColumnType("float");

                    b.Property<int>("GenreId")
                        .HasColumnType("int");

                    b.Property<DateTime>("ReleasedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("GenreId");

                    b.ToTable("Song");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Duration = 1.21,
                            GenreId = 2,
                            ReleasedDate = new DateTime(1973, 2, 12, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Title = "Song1"
                        },
                        new
                        {
                            Id = 2,
                            Duration = 2.0499999999999998,
                            GenreId = 3,
                            ReleasedDate = new DateTime(1971, 8, 17, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Title = "Song2"
                        },
                        new
                        {
                            Id = 3,
                            Duration = 1.8799999999999999,
                            GenreId = 1,
                            ReleasedDate = new DateTime(1975, 5, 20, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Title = "Song3"
                        },
                        new
                        {
                            Id = 4,
                            Duration = 1.3500000000000001,
                            GenreId = 5,
                            ReleasedDate = new DateTime(1973, 2, 12, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Title = "Song4"
                        },
                        new
                        {
                            Id = 5,
                            Duration = 3.0499999999999998,
                            GenreId = 4,
                            ReleasedDate = new DateTime(2010, 1, 21, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Title = "Song5"
                        },
                        new
                        {
                            Id = 6,
                            Duration = 2.21,
                            GenreId = 3,
                            ReleasedDate = new DateTime(1997, 3, 5, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Title = "Song6"
                        },
                        new
                        {
                            Id = 7,
                            Duration = 2.3399999999999999,
                            GenreId = 1,
                            ReleasedDate = new DateTime(1999, 2, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Title = "Song7"
                        },
                        new
                        {
                            Id = 8,
                            Duration = 2.1699999999999999,
                            GenreId = 3,
                            ReleasedDate = new DateTime(1986, 1, 2, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Title = "Song8"
                        });
                });

            modelBuilder.Entity("Modul4HW6.DataAccess.Models.ArtistSong", b =>
                {
                    b.HasOne("Modul4HW6.DataAccess.Models.Artist", "Artist")
                        .WithMany("ArtistSongs")
                        .HasForeignKey("ArtistId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Modul4HW6.DataAccess.Models.Song", "Song")
                        .WithMany("ArtistSongs")
                        .HasForeignKey("SongId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Artist");

                    b.Navigation("Song");
                });

            modelBuilder.Entity("Modul4HW6.DataAccess.Models.Song", b =>
                {
                    b.HasOne("Modul4HW6.DataAccess.Models.Genre", "Genre")
                        .WithMany("Songs")
                        .HasForeignKey("GenreId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Genre");
                });

            modelBuilder.Entity("Modul4HW6.DataAccess.Models.Artist", b =>
                {
                    b.Navigation("ArtistSongs");
                });

            modelBuilder.Entity("Modul4HW6.DataAccess.Models.Genre", b =>
                {
                    b.Navigation("Songs");
                });

            modelBuilder.Entity("Modul4HW6.DataAccess.Models.Song", b =>
                {
                    b.Navigation("ArtistSongs");
                });
#pragma warning restore 612, 618
        }
    }
}
