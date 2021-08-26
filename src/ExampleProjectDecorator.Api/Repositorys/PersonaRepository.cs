
using ExampleProjectDecorator.Api.Interfaces;
using ExampleProjectDecorator.Api.Models;

namespace ExampleProjectDecorator.Api.Repositorys
{
    public class PersonaRepository : IPersonaRepository
    {
        public PersonaDTO Get()
        {
            var dany = new Persona{Id = 1, Name = "Daenerys Targaryen", House = "Targaryen"};
            var ned = new Persona{Id = 1, Name = "Ned Stark", House = "Stark"};
            var rob = new Persona{Id = 1, Name = "Rob Stark", House = "Stark"};
            var jon = new Persona{Id = 1, Name = "Json Targaryen", House = "Targaryen"};

            var personas = new[] {dany, ned, rob, jon};

            var dto = new PersonaDTO("DataBase", personas);  

            return dto;
        }
    }
}