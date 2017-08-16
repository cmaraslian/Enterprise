using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fiap.HelloWorld.UI.Model
{
    class Balao : Veiculo, IVoador
    {

        //Construtor
        public Balao(string placa) : base(placa)
        {
        }

        //Métodos
        public override void Acelerar()
        {
            Console.WriteLine("Ventando");
        }

        public void Voar()
        {
            Console.WriteLine("Balão voando");
        }
    }
}
