using Microsoft.EntityFrameworkCore;
using System.Data.SqlTypes;

namespace MusicApp
{

    public class MusicAppDB : DbContext
    {
        public MusicAppDB()
        {
            this.Database.EnsureDeleted();
            //this.Database.EnsureCreated();
        }

        public DbSet<Artist> Artists { get; set; }
        public DbSet<Album> Albumls { get; set; }
        public DbSet<Track> Tracks { get; set; }
        public DbSet<Playlist> Playlists { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);

            optionsBuilder.UseSqlServer(@"Data Source=WINDOWS-66D5279\SQLEXPRESS;
                                        Initial Catalog = MusicAppDb;
                                        Integrated Security=True;
                                        Connect Timeout=2;Encrypt=False;
                                         Trust Server Certificate=False;
                                        Application Intent=ReadWrite;Multi Subnet Failover=False");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            //Initializator - Seeder
            modelBuilder.Entity<Artist>().HasData(new Artist[]
            {
                new Artist { Id = 1, Name = "David", Surname = "Bowie", Country = "UK"},
                new Artist { Id = 2, Name = "Freddie", Surname = "Mercury", Country = "UK"},
                new Artist { Id = 3, Name = "Jimi", Surname = "Hendrix", Country = "USA"},
                new Artist { Id = 4, Name = "Elvis", Surname = "Presley", Country = "USA"},
                new Artist { Id = 5, Name = "John", Surname = "Lennon", Country = "UK"},
                new Artist { Id = 6, Name = "Paul", Surname = "McCartney", Country = "UK"},
                new Artist { Id = 7, Name = "Mick", Surname = "Jagger", Country = "UK"},
                new Artist { Id = 8, Name = "Kurt", Surname = "Cobain", Country = "USA"},
                new Artist { Id = 9, Name = "Bob", Surname = "Dylan", Country = "USA"},
                new Artist { Id = 10, Name = "Elton", Surname = "John", Country = "UK"},
            });
            modelBuilder.Entity<Album>()
                .HasOne(a => a.AlbumRating)
                .WithOne(ar => ar.Album)
                .HasForeignKey<Album>(a => a.RatingId);

            modelBuilder.Entity<AlbumRating>()
                .HasOne(ar => ar.Album)
                .WithOne(a => a.AlbumRating)
                .HasForeignKey<AlbumRating>(ar => ar.AlbumId);

            modelBuilder.Entity<Album>().HasData(new Album[]
            {
                new Album { Id = 1, Name = "The Rise and Fall of Ziggy Stardust and the Spiders from Mars", ArtistId = 1, Year = 1972, Genre = "Rock", RatingId = 1},
                new Album { Id = 2, Name = "Bohemian Rhapsody", ArtistId = 2, Year = 1975, Genre = "Rock", RatingId = 2},
                new Album { Id = 3, Name = "Are You Experienced", ArtistId = 3, Year = 1967, Genre = "Rock", RatingId = 3},
                new Album { Id = 4, Name = "Elvis Presley", ArtistId = 4, Year = 1956, Genre = "Rock and Roll", RatingId = 4},
                new Album { Id = 5, Name = "Imagine", ArtistId = 5, Year = 1971, Genre = "Rock", RatingId = 5}
            });



            modelBuilder.Entity<Track>().HasData(new Track[]
            {
                new Track { Id = 1, Name = "Starman", AlbumId = 1, PlaylistId = 1, Duration = new TimeSpan(0, 4, 10)},
                new Track { Id = 2, Name = "Ziggy Stardust", AlbumId = 1, PlaylistId = 1, Duration = new TimeSpan(0, 3, 13)},
                new Track { Id = 3, Name = "Bohemian Rhapsody", AlbumId = 2, PlaylistId = 2, Duration = new TimeSpan(0, 5, 55)},
                new Track { Id = 4, Name = "Somebody to Love", AlbumId = 2, PlaylistId = 2, Duration = new TimeSpan(0, 4, 56)},
                new Track { Id = 5, Name = "Purple Haze", AlbumId = 3, PlaylistId = 3, Duration = new TimeSpan(0, 2, 50)},
                new Track { Id = 6, Name = "Foxey Lady", AlbumId = 3, PlaylistId = 3, Duration = new TimeSpan(0, 3, 18)},
                new Track { Id = 7, Name = "Hound Dog", AlbumId = 4, PlaylistId = 4, Duration = new TimeSpan(0, 2, 16)},
                new Track { Id = 8, Name = "Jailhouse Rock", AlbumId = 4, PlaylistId = 4, Duration = new TimeSpan(0, 2, 37)},
                new Track { Id = 9, Name = "Imagine", AlbumId = 5, PlaylistId = 5, Duration = new TimeSpan(0, 3, 3)},
                new Track { Id = 10, Name = "Jealous Guy", AlbumId = 5, PlaylistId = 5, Duration = new TimeSpan(0, 4, 14)},
                new Track { Id = 11, Name = "Hey Jude", AlbumId = 1, PlaylistId = 1, Duration = new TimeSpan(0, 7, 11)},
                new Track { Id = 12, Name = "Let It Be", AlbumId = 2, PlaylistId = 2, Duration = new TimeSpan(0, 4, 3)},
                new Track { Id = 13, Name = "Satisfaction", AlbumId = 3, PlaylistId = 3, Duration = new TimeSpan(0, 3, 44)},
                new Track { Id = 14, Name = "Smells Like Teen Spirit", AlbumId = 4, PlaylistId = 4, Duration = new TimeSpan(0, 5, 1)},
                new Track { Id = 15, Name = "Like a Rolling Stone", AlbumId = 5, PlaylistId = 5, Duration = new TimeSpan(0, 6, 9)},
            });


            modelBuilder.Entity<Playlist>().HasData(new Playlist[]
            {
                new Playlist { Id = 1, Name= "Classic Rock Hits", Category = "Rock"},
                new Playlist { Id = 2, Name= "70s Rock Anthems", Category = "Rock"},
                new Playlist { Id = 3, Name= "Guitar Legends", Category = "Rock"},
                new Playlist { Id = 4, Name= "Rock 'n Roll Classics", Category = "Rock and Roll"},
                new Playlist { Id = 5, Name= "Songwriter Essentials", Category = "Singer-Songwriter"},
            });



            modelBuilder.Entity<AlbumRating>().HasData(new AlbumRating[] {
                new AlbumRating { Id = 1, Rating = 3.9, AlbumId = 1},
                new AlbumRating { Id = 2, Rating = 4.9, AlbumId = 2},
                new AlbumRating { Id = 3, Rating = 4.6, AlbumId = 3},
                new AlbumRating { Id = 4, Rating = 4.1, AlbumId = 4},
                new AlbumRating { Id = 5, Rating = 4.7, AlbumId = 5},
            });

        }
    }
    
}

