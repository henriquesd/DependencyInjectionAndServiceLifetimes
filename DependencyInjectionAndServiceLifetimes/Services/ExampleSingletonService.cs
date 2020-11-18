using System;
using DependencyInjectionAndServiceLifetimes.Interfaces;

namespace DependencyInjectionAndServiceLifetimes.Services
{
    public class ExampleSingletonService : IExampleSingletonService
    {
        private readonly Guid Id;

        public ExampleSingletonService()
        {
            Id = Guid.NewGuid();
        }

        public string GetGuid() => Id.ToString();
    }
}