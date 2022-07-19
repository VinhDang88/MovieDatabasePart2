using System;
using System.Collections.Generic;

namespace MovieDataBase.Models
{
    public partial class Movie
    {
        public int Id { get; set; }
        public string? Title { get; set; }
        public string? Genre { get; set; }
        public double? Runtime { get; set; }

        public static void SearchByGenre(string genre)
        {
            using (MovieDBContext context = new MovieDBContext())
            {
                List<Movie> result = context.Movies.Where(m => m.Genre == genre.ToLower()).ToList();
                if (result.Count > 0)
                {
                    foreach (Movie movie in result)
                    {
                        Console.WriteLine($"Movies:{movie.Title}");

                    }
                }
                else
                {
                    Console.WriteLine("Sorry, based on your choice we don't have that!");
                }
          
            }
        }
        public static void SearchByTitle(string title)
        {
            using (MovieDBContext context = new MovieDBContext())
            {
                List<Movie> result = context.Movies.Where(m => m.Title == title.ToLower()).ToList();
                if (result.Count > 0)
                {
                    foreach (Movie movie in result)
                    {
                        Console.WriteLine($"Movie: {movie.Title}");
                    }
                }
                else
                {
                    Console.WriteLine("Sorry, based on your choice we don't have that!");
                }
            }
        }
    }
}
