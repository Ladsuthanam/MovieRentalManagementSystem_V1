using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieRentalManagementSystem
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Movie movie =new Movie("MOVIE_001", "Titanic", "James Cameroon", "1.00 ");
            Console.WriteLine(movie.ToString());

            Console.ReadLine();

        }
    }
}
