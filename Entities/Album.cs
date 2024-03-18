using System.ComponentModel.DataAnnotations;

namespace MusicApp
{
    public class Album
    {
        public int Id { get; set; }
        [Required, MaxLength(100)]
        public string Name { get; set; }
        public int ArtistId { get; set; }
        public int Year { get; set; }
        [Required, MaxLength(100)]
        public string Genre { get; set; }

        public int RatingId { get; set; }
        public DateTime? PublicationDate { get; set; }
        public virtual Artist Artist { get; set; }

        public virtual AlbumRating AlbumRating { get; set; }
        public virtual ICollection<Track> Tracks { get; set; }
    }
}
