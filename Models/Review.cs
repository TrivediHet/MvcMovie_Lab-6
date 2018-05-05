using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MvcMovie.Models
{
    public class Review
    {
        public int ID { get; set; }

        [Required]
        public Movie TargetMovie { get; set; }

        [Required]
        public string Reviewer { get; set; }

        [Required]
        public string Comment { get; set; }
    }
}
