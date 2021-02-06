using Entity;
using System;
using System.Collections.Generic;
using System.Text;

namespace BLL.PersonasConf
{
    public class GuardarPersonasResponse
    {
        public Persona Persona { get; set; }
        public string Mensaje { get; set; }
        public bool Error { get; set; }

        public GuardarPersonasResponse(Persona persona)
        {
            Error = false;
            Persona = persona;
        }

        public GuardarPersonasResponse(string mensaje)
        {
            Error = true;
            Mensaje = mensaje;
        }
    }
}
