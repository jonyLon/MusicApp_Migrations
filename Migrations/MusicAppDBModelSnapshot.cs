﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using MusicApp;

#nullable disable

namespace MusicApp.Migrations
{
    [DbContext(typeof(MusicAppDB))]
    partial class MusicAppDBModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.28")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("MusicApp.Album", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int>("ArtistId")
                        .HasColumnType("int");

                    b.Property<string>("Genre")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<DateTime?>("PublicationDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("RatingId")
                        .HasColumnType("int");

                    b.Property<int>("Year")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("ArtistId");

                    b.ToTable("Albumls");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            ArtistId = 1,
                            Genre = "Rock",
                            Name = "The Rise and Fall of Ziggy Stardust and the Spiders from Mars",
                            RatingId = 1,
                            Year = 1972
                        },
                        new
                        {
                            Id = 2,
                            ArtistId = 2,
                            Genre = "Rock",
                            Name = "Bohemian Rhapsody",
                            RatingId = 2,
                            Year = 1975
                        },
                        new
                        {
                            Id = 3,
                            ArtistId = 3,
                            Genre = "Rock",
                            Name = "Are You Experienced",
                            RatingId = 3,
                            Year = 1967
                        },
                        new
                        {
                            Id = 4,
                            ArtistId = 4,
                            Genre = "Rock and Roll",
                            Name = "Elvis Presley",
                            RatingId = 4,
                            Year = 1956
                        },
                        new
                        {
                            Id = 5,
                            ArtistId = 5,
                            Genre = "Rock",
                            Name = "Imagine",
                            RatingId = 5,
                            Year = 1971
                        });
                });

            modelBuilder.Entity("MusicApp.AlbumRating", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int>("AlbumId")
                        .HasColumnType("int");

                    b.Property<double>("Rating")
                        .HasColumnType("float");

                    b.HasKey("Id");

                    b.HasIndex("AlbumId")
                        .IsUnique();

                    b.ToTable("AlbumRating");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            AlbumId = 1,
                            Rating = 3.8999999999999999
                        },
                        new
                        {
                            Id = 2,
                            AlbumId = 2,
                            Rating = 4.9000000000000004
                        },
                        new
                        {
                            Id = 3,
                            AlbumId = 3,
                            Rating = 4.5999999999999996
                        },
                        new
                        {
                            Id = 4,
                            AlbumId = 4,
                            Rating = 4.0999999999999996
                        },
                        new
                        {
                            Id = 5,
                            AlbumId = 5,
                            Rating = 4.7000000000000002
                        });
                });

            modelBuilder.Entity("MusicApp.Artist", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Country")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("Surname")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.HasKey("Id");

                    b.ToTable("Artists");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Country = "UK",
                            Name = "David",
                            Surname = "Bowie"
                        },
                        new
                        {
                            Id = 2,
                            Country = "UK",
                            Name = "Freddie",
                            Surname = "Mercury"
                        },
                        new
                        {
                            Id = 3,
                            Country = "USA",
                            Name = "Jimi",
                            Surname = "Hendrix"
                        },
                        new
                        {
                            Id = 4,
                            Country = "USA",
                            Name = "Elvis",
                            Surname = "Presley"
                        },
                        new
                        {
                            Id = 5,
                            Country = "UK",
                            Name = "John",
                            Surname = "Lennon"
                        },
                        new
                        {
                            Id = 6,
                            Country = "UK",
                            Name = "Paul",
                            Surname = "McCartney"
                        },
                        new
                        {
                            Id = 7,
                            Country = "UK",
                            Name = "Mick",
                            Surname = "Jagger"
                        },
                        new
                        {
                            Id = 8,
                            Country = "USA",
                            Name = "Kurt",
                            Surname = "Cobain"
                        },
                        new
                        {
                            Id = 9,
                            Country = "USA",
                            Name = "Bob",
                            Surname = "Dylan"
                        },
                        new
                        {
                            Id = 10,
                            Country = "UK",
                            Name = "Elton",
                            Surname = "John"
                        });
                });

            modelBuilder.Entity("MusicApp.Playlist", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Category")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.HasKey("Id");

                    b.ToTable("Playlists");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Category = "Rock",
                            Name = "Classic Rock Hits"
                        },
                        new
                        {
                            Id = 2,
                            Category = "Rock",
                            Name = "70s Rock Anthems"
                        },
                        new
                        {
                            Id = 3,
                            Category = "Rock",
                            Name = "Guitar Legends"
                        },
                        new
                        {
                            Id = 4,
                            Category = "Rock and Roll",
                            Name = "Rock 'n Roll Classics"
                        },
                        new
                        {
                            Id = 5,
                            Category = "Singer-Songwriter",
                            Name = "Songwriter Essentials"
                        });
                });

            modelBuilder.Entity("MusicApp.Track", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int>("AlbumId")
                        .HasColumnType("int");

                    b.Property<TimeSpan>("Duration")
                        .HasColumnType("time");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<int>("PlaylistId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("AlbumId");

                    b.HasIndex("PlaylistId");

                    b.ToTable("Tracks");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            AlbumId = 1,
                            Duration = new TimeSpan(0, 0, 4, 10, 0),
                            Name = "Starman",
                            PlaylistId = 1
                        },
                        new
                        {
                            Id = 2,
                            AlbumId = 1,
                            Duration = new TimeSpan(0, 0, 3, 13, 0),
                            Name = "Ziggy Stardust",
                            PlaylistId = 1
                        },
                        new
                        {
                            Id = 3,
                            AlbumId = 2,
                            Duration = new TimeSpan(0, 0, 5, 55, 0),
                            Name = "Bohemian Rhapsody",
                            PlaylistId = 2
                        },
                        new
                        {
                            Id = 4,
                            AlbumId = 2,
                            Duration = new TimeSpan(0, 0, 4, 56, 0),
                            Name = "Somebody to Love",
                            PlaylistId = 2
                        },
                        new
                        {
                            Id = 5,
                            AlbumId = 3,
                            Duration = new TimeSpan(0, 0, 2, 50, 0),
                            Name = "Purple Haze",
                            PlaylistId = 3
                        },
                        new
                        {
                            Id = 6,
                            AlbumId = 3,
                            Duration = new TimeSpan(0, 0, 3, 18, 0),
                            Name = "Foxey Lady",
                            PlaylistId = 3
                        },
                        new
                        {
                            Id = 7,
                            AlbumId = 4,
                            Duration = new TimeSpan(0, 0, 2, 16, 0),
                            Name = "Hound Dog",
                            PlaylistId = 4
                        },
                        new
                        {
                            Id = 8,
                            AlbumId = 4,
                            Duration = new TimeSpan(0, 0, 2, 37, 0),
                            Name = "Jailhouse Rock",
                            PlaylistId = 4
                        },
                        new
                        {
                            Id = 9,
                            AlbumId = 5,
                            Duration = new TimeSpan(0, 0, 3, 3, 0),
                            Name = "Imagine",
                            PlaylistId = 5
                        },
                        new
                        {
                            Id = 10,
                            AlbumId = 5,
                            Duration = new TimeSpan(0, 0, 4, 14, 0),
                            Name = "Jealous Guy",
                            PlaylistId = 5
                        },
                        new
                        {
                            Id = 11,
                            AlbumId = 1,
                            Duration = new TimeSpan(0, 0, 7, 11, 0),
                            Name = "Hey Jude",
                            PlaylistId = 1
                        },
                        new
                        {
                            Id = 12,
                            AlbumId = 2,
                            Duration = new TimeSpan(0, 0, 4, 3, 0),
                            Name = "Let It Be",
                            PlaylistId = 2
                        },
                        new
                        {
                            Id = 13,
                            AlbumId = 3,
                            Duration = new TimeSpan(0, 0, 3, 44, 0),
                            Name = "Satisfaction",
                            PlaylistId = 3
                        },
                        new
                        {
                            Id = 14,
                            AlbumId = 4,
                            Duration = new TimeSpan(0, 0, 5, 1, 0),
                            Name = "Smells Like Teen Spirit",
                            PlaylistId = 4
                        },
                        new
                        {
                            Id = 15,
                            AlbumId = 5,
                            Duration = new TimeSpan(0, 0, 6, 9, 0),
                            Name = "Like a Rolling Stone",
                            PlaylistId = 5
                        });
                });

            modelBuilder.Entity("MusicApp.Album", b =>
                {
                    b.HasOne("MusicApp.Artist", "Artist")
                        .WithMany("Albums")
                        .HasForeignKey("ArtistId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Artist");
                });

            modelBuilder.Entity("MusicApp.AlbumRating", b =>
                {
                    b.HasOne("MusicApp.Album", "Album")
                        .WithOne("AlbumRating")
                        .HasForeignKey("MusicApp.AlbumRating", "AlbumId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Album");
                });

            modelBuilder.Entity("MusicApp.Track", b =>
                {
                    b.HasOne("MusicApp.Album", "Album")
                        .WithMany("Tracks")
                        .HasForeignKey("AlbumId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("MusicApp.Playlist", "Playlist")
                        .WithMany("Tracks")
                        .HasForeignKey("PlaylistId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Album");

                    b.Navigation("Playlist");
                });

            modelBuilder.Entity("MusicApp.Album", b =>
                {
                    b.Navigation("AlbumRating")
                        .IsRequired();

                    b.Navigation("Tracks");
                });

            modelBuilder.Entity("MusicApp.Artist", b =>
                {
                    b.Navigation("Albums");
                });

            modelBuilder.Entity("MusicApp.Playlist", b =>
                {
                    b.Navigation("Tracks");
                });
#pragma warning restore 612, 618
        }
    }
}