using System.Collections.Generic;
using ExampleProjectDecorator.Api.Models;

namespace ExampleProjectDecorator.Api.Interfaces
{
    public interface IPersonaRepository
    {
        PersonaDTO Get();
    }
}