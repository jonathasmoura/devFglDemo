using System;
using devFglDemo.Application.Responses.Contracts;
using Flunt.Notifications;

namespace devFglDemo.Application.Requests.MarcaRequests
{
    public class ActiveMarcaByIdRequest : Notifiable, IRequest
    {
        public ActiveMarcaByIdRequest() { }
        public ActiveMarcaByIdRequest(Guid id)
        {
            Id = id;
        }

        public Guid Id { get; set; }
        public void Validate() { }
    }
}
