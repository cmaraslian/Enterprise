using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;
using System.Web;
using TreinoNAC.Context;
using TreinoNAC.Models;

namespace TreinoNAC.Repositories
{
    public class FuncionarioRepository : IFuncionarioRepository
    {

        private EscritorioContext _context;

        public FuncionarioRepository(EscritorioContext context)
        {
            _context = context;
        }


        public void Alterar(Funcionario funcionario)
        {
            _context.Entry(funcionario).State = EntityState.Modified;
           
        }

        public Funcionario Buscar(int id)
        {
            return  _context.Funcionarios.Find(id);
        }

        public List<Funcionario> BuscarPor(Expression<Func<Funcionario, bool>> filtro)
        {
            return _context.Funcionarios.Include("Departamento").Where(filtro).ToList();
        }

        public void Cadastrar(Funcionario funcionario)
        {
            _context.Funcionarios.Add(funcionario);
        }

        public void Excluir(int id)
        {
            _context.Funcionarios.Remove(_context.Funcionarios.Find(id));
           
        }

        public List<Funcionario> Listar()
        {
            return _context.Funcionarios.ToList();
        }
    }
}