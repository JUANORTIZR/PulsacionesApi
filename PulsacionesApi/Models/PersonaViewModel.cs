using Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PulsacionesApi.Models
{
    public class PersonaViewModel:PersonaInputModel
    {
        public PersonaViewModel(Persona persona)
        {
            Identificacion = persona.Identificacion;
            Nombre = persona.Nombre;
            Edad = persona.Edad;
            Sexo = persona.Sexo;
            Pulsaciones = persona.Pulsaciones;
        }

        public float  Pulsaciones { get; set; }
    }
}
