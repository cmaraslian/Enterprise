using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fiap.HelloWorld.UI.Model
{
    class Carro : Veiculo
    {
        //Propriedade
        public int Porta { get; set; }

        //Construtor
        public Carro(string placa):base(placa)
        {
            
        }

        //Método
        public override void Acelerar()
        {
            Console.WriteLine("Carro Acelerando");
        }
    }
}
