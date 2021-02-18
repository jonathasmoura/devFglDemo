using System;
using Flunt.Notifications;

namespace devFglDemo.Domain.Entities.Base
{
    public class DomainBase : Notifiable, IEquatable<DomainBase>
    {
        public DomainBase()
        {
            Id = Guid.NewGuid();
            IsActive = true;
            Created = DateTime.Now;
            ActivationDate = Created;

        }
        public Guid Id { get; set; }
        public bool IsActive { get; set; }
        public DateTime? ActivationDate { get; set; }
        public DateTime? InactivationDate { get; set; }
        public DateTime Created { get; set; }

        public bool Equals(DomainBase other)
        {
            return Id == other.Id;
        }
    }
}
