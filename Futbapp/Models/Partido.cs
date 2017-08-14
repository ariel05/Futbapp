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
        public int Id { get; set; }
        public DateTime Fecha { get; set; }
        public int SalaID { get; set; }
        [ForeignKey("SalaID")]
        public Sala Sala { get; set; }
        public List<EquipoPartidos> Equipos { get; set; }


        public void setFecha(int Mes, int Dia, int Hora)
        {
            Fecha = new System.DateTime();
            Fecha.AddMonths(Mes);
            Fecha.AddDays(Dia);
            Fecha.AddHours(Hora);
        }

        public int getMes()
        {
            return Fecha.Month;
        }
        
        public int getDia()
        {
            return Fecha.Day;
        }

        public int getHora()
        {
            return Fecha.Hour;
        }
    }
}