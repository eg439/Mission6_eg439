using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Mission6_eg439.Models
{
    public class Category
    {
        [Key]
        [Required(ErrorMessage = "Please select a Category!!")]
        public int CategoryId { get; set; }
        public string CategoryName { get; set; }
    }
}
