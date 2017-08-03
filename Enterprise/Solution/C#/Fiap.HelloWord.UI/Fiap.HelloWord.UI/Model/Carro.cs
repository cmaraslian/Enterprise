using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fiap.HelloWord.UI.Model
{
    class Carro : Veiculo
    {
        public int Portas { get; set; }


        public Carro(string placa) : base(placa)
        {

        }


    }




}
