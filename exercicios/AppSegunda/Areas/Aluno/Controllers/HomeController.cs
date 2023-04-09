using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AppSegunda.Areas.Aluno.Controllers
{
    public class HomeController : Controller
    {
        // GET: Aluno/Home
        public ActionResult Index()
        {
            return View();
        }
    }
}