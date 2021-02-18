using System;
using devFglDemo.Application.Contracts;
using devFglDemo.Application.Responses;
using devFglDemo.Application.Responses.Contracts;
using devFglDemo.Domain.Entities;
using Flunt.Notifications;

namespace devFglDemo.Application.Requests.UserRequests
{
    public class ActiveUserByIdRequestHandler : Notifiable, IRequestHandler<ActiveUserByIdRequest>
    {
        private readonly IUserRepository _userRepository;
        public ActiveUserByIdRequestHandler(IUserRepository userRepository)
        {
            _userRepository = userRepository;
        }
        public IRequestResult Handle(ActiveUserByIdRequest request)
        {
            request.Validate();

            if (request.Invalid)
                return new RequestResult(false, "Ops, não foi possível encontrar seu registro!!!", request.Notifications);

            var entity = _userRepository.GetById(request.Id);
            entity.Activate();
            entity.ActivationDate = DateTime.Now;

            _userRepository.Edit(entity);

            return new RequestResult(true, "Usuário ativado com sucesso!!!", entity);
        }
    }
}
