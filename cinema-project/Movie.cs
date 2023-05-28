using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cinema_project
{
    internal class Movie
    {
        private int movieId;
        private string name;
        private int year;
        private string producer;
        private string genre;
        private string country;
        private string description;

        public Movie(int movieId, string name, int year, string producer, string genre, string country, string description)
        {
            this.MovieId = movieId;
            this.Name = name;
            this.Year = year;
            this.Producer = producer;
            this.Genre = genre;
            this.Country = country;
            this.Description = description;
        }

        public int MovieId { get => movieId; set => movieId = value; }
        public string Name { get => name; set => name = value; }
        public int Year { get => year; set => year = value; }
        public string Producer { get => producer; set => producer = value; }
        public string Genre { get => genre; set => genre = value; }
        public string Country { get => country; set => country = value; }
        public string Description { get => description; set => description = value; }
    }
}
