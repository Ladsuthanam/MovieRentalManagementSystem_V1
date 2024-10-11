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

            MovieManager movieManager = new MovieManager();
            int option;
            //Movie movie =new Movie("MOVIE_001", "Titanic", "James Cameroon", "1.00 ");
            //Console.WriteLine(movie.ToString());
            do
            {
                Console.WriteLine("Movie Rental Management System:");
                Console.WriteLine("1. Add a Movie");
                Console.WriteLine("2. View All Movies");
                Console.WriteLine("3. Update a Movie");
                Console.WriteLine("4. Delete a Movie");
                Console.WriteLine("5. Exit");
                Console.WriteLine("Choose an option:");
                option = int.Parse(Console.ReadLine());

                switch (option) {
                    case 1:
                        Console.WriteLine("Enter Movie MovieId in Integer");
                        int MovieId = int.Parse(Console.ReadLine());
                        Console.WriteLine("Enter Movie Title:");
                        string titel = Console.ReadLine();
                        Console.WriteLine("Enter Movie Director:");
                        string director = Console.ReadLine();
                        Console.WriteLine("Enter Movie rental price:");
                        string rentalprice = Console.ReadLine();
                        movieManager.CreateMovie(MovieId,titel,director,rentalprice);   

                        break;
                    case 2:
                        movieManager.ReadMovies();
                        break;
                    case 3:
                        Console.WriteLine("Enter Movie Id to update");
                        int UpdateId = int.Parse(Console.ReadLine());
                        Console.WriteLine("Enter Movie newTitle To Update:");
                        string newtitel = Console.ReadLine();
                        Console.WriteLine("Enter Movie newDirector to Update:");
                        string newdirector = Console.ReadLine();
                        Console.WriteLine("Enter Movie rental newRentalprice to Update:");
                        string newrentalprice = Console.ReadLine();

                        movieManager.UpdateMovie(UpdateId,newtitel,newdirector,newrentalprice);
                        break;
                    


                }


            } while (option !=5);



            Console.ReadLine();

        }
    }
}
