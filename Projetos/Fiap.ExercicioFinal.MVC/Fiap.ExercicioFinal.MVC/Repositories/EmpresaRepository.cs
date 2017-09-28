using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Fiap.ExercicioFinal.MVC.Models;
using Fiap.ExercicioFinal.MVC.Persistencia;

namespace Fiap.ExercicioFinal.MVC.Repositories
{
    public class EmpresaRepository : IEmpresaRepository
    {

        private EmpresarialContext _context;

        public EmpresaRepository(EmpresarialContext context)
        {
            _context = context;
        }

        
        public void cadastrar(Empresa empresa)
        {
            _context.Empresas.Add(empresa);
            _context.SaveChanges();   
        }

        public List<Empresa> Listar()
        {
            return _context.Empresas.ToList();
        }
    }
}