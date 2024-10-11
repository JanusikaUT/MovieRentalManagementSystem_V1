using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieRentalManagementSystem
{
    public class Movie
    {
        private string movieId { get; set; }
        private string title { get; set; }
        private string director { get; set; }
        private string rentalPrice { get; set; }

        public static int TotalMovies {  get; private set; }

        public Movie(string movieId, string title, string director, string rentalPrice)
        {
            movieId = movieId;
            title = title;
            director = director;
            rentalPrice = rentalPrice;
            TotalMovies++;
        }

        public  virtual string DisplayMoviInfo()
        {
            return $"movieId:{movieId},title:{title},director:{director},rentalPrice:{rentalPrice}";
        }

        public override string ToString()
        {
            return DisplayMoviInfo();
        }
    }
}
