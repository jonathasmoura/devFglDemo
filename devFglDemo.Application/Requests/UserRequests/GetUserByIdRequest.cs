using System;
using devFglDemo.Application.Responses.Contracts;
using Flunt.Notifications;

namespace devFglDemo.Application.Requests.UserRequests
{
    public class GetUserByIdRequest : Notifiable, IRequest
    {

        public GetUserByIdRequest() { }

        public GetUserByIdRequest(Guid id)
        {
            Id = id;
        }
        public Guid Id { get; set; }
        public void Validate() { }
    }
}
