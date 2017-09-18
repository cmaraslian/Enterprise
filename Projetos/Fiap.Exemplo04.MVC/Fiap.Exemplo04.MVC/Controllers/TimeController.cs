using Fiap.Exemplo04.MVC.Models;
using Fiap.Exemplo04.MVC.Persistencia;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Fiap.Exemplo04.MVC.Controllers
{
    public class TimeController : Controller
    {
        private FutebolContext _context = new FutebolContext();

        [HttpGet]
        public ActionResult Cadastrar()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Cadastrar(Time time)
        {
            _context.Times.Add(time);
            _context.SaveChanges();
            TempData["msg"] = "Cadastrado!";
            return RedirectToAction("Cadastrar");
        }
        [HttpGet]
        public ActionResult Listar()
        {
            //Faz incluir o time e o tecnico para nao dar nullpointer
            return View(_context.Times.Include("Tenico").ToList());
        }

    }

}