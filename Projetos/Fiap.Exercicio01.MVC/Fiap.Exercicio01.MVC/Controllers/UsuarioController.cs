using Fiap.Exercicio01.MVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Fiap.Exercicio01.MVC.Controllers
{
    public class UsuarioController : Controller
    {
        // GET: Usuario
        [HttpGet]
        public ActionResult Abrir()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Salvar(Usuario usuario)
        {
            TempData["msg"]  = "Sucesso!";
            return View(usuario); //usando o tipado

        }
    }
}