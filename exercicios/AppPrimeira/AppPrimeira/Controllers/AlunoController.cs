using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AppPrimeira.Controllers
{
    public class AlunoController : Controller
    {
        // GET: Aluno
        public ActionResult Index()
        {
            ViewBag.Primeira = "Alunos MB";
            ViewData["Pri"] = "Escola técnica";
            return View();
        }
        public ActionResult Teste()
        {
            TempData["Exemplo"] = "Mensagem do TempData";
            return RedirectToAction("Resultado");
        }
        public ActionResult Resultado()
        {
            if (TempData["Exemplo"] != null)
            {
                ViewBag.Exemplo2 = "Alunos MB";
            }
            return View();
        }
        public ActionResult Redirecionamento()
        {
            return RedirectToAction("Resultado", "Aluno");
        }
    }
}