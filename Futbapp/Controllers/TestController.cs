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
                Usuario nuevoUsuario = new Usuario("Ariel", "Rivero",
                "ariel200506@gmail.com", "ariel05", "123456789",
                "Buenos Aires", "La Matanza", "Virrey Del Pino");
 //               using (SqlConnection conexion = new SqlConnection(ConfigurationManager.ConnectionStrings["FutbappContext"].ConnectionString))
  //              {
  //                  using (SqlCommand sentencia = conexion.CreateCommand())
   //                 {
                        futbappDB.Usuario.Add(nuevoUsuario);
                        futbappDB.SaveChanges();
  //                  }

  //              }
            }
            return "Todo Ok";
        }
    }
}
