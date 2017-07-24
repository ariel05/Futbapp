using Futbapp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Futbapp.Controllers
{
    public class RegistroController : Controller
    {
        FutbappContext futbappDB = new FutbappContext();
        Usuario usuarioRegistro = new Usuario();
        // GET: Registro
        [HttpPost]
        public ActionResult Registro(String Usuario, String Email, String Password)
        {
            Usuario usuario = futbappDB.Usuarios.FirstOrDefault(u => u.NombreDeUsuario == Usuario && u.Email == Email);
            if(usuario == null)
            {
                usuarioRegistro.NombreDeUsuario = Usuario;
                usuarioRegistro.Email = Email;
                usuarioRegistro.Password = Password;

                futbappDB.Usuarios.Add(usuarioRegistro);
                futbappDB.SaveChanges();

                return RedirectToAction("CompletarRegistro", "Home");
            }
            else if(usuario.NombreDeUsuario != null)
            {
                TempData["Error"] = "El usuario elegido ya existe, por favor ingrese un usuario distinto";
            }
            else if(usuario.Email != null)
            {
                TempData["Error"] = "El email ingresado ya está siendo usado, por favor ingrese un email distinto";
            }
            return RedirectToAction("Index", "Home");
        }
        [HttpPost]
        public ActionResult Completar(String Nombre, String Apellido, String Provincia, String Ciudad, 
            String Zona, String Dia, String Mes, String Anio)
        {
            usuarioRegistro.Nombre = Nombre;
            usuarioRegistro.Apellido = Apellido;
            usuarioRegistro.Provincia = Provincia;
            usuarioRegistro.Ciudad = Ciudad;
            usuarioRegistro.Zona = Zona;

            TempData["Error"] = "¡Registro exitoso!";
            return RedirectToAction("Index", "Home");
        }
    }
}