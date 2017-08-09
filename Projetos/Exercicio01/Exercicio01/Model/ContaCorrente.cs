using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Fiap.Banco.Model
{
    sealed class ContaCorrente : Conta
    {
        public Tipo tipo { get; set; }

        public override void Depositar(decimal valor)
        {
            this.saldo = this.saldo + valor;
        }

        public override void Retirar(decimal valor)
        {
            if (tipo.Equals(Tipo.Comum) && this.saldo - valor < 0)
            {
                throw new ArgumentException("Saldo insuficiente");
            }
            else
            {
                this.saldo = this.saldo - valor;
            }

        }
    }

    

}
