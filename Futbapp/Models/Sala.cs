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
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public String Nombre { get; set; }
        public int UbicacionID { get; set; }
        [ForeignKey("UbicacionID")]
        public Ubicacion Ubicacion { get; set; }
        public List<Partido> Partido { get; set; }
    }
}