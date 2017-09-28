using Fiap.ExercicioFinal.MVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fiap.ExercicioFinal.MVC.Repositories
{
    //Alterar a interface para publica
    public interface IEmpresaRepository
    {

        void cadastrar(Empresa empresa);
        List<Empresa> Listar();

    }
}
