using Fiap.Exercicio01.MVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Fiap.Exercicio01.MVC.Controllers
{
    public class CarroController : Controller
    {

        //Simular o banco
        private List<Carro> _lista = new List<Carro>();


      
        [HttpGet] //Abre o forumlario
        public ActionResult Cadastrar()
        {
            return View();
        }

        [HttpPost] //Processa  o forumlario
        public ActionResult Cadastrar(Carro carro)
        {
            _lista.Add(carro);
            TempData["msg"] = "Cadastrado!";
            return View();
        }

        public ActionResult Listar() //mvcaction4 atalho para criar rapido o metodo
        {

            Carro carro = new Carro();
            carro.Descricao = "dasdsa";
            carro.ArCondicionado = true;
            carro.Placa = "ZZZ";
            carro.Valor = 31321;

            _lista.Add(carro);
            
            return View(_lista);
        }


    }
}