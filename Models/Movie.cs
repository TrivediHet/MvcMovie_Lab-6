using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace MvcMovie.Models
{
    public class Movie
    {
        public int ID { get; set; }

        [StringLength(60, MinimumLength = 3, ErrorMessage = "Make sure that the title is between 3 and 60 characters")]
        [Required(ErrorMessage = "Please enter the movie title")]
        public string Title { get; set; }

        [Display(Name = "Release Date")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:MMM dd, yyyy}", ApplyFormatInEditMode = true)]
        public DateTime ReleaseDate { get; set; }

        [Range(1, 100)]
        [DataType(DataType.Currency)]
        public decimal Price { get; set; }

        [RegularExpression(@"^[A-Z]+[a-zA-Z""'\s-]*$")]
        [Required(ErrorMessage = "Please enter the movie genre")]
        [StringLength(30)]
        public string Genre { get; set; }
        
        [Required(ErrorMessage = "Please select the appropriate movie rating")]
        public string Rating { get; set; }

        public List<Review> ReviewList { get; set; }
    }
}
