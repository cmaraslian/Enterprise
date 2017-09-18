using Fiap.Exemplo03.MVC.Models;
using Fiap.Exemplo03.MVC.Persistencia;
using System;
using System.Collections.Generic;
using System.Data.Entity;
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

        public ActionResult Listar()
        {   
            return View(_context.Frutas.ToList());
        }

        [HttpGet]
        public ActionResult Alterar(int id)
        {
            return View(_context.Frutas.Find(id));
        }

        [HttpPost]
        public ActionResult Alterar(Fruta fruta)
        {
            _context.Entry(fruta).State = EntityState.Modified;
            _context.SaveChanges();
            TempData["msg"] = "Atualizado!";
            return RedirectToAction("Listar");
        }

        public ActionResult Excluir(int id)
        {
            _context.Frutas.Remove(_context.Frutas.Find(id));
            _context.SaveChanges();
            TempData["msg"] = "Excluido!";
            return RedirectToAction("listar");
            
        }

    }
}