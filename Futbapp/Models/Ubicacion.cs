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
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public String Codigo { get; set; }
        public String Provincia { get; set; }
        public String Localidad { get; set; }
        public String Zona { get; set; }

        public Ubicacion(String provincia, String localidad, String zona)
        {
            Provincia = provincia;
            Localidad = localidad;
            Zona = zona;
        }
    }
}