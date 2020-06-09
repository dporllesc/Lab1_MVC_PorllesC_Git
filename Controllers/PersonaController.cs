using Lab1_MVC_PorllesC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Lab1_MVC_PorllesC.Controllers
{
    public class PersonaController : Controller
    {
        ClsPersona objPersona = new ClsPersona();

        // GET: Persona
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult MostarDatos()
        {
            objPersona.apellido = "Porlles Carrillo";
            objPersona.nombre = "Diego";
            objPersona.edad = 22;
            objPersona.peso = 65.78;
            objPersona.sexo = true;

           
            return View(objPersona);
        }
    }
}