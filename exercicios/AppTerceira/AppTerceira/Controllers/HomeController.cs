using AppTerceira.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AppTerceira.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            Fisica pf = new Fisica()
            {
                Id = 2,
                Nome = "Roberta",
                Sexo = 'F',
                CPF = 12345678911,
                RG = 12345678,
                Dig_RG = '9'
            };

            ViewData["Id"] = pf.Id;
            ViewData["Nome"] = pf.Nome;
            ViewData["Sexo"] = pf.Sexo;
            ViewData["CPF"] = pf.CPF;
            ViewData["RG"] = pf.RG;
            ViewData["Dig_RG"] = pf.Dig_RG;


            return View(pf);
        }

        public ActionResult About()
        {
            Pessoa pessoa = new Pessoa();

            pessoa.Id = 12;
            pessoa.Nome = "Enildo";
            pessoa.Sexo = 'M';

            ViewBag.Id = pessoa.Id;
            ViewBag.Nome = pessoa.Nome;
            ViewBag.Sexo = pessoa.Sexo;

            return View(pessoa);
        }

        public ActionResult Contact()
        {
            Juridica pj = new Juridica();

            pj.Id = 1001;
            pj.Nome = "Fabrica de Gênios";
            pj.Cnpj = 123456789123412;
            pj.IE = 123456789;

            return View(pj);
        }

        public ActionResult ExemploTempData()
        {
            Juridica pj = new Juridica();

            pj.Id = 256;
            pj.Nome = "Desenvolvedores CIA";
            pj.Cnpj = 123456789188888;
            pj.IE = 123456789;

            TempData["Id"] = pj.Id;
            TempData["Nome"] = pj.Nome;
            TempData["Cnpj"] = pj.Cnpj;
            TempData["IE"] = pj.IE;

            return RedirectToAction("Contact");
        }

        public ActionResult Pessoa()
        {
            Pessoa objPessoa = new Pessoa();
            return View(objPessoa);
        }
        [HttpPost]
        public ActionResult ConsultaPessoa(int Id, string Nome, char Sexo)
        {
            ViewBag.Id = Id;
            ViewBag.Nome = Nome;
            ViewBag.Sexo = Sexo;

            return View();
        }
    }
}