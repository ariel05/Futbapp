using Futbapp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Web;
using System.Web.Mvc;

namespace Futbapp.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            FutbappContext FutbappDB = new FutbappContext();
            List<Usuario> usuario = FutbappDB.Usuarios.OrderByDescending(a => a.GolesHechos).ToList();

            ViewBag.Usuario = usuario;

            return View();
        }

        public ActionResult Registro() {
            return View();
        }

        public ActionResult CompletarRegistro()
        {
            return View();
        }

        //Creo un método que se ejecutará cuando el formulario de comentarios sea usado
        [HttpPost]
        public void ComentarioContacto(String nombre, String email, String comentario) //Obtengo por parámetros los datos del formulario usados con el atributo "name"
        {
            SmtpClient clienteSmtp = new SmtpClient("smtp.gmail.com", 587); 
            //            clienteSmtp.Host = "smtp.gmail.com"; Opto por pasar estos datos por el constructor
            //            clienteSmtp.Port = 587;
            clienteSmtp.Credentials = new NetworkCredential("proyectospruebaunlam@gmail.com", "unlam123456789"); //Usuario y contraceña por constructor
            clienteSmtp.EnableSsl = true;

            //Mensaje para el dueño de la app
            MailMessage mensajeAlDueño = new MailMessage();
            mensajeAlDueño.From = new MailAddress("proyectospruebasunlam@gmail.com", "Futbapp Play"); //Quién envía el mensaje y cómo se lo titula
            mensajeAlDueño.To.Add("ariel200506@gmail.com");  //Los "to.add" agrega a quienes se les enviará el mensaje, en este caso a dos, ariel y, proyecto se autoenvía un mensaje
            mensajeAlDueño.To.Add("proyectospruebaunlam@gmail.com");
            mensajeAlDueño.Subject = "Tenes un comentario nuevo en la app"; //Este es el tema
            mensajeAlDueño.Body = nombre + "(" + email + ") + Dijo: "+comentario; //Este es el mensaje

            clienteSmtp.Send(mensajeAlDueño); //Finalmente envío el objeto "mensajeAlDueño"

            //Mensaje para el usuario
            MailMessage mensajeAlUsuario = new MailMessage();
            mensajeAlUsuario.From = new MailAddress("proyectospruebasunlam@gmail.com", "Futbapp Play");
            mensajeAlUsuario.To.Add(email);
            mensajeAlUsuario.Subject = "Comentario realizado en Futbapp";
            mensajeAlUsuario.IsBodyHtml = true; //Habilito que el mensaje del ".Body" sea en html
            mensajeAlUsuario.Body = " <h1>Futbapp: Muchas gracias por escribirnos</h1><br> <h3>"
                + nombre + " Vamos a responderte con la mayor brevedad posible - Futbapp </h3>";

            clienteSmtp.Send(mensajeAlUsuario);

        }
    }
}