using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fiap.Banco.Model
{
    abstract class Conta
    {
        public int agencia { get; set; }
        public DateTime dataAbertura { get; set; }
        public int numero { get; set; }
        public Decimal saldo { get; set; }

        public abstract void Depositar(decimal Valor);

        public abstract void Retirar(decimal Valor);

        public Conta()
        {
                
        }
    }

     

}
