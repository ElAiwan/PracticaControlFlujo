using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Evaluacion
{
    public class Usuario
    {
        public string User {  get; set; }
        public string Password { get; set; }
        public string Nombres { get; set; }
        public string Apellidos { get; set; }
        public DateTime FechaNacimiento {  get; set; }

        public Usuario(string user, string password, string nombres, string apellidos, DateTime fechaNacimiento)
        {
            User = user;
            Password = password;
            Nombres = nombres;
            Apellidos = apellidos;
            FechaNacimiento = fechaNacimiento;
        }

        public int CalcularEdad()
        {
            DateTime hoy = DateTime.Today;
            int edad = hoy.Year - FechaNacimiento.Year;
            if (FechaNacimiento.Date > hoy.AddYears(-edad)) edad--;  // Ajusta si el cumpleaños aún no ha ocurrido este año
            return edad;
        }
        public Usuario (string user, string password)
        {
            User = user;
            Password = password;
        }
    }
}
