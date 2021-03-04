using System;
using devFglDemo.Application.Contracts;
using devFglDemo.Application.Requests.MarcaRequests;
using devFglDemo.Application.Responses;
using devFglDemo.Application.Responses.Contracts;
using devFglDemo.Domain.Entities;
using Flunt.Notifications;

namespace devFglDemo.Application.Requests.MarcaRequests
{
    public class ActiveMarcaByIdRequestHandler : Notifiable, IRequestHandler<ActiveMarcaByIdRequest>
    {
        private readonly IMarcaRepository _marcaRepository;
        public ActiveMarcaByIdRequestHandler(IMarcaRepository marcaRepository)
        {
            _marcaRepository = marcaRepository;
        }

        public IRequestResult Handle(ActiveMarcaByIdRequest request)
        {
            throw new NotImplementedException();
        }
    }
}
