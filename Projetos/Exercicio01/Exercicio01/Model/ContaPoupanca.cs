using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fiap.Banco.Model
{
    class ContaPoupanca : Conta, IContaInvestimento
    {

        Decimal taxa { get; set; }

        private readonly string _rendimento;
        


        public decimal CalculaRetornoInvestimento()
        {
            throw new NotImplementedException();
        }
    }
}
