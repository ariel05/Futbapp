using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Futbapp.Models
{
    [Table("Ubicacion")]
    public class Ubicacion
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public String Id { get; set; }
        public String Provincia { get; set; }
        public String Ciudad { get; set; }
        public String Zona { get; set; }
        public List<Usuario> Usuario { get; set; }
        public List<Sala> Sala { get; set; }
    }
}