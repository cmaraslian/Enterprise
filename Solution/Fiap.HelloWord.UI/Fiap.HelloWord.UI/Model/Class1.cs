using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fiap.HelloWord.UI.Model
{

    class Balao : Veiculo, IVoador
    {
        public Balao(string placa) : base(placa)
        {
        }

        public override void Acelerar()
        {
            Console.WriteLine("Acelerando...");
        }

        public void Voar()
        {
            Console.WriteLine("Voando...");
        }
    }
}
