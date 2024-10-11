using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieRentalManagementSystem
{
    public class MovieManager
    {
        List<Movie> movies = new List<Movie>();

        public void CreateMovie(string movieId, string title, string director, string rentalPrice)
        {
            movies.Add(new Movie(movieId,title,director,rentalPrice));
            Console.WriteLine("Movie added successfully");
        }

        public void ReadMovies()
        {
            if (movies.Count == 0)
            {
                Console.WriteLine("No movies Available");
            }
            Console.WriteLine("List of Movies:");
            foreach (var movie in movies)
            {
                Console.WriteLine(movie);
            }
        }

        public void UpdateMovie(string movieId, string title, string director, string rentalPrice)
        {
            Console.WriteLine("Enter Update movieId");
            if (!movies.movieId.(Console.ReadLine().FirstOrDefault(m => movieId == movieId)))
            {
                movies.movieId = movieId;
                movies.title = title;
                movies.director = director;
                movies.rentalPrice = rentalPrice;
                return;
            }
            return;

        }

        public void DeleteMovie(string deleteId)
        {
            int deleteId = int.Parse(Console.ReadLine());
            if (deleteId != null)
            {
                movies.Remove(deleteId);
                Console.WriteLine("Successfully movie delete");
            }
        }

        public void ValidateMovieRentalPrice(decimal Price)
        {
            do 
            {
               if(Price <= 0)
                {
                    Console.WriteLine("Please enter positive Number");
                }

            } 
            while (Price > 0);
            Console.WriteLine(Price);
        }
    }
}
