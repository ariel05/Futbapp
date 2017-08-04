using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Futbapp.Models
{
    [Table("Sala")]
    public class Sala
    {
        [Key]
        public String Id { get; set; }
        public String Nombre { get; set; }
        public Ubicacion Ubicacion { get; set; }
        public List<Partido> Partido { get; set; }
    }
}