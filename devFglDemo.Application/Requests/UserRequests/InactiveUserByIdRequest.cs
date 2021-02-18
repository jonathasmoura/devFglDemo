using System;
using devFglDemo.Application.Responses.Contracts;
using Flunt.Notifications;

namespace devFglDemo.Application.Requests.UserRequests
{
    public class InactiveUserByIdRequest : Notifiable, IRequest
    {
        public InactiveUserByIdRequest(){}
        public InactiveUserByIdRequest(Guid id)
        {
            Id = id;
        }

        public Guid Id { get; set; }
        public void Validate() { }
    }
}
