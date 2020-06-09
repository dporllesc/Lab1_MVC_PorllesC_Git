using Lab1_MVC_PorllesC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Lab1_MVC_PorllesC.Controllers
{
    public class SumaController : Controller
    {
        // GET: Suma
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult CalcularSuma()
        {
            ClsSuma objsuma = new ClsSuma();

            objsuma.a = Convert.ToDouble(Request.Form["Valor1"]);
            objsuma.b = Convert.ToDouble(Request.Form["Valor2"]);

            objsuma.resultado = objsuma.a + objsuma.b;

            return View("CalcularSuma",objsuma);
        }
        public ActionResult MostrarSuma()
        {
            return View();
        }
    }
}