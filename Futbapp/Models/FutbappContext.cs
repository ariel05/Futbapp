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

        public DbSet<Usuario> Usuarios { get; set; }
        public DbSet<Equipo> Equipos { get; set; }
        public DbSet<Partido> Partidos { get; set; }
        public DbSet<Ubicacion> Ubicaciones { get; set; }
        public DbSet<Sala> Salas { get; set; }
        public DbSet<Provincia> Provincias { get; set; }
        public DbSet<Ciudad> Ciudades { get; set; }
        public DbSet<Zona> Zonas { get; set; }

    }
}