using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Futbapp.Models
{
    public class Usuario
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public String NombreDeUsuario { get; set; }
        public String Nombre { get; set; }
        public String Apellido { get; set; }
        public String Email { get; set; }
        public Ubicacion Ubicacion;
        public String Password { get; set; }

        public Usuario(String nombre, String apellido, String email, String nombreDeUsuario, String password, 
            String provincia, String localidad, String zona)
        {
            Nombre = nombre;
            Apellido = apellido;
            Email = email;
            NombreDeUsuario = nombreDeUsuario;
            Password = password;
            Ubicacion = new Ubicacion(provincia, localidad, zona);
        }
    }

}