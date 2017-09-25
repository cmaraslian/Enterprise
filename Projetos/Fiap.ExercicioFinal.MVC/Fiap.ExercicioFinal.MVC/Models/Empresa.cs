using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Fiap.ExercicioFinal.MVC.Models
{
    public class Empresa
    {

        public int EmpresaId { get; set; }

        [Required]
        public string CNPJ { get; set; }

        [Required]
        public string RazaoSocial { get; set; }

        public ICollection<Funcionario> funcionarios  { get; set; }
        

    }
}