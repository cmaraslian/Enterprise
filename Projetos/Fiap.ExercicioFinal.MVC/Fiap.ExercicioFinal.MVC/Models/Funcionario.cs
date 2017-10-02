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
        [StringLength(100,ErrorMessage ="Valor máximo de 100 caracteres")]
        public string Nome { get; set; }

        [Required]
        [Display(Name ="Salário")]
        public double Salario { get; set; }

        [Required]
        [Display(Name ="Data de admissão")]
        public DateTime DataAdmissao { get; set; }
               
        public Empresa Empresa { get; set; }

        public int EmpresaId { get; set; }


    }
}