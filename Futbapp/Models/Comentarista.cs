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
        private String Codigo { get; set; }
        private String Nombre { get; set; }
        private String Email { get; set; }
        private String Comentario { get; set; }
    }
}