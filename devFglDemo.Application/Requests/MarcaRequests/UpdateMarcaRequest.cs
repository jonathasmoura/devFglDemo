using System;
using devFglDemo.Application.Responses.Contracts;
using Flunt.Notifications;
using Flunt.Validations;

namespace devFglDemo.Application.Requests.MarcaRequests
{
    public class UpdateMarcaRequest : Notifiable, IRequest
    {
        public UpdateMarcaRequest() { }
        public UpdateMarcaRequest(Guid id, string name, string description)
        {
            Id = id;
            Name = name;
            Description = description;
        }
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public void Validate()
        {
            AddNotifications(new Contract()
            .Requires()
            .HasMinLen(Name, 3, "UpdateMarcaRequest.Name", "Nome deve ter no mínimo 3 caracteres."));
        }
    }
}
