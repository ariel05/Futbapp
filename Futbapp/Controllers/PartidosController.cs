using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Futbapp.Controllers
{
    public class PartidosController : Controller
    {
        // GET: Partidos
        public ActionResult CrearPartidos()
        {
            return View();
        }

        public ActionResult BuscarPartidos()
        {
            return View();
        }
    }
}