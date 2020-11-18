using System;
using DependencyInjectionAndServiceLifetimes.Interfaces;

namespace DependencyInjectionAndServiceLifetimes.Services
{
    public class ExampleScopedService : IExampleScopedService
    {
        private readonly Guid Id;

        public ExampleScopedService()
        {
            Id = Guid.NewGuid();
        }

        public string GetGuid() => Id.ToString();
    }
}