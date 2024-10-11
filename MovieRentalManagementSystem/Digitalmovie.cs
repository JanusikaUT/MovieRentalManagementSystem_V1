using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieRentalManagementSystem
{
    public class Digitalmovie : Movie
    {
        public int FileSize { get; set; }
        public string Format { get; set; }
        public Digitalmovie(string movieId, string title, string director, string rentalPrice) : base(movieId, title, director, rentalPrice)
        {

        }
    }
}
