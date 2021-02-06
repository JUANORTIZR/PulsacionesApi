using Entity;
using System;
using System.Collections.Generic;
using System.Text;

namespace BLL.PersonasConf
{
    public class ConsultarPersonaIdResponse
    {
        public Persona _Persona { get; set; }
        public bool Error { get; set; }
        public string Mensaje { get; set; }

        public ConsultarPersonaIdResponse(Persona persona)
        {
            Error = false;
            _Persona = persona;
        }

        public ConsultarPersonaIdResponse(string mensaje)
        {
            Error = true;
            Mensaje = mensaje;
        }
    }
}
