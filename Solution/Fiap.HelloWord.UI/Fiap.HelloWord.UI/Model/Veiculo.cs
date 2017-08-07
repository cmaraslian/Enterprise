using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fiap.HelloWord.UI.Model
{
    abstract class Veiculo
    {

        private string _placa;

        public string Placa
        {
            get { return _placa; }
            set { _placa = value; }
        }

        //Construtor 
        public Veiculo(string placa)
        {
            _placa = placa;
        }

        //Propriedade
        public Cambio Cambio { get; set; }



        public abstract void Acelerar();

        //virtual --> permite a sobrescrita do método
        public virtual void Frear()
        {
            Console.WriteLine("Veiculo");
        }

    }
}
