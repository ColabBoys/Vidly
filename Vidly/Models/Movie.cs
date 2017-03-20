using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Vidly.Models
{
    public class Movie
    {
        //this class is a plain old clr object POCO
        public int Id { get; set;  }
        [Required]
        [StringLength(255)]
        public string Name { get; set; }

        public Genre Genre { get; set; }

        [Display(Name = "Genre")]
        [Required]
        public byte GenreId { get; set; }
        public DateTime DateAdded { get; set; }

        //[SqlDefaultValue(DefaultValue = "getutcdate()")]

        [Display(Name = "Release Date")]
        public DateTime ReleaseDate { get; set; }

        [Display(Name = "Number In Stock")]
        [Range(1, 20, ErrorMessage = "Stock must be between 1 & 20")]
        public byte NumberInStock { get; set; }
    }

    // /movies/random
    // create movies controller with an action called random
}