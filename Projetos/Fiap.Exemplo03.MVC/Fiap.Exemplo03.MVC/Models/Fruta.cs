using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Fiap.Exemplo03.MVC.Models
{
    public class Fruta
    {
        public int Id { get; set; }

        [Required]
        [StringLength(100,MinimumLength =3)]
        public string Nome { get; set; }

        public float Calorias { get; set; }

        [Display(Name = "Orgânico")]
        public bool Organico { get; set; }

        public bool Semente { get; set; }

        [Required]
        public DateTime DataCadastro { get; set; }
    }
}