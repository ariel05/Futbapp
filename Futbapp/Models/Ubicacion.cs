using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Futbapp.Models
{
    public class Ubicacion
    {
        [Key]
        [Column (Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public String Id { get; set; }
        public String Provincia { get; set; }
        public String Ciudad { get; set; }
        public String Zona { get; set; }
    }
}