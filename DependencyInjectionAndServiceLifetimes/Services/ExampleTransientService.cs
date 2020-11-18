using System;
using DependencyInjectionAndServiceLifetimes.Interfaces;

namespace DependencyInjectionAndServiceLifetimes.Services
{
    public class ExampleTransientService : IExampleTransientService
    {
        private readonly Guid Id;

        public ExampleTransientService()
        {
            Id = Guid.NewGuid();
        }

        public string GetGuid() => Id.ToString();
    }
}