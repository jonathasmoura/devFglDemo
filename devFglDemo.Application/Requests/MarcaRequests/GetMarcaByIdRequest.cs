using System;
using devFglDemo.Application.Responses.Contracts;
using Flunt.Notifications;

namespace devFglDemo.Application.Requests.MarcaRequests
{
    public class GetMarcaByIdRequest : Notifiable, IRequest
    {

        public GetMarcaByIdRequest() { }

        public GetMarcaByIdRequest(Guid id)
        {
            Id = id;
        }
        public Guid Id { get; set; }
        public void Validate() { }
    }
}
