using System.Collections.Generic;

namespace ExampleProjectDecorator.Api.Models
{
    public class PersonaDTO
    {
        public IEnumerable<Persona> Personas { get; set; }
        public string FromSource { get; set; }

        public PersonaDTO(string fromSource, IEnumerable<Persona> personas)
        {
            Personas = personas;
            FromSource = fromSource;
        }

        public void SetFromSource(string fromSource){
            FromSource = fromSource;
        }
    }
}