using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieRentalManagementSystem
{
    public class DVDMovie : Movie
    {
        public decimal DiscWeight {  get; set; }
        public int Duration { get; set; }

        public DVDMovie(decimal discWeight, int duration) : base(movieId, title, director, rentalPrice)
        {
            DiscWeight = discWeight;
            Duration = duration;
        }

        public override string DisplayMovieInfo(discWeight,duration,movieId) : base(movieId, title, director, rentalPrice))
        {
            return base.DisplayMoviInfo()+ $"DiscWeight:{DiscWeight},Duration:{Duration}";
        }


    }
}
