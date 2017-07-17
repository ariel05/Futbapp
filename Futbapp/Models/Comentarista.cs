using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Futbapp.Models
{
    public class Comentarista
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public String Codigo { get; set; }
        public String Nombre { get; set; }
        public String Email { get; set; }
        public String Comentario { get; set; }
    }
}