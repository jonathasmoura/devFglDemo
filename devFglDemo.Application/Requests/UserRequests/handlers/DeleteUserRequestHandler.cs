using devFglDemo.Application.Contracts;
using devFglDemo.Application.Responses;
using devFglDemo.Application.Responses.Contracts;
using devFglDemo.Domain.Entities;
using Flunt.Notifications;

namespace devFglDemo.Application.Requests.UserRequests
{
    public class DeleteUserRequestHandler : Notifiable, IRequestHandler<DeleteUserRequest>
    {

        private readonly IUserRepository _userRepository;

        public DeleteUserRequestHandler(IUserRepository userRepository)
        {
            _userRepository = userRepository;
        }

        public IRequestResult Handle(DeleteUserRequest request)
        {
            request.Validate();

            if (request.Invalid)
                return new RequestResult(false, "Ops, não foi possível localizar o usuário", request.Notifications);

            var entity = _userRepository.GetById(request.Id);
            
            
            _userRepository.Delete(entity);

            return new RequestResult(true, "Usuário excluído com sucesso ", entity);
        }
    }
}
