using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TreinoNAC.Models;
using TreinoNAC.Units;

namespace TreinoNAC.Controllers
{
    public class FuncionarioController : Controller
    {

        UnitOfWork _unit = new UnitOfWork();
        
        [HttpGet]
        public ActionResult Cadastrar()
        {
            var lista = _unit.DepartamentoRepository.Listar();
            ViewBag.departamentos = new SelectList(lista, "DepartamentoID", "Nome");
            return View();
        }

        [HttpPost]
        public ActionResult Cadastrar(Funcionario funcionario)
        {
            if (ModelState.IsValid)
            {
                _unit.FuncionarioRepository.Cadastrar(funcionario);
                _unit.Salvar();
                TempData["msg"] = "Cadastrado!";
                return RedirectToAction("Cadastrar");
            }

            else
            {
                var lista = _unit.DepartamentoRepository.Listar();
                ViewBag.departamentos = new SelectList(lista, "DepartamentoID", "Nome");
                return View(funcionario);

            }

        }
                

        public ActionResult Listar()
        {   
            return View(_unit.FuncionarioRepository.Listar());
        }
    }
}