using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using Futbapp.Models;

namespace Futbapp.Controllers
{
    public class UsuarioController : Controller
    {
        private FutbappContext FutbappDB = new FutbappContext();
        public ActionResult MiPerfil()
        {
            Usuario usuario = (Usuario)Session["UsuarioLogeado"];
            Ubicacion ubicacion = FutbappDB.Ubicaciones.FirstOrDefault(u => u.Id == usuario.Ubicacion.Id);
            Equipo equipo = FutbappDB.Equipos.FirstOrDefault(u => u.NombreDeEquipo == usuario.Equipo.NombreDeEquipo);
            ViewBag.Ubicacion = ubicacion;
            ViewBag.Equipo = equipo;

            return View(usuario);
        }

        // GET: Usuario
        public ActionResult Index()
        {
            return View(FutbappDB.Usuarios.ToList());
        }
    }
}
