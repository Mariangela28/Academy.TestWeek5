using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Academy.TestWeek5.MVC.Models
{
    public class PiattoViewModel
    {
        public int Id { get; set; }

        [Required, DisplayName("Nome del piatto")]
        public string Nome { get; set; }

        [Required, DisplayName("Descrizione")]
        public string Descrizione { get; set; }

        [Required, DisplayName("Tipologia")]
        public string Tipologia { get; set; }

        [Required, DisplayName("Prezzo")]
        public double Prezzo { get; set; }

    }
}
