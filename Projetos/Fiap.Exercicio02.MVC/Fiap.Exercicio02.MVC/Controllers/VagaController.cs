using Fiap.Exercicio02.MVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Fiap.Exercicio02.MVC.Controllers
{
    public class VagaController : Controller
    {

        private static List<Vaga> _banco = new List<Vaga>();


        [HttpGet]
        public ActionResult cadastrar()
        {
            PopulaComboNiveis();

            return View();
        }

        private void PopulaComboNiveis()
        {
            List<string> niveis = new List<string>();
            niveis.Add("Junior");
            niveis.Add("Pleno");
            niveis.Add("Senior");
            ViewBag.opcoes = new SelectList(niveis);
        }

        //mvcaction4

        [HttpPost]
        public ActionResult cadastrar(Vaga vaga)
        {
            PopulaComboNiveis();
            TempData["msg"] = "Cadastrado!";
            _banco.Add(vaga);
            return View();
        }

        public ActionResult Listar()

        {
            return View(_banco);
        }

    }
}