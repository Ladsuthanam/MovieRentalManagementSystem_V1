﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieRentalManagementSystem
{
    internal class MovieManager
    {
        private List<Movie> movies = new List<Movie>();
        private string AutoM_Id = "MOVIE_001";
        

        public void CreateMovie(string movieId, string title, string directer, string rentalPrice)
        {
            var movie = new Movie(AutoM_Id,title,directer,rentalPrice);
            movies.Add(movie);
            Console.WriteLine("Movie added successfully");

        }
        public void ReadMovies()
        {
            if (movies == null) {
                Console.WriteLine("Not Found Movies");
                return;
            }
            foreach (var movie in movies) {
                Console.WriteLine("List of Movies:");
                Console.WriteLine(movie);
            }

        }

        public void UpdateMovie(string movieId, string title, string directer, string rentalPrice)
        {
            var movie = movies.Find(m => m.MovieId == movieId);
            if (movie == null) {
                Console.WriteLine("Not Found Movie");
                return;
            }

            movies.Remove(movie);
            CreateMovie(movieId,title,directer,rentalPrice);
            Console.WriteLine("Movie updated successfully");

        }
        public void DeleteMovie(string movieId)
        {
            var movie = movies.Find(m => m.MovieId == movieId);
            if (movie == null) {
                Console.WriteLine("Not Found Movie");
                return;
            }

            movies.Remove(movie);
            Console.WriteLine("Movie deleted successfully.");



        }
    }
}
