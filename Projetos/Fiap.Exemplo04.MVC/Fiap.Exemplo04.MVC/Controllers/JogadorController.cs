using Fiap.Exemplo04.MVC.Models;
using Fiap.Exemplo04.MVC.Persistencia;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Fiap.Exemplo04.MVC.Controllers
{
    public class JogadorController : Controller
    {

        private FutebolContext _context = new FutebolContext();
       // GET: Jogador
       [HttpGet]
        public ActionResult Cadastrar()
        {
            //Buscar todos os times cadastrados
            var lista = _context.Times.ToList();
            //Passa os valores para o select da tela
            ViewBag.times = new SelectList(lista, "TimeId", "Nome");
            return View();
        }

        [HttpPost]
        public ActionResult Cadastrar(Jogador jogador)
        {
            _context.Jogadores.Add(jogador);
            _context.SaveChanges();
            TempData["msg"] = "cadastradro!";
            return RedirectToAction("cadastrar");
        }

        public ActionResult Listar()
        {
            return View(_context.Jogadores.Include("Time").ToList());
        }

    }
}