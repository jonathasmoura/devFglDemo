using System;
using devFglDemo.Application.Responses.Contracts;
using Flunt.Notifications;
using Flunt.Validations;

namespace devFglDemo.Application.Requests.UserRequests
{
    public class CreateUserRequest : Notifiable, IRequest
    {
        public CreateUserRequest(string name, string email, string gender)
        {
            Name = name;
            Email = email;
            Gender = gender;
        }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Gender { get; set; }

        public void Validate()
        {
            AddNotifications(new Contract()
            .Requires()
            .HasMinLen(Name, 3, "CreateUserRequest.Name", "Nome deve ter no mínimo 3 caracteres.")
            .HasMinLen(Name, 3, "CreateUserRequest.Name", "Nome deve ter no máximo 100 caracteres.")
            //.IsNullOrEmpty(Gender, "CreateUserRequest.Gender", "Gênero digitado não pode estar vazio")
            .IsEmail(Email, "CreateUserRequest.Email", "E-mail inválido"));
        }
    }
}
