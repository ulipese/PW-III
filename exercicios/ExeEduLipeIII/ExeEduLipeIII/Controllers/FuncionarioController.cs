using ExeEduLipeIII.Models;
using Microsoft.Ajax.Utilities;
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
        [HttpPost]
        public ActionResult SelectFunc(FormCollection funcionario) {
            if (funcionario["Codigo"] == "") {
                TempData["Nome"] = funcionario["Nome"];
                TempData["Funcao"] = funcionario["Funcao"];
                TempData["InputNull"] = "O campo Código deve ser preenchido!";
                return RedirectToAction("Cadastrar");
            } else if (funcionario["Nome"] == "") {
                TempData["Funcao"] = funcionario["Funcao"];
                TempData["InputNull"] = "O campo Nome deve ser preenchido!";
                return RedirectToAction("Cadastrar");
            } else if (funcionario["Funcao"] == "") {
                TempData["Nome"] = funcionario["Nome"];
                TempData["InputNull"] = "O campo Função deve ser preenchido!";
                return RedirectToAction("Cadastrar");
            } else {
                ViewBag.Codigo = funcionario["Codigo"];
                ViewBag.Nome = funcionario["Nome"];
                ViewBag.Funcao = funcionario["Funcao"];
                return View();
            }

        }
    }
}