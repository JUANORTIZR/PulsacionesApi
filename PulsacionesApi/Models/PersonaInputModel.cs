using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PulsacionesApi.Models
{
    public class PersonaInputModel
    {
        public string Identificacion { get; set; }
        public string Nombre { get; set; }
        public int Edad { get; set; }
        public string Sexo { get; set; }
        
    }
}
