using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using TreinoNAC.Models;

namespace TreinoNAC.Context
{
    public class EscritorioContext : DbContext
    {

        public DbSet <Departamento> Departamentos  { get; set; }

        public DbSet<Funcionario> Funcionarios { get; set; }

    }
}