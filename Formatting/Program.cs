using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using movie;
namespace Formatting
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            List<Movie> movieList = new List<Movie>();
            movieList.Add(new Movie(1, "Inception", 2010, Movie.MovieGenre.SciFi, 100000, 85000));
            movieList.Add(new Movie(2, "Shrek", 2001, Movie.MovieGenre.Comedy, 50000, 45000));
            movieList.Add(new Movie(3, "The Dark Knight", 2008, Movie.MovieGenre.Action, 150000, 140000));
            movieList.Add(new Movie(4, "Interstellar", 2014, Movie.MovieGenre.SciFi, 120000, 95000));
            movieList.Add(new Movie(5, "The Conjuring", 2013, Movie.MovieGenre.Horror, 40000, 25000));

            Console.WriteLine(new string('-', 55));
            Console.WriteLine($"{"Համար",4} {"Անվանում",-15} {"Տարի",-8} {"Ժանր",-12} {"Ռեյտինգ",8}");
            Console.WriteLine(new string('-', 55));

            foreach (var movie in movieList)
            {
                Console.WriteLine(movie);
            }
            Console.WriteLine(new string('-', 55));

            Console.ReadLine(); 
        }
    }
}
