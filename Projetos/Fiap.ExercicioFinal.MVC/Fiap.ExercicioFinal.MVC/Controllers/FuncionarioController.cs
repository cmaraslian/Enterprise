using Fiap.ExercicioFinal.MVC.Models;
using Fiap.ExercicioFinal.MVC.Units;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Fiap.ExercicioFinal.MVC.Controllers
{
    public class FuncionarioController : Controller
    {

        private UnitOfWork _unit = new UnitOfWork();

        [HttpGet]
        public ActionResult Listar()
        {
            return View(_unit.FuncionarioRepository.Listar());
        }


        protected override void Dispose(bool disposing)
        {
            _unit.Dispose();
            base.Dispose(disposing);
        }

        [HttpGet]
        public ActionResult Cadastrar()
        {
            ViewBag.empresas = new SelectList(_unit.EmpresaRepository.Listar(), "EmpresaId", "RazaoSocial");
            return View();
        }

        [HttpPost]
        public ActionResult Cadastrar(Funcionario funcionario)
        {

            if (ModelState.IsValid)
            {
                _unit.FuncionarioRepository.Cadastrar(funcionario);
                _unit.Salvar();
                TempData["msg"] = "Cadastrado";
                return RedirectToAction("cadastrar");
            }
            else {
                ViewBag.empresas = new SelectList(_unit.EmpresaRepository.Listar(), "EmpresaId", "RazaoSocial");
                return View(funcionario);
            }
            
        }

    }
}