using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Mission6_eg439.Models
{
    public class Movie
    {
        [Key]
        [Required]
        public int MovieId { get; set; }
        public string Title { get; set; }
        public string Year { get; set; }
        public string Director { get; set; }
        public string Rating { get; set; }
        public bool Edited { get; set; }
        public string lentTo { get; set; }
        public string Notes { get; set; }
        //foreign key
        [Required(ErrorMessage ="Please select a Category!!")]
        public int CategoryId { get; set; }
        public Category Category { get; set; }
    }
}
