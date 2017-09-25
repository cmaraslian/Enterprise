using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Fiap.Exemplo04.MVC.Models
{
    public class Jogador
    {
        public int JogadorId { get; set; }

        [Required]
        [StringLength(200,ErrorMessage="Máximo de 200 caracteres")]
        public string Nome { get; set; }
        
        [Required]
        [DataType(DataType.DateTime, ErrorMessage = "Data inválida")]
        public DateTime DataNascimento { get; set; }

        //Relacionamentos
       
        public Time Time { get; set; }
        [Required]
        public int TimeId { get; set; }
    }
}