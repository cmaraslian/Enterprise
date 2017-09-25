using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Fiap.ExercicioFinal.MVC.Models
{
    public class Funcionario
    {

        public int FuncionarioId { get; set; }

        [Required]
        public string Nome { get; set; }

        [Required]
        public double Salario { get; set; }

        [Required]
        public DateTime DataAdmissao { get; set; }

        [Required]
        public Empresa empresa { get; set; }


    }
}