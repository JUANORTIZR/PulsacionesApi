using DAL;
using Entity;
using System;
using System.Collections.Generic;
using System.Text;

namespace BLL.PersonasConf
{
    public class PersonaService
    {

        private PersonasRepository personaRepository;
        public PersonaService()
        {
            personaRepository = new PersonasRepository();
        }


        public GuardarPersonaResponse Guardar(Persona persona)
        {
            try
            {
                persona.CalcularPulsaciones();
                personaRepository.Guardar(persona);
                return new GuardarPersonaResponse(persona);
            }
            catch (Exception e)
            {
                return new GuardarPersonaResponse(e.Message);
            }
        }

        public ConsultarPersonaResponse Consultar()
        {
            try
            {
                List<Persona> personas = personaRepository.Consultar();
                return new ConsultarPersonaResponse(personas);
            }
            catch (Exception e)
            {
                return new ConsultarPersonaResponse(e.Message);
            }
        }
    }
}
