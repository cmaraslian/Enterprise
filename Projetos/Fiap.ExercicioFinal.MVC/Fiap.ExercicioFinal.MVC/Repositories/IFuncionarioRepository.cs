using Fiap.ExercicioFinal.MVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Fiap.ExercicioFinal.MVC.Repositories
{

    //Alterar para publico
    public interface IFuncionarioRepository
    {

        //Cuidado, o metodo comeca com a letra maiuscula
        void Cadastrar(Funcionario funcionario);
        void Alterar(Funcionario funcionario);
        void Remover(int id);
        List<Funcionario> Listar();
        List<Funcionario> BuscarPor(Expression<Func<Funcionario,bool>>filtro); //Entender, Treinar, Decorar
        Funcionario Buscar(int id);
        
    }
}
