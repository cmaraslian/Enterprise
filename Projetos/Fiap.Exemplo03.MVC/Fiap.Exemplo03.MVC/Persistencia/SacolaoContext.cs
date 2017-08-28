using Fiap.Exemplo03.MVC.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Fiap.Exemplo03.MVC.Persistencia
{
    public class SacolaoContext : DbContext
    {
        public DbSet<Fruta> Frutas { get; set; }
    }
}