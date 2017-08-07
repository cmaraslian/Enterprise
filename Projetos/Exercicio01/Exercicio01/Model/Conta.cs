using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fiap.Banco.Model
{
    abstract class Conta
    {
        string Agencia { get; set; }
        DateTime DataAbertura { get; set; }
        private int Numero { get; set; }
        private Decimal Saldo { get; set; }

        public void Depositar(decimal Valor)
        {
            Saldo = Saldo + Valor;
        }
        
        public void Retirar(decimal Valor)
        {
            Saldo = Saldo - Valor;
        }
                      

    }

     

}
