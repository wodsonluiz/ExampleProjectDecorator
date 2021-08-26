using System;
using ExampleProjectDecorator.Api.Interfaces;
using ExampleProjectDecorator.Api.Models;
using Microsoft.Extensions.Caching.Memory;

namespace ExampleProjectDecorator.Api.Repositorys.Caching
{
    public class PersonaRepositoryDecorator<T> : IPersonaRepository 
        where T : IPersonaRepository
    {
        private IMemoryCache _memoryCache;
        private T _inner;

        public PersonaRepositoryDecorator(IMemoryCache memoryCache, T inner)
        {
            _memoryCache = memoryCache;
            _inner = inner;
        }
        public PersonaDTO Get()
        {
            var key = "Persona";
            var itens = _memoryCache.Get<PersonaDTO>(key);

            if (itens == null)
            {
                itens = _inner.Get();
                if (itens != null)
                {
                    _memoryCache.Set(key, itens, TimeSpan.FromMinutes(1));
                }
            }
            else
            {
                itens.SetFromSource("Cache");
            }

            return itens;
        }
    }
}