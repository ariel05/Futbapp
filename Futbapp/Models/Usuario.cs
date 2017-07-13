using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Futbapp.Models
{
    public class Usuario
    {
        private String Nombre { get; set; }
        private String Apellido { get; set; }
        private String Email { get; set; }
        private String NombreDeUsuario { get; set; }
        private Ubicacion Ubicacion;
        private String Password { get; set; }

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