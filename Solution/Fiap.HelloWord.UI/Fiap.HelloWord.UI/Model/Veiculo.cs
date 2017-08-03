using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fiap.HelloWord.UI.Model
{
    class Veiculo
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

    }
}
