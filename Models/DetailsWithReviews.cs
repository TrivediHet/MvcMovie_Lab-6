using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MvcMovie.Models
{
    public class DetailsWithReviews
    {
        public Movie TargetMovie { get; set; }
        public List<Review> ReviewList { get; set; }
    }
}
