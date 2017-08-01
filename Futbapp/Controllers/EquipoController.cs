using Futbapp.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Futbapp.Controllers
{
    public class EquipoController : Controller
    {
        FutbappContext futbappDB = new FutbappContext();
        // GET: Equipo
        [HttpPost]
        public ActionResult Crear(String Nombre)
        {
           
            Equipo equipo = futbappDB.Equipos.FirstOrDefault(u => u.Nombre == Nombre);
            if(equipo == null)
            {
                Equipo equipos = new Equipo();
                Usuario usuario = (Usuario)Session["UsuarioLogeado"];
                Usuario miUser = new Usuario();
                miUser = futbappDB.Usuarios.Find(usuario.NombreDeUsuario);
                equipos.Nombre = Nombre;
                equipos.Lider = miUser;

                miUser.equipo = equipos;
                futbappDB.Equipos.Add(equipos);
                futbappDB.SaveChanges();
            }
            return RedirectToAction("MiPerfil", "Usuario");
        }

        public ActionResult AgregarMiembros(String nombreDeUsuario)
        {
            Usuario miembro = futbappDB.Usuarios.FirstOrDefault(u => u.NombreDeUsuario == nombreDeUsuario);
                Usuario usuario = (Usuario) Session["UsuarioLogeado"];
                Equipo equipo = futbappDB.Equipos.FirstOrDefault(u => u.Lider == usuario);

                equipo.Miembros.Add(miembro);
            if (miembro != null && equipo.Miembros.Count < 7)
            {
                futbappDB.Equipos.Add(equipo);
                futbappDB.SaveChanges();
                return RedirectToAction("MiPerfil", "Usuario");
            }
            return RedirectToAction("Index", "Home");
        }
    }
}