using Futbapp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Futbapp.Controllers
{
    public class PartidosController : Controller
    {
        FutbappContext FutbapDB = new FutbappContext();
        public ActionResult IrACrearPartidos(String NombreDeSala)
        {
            Sala sala = FutbapDB.Salas.FirstOrDefault(s => s.Nombre == NombreDeSala);
            Ubicacion ubicacion = FutbapDB.Ubicaciones.FirstOrDefault(u => u.Id == sala.UbicacionID);
            Zona zona = FutbapDB.Zonas.FirstOrDefault(z => z.Id == ubicacion.ZonaID);

            ViewBag.Zona = zona;
            ViewBag.Sala = sala;
            return View();
        }

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