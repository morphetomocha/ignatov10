using System;
using System.Collections.Generic;
using System.Text;

namespace ignatov10.Models
{
    public class MusicGenre
    {
        public int MusicId { get; set; }
        public int GenreId { get; set; }

        public MusicGenre(int musicId, int genreId)
        {
            MusicId = musicId;
            GenreId = genreId;
        }
    }
}
