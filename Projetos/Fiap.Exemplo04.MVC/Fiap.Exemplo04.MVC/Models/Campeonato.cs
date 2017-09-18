using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Fiap.Exemplo04.MVC.Models
{
    public class Campeonato
    {
        public int CampeonatoId { get; set; }
        public string Nome { get; set; }
        public decimal Premiacao { get; set; }
        //Relacionamentos
        public List<Time> Times { get; set; }
    }
}