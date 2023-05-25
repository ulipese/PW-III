using ExeEduLipeIII.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ExeEduLipeIII.Controllers
{
    public class FuncionarioController : Controller
    {
        // GET: Funcionario
        public ActionResult Index()
        {
            

            return View();
        }

        public ActionResult Cadastrar() {
            Funcionario funcionario= new Funcionario();

            return View(funcionario);
        }

        public ActionResult SelectFunc(int Codigo, string Nome, string Funcao) {
            ViewBag.Codigo = Codigo;
            ViewBag.Nome = Nome;
            ViewBag.Funcao = Funcao;

            return View();
        }
    }
}