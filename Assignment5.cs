using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignments
{
    using Assignments.MovieManagementApp;
    using System;
    using System.Collections.Generic;

    namespace MovieManagementApp
    {
        class Movie
        {
            private int _movieId;
            private string _movieName;
            private int _movieYear;

            public int MovieID
            {
                get { return _movieId; }
                set { _movieId = value; }
            }

            public string MovieName
            {
                get { return _movieName; }
                set { _movieName = value; }
            }

            public int MovieYear
            {
                get { return _movieYear; }
                set { _movieYear = value; }
            }
        }

        class MovieRepo
        {
            private List<Movie> movies = new List<Movie>();

            public void AddMovie(Movie movie)
            {
                movies.Add(movie);
                Console.WriteLine($"Movie '{movie.MovieName}' added successfully.");
            }

            public Movie GetMovie(int id)
            {
                return movies.Find(m => m.MovieID == id);
            }

            public void UpdateMovie(Movie movie)
            {
                var existing = GetMovie(movie.MovieID);
                if (existing != null)
                {
                    existing.MovieName = movie.MovieName;
                    existing.MovieYear = movie.MovieYear;
                    Console.WriteLine($"Movie '{movie.MovieName}' updated successfully.");
                }
                else
                {
                    Console.WriteLine("Movie not found.");
                }
            }

            public void DeleteMovie(int id)
            {
                var movie = GetMovie(id);
                if (movie != null)
                {
                    movies.Remove(movie);
                    Console.WriteLine($"Movie with ID {id} deleted successfully.");
                }
                else
                {
                    Console.WriteLine("Movie not found.");
                }
            }

            public Movie[] GetAllMovies()
            {
                return movies.ToArray();
            }
        }

        static class ConsoleUtil
        {
            public static string GetInputString(string prompt)
            {
                Console.WriteLine(prompt);
                return Console.ReadLine();
            }

            public static int GetInputInt(string prompt)
            {
                return int.Parse(GetInputString(prompt));
            }
        }

       
        
    }

    internal class Assignment5
    {
        static MovieRepo repo = new MovieRepo();

        static void Main(string[] args)
        {
            bool running = true;
            while (running)
            {
                Console.WriteLine("\nChoose: 1-Add, 2-Find, 3-Display All, 4-Update, 5-Delete, 6-Exit");
                int choice = ConsoleUtil.GetInputInt("Enter your choice:");
                running = ProcessChoice(choice);
            }
        }

        static bool ProcessChoice(int choice)
        {
            switch (choice)
            {
                case 1: AddMovie(); return true;
                case 2: FindMovie(); return true;
                case 3: DisplayAll(); return true;
                case 4: UpdateMovie(); return true;
                case 5: DeleteMovie(); return true;
                case 6: return false;
                default: Console.WriteLine("Invalid choice."); return true;
            }
        }

        static void AddMovie()
        {
            Movie movie = new Movie
            {
                MovieID = ConsoleUtil.GetInputInt("Enter Movie ID:"),
                MovieName = ConsoleUtil.GetInputString("Enter Movie Name:"),
                MovieYear = ConsoleUtil.GetInputInt("Enter Release Year:")
            };
            repo.AddMovie(movie);
        }

        static void FindMovie()
        {
            int id = ConsoleUtil.GetInputInt("Enter Movie ID to find:");
            var movie = repo.GetMovie(id);
            if (movie != null)
                Console.WriteLine($"Found: ID={movie.MovieID}, Name={movie.MovieName}, Year={movie.MovieYear}");
            else
                Console.WriteLine("Movie not found.");
        }

        static void DisplayAll()
        {
            var movies = repo.GetAllMovies();
            foreach (var movie in movies)
            {
                Console.WriteLine($"ID={movie.MovieID}, Name={movie.MovieName}, Year={movie.MovieYear}");
            }
        }

        static void UpdateMovie()
        {
            int id = ConsoleUtil.GetInputInt("Enter Movie ID to update:");
            var movie = repo.GetMovie(id);
            if (movie != null)
            {
                movie.MovieName = ConsoleUtil.GetInputString("Enter new Movie Name:");
                movie.MovieYear = ConsoleUtil.GetInputInt("Enter new Release Year:");
                repo.UpdateMovie(movie);
            }
            else
            {
                Console.WriteLine("Movie not found.");
            }
        }

        static void DeleteMovie()
        {
            int id = ConsoleUtil.GetInputInt("Enter Movie ID to delete:");
            repo.DeleteMovie(id);
        }
    }

}
