using Futbapp.Models;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Futbapp.Controllers
{
    public class TestController : Controller
    {
        public String ProbarEntityFramework()
        {
            using(FutbappContext futbappDB = new Models.FutbappContext())
            {
                Usuario nuevoUsuario = new Usuario();
                nuevoUsuario.NombreDeUsuario = "ariel05";
                nuevoUsuario.Nombre = "Ariel";
                nuevoUsuario.Apellido = "Rivero";
                nuevoUsuario.Email = "ariel200506@gmail.com";
                nuevoUsuario.Password = "123456789";

                futbappDB.Usuarios.Add(nuevoUsuario);
                futbappDB.SaveChanges();
            }
            return "Todo Ok";
        }
    }
}
