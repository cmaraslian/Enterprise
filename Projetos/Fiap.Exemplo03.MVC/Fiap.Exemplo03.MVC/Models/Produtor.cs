using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Fiap.Exemplo03.MVC.Models
{
    public class Produtor
    {

        public int Id { get; set; }

        [Required]
        [StringLength(100,MinimumLength=3)]
        public string Nome { get; set; }


        public bool Certificado { get; set; }

        [Display(Name = "Orgânico")]
        public DateTime DataCadastro { get; set; }

        public decimal Limite { get; set; }

    }
}