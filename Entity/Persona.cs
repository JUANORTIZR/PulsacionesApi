using System;

namespace Entity
{
    public class Persona
    {
        public Persona()
        {
        
        }

        public string Identificacion { get; set; }
        public string Nombre { get; set; }
        public string Sexo { get; set; }
        public int Edad { get; set; }
        public float Pulsaciones { get; set; }

        public void CalcularPulsaciones()
        {
            if (Sexo.ToUpper().Equals("Femenino".ToUpper()))
            {
                Pulsaciones = ((220 - Edad) / 10);
                return;
            }

            Pulsaciones = ((210 - Edad) / 10);
        }
    }
}
