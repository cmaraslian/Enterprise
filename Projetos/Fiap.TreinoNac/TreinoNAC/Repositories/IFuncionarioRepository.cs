using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using TreinoNAC.Models;

namespace TreinoNAC.Repositories
{

    //Colocar a interface como public **** NAO ESQUECER ****
    public interface IFuncionarioRepository
    {
        void Cadastrar(Funcionario funcionario);
        void Alterar(Funcionario funcionario);
        void Excluir(int id);
        List<Funcionario> Listar();
        Funcionario Buscar(int id);
        List<Funcionario> BuscarPor(Expression<Func<Funcionario,bool>>filtro);

    }
}
