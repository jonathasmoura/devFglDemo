using System;
using devFglDemo.Application.Contracts;
using devFglDemo.Application.Responses;
using devFglDemo.Application.Responses.Contracts;
using devFglDemo.Domain.Entities;
using Flunt.Notifications;

namespace devFglDemo.Application.Requests.MarcaRequests
{
    public class InactiveMarcaByIdRequestHandler : Notifiable, IRequestHandler<InactiveMarcaByIdRequest>
    {
        public IRequestResult Handle(InactiveMarcaByIdRequest request)
        {
            throw new NotImplementedException();
        }
    }
}
