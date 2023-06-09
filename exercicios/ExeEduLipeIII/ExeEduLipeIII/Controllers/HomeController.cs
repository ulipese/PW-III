﻿using ExeEduLipeIII.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ExeEduLipeIII.Controllers
{
    public class HomeController : Controller
    {
        
        public ActionResult Inicio()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
        public ActionResult Nota()
        {
            return View();
        }
        public ActionResult CalculaNota(int Erros)
        {
            if (Erros >= 0)
            {
                Nota nota = new Nota();
                nota.NotaAluno = 10 - Erros;
                return View(nota);
            } else
            {
                return RedirectToAction("Nota");
            }
        }

    }
}