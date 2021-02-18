using System;
using devFglDemo.Application.Responses.Contracts;
using Flunt.Notifications;
using Flunt.Validations;

namespace devFglDemo.Application.Requests.UserRequests
{
    public class UpdateUserRequest : Notifiable, IRequest
    {
        public UpdateUserRequest() { }
        public UpdateUserRequest(Guid id, string name, string email)
        {
            Id = id;
            Name = name;
            Email = email;
        }
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public void Validate()
        {
            AddNotifications(new Contract()
            .Requires()
            .HasMinLen(Name, 3, "UpdateUserRequest.Name", "Nome deve ter no mínimo 3 caracteres.")
            .IsEmail(Email, "UpdateUserRequest.Email", "E-mail inválido"));
        }
    }
}
