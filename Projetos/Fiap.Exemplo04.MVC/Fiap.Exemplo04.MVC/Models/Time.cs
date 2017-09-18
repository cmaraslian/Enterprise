using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Fiap.Exemplo04.MVC.Models
{
    public class Time
    {
        public int TimeId { get; set; }
        public string Nome { get; set; }
        [Display(Name ="Data de Fundação")]
        public DateTime DataFundacao { get; set; }

        //Relacionamentos
        public Tecnico Tecnico { get; set; }
        public int TecnicoId { get; set; }

        public List<Jogador> Jogadores { get; set; }

        public List<Campeonato> Campeonatos { get; set; }
    }
}