using devFglDemo.Application.Contracts;
using devFglDemo.Application.Responses;
using devFglDemo.Application.Responses.Contracts;
using devFglDemo.Domain.Entities;
using Flunt.Notifications;

namespace devFglDemo.Application.Requests.MarcaRequests
{
    public class GetMarcaByIdRequestHandler : Notifiable, IRequestHandler<GetMarcaByIdRequest>
    {
        public IRequestResult Handle(GetMarcaByIdRequest request)
        {
            throw new System.NotImplementedException();
        }
    }
}
