using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProsjektUkeSantasList.Ifs
{
    public class MusicGenres
    {
        public void judgingMusic(Person person)
        {
            if (person.MusicGenres == null)
            {
                throw new Exception("Error music genre is null");
            }
            if (
                person.MusicGenres.Contains("J-pop")
                || person.MusicGenres.Contains("Folk")
                || person.MusicGenres.Contains("Blues")
            )
            {
                person.Points += 50;
            }
            else
            {
                person.Points -= 50;
            }

        }
    }
}