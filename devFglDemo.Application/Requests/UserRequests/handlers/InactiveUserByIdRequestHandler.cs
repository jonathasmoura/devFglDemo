using System;
using devFglDemo.Application.Contracts;
using devFglDemo.Application.Responses;
using devFglDemo.Application.Responses.Contracts;
using devFglDemo.Domain.Entities;
using Flunt.Notifications;

namespace devFglDemo.Application.Requests.UserRequests
{
    public class InactiveUserByIdRequestHandler : Notifiable, IRequestHandler<InactiveUserByIdRequest>
    {
        private readonly IUserRepository _userRepository;
        public InactiveUserByIdRequestHandler(IUserRepository userRepository)
        {
            _userRepository = userRepository;
        }
        public IRequestResult Handle(InactiveUserByIdRequest request)
        {
            request.Validate();

            if (request.Invalid)
                return new RequestResult(false, "Ops, não foi possível encontrar seu registro!!!", request.Notifications);

            var entity = _userRepository.GetById(request.Id);
            entity.Inactivate();
            entity.InactivationDate = DateTime.Now;

            _userRepository.Edit(entity);

            return new RequestResult(true, "Usuário desativado com sucesso!!!", entity);
        }
    }
}
