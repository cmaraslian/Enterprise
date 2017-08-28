using Fiap.Exemplo03.MVC.Models;
using Fiap.Exemplo03.MVC.Persistencia;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Fiap.Exemplo03.MVC.Controllers
{
    public class FrutaController : Controller
    {
        private SacolaoContext _context = new SacolaoContext();

        [HttpGet]
        public ActionResult Cadastrar()
        {  
            return View();
        }

        [HttpPost]
        public ActionResult Cadastrar(Fruta fruta)
        {
            fruta.DataCadastro = DateTime.Now;
            _context.Frutas.Add(fruta);
            _context.SaveChanges();
            TempData["msg"] = "Cadastrado!";
            //Para nao cadastrar novamente no F5
            return RedirectToAction("Cadastrar");
        }

    }
}