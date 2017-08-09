using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Futbapp.Models
{
    [Table("Ciudad")]
    public class Ciudad
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public string NombreDeCiudad { get; set; }
        public int ProvinciaID { get; set; }
        [ForeignKey("ProvinciaID")]
        public Provincia Provincia { get; set; }
        public List<Zona> Zona { get; set; }
    }
}