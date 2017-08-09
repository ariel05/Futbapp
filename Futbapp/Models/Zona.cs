using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Futbapp.Models
{
    [Table("Zona")]
    public class Zona
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public string NombreDeZona { get; set; }
        public int CiudadID { get; set; }
        [ForeignKey("CiudadID")]
        public Ciudad Ciudad { get; set; }
        public List<Ubicacion> Ubicacion { get; set; }
    }
}