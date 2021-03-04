using devFglDemo.Application.Contracts;
using devFglDemo.Application.Responses;
using devFglDemo.Application.Responses.Contracts;
using Flunt.Notifications;

namespace devFglDemo.Application.Requests.MarcaRequests
{
    public class UpdateMarcaRequestHandler : Notifiable, IRequestHandler<UpdateMarcaRequest>
    {
        public IRequestResult Handle(UpdateMarcaRequest request)
        {
            throw new System.NotImplementedException();
        }
    }
}
