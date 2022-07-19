using MovieDataBase;
using MovieDataBase.Models;
using System.Linq;
//Display
Console.WriteLine("Welcome to the Movie Zone!");
Console.WriteLine("We have two options that you can pick from to search a movie");
Console.WriteLine("You can pick the genre or title of a movie");
string choice = Console.ReadLine().Trim().ToLower();
GetUserChoice(choice);
//Methods
static void DisplayMovie(List<Movie> newMovie)
{
    foreach (Movie movie in newMovie)
    {
        Console.WriteLine($"{movie.Title}, {movie.Genre}, {movie.Runtime}");
    }
}
static void AddMovie(List<Movie> newMovie)
{
    using (MovieDBContext context = new MovieDBContext())
    {
        foreach (Movie movie in newMovie)
        {
            context.Movies.Add(movie);
        }
        //context.Movies.Add(newMovie);
        context.SaveChanges();
    }
}
static void GetUserChoice(string choice)
{
    bool result = true;
    
    while (true)
    {
        //string choice = Console.ReadLine().Trim().ToLower();
        if (choice == "genre")
        {
            Console.WriteLine("Please pick the genre you want to watch");
            string genre = Console.ReadLine().Trim().ToLower();
            Movie.SearchByGenre(genre);
            result = true;
            break;
        }
        else if (choice == "title")
        {
            Console.WriteLine("Please pick a movie you want to watch");
            string title = Console.ReadLine().Trim().ToLower();
            Movie.SearchByTitle(title);
            result = true;
            break;
        }
        else
        {
            Console.WriteLine("That was invalid. Try again.");
            result = false;
            break;
        }
    }
}
static void DisplayMovies()
{
    using (MovieDBContext context = new MovieDBContext())
    {
        foreach (Movie movie in context.Movies)
        {
            Console.WriteLine($"{movie.Title} {movie.Genre} {movie.Runtime}");
        }
    }
}
List<Movie> newMovie = new List<Movie>()
{
    new Movie()
    {
        Title = "Jurassic Park",
        Genre = "Scifi",
        Runtime = 127
    },
    new Movie()
    {
        Title = "Basket Case",
        Genre = "Horror",
        Runtime = 91
    },
    new Movie()
    {
        Title = "The Matrix",
        Genre = "Scifi",
        Runtime = 136
    },
    new Movie()
    {
        Title = "The Godfather",
        Genre = "Crime",
        Runtime = 175
    },
    new Movie()
    {
        Title = "The Faculty",
        Genre = "Horror",
        Runtime = 104
    },
    new Movie()
    {
        Title = "Friday the 13th",
        Genre = "Horror",
        Runtime = 95
    },
    new Movie()
    {
        Title = "Minions: The Rise of Gru",
        Genre = "Comedy",
        Runtime = 90
    },
    new Movie()
    {
        Title = "Forest Gump",
        Genre = "Drama",
        Runtime = 142
    },
    new Movie()
    {
        Title = "Shallow Hal",
        Genre = "Comedy",
        Runtime = 114
    },
    new Movie()
    {
        Title = "Shrek",
        Genre = "Animated",
        Runtime = 90
    },
    new Movie()
    {
        Title = "A Silent Voice",
        Genre = "Anime",
        Runtime = 129
    },

};