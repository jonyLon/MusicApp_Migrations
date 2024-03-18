using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MusicApp
{
    public class AlbumRating
    {
        public int Id {  get; set; }
        public double Rating { get; set; }

        public int AlbumId {  get; set; }

        public virtual Album Album { get; set; }
    }
}
