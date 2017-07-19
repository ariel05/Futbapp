using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Futbapp.Models
{
    public class FutbappContext: DbContext
    {
        ///<summary>
        /// Llamo al constructor de la Clase DbContext y le paso
        /// el nombre de la cadena de conexion de web.config
        /// </summary>
        public FutbappContext() : base("name = FutbappContext")//Este parámetro corresponde al nombre de la cedena de conexion, no de la clase
        {
        }

        public DbSet<Usuario> Usuario { get; set; }

    }
}