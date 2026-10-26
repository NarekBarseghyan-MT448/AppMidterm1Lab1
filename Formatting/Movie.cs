using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Formatting;
namespace movie
{
    internal class Movie
    {
        public enum MovieGenre
        {
            Action = 1,
            Comedy,
            Drama,
            Horror,
            SciFi
        }
        public int Id { get; set; }
        public string Title { get; set; }
        public int Year { get; set; }
        public MovieGenre Genre { get; set; }
        public int Views { get; set; }
        public int Likes { get; set; }
        public Movie(int id, string title, int year, MovieGenre genre,int views,int likes)
        {
            Id = id;
            Title= title;
            Year = year;
            Genre = genre;
            Views = views;
            Likes = likes;
        }
        public double GetRating()
        {
            if (Views == 0) return 0;
            return Math.Sqrt((double)(Likes * Likes) / Views);
        }

        public override string ToString()
        {
            string yearInBrackets = $"({Year})";
            return $"{Id,4} {Title,-15} {yearInBrackets,-8} {Genre,-12} {GetRating(),8:F3}";
        }
    }
}