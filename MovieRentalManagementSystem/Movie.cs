using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace MovieRentalManagementSystem
{
    public class Movie
    {

        public int MovieId { get; private set; }
        public string Title { get; private set; }
        public string Directer { get; private set; }
        public string RentalPrice { get; private set; }
        

        public Movie(int movieId, string title, string directer, string rentalPrice)
        {
            MovieId = movieId;
            Title = title;
            Directer = directer;
            RentalPrice = rentalPrice;
        }

        public override string ToString()
        {
            return $"movieIdId: {MovieId}, title: {Title}, director:{Directer}, rentalPrice: {RentalPrice}";
        }


    }

    public class DigitalMovie : Movie
    {
        private string FileSize;
        private string Format;

        public DigitalMovie(int movieId, string title, string directer, string rentalPrice) : base(movieId, title, directer, rentalPrice) 
        {

        }
    }

    public class DVDMovie : Movie

       
    {

        private decimal DiscWeight;
        private string Duration;
        public DVDMovie(int movieId, string title, string directer, string rentalPrice) : base(movieId, title, directer, rentalPrice)
        {

        }
    }
}
