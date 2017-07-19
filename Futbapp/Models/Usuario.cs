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
        public String NombreDeUsuario { get; set; }
        public String Nombre { get; set; }
        public String Apellido { get; set; }
        public String Email { get; set; }
        public String Password { get; set; }
        public Ubicacion Ubicacion;

        public Usuario() { }

        public Usuario(String nombreDeUsuario, String nombre, String apellido, String email,  String password, 
            String provincia, String localidad, String zona)
        {
            NombreDeUsuario = nombreDeUsuario;
            Nombre = nombre;
            Apellido = apellido;
            Email = email;
            Password = password;
            Ubicacion = new Ubicacion(provincia, localidad, zona);
        }
    }

}