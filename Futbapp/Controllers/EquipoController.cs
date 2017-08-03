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
            
            Equipo equipos = futbappDB.Equipos.FirstOrDefault(u => u.NombreDeEquipo == Nombre);
            if(equipos == null)
            {
                Equipo equipo = new Equipo();
                Usuario user = new Usuario();
                Usuario usuario = (Usuario)Session["UsuarioLogeado"];

                equipo.NombreDeEquipo = Nombre;
                equipo.NombreDeLider = usuario.NombreDeUsuario;

                futbappDB.Usuarios.Attach(usuario);
                var entry = futbappDB.Entry(usuario);
                usuario.Equipo = equipo;
                entry.Property(u => u.Equipo).IsModified = true;
                futbappDB.Equipos.Add(equipo);
                futbappDB.SaveChanges();
            }
            return RedirectToAction("MiPerfil", "Usuario");
        }

        public ActionResult AgregarMiembros(String nombreDeUsuario)
        {
            Usuario miembro = futbappDB.Usuarios.FirstOrDefault(u => u.NombreDeUsuario == nombreDeUsuario);
                Usuario usuario = (Usuario) Session["UsuarioLogeado"];
                Equipo equipo = futbappDB.Equipos.FirstOrDefault(u => u.NombreDeLider == usuario.NombreDeUsuario);
            if (miembro != null)
            {
                futbappDB.Usuarios.Attach(miembro);
                var entry = futbappDB.Entry(miembro);
                miembro.Equipo = equipo;
                entry.Property(u => u.Equipo).IsModified = true;
                futbappDB.SaveChanges();
                return RedirectToAction("MiPerfil", "Usuario");
            }
            return RedirectToAction("Index", "Home");
        }
    }
}