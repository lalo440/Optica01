using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;


namespace Optica01.Models
{
    public class Pacientes
    {
        public int id { get; set; }
        public string nombre { get; set; }
        public int telefono { get; set; }
        public string sexo { get; set; }
        public int edad { get; set; }
        public int graduacion { get; set; }
        public string sucursal { get; set; }
        public string direccion { get; set; }
        public string observaciones { get; set; }
        public string fecha { get; set; }


    }
}