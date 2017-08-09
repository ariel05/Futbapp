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
            Ubicacion ubicacion = FutbappDB.Ubicaciones.FirstOrDefault(u => u.Id == usuario.UbicacionID);

            //            List<Usuario> user = FutbappDB.Usuarios.Include(u => u.Equipo.NombreDeEquipo == usuario.EquipoID).ToList();
            try
            {
                Equipo equipo = FutbappDB.Equipos.FirstOrDefault(u => u.NombreDeEquipo == usuario.EquipoID);
                List<Usuario> users = FutbappDB.Usuarios.OrderBy(a => a.Apellido).Where(a => a.EquipoID == equipo.NombreDeEquipo).ToList();

                ViewBag.Usuario = users;
                ViewBag.Equipo = equipo;

            }
            catch(System.Reflection.TargetException)
            {
                ViewBag.Usuario = new Usuario();
                ViewBag.Equipo = new Equipo();

            }
            ViewBag.Ubicacion = ubicacion;

            return View(usuario);
        }

        // GET: Usuario
        public ActionResult Index()
        {
            return View(FutbappDB.Usuarios.ToList());
        }
    }
}
