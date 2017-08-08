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
            Usuario usuario = (Usuario)Session["UsuarioLogeado"];

            Equipo equipos = futbappDB.Equipos.FirstOrDefault(u => u.NombreDeEquipo == Nombre);
            if(equipos == null)
            {
                Equipo equipo = new Equipo();

                equipo.NombreDeEquipo = Nombre;
                equipo.NombreDeLider = usuario.NombreDeUsuario;

                futbappDB.Equipos.Add(equipo);
                futbappDB.SaveChanges();

                Equipo team = futbappDB.Equipos.FirstOrDefault(u => u.NombreDeEquipo == Nombre);

                FirstCreateTeam(team, usuario);
            }
            else
            {
                TempData["Error"] = "¡El nombre de equipo ya existe, pruebe con otro nombre!";
            }

            return RedirectToAction("MiPerfil", "Usuario");
        }

        public void FirstCreateTeam(Equipo equipo, Usuario usuario)
        {

            futbappDB.Entry(usuario).State = EntityState.Modified;


            var userEquipo = futbappDB.Set<Equipo>().Include(p => p.Usuario).FirstOrDefault(
                u => u.NombreDeEquipo == equipo.NombreDeEquipo);
            userEquipo.Usuario.Add(usuario);

            futbappDB.SaveChanges();
        }

        public ActionResult AgregarMiembros(String NombreDeUsuario)
        {
            Usuario miembro = futbappDB.Usuarios.FirstOrDefault(u => u.NombreDeUsuario == NombreDeUsuario);
                Usuario usuario = (Usuario) Session["UsuarioLogeado"];
                Equipo equipo = futbappDB.Equipos.FirstOrDefault(u => u.NombreDeLider == usuario.NombreDeUsuario);
            if (miembro != null)
            {
                /*futbappDB.Usuarios.Attach(miembro);
                var entry = futbappDB.Entry(miembro);
                miembro.EquipoID = equipo.NombreDeEquipo;
                entry.Property(u => u.Equipo).IsModified = true;*/

                futbappDB.Usuarios.Attach(miembro);
                var actualizar = futbappDB.Entry(miembro);
                miembro.EquipoID = equipo.NombreDeEquipo;
                actualizar.Property(a => a.EquipoID).IsModified = true;

                futbappDB.SaveChanges();
                return RedirectToAction("MiPerfil", "Usuario");
            }
            return RedirectToAction("Index", "Home");
        }

        public ActionResult VerMiEquipo(Usuario usuario)
        {


            return null;
        }
    }
}