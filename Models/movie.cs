using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;  //validations namespace


namespace mvc_examples.Models
{
    public class movie
    {
        [Required]
        [Display(Name = "Movie ID")]
        public int id { get; set; }

        [Required]
        public string Title { get; set; }

        [Required]
        [DataType(DataType.Date)]
        public DateTime ReleaseDate { get; set; }

        [Required]
        public string Genre { get; set; }

        [Required]
        [Range(100,350)]
        [DataType(DataType.Currency)]
        public decimal price{ get; set; }

        [Required]
        [StringLength(5)]
        public string rating { get; set; }
        
    }
}