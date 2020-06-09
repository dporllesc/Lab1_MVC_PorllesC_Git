using Lab1_MVC_PorllesC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Lab1_MVC_PorllesC.Controllers
{
    public class TablaController : Controller
    {
        // GET: Tabla
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult CalcularTabla(ClsTabla tabla)
        {
            return View(tabla);
        }
        public ActionResult MostrarTabla()
        {
            return View();
        }
    }
}