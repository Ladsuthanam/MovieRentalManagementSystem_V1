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
      

        private string movieId {  get; set; }
        private string title { get; set; }
        private string directer {  get; set; }
        private string rentalPrice { get; set; }

        public Movie(string movieId, string movieName, string movieUrl, string rentalPrice)
        {
            MovieId = movieId;
            Tittle = movieName;
            movieUrl = movieUrl;
            rentalPrice = rentalPrice;
        }
        public override string ToString()
        {
            return $"movieIdId: {MovieId}, title: {Title}, director: {Director}, rentalPrice: {RentalPrice}";
        }

    }
}
