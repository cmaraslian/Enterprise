using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TreinoNAC.Models
{
    public class Departamento
    {

        public int  DepartamentoId { get; set; }

        public string Nome { get; set; }

        public List<Funcionario> Funcionarios { get; set; }



    }
}