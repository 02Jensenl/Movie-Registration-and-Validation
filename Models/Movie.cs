using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace RegMovie.Models
{
    public class Movie
    {
        [Range(1, 1000)]
        public int ID { get; set; }


        [Required]
        [StringLength(50, MinimumLength = 1, ErrorMessage = "Length of the title should be under 50 characters")]
        public string Title { get; set; }


        [Required (ErrorMessage = "Must pick a genre")]
        public string Genre { get; set; }

        [Range(1880, 2020, ErrorMessage = "Value must be between 1880 and 2020")]
        public int Year { get; set; }
        
        [Required]
        public List<string> Actors { get; set; }

        [Required]
        public List<string> Director { get; set; }
    }
}
