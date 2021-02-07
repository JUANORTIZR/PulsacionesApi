using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BLL.PersonasConf;
using Entity;
using PulsacionesApi.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Cors;
using DAL;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace PulsacionesApi.Controllers
{
    [Route("[controller]")]
    [ApiController]
   
    public class PersonaController : ControllerBase
    {

        private readonly PersonaService personaService;

        public PersonaController(PulsacionesContext context)
        {
            personaService = new PersonaService(context);
        }
        // GET: api/<ValuesController>
        [HttpGet]
        public ActionResult<List<Persona>> Get()
        {
            var response = personaService.Consultar();

            if(response.Error == true) return BadRequest(response.Mensaje);

            return response.Personas;
        }
     

        // GET api/<ValuesController>/5
        [HttpGet("{id}")]
        public ActionResult<Persona> Get(string id)
        {
            var response = personaService.ConsultarPersona(id);
            if (response.Error)
            {
                ModelState.AddModelError("Consultar Persona", response.Mensaje);
                var problemDetails = new ValidationProblemDetails(ModelState)
                {
                    Status = StatusCodes.Status400BadRequest,
                };
                return BadRequest(problemDetails);
            }
            return Ok(response._Persona);
            
        }

        // POST api/<ValuesController>
        [HttpPost]
        public ActionResult<Persona> Post(PersonaInputModel personaInput)
        {
            Persona persona = MapearPersona(personaInput);
            var response = personaService.Guardar(persona);
            if (response.Error)
            {
                ModelState.AddModelError("Guardar Persona", response.Mensaje);
                var problemDetails = new ValidationProblemDetails(ModelState)
                {
                    Status = StatusCodes.Status400BadRequest,
                };
                return BadRequest(problemDetails);
            }
            return Ok(response.Persona);
        }

       
      
        private Persona MapearPersona(PersonaInputModel personaInput)
        {
            var persona = new Persona
            {
                Identificacion = personaInput.Identificacion,
                Nombre = personaInput.Nombre,
                Edad = personaInput.Edad,
                Sexo = personaInput.Sexo
            };
            return persona;

        }

        // PUT api/<ValuesController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<ValuesController>/5
        [HttpDelete("{id}")]
        public void Delete(string id)
        {
            personaService.Eliminar(id);
        }
    }
}
