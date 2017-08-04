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
            Equipo equipo = FutbappDB.Usuarios.First(e => e.NombreDeUsuario == usuario.NombreDeUsuario).Equipo;

            List<Usuario> user = FutbappDB.Usuarios.Include(u => u.Equipo).ToList();


            return View(usuario);
        }

        // GET: Usuario
        public ActionResult Index()
        {
            return View(FutbappDB.Usuarios.ToList());
        }
    }
}
