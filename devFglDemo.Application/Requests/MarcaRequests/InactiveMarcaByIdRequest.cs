using System;
using devFglDemo.Application.Responses.Contracts;
using Flunt.Notifications;

namespace devFglDemo.Application.Requests.MarcaRequests
{
    public class InactiveMarcaByIdRequest : Notifiable, IRequest
    {
        public InactiveMarcaByIdRequest(){}
        public InactiveMarcaByIdRequest(Guid id)
        {
            Id = id;
        }

        public Guid Id { get; set; }
        public void Validate() { }
    }
}
