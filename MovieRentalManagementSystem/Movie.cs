using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieRentalManagementSystem
{
    public class Movie
    {
      

        private string movieId {  get; set; }
        private string movieName { get; set; }
        private string movieUrl { get; set; }
        private string rentalPrice { get; set; }

        public Movie(string movieId, string movieName, string movieUrl, string rentalPrice)
        {
            this.movieId = movieId;
            this.movieName = movieName;
            this.movieUrl = movieUrl;
            this.rentalPrice = rentalPrice;
        }


    }
}
