using Entity;
using System;
using System.Collections.Generic;
using System.Text;

namespace BLL.PersonasConf
{
    public class ConsultarPersonaResponse
    {
        public List<Persona> Personas { get; set; }
        public bool Error { get; set; }
        public string Mensaje { get; set; }

        public ConsultarPersonaResponse(List<Persona> personas)
        {
            Personas = personas;
            Error = false;
        }

        public ConsultarPersonaResponse(string mensaje)
        {
            Mensaje = mensaje;
            Error = true;
        }
    }
}
