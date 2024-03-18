using System.ComponentModel.DataAnnotations;

namespace MusicApp
{
    public class Playlist
    {
        public int Id { get; set; }
        [Required, MaxLength(100)]
        public string Name { get; set; }
        [Required, MaxLength(100)]
        public string Category { get; set; }

        public virtual ICollection<Track> Tracks { get; set; }
    }
}
