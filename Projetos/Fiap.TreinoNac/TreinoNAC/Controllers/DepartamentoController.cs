using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TreinoNAC.Models;
using TreinoNAC.Units;

namespace TreinoNAC.Controllers
{
    public class DepartamentoController : Controller
    {

        UnitOfWork _unit = new UnitOfWork();
        

        [HttpGet]
        public ActionResult Cadastrar()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Cadastrar(Departamento departamento)
        {

            if (ModelState.IsValid)
            {
                _unit.DepartamentoRepository.cadastrar(departamento);
                _unit.Salvar();
                TempData["msg"] = "Cadastrado!";
                return RedirectToAction("Cadastrar");
            }
            else
            {
                return View(departamento);
            }
        }

        public ActionResult Listar()
        {
            return View(_unit.DepartamentoRepository.Listar());
        }



    }
}