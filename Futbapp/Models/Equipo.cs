using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Futbapp.Models
{
    public class Equipo
    {
        [Key]
        public String Nombre { get; set; }
        public int posicion { get; set; }
        public int Puntos { get; set; }
        public int GF { get; set; }
        public int GC { get; set; }
        public int Victorias { get; set; }
        public int Empates { get; set; }
        public int Perdidas { get; set; }
        public ISet<Usuario> Miembros;
        public Usuario Lider;

    }
}