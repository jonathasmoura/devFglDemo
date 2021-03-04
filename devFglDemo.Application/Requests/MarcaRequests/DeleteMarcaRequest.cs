using System;
using devFglDemo.Application.Responses.Contracts;
using Flunt.Notifications;
using Flunt.Validations;

namespace devFglDemo.Application.Requests.MarcaRequests
{
    public class DeleteMarcaRequest : Notifiable, IRequest
    {
        public DeleteMarcaRequest() { }
        public DeleteMarcaRequest(Guid id)
        {
            Id = id;
        }

        public Guid Id { get; set; }

        public void Validate() { }
    }
}
