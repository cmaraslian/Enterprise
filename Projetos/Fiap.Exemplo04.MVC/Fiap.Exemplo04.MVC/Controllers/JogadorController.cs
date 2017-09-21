using Fiap.Exemplo04.MVC.Models;
using Fiap.Exemplo04.MVC.Persistencia;
using Fiap.Exemplo04.MVC.Units;
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

        private UnityOfWork _unit = new UnityOfWork();

        // GET: Jogador
        [HttpGet]
        public ActionResult Cadastrar()
        {
            //Buscar todos os times cadastrados
            var lista = _unit.JogadorRepository.Listar();
            //Passa os valores para o select da tela
            ViewBag.times = new SelectList(lista, "TimeId", "Nome");
            return View();
        }

        [HttpPost]
        public ActionResult Cadastrar(Jogador jogador)
        {
            _unit.JogadorRepository.Cadastrar(jogador);
            _unit.Save();
            TempData["msg"] = "cadastradro!";
            return RedirectToAction("cadastrar");
        }

        public ActionResult Listar()
        {
            //return View(_context.Jogadores.Include("Time").ToList());
        }

        protected override void Dispose(bool disposing)
        {
            _unit.Dispose();
            base.Dispose(disposing);
        }

        
    }
}