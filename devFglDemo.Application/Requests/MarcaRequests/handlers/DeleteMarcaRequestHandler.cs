using devFglDemo.Application.Contracts;
using devFglDemo.Application.Requests.MarcaRequests;
using devFglDemo.Application.Responses;
using devFglDemo.Application.Responses.Contracts;
using devFglDemo.Domain.Entities;
using Flunt.Notifications;

namespace devFglDemo.Application.Requests.MarcaRequests
{
    public class DeleteMarcaRequestHandler : Notifiable, IRequestHandler<DeleteMarcaRequest>
    {
        public IRequestResult Handle(DeleteMarcaRequest request)
        {
            throw new System.NotImplementedException();
        }
    }
}
