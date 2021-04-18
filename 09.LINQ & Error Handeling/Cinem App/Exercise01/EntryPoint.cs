using Exercise01_Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace CinemaApp
{
    class EntryPoint
    {
        public static void Main(string[] args)
        {
            try
            {
                #region Objects

                var cinemasList = new List<Cinema>();
                var cinema1 = new Cinema("Cineplexx", 8);
                var cinema2 = new Cinema("Milenium", 6);
                var cinema3 = new Cinema("Partinzan", 5);
                var cinema4 = new Cinema("Makedonija", 9);
                var cinema5 = new Cinema("Idnina", 8);

                cinemasList.Add(cinema1);
                cinemasList.Add(cinema2);
                cinemasList.Add(cinema3);
                cinemasList.Add(cinema4);
                cinemasList.Add(cinema5);

                var moviesList = new List<Movie>();
                var movie1 = new Movie("Treto poluvreme", Genre.Drama, 4);
                var movie2 = new Movie("Medena zemja", Genre.Drama, 5);
                var movie3 = new Movie("Tetoviranje", Genre.Drama, 5);
                var movie4 = new Movie("Balkankan", Genre.Comedy, 4);
                var movie5 = new Movie("Coming to America", Genre.Comedy, 4);
                //Movie movie6 = new Movie("Prasina", Genre.Drama, 8);

                moviesList.Add(movie1);
                moviesList.Add(movie2);
                moviesList.Add(movie3);
                moviesList.Add(movie4);
                moviesList.Add(movie5);

                cinema1.Movies.AddRange(new List<Movie> { movie1, movie2, movie3, movie4, movie5 });
                cinema2.Movies.AddRange(new List<Movie> { movie1, movie2, movie3, movie4, movie5 });
                cinema3.Movies.AddRange(new List<Movie> { movie1, movie2, movie3, movie4, movie5 });
                cinema4.Movies.AddRange(new List<Movie> { movie1, movie2, movie3, movie4, movie5 });
                cinema5.Movies.AddRange(new List<Movie> { movie1, movie2, movie3, movie4, movie5 });

                #endregion Objects

                //Console.WriteLine(cinema2.MoviePlaying(movie1));
                Console.WriteLine("Please select a cinema.");
                string nameOfCinema = Console.ReadLine().Trim();

                var movieTitles = moviesList.Select(x => x.Title).ToList();
                var genreMovies = moviesList.Select(x => x.Genre).ToList();
                var genreOfMovie = moviesList.Where(x => x.Genre == Genre.Drama).Select(x => x.Title).ToList();

                if (cinemasList.Exists(x => string.Equals(x.Name, nameOfCinema, StringComparison.OrdinalIgnoreCase)) != true)
                {
                    Console.WriteLine($"There is no cinema with that is named {nameOfCinema}.");
                }
                else if (cinemasList.Exists(x => string.Equals(x.Name, nameOfCinema, StringComparison.OrdinalIgnoreCase)))
                {
                    Console.WriteLine($"Please select \n 1. If you want to see All Movies \n 2. By Genre.");
                    string makeSelectionOne = Console.ReadLine().Trim();

                    if (makeSelectionOne != "1" && makeSelectionOne != "2")
                    {
                        Console.WriteLine(new string('-', 60));
                        Console.WriteLine("Please select ether 1 or 2!");
                        Console.WriteLine(new string('-', 60));
                    }
                    if (makeSelectionOne == "1")
                    {
                        Console.WriteLine($"Here is a list of all the movies:");
                        Console.WriteLine(new string('-', 60));
                        movieTitles.ForEach(x => Console.WriteLine(x));
                        Console.WriteLine(new string('-', 60));
                        Console.WriteLine("Please write the name of the movie you wish to see");
                        Console.WriteLine(new string('-', 60));
                        string nameOfMovie1 = Console.ReadLine().Trim();

                        if (moviesList.Exists(x => string.Equals(x.Title, nameOfMovie1, StringComparison.OrdinalIgnoreCase)) != true)
                        {
                            Console.WriteLine($"There is no movie with the title {nameOfMovie1}.");
                        }
                        else if (moviesList.Exists(x => string.Equals(x.Title, nameOfMovie1, StringComparison.OrdinalIgnoreCase)))
                        {
                            Console.WriteLine(new string('-', 60));
                            Console.WriteLine($"The cinema {nameOfCinema} is playing the movie {nameOfMovie1}");
                            Console.WriteLine(new string('-', 60));
                        }
                    }
                    if (makeSelectionOne == "2")
                    {
                        Console.WriteLine("Select a Genre of a movie");
                        genreMovies.ForEach(x => Console.WriteLine(x));

                        Console.WriteLine(new string('-', 60));

                        string inputGenre = Console.ReadLine().ToLower();
                        genreOfMovie.ForEach(x => Console.WriteLine($"The movie is: {x}"));
                        string inputNameOfMovie = Console.ReadLine().ToLower();
                    }
                }
            }
            catch (NullReferenceException ex)
            {
                Console.WriteLine($"NullReferenceException: {ex.Message}");
                throw;
            }
            catch (ArgumentOutOfRangeException ex)
            {
                Console.WriteLine($"ArgumentOutOfRangeException: {ex.Message}");
            }
            catch (Exception e)
            {
                Console.WriteLine($"Exception: {e.Message}");
            }

            Console.ReadLine();
        }
    }
}