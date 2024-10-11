using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieRentalManagementSystem
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //var manager = new MovieManager();
            //int option = 0;

            //do
            //{
            //    Console.WriteLine("\n Movie Rental Management System:");
            //    Console.WriteLine("1. Add a Movie");
            //    Console.WriteLine("2. View All Movies");
            //    Console.WriteLine("3. Update a Movie");
            //    Console.WriteLine("4. Delete a Movie");
            //    Console.WriteLine("5. Exit");
            //    Console.Write("Choose an option:");

            //    switch (option)
            //    {
            //        case 1:
            //            Console.Write("Enter movieId");
            //            string movieId = Console.ReadLine();
            //            Console.Write("Enter Movie Title");
            //            string title = Console.ReadLine();
            //            Console.Write("Enter Movie Director");
            //            string director = Console.ReadLine();
            //            Console.Write("Enter Movie rentalPrice");
            //            string rentalPrice = Console.ReadLine();
            //            manager.CreateMovie(movieId, title, director, rentalPrice);
            //            Console.WriteLine("Movie added Successfully");
            //            break;
            //        case 2:
            //            manager.ReadMovies();
            //            break;
            //        case 3:
            //            Console.Write("Enter movieId to Update:");
            //            string newmovieId = Console.ReadLine();
            //            Console.Write("Enter new Title");
            //            string newtitle = Console.ReadLine();
            //            Console.Write("Enter new Director");
            //            string newdirector = Console.ReadLine();
            //            Console.Write("Enter new  rentalPrice");
            //            string newrentalPrice = Console.ReadLine();
            //            manager.UpdateMovie(newmovieId, newtitle, newdirector, newrentalPrice);
            //            Console.WriteLine("Movie Updated Successfully");
            //            break;
            //        case 4:
            //            Console.Write("Enter the Movie Id to delete:");
            //            int deleteId = int.Parse(Console.ReadLine());
            //            manager.DeleteMovie(deleteId);
            //            Console.WriteLine("Movie deleted Successfully");
            //            break;
            //        case 5:
            //            Console.WriteLine("");
            //            break;
            //        default:
            //            Console.WriteLine("Invalid Input, choose 1 to 5");
            //            break;

            //    }
            //}
            //while (option != 5);
            var repository = new MovieRepository();
            var manager = new MovieManager();
            int option = 0;

            do
            {
                Console.WriteLine("\n Movie Rental Management System:");
                Console.WriteLine("1. Add a Movie");
                Console.WriteLine("2. View All Movies");
                Console.WriteLine("3. Update a Movie");
                Console.WriteLine("4. Delete a Movie");
                Console.WriteLine("5. Exit");
                Console.Write("Choose an option:");

                switch (option)
                {
                    case 1:
                        Console.Write("Enter movieId");
                        string movieId = Console.ReadLine();
                        Console.Write("Enter Movie Title");
                        string title = Console.ReadLine();
                        Console.Write("Enter Movie Director");
                        string director = Console.ReadLine();
                        Console.Write("Enter Movie rentalPrice");
                        string rentalPrice = Console.ReadLine();
                        repository.CreateMovie(movieId, title, director, rentalPrice);
                        Console.WriteLine("Movie added Successfully");
                        break;

                    case 2:
                        repository.ReadMovies();
                        break;

                    case 3:
                        Console.Write("Enter movieId to Update:");
                        string newmovieId = Console.ReadLine();
                        Console.Write("Enter new Title");
                        string newtitle = Console.ReadLine();
                        Console.Write("Enter new Director");
                        string newdirector = Console.ReadLine();
                        Console.Write("Enter new  rentalPrice");
                        string newrentalPrice = Console.ReadLine();
                        repository.UpdateMovie(newmovieId, newtitle, newdirector, newrentalPrice);
                        Console.WriteLine("Movie Updated Successfully");
                        break;

                    case 4:
                        Console.Write("Enter the Movie Id to delete:");
                        int movieId = int.Parse(Console.ReadLine());
                        repository.DeleteMovie(movieId);
                        Console.WriteLine("Movie deleted Successfully");
                        break;

                    case 5:
                        Console.WriteLine("Exit");
                        break;
                    default:
                        Console.WriteLine("Invalid Input, choose 1 to 5");
                        break;

                }
            }
            while (option != 5);
        }
    }
}
