using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Persona.Models
{
    public class Persona
    {
        public int Dui { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public DateTime FechaNacimiento { get; set; }
        public string Direccion { get; set; }
        public string correo { get; set; }
    }
}