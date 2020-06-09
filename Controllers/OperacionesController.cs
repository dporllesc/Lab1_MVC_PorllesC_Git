using Lab1_MVC_PorllesC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Lab1_MVC_PorllesC.Controllers
{
    public class OperacionesController : Controller
    {
        // GET: Operaciones
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult CalcularOperacion()
        {
            ClsOperaciones objOperacion = new ClsOperaciones();

            objOperacion.numero1 = Convert.ToDouble(Request.Form["numero1"]);
            objOperacion.numero2 = Convert.ToDouble(Request.Form["numero2"]);

            objOperacion.tipo = Request.Form["Tipo"];
            
            if(objOperacion.tipo == "S")
            {
                objOperacion.resultado = objOperacion.numero1 + objOperacion.numero2;
            }

            if (objOperacion.tipo == "R")
            {
                objOperacion.resultado = objOperacion.numero1 - objOperacion.numero2;
            }
            if (objOperacion.tipo == "M")
            {
                objOperacion.resultado = objOperacion.numero1 * objOperacion.numero2;
            }

            if (objOperacion.tipo == "D")
            {
                if(objOperacion.numero2 !=0)
                { 
                objOperacion.resultado = objOperacion.numero1 / objOperacion.numero2;
                }
            }


            return View(objOperacion);
        }

    }
}