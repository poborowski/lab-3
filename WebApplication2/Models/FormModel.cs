using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication2.Models
{
    public class FormModel
    {
        [Required]
        [Display(Name = "Podaj imię")]

        public string Name { get; set; }

        [Display(Name = "Podaj ilość powtórzeń")]
        [Range(1, 5)]
        public int Repeat { get; set; }

    }
}

