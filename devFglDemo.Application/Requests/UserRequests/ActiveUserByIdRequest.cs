using System;
using devFglDemo.Application.Responses.Contracts;
using Flunt.Notifications;

namespace devFglDemo.Application.Requests.UserRequests
{
    public class ActiveUserByIdRequest : Notifiable, IRequest
    {
        public ActiveUserByIdRequest() { }
        public ActiveUserByIdRequest(Guid id)
        {
            Id = id;
        }

        public Guid Id { get; set; }
        public void Validate() { }
    }
}
