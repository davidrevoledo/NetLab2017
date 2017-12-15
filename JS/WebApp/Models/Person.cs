using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace WebApp.Models
{
    public class Person
    {
        [Required]
        [MaxLength(50, ErrorMessage = "No Ingrese...")]
        public string Name { get; set; }

        [Required]
        [MaxLength(50, ErrorMessage = "No Ingrese...")]
        public string Surname { get; set; }

        public int Age { get; set; }
    }
}