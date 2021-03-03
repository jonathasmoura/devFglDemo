using System;
using devFglDemo.Domain.Entities.Base;
using Flunt.Validations;

namespace devFglDemo.Domain.Entities
{
    public class Marca : DomainBase
    {
        public Marca(string name, string description)
        {
            Name = name;
            Description = description;
        }

        public string Name { get; set; }
        public string Description { get; set; }
        public void Activate() => IsActive = true;
        public void Inactivate() => IsActive = false;

        public override string ToString()
        {
            return $"{Name} {Description}";
        }
        public void UpdateInfo(string name, string description)
        {
            Name = name;
            Description = description;
        }
    }
}
