using Entity;
using System;
using System.Collections.Generic;

namespace DAL
{
    public class PersonasRepository
    {
        private List<Persona> personas;
        public PersonasRepository()
        {
            personas = new List<Persona>();
            personas = CrearPersonas();
        }

        private List<Persona> CrearPersonas()
        {
            List<Persona> _personas = new List<Persona>();
            Persona persona1 = new Persona();
            persona1.Identificacion = "1";
            persona1.Nombre = "Anye";
            persona1.Edad = 20;
            persona1.Sexo = "Femenino";
            persona1.CalcularPulsaciones();
            Persona persona2 = new Persona();
            persona2.Identificacion = "2";
            persona2.Nombre = "Juan";
            persona2.Edad = 22;
            persona2.Sexo = "Masculino";
            persona2.CalcularPulsaciones();
            _personas.Add(persona1);
            _personas.Add(persona2);
            return _personas;
        }


        public void Guardar(Persona persona)
        {
            personas.Add(persona);
        }

        public List<Persona> Consultar()
        {
            return personas;
        }
    }
}
