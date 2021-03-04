using System;
using devFglDemo.Application.Responses.Contracts;
using Flunt.Notifications;
using Flunt.Validations;

namespace devFglDemo.Application.Requests.MarcaRequests
{
    public class CreateMarcaRequest : Notifiable, IRequest
    {
        public CreateMarcaRequest(string name, string description)
        {
            Name = name;
            Description = description;
        }
        public string Name { get; set; }
        public string Description { get; set; }
        public void Validate()
        {
            AddNotifications(new Contract()
            .Requires()
            .HasMinLen(Name, 3, "CreateMarcaRequest.Name", "Nome deve ter no mínimo 3 caracteres.")
            .HasMaxLen(Name, 100, "CreateMarcaRequest.Name", "Nome deve ter no máximo 100 caracteres.")
            .HasMinLen(Description, 3, "CreateMarcaRequest.Name", "Nome deve ter no mínimo 3 caracteres.")
            .HasMaxLen(Description, 100, "CreateMarcaRequest.Name", "Nome deve ter no máximo 100 caracteres."));

        }
    }
}
