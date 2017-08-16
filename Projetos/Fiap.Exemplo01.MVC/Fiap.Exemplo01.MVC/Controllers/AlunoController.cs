using Fiap.Exemplo01.MVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Fiap.Exemplo01.MVC.Controllers
{
    public class AlunoController : Controller
    {        
        //Action para abrir o formulário
        [HttpGet]
        public ActionResult Cadastro()
        {
            return View();
        }

        [HttpPost]
        //Action para cadastrar as informações do formulário
        public ActionResult Salvar(Aluno aluno)
        {
            //Passar valores para a tela
            ViewBag.nomeAluno = aluno.Nome;
            ViewBag.dataNascimento = aluno.Data;
            ViewBag.salario = aluno.Salario;
            TempData["mensagem"] = "Aluno registrado!";
            return View(aluno);
            //return Content("Gravou! " + aluno.Nome + "  " 
            //    + aluno.Data + " " + aluno.Salario); //Texto
        }


    }
}