using ExampleProjectDecorator.Api.Interfaces;
using ExampleProjectDecorator.Api.Models;
using Microsoft.AspNetCore.Mvc;

namespace ExampleProjectDecorator.Api.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class PersonaGameOfThronesController : ControllerBase
    {
        private readonly IPersonaRepository _personaRepository;

        public PersonaGameOfThronesController(IPersonaRepository personaRepository)
        {
            _personaRepository = personaRepository;
        }

        [HttpGet]
        public PersonaDTO Get()
        {
            return _personaRepository.Get();
        }
    }
}