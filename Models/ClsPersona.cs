using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Lab1_MVC_PorllesC.Models;

namespace Lab1_MVC_PorllesC.Models
{
    public class ClsPersona
    {
        public string apellido { get; set; }
        public string nombre { get; set; }
        public int edad { get; set; }
        public double peso { get; set; }
        public bool sexo { get; set; }
    }
}