using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Futbapp.Models
{
    [Table("Partido")]
    public class Partido
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public String Id { get; set; }
        public DateTime Fecha { get; set; }
        public string SalaID { get; set; }
        public List<Equipo> Equipos { get; set; }
        [ForeignKey("SalaID")]
        public Sala Sala { get; set; }
    }
}