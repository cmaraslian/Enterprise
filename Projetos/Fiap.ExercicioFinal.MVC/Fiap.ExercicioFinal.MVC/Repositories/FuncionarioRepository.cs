using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Web;
using Fiap.ExercicioFinal.MVC.Models;
using Fiap.ExercicioFinal.MVC.Persistencia;
using System.Data.Entity;

namespace Fiap.ExercicioFinal.MVC.Repositories
{
    public class FuncionarioRepository : IFuncionarioRepository
    {
        private EmpresarialContext _context;
        //Colocar o connection strings no web.config e alterar o nome da conexao.
                        
        public FuncionarioRepository(EmpresarialContext context)
        {
            _context = context;
        } 

        public void Alterar(Funcionario funcionario)
        {
            _context.Entry(funcionario).State = EntityState.Modified;
        }

        public Funcionario Buscar(int id)
        {
            return _context.Funcionarios.Find(id);
        }

        public List<Funcionario> BuscarPor(Expression<Func<Funcionario, bool>> filtro)
        {
            //O include traz a Empresa do relacionamento no resultado.
            return _context.Funcionarios.Include("Empresa").Where(filtro).ToList();

        }

        public void Cadastrar(Funcionario funcionario)
        {
            _context.Funcionarios.Add(funcionario);
            _context.SaveChanges();
        }

        public List<Funcionario> Listar()
        {
            return _context.Funcionarios.Include("Empresa").ToList();
        }

        public void Remover(int id)
        {
            var func = Buscar(id);
            _context.Funcionarios.Remove(func);
        }
    }
}