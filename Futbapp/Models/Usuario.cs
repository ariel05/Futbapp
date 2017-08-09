using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Futbapp.Models
{
    [Table("Usuario")]
    public class Usuario
    {
        [Key]
        public String NombreDeUsuario { get; set; }
        public String Nombre { get; set; }
        public String Apellido { get; set; }
        public String Email { get; set; }
        public String Password { get; set; }
        public int GolesHechos { get; set; }
        public int PartidosJugados { get; set; }
        public int Posicion { get; set; }
        public int UbicacionID { get; set; }
        public String EquipoID { get; set; }
        [ForeignKey("UbicacionID")]
        public Ubicacion Ubicacion { get; set; }
        [ForeignKey("EquipoID")]
        public Equipo Equipo { get; set; }
    }

}