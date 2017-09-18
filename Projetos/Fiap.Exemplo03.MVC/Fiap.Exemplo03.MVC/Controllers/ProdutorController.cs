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
    public class ProdutorController : Controller
    {

        private SacolaoContext _context = new SacolaoContext();
        
        // GET: Produtor
        [HttpGet]
        public ActionResult Cadastrar()
        {   
            return View();
        }

        [HttpPost]
        public ActionResult Cadastrar(Produtor produtor)
        {
            produtor.DataCadastro = DateTime.Now;
            _context.Produtores.Add(produtor);
            _context.SaveChanges();
            TempData["msg"] = "Cadastrado";
            return RedirectToAction("Cadastrar");
        }

        public ActionResult Listar()
        {   
            return View(_context.Produtores.ToList());
        }

        [HttpGet]
        public ActionResult Alterar(int id)
        {
            return View(_context.Produtores.Find(id));
        }

        [HttpPost]
        public ActionResult Alterar(Produtor produtor)
        {
            _context.Entry(produtor).State = EntityState.Modified;
            _context.SaveChanges();
            TempData["msg"] = "Atualizado!";
            return RedirectToAction("Listar");
        }

        public ActionResult Excluir(int id)
        {
            _context.Produtores.Remove(_context.Produtores.Find(id));
            _context.SaveChanges();
            TempData["msg"] = "Excluido!";
            return RedirectToAction("Listar");
            
        }

    }
}