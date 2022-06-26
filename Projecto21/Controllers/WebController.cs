using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Projecto21.Funciones;
using Projecto21.Models;
namespace Projecto21.Controllers
{
    public class WebController : Controller
    {
        // GET: Web
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult Formulario()
        {
            return View();
        }
        public ActionResult GuardarDatos(Visitante Data)
        {
            Misfunciones Operacion = new Misfunciones();
            Operacion.Escribir(Data);
            return View();
        }
    }
}