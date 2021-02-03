using Entity;
using System;
using System.Collections.Generic;
using System.Text;

namespace BLL.PersonasConf
{
    public class GuardarPersonaResponse
    {
        public Persona Persona { get; set; }
        public string Mensaje { get; set; }
        public bool Error { get; set; }

        public GuardarPersonaResponse(Persona persona)
        {
            Error = false;
            Persona = persona;
        }

        public GuardarPersonaResponse(string mensaje)
        {
            Error = true;
            Mensaje = mensaje;
        }
    }
}
