using System;
using System.Collections.Generic;
using System.Linq;

namespace Models
{
    public class Person 
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }
        public GenreEnum FavoriteMusicType { get; set; }
        public List<Song> FavoriteSongs { get; set; } = new List<Song>();

        public Person(string firstName, string lastName, int age, GenreEnum favoriteMusicType)
        {
            Random rnd = new Random();

            Id = rnd.Next(0, int.MaxValue);
            FirstName = firstName;
            LastName = lastName;
            Age = age;
            FavoriteMusicType = favoriteMusicType;
        }

        public Person(string firstName, string lastName, int age, GenreEnum favoriteMusicType, List<Song> favoriteSongs)
        {
            Random rnd = new Random();

            Id = rnd.Next(0, int.MaxValue);
            FirstName = firstName;
            LastName = lastName;
            Age = age;
            FavoriteMusicType = favoriteMusicType;
            FavoriteSongs = favoriteSongs;
        }

        public Person()
        {
            Random rnd = new Random();

            Id = rnd.Next(0, int.MaxValue);

        }

        public string GetFavSongs()
        {
            List<string> favoriteSongTitles = FavoriteSongs.Select(x => x.Title).ToList();

            return FavoriteSongs.Count == 0
                ? "This person hates music"
                : string.Join("; ", FavoriteSongs.Select(x => $"{x.Title} {x.Genre}"));
        }
    }
}
