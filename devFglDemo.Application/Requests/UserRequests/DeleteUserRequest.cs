using System;
using devFglDemo.Application.Responses.Contracts;
using Flunt.Notifications;
using Flunt.Validations;

namespace devFglDemo.Application.Requests.UserRequests
{
    public class DeleteUserRequest : Notifiable, IRequest
    {
        public DeleteUserRequest(){}
        public DeleteUserRequest(Guid id, string name, string email, string gender)
        {
            Name = name;
            Email = email;
            Gender = gender;
        }

        public Guid id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Gender { get; set; }

        public void Validate(){}
    }
}
