﻿using System;
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
        public int Id { get; set; }
        public int ZonaID { get; set; }
        [ForeignKey("ZonaID")]
        public Zona Zona { get; set; }
        public List<Usuario> Usuario { get; set; }
        public List<Sala> Sala { get; set; }
    }
}