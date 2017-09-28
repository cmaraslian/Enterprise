using Fiap.ExercicioFinal.MVC.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;




namespace Fiap.ExercicioFinal.MVC.Persistencia
{
    public class EmpresarialContext : DbContext
        
    {
        public DbSet<Funcionario> Funcionarios { get; set; }

        public DbSet<Empresa> Empresas { get; set; }


    }
}