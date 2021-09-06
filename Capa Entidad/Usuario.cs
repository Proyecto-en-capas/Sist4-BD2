using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Capa_Entidad
{
    public class Usuario
    {
        public int Legajo {get;set;}
        public String Nombre { get; set; } 
		public String Apellido { get; set; } 
		public String DNI { get; set; }
        public int IdRol { get; set; }
        public DateTime FechaDeAlta { get; set; }
        public DateTime FechaDeBaja { get; set; }
        public DateTime FechaDeMod { get; set; }
        public String Estado { get; set; }
        public int Contrasenia { get; set; }
        public String Area { get; set; }
    }
}
