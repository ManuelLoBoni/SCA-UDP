using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SistemaWeb_Laboratorios.Controllers
{
    public class AccesosController : Controller
    {
        // GET: Accesos
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Registrar()
        {
            return View();
        }
    }
}