using ignatov10.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace ignatov10
{
   public static class Shtuka
    {
        public static Genre DaiGenre(this MusicGenres genre, int id = 0)
        {
            switch (genre)
            {
                case MusicGenres.Metal:
                    return new Genre(id, "Металл");
                case MusicGenres.Rap:
                    return new Genre(id, "Рэп");
                case MusicGenres.HipHop:
                    return new Genre(id, "Хип-хоп");
                case MusicGenres.Rock:
                    return new Genre(id, "Рок");
            }

            throw new Exception("Введённый жанр не соответствует ни одному из известных");
        }
    }
}
