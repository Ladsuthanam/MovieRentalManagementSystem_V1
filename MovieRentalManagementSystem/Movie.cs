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



        public Movie(string movieId, string title, string directer, string rentalPrice)
        {
            this.movieId = movieId;
            this.title = title;
            this.directer = directer;
            this.rentalPrice = rentalPrice;
        }



    }
}
