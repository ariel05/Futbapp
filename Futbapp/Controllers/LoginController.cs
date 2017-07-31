using Futbapp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Futbapp.Controllers
{
    public class LoginController : Controller
    {
        FutbappContext futbappDB = new FutbappContext();
        // GET: Login
        [HttpPost]
        public ActionResult Login(String Usuario, String Password)
        {
            Usuario usuario = futbappDB.Usuarios.FirstOrDefault(
                u => u.NombreDeUsuario == Usuario && u.Password == Password);
            if(usuario != null)
            {
                Session["UsuarioLogeado"] = usuario;
                return View();
            }
            else
            {
                TempData["Error"] = "Usuario o contraceña incorrecto";
            }
            return RedirectToAction("Index", "Home");
        }

        public ActionResult Logout()
        {
            Session.Clear();

            return RedirectToAction("Index", "Home");
        }
    }
}