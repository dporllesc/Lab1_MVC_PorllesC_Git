using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Lab1_MVC_PorllesC.Controllers
{
    public class DatosController : Controller
    {
        // GET: Datos
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult VerDatos()
        {
            ViewBag.Curso = "Desarrollo de Aplicaciones Web II";
            ViewBag.Ciclo = 8;

            ViewData["Docente"] = "Enrique Lanchipa Valencia";
            ViewData["Estudiante"] = 20;
            ViewData["FechaHora"] = DateTime.Now.ToString();

            return View();
        }
    }
}