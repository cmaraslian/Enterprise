using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TreinoNAC.Models
{
    public class Funcionario
    {

        public int FuncionarioId { get; set; }

        public string Nome { get; set; }

        public DateTime DataCadastro { get; set; }

        public Departamento Departamento { get; set; }








    }
}