using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Zadanie_lab3.Models
{
    public class FormModel
    {
        [Display(Name = "Imie")]
        [Required]
        public string Name { get; set; }
        [Display(Name = "Liczba powtórzeń")]
        [Required]
        public int Ilosc_powtorzen { get; set; }
    }
}
