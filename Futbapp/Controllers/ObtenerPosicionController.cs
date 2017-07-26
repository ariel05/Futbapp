using Futbapp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Futbapp.Controllers
{
    public class ObtenerPosicionController : Controller
    {
        FutbappContext FutbappDB = new FutbappContext();

        // GET: ObtenerPosicion
        public ActionResult ObtenerPosicionDeUsuarios()
        {
            List<Usuario> usuario = FutbappDB.Usuarios.OrderByDescending(a => a.GolesHechos).ToList();

            return View();
        }

        public ActionResult ObtenerPosicionDeEquipos()
        {
            List<Equipo> equipo = FutbappDB.Equipos.OrderByDescending(a => a.Puntos).ToList();
            return View();
        }
    }
}