using Entity;
using System;
using System.Collections.Generic;
using System.Text;

namespace BLL.PersonasConf
{
    public class ConsultarPersonasResponse
    {
        public List<Persona> Personas { get; set; }
        public bool Error { get; set; }
        public string Mensaje { get; set; }

        public ConsultarPersonasResponse(List<Persona> personas)
        {
            Personas = personas;
            Error = false;
        }

        public ConsultarPersonasResponse(string mensaje)
        {
            Mensaje = mensaje;
            Error = true;
        }
    }
}
