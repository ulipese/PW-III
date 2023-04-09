using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ExeFelipeEMassagliI.Controllers
{
    public class AulaController : Controller
    {
        // GET: Aula
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult Check()
        {
            TempData["Aluno"] = "O MVC é um padrão de desenvolvimento muito utilizado no mundo web conhecido por 'forçar' o programador a separar as responsabilidades.";
            return RedirectToAction("Aluno");
        }
        public ActionResult Aluno()
        {
            ViewData["Alu"] = "Aluno";
            ViewBag.Aluno = "Os melhores alunos são aqueles que estudam mais!";
            if (TempData["Aluno"] != null)
            {
                ViewData["AlunoCheck"] = TempData["Aluno"];
            } 
            
            return View();
        }
        public ActionResult RedirectGoogle()
        {
            return Redirect("https://google.com");
        }

    }
}