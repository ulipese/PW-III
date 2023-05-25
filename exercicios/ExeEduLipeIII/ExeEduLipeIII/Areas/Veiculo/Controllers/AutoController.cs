using ExeEduLipeIII.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ExeEduLipeIII.Areas.Veiculo.Controllers
{
    public class AutoController : Controller
    {
        // GET: Veiculo/Auto
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Moto ()
        {
            Moto moto = new Moto();
            moto.Categoria = "Sport";
            moto.Cilindrada = 998;

            ViewBag.MotoInfo = $"Ducati / {moto.Categoria} / {moto.Cilindrada} cc / Automática";
  

            return View();
        }
        public ActionResult Carro() {
            Carro carro = new Carro();
            carro.Nome = "Camaro";
            carro.Tipo = "Coupe";
            carro.Fabricante = "Chevrolet";

            ViewBag.CarroInfo = $"{carro.Fabricante} / {carro.Tipo} / {carro.Nome} / Automática";
            

            return View();
        }
        public ActionResult Veiculo() {
            Carro carro = new Carro();
            carro.Nome = "Camaro";
            carro.Tipo = "Coupe";
            carro.Fabricante = "Chevrolet";

            Moto moto = new Moto();
            moto.Categoria = "Sport";
            moto.Cilindrada = 998;

            ViewBag.MotoInfo = $"Ducati / {moto.Categoria} / {moto.Cilindrada} cc / Automática";

            return View(carro);
        }
    }
}