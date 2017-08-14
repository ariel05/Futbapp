using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Futbapp.Models
{
    [Table("EquipoPartidos")]
    public class EquipoPartidos
    {
        public int EquipoID { get; set;}
        public int PartidoID { get; set; }
        public DateTime FechaDeJuego { get; set; }
        [ForeignKey("EquipoID")]
        public Equipo Equipo { get; set; }
        [ForeignKey("PartidoID")]
        public Partido Partido { get; set; }
    }
}