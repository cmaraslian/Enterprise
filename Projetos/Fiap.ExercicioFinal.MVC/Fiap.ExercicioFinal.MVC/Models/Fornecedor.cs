using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Fiap.ExercicioFinal.MVC.Models
{
    public class Fornecedor
    {
        public int FornecedorId { get; set; }

        [Required]
        [MaxLength(100,ErrorMessage ="Camanho maixo de 100 caracteres ultrapassado")]
        public string Nome { get; set; }

        [Display(Name ="Data de Cadastro")]
        public DateTime DataCadastro { get; set; }




    }
}