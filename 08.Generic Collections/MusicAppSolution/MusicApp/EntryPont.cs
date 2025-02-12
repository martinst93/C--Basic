﻿using System;
using Models;

namespace MusicApp
{
    public class EntryPont
    {
        static void Main(string[] args)
        {
            Person newPerson = new Person("Martin", "Stojanov", 27, GenreEnum.Rock);

            Song song1 = new Song("Riders on the storm", 500, GenreEnum.Rock);
            Song song2 = new Song("Stairway to heaven", 350, GenreEnum.Rock);
            Song song3 = new Song("Highway to hell", 420, GenreEnum.Rock);

            newPerson.FavoriteSongs.Add(song1);
            newPerson.FavoriteSongs.Add(song2);
            newPerson.FavoriteSongs.Add(song3);

            Console.WriteLine(newPerson.GetFavSongs());
        }
    }
}
