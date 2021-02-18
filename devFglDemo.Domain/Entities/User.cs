using System;
using devFglDemo.Domain.Entities.Base;
using Flunt.Validations;

namespace devFglDemo.Domain.Entities
{
    public class User : DomainBase
    {
        public User(string name, string email, string gender)
        {
            Name = name;
            Email = email;
            Gender = gender;
        }

        public string Name { get; private set; }
        public string Email { get; private set; }
        public string Gender { get; private set; }

        public void Activate() => IsActive = true;
        public void Inactivate() => IsActive = false;

        public override string ToString()
        {
            return $"{Name} {Email}";
        }
        public void UpdateInfo(string name, string email)
        {
            Name = name;
            Email = email;
        }
    }
}
