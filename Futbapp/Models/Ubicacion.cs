using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Futbapp.Models
{
    public class Ubicacion
    {
        [Key]
        public String Id { get; set; }
        public String Provincia { get; set; }
        public String Ciudad { get; set; }
        public String Zona { get; set; }
        public List<Partido> Partidos { get; set; }
        public List<Usuario> Usuarios { get; set; }
    }
}