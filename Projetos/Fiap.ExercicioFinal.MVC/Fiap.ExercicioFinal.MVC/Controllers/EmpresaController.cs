using Fiap.ExercicioFinal.MVC.Models;
using Fiap.ExercicioFinal.MVC.Units;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Fiap.ExercicioFinal.MVC.Controllers
{
    public class EmpresaController : Controller

    {
        private UnitOfWork _unit = new UnitOfWork();

        protected override void Dispose(bool disposing)
        {
            _unit.Dispose();
            base.Dispose(disposing);
        }

        [HttpGet]
        public ActionResult Cadastrar()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Cadastrar(Empresa empresa)
        {
            if (ModelState.IsValid)
            {
                _unit.EmpresaRepository.cadastrar(empresa);
                _unit.Salvar();
                TempData["msg"] = "Cadastrado!";
                return RedirectToAction("Cadastrar");
            }
            else
            { 
                return View(empresa);
            }
        }

        public ActionResult Listar()
        {
            return View();
        }

    }
}