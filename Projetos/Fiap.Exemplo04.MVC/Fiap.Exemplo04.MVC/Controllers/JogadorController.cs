using Fiap.Exemplo04.MVC.Models;
using Fiap.Exemplo04.MVC.Persistencia;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Fiap.Exemplo04.MVC.Units;

namespace Fiap.Exemplo04.MVC.Controllers
{
    public class JogadorController : Controller
    {

     
        private UnitOfWork _unit = new UnitOfWork();

        [HttpGet]
        public ActionResult Listar()
        {
            return View(_unit.JogadorRepository.Listar());
        }

        [HttpGet]
        public ActionResult Cadastrar()
        {
            //Buscar todos os times cadastrados
            var lista = _unit.TimeRepository.Listar();
            //Passa os valores para o select da tela
            ViewBag.times = new SelectList(lista, "TimeId", "Nome");
            return View();
        }

        [HttpPost]
        public ActionResult Cadastrar(Jogador jogador)
        {

            if (ModelState.IsValid)
            {
                _unit.JogadorRepository.Cadastrar(jogador);
                _unit.Save();
                TempData["msg"] = "Jogador Cadastrado!";
                return RedirectToAction("Cadastrar");
            }
            else
            {
                var lista = _unit.TimeRepository.Listar();
                ViewBag.times = new SelectList(lista, "TimeId", "Nome");
                return View(jogador);
            }
        }

        protected override void Dispose(bool disposing)
        {
            _unit.Dispose();
            base.Dispose(disposing);
        }
    }
}