using devFglDemo.Application.Contracts;
using devFglDemo.Application.Responses;
using devFglDemo.Application.Responses.Contracts;
using Flunt.Notifications;

namespace devFglDemo.Application.Requests.UserRequests
{
    public class UpdateUserRequestHandler : Notifiable, IRequestHandler<UpdateUserRequest>
    {

        private readonly IUserRepository _userRepository;

        public UpdateUserRequestHandler(IUserRepository userRepository)
        {
            _userRepository = userRepository;
        }

        /*public IRequestResult Handle(UpdateUserRequest request)
        {
            request.Validate();

            if (request.Invalid)
                return new RequestResult(false, "Ops, não foi possível localizar o usuário", request.Notifications);

            var entity = _userRepository.GetById(request.id);
            entity.UpdateInfo(request.Name, request.Email);
            
            _userRepository.Edit(entity);

            return new RequestResult(true, "Usuário atualizado com sucesso", request);
        }*/

        public IRequestResult Handle(UpdateUserRequest request)
        {
            request.Validate();
            if (request.Invalid)
                return new RequestResult(true, "Ops, não foi possível encontrar seu registro!!!", request.Notifications);

            var entity = _userRepository.GetById(request.Id);

             if (!_userRepository.UserExists(request.Id))
                return new RequestResult(false, "Ops, não foi possível localizar seu registro!!!", entity);

            entity.UpdateInfo(request.Name, request.Email);

            _userRepository.Edit(entity);

            return new RequestResult(true, "Usuário atualizado com sucesso", request);
        }
    }
}
