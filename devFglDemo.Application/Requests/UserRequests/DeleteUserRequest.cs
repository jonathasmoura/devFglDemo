using System;
using devFglDemo.Application.Responses.Contracts;
using Flunt.Notifications;
using Flunt.Validations;

namespace devFglDemo.Application.Requests.UserRequests
{
    public class DeleteUserRequest : Notifiable, IRequest
    {
        public DeleteUserRequest() { }
        public DeleteUserRequest(Guid id)
        {
            Id = id;
        }

        public Guid Id { get; set; }

        public void Validate() { }
    }
}
