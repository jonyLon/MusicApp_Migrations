

using System.ComponentModel.DataAnnotations;

namespace MusicApp
{
   public class Artist
   {
        public int Id { get; set; }
        [Required, MaxLength(100)]
        public string Name { get; set; }
        [Required, MaxLength(100)]
        public string Surname { get; set; }
        [Required, MaxLength(100)]
        public string Country { get; set; }

        public virtual ICollection<Album> Albums { get; set; }
    }
}
