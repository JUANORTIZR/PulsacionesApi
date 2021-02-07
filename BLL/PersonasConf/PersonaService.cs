using DAL;
using Entity;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace BLL.PersonasConf
{
    public class PersonaService
    {

        private readonly PulsacionesContext context;
        public PersonaService(PulsacionesContext _context)
        {
           context = _context;
        }


        public GuardarPersonasResponse Guardar(Persona persona)
        {
            try
            {
                var personaRegistrada = context.Personas.Find(persona.Identificacion);
                if(personaRegistrada != null) return new GuardarPersonasResponse("La persona ya se encuentra resgistrada");

                persona.CalcularPulsaciones();
                context.Personas.Add(persona);
                context.SaveChanges();

                return new GuardarPersonasResponse(persona);
            }
            catch (Exception e)
            {
                return new GuardarPersonasResponse(e.Message);
            }
        }

        public ConsultarPersonasResponse Consultar()
        {
            try
            {
                List<Persona> personas = context.Personas.ToList();
                return new ConsultarPersonasResponse(personas);
            }
            catch (Exception e)
            {
                return new ConsultarPersonasResponse(e.Message);
            }
        }

        public ConsultarPersonaIdResponse ConsultarPersona(string id)
        {
           
            Persona persona = context.Personas.Find(id);
            if (persona == null) { 
                return new ConsultarPersonaIdResponse($"No hay persona resgistrada con el id {id} en nuestra base de datos");
            }
            return new ConsultarPersonaIdResponse(persona);
            
        }

        public string Eliminar(string id)
        {
            Persona persona = context.Personas.Find(id);
            if (persona.Equals(null)) return "La persona que intenta eliminar no se encuentra registrada";

            context.Personas.Remove(persona);
            context.SaveChanges();

            return "Persona eliminada correctamente";

        }
    }
}
