using devFglDemo.Application.Contracts;
using devFglDemo.Application.Responses;
using devFglDemo.Application.Responses.Contracts;
using devFglDemo.Domain.Entities;
using Flunt.Notifications;

namespace devFglDemo.Application.Requests.UserRequests
{
    public class GetUserByIdRequestHandler : Notifiable, IRequestHandler<GetUserByIdRequest>
    {
        private readonly IUserRepository _userRepository;
        public GetUserByIdRequestHandler(IUserRepository userRepository)
        {
            _userRepository = userRepository;
        }
        public IRequestResult Handle(GetUserByIdRequest request)
        {
            request.Validate();


            if (request.Invalid)
                return new RequestResult(true, "Ops, não foi possível encontrar seu registro!!!", request.Notifications);

            

            var entity = _userRepository.GetById(request.Id);
            
            if (!_userRepository.UserExists(request.Id))
                return new RequestResult(false, "Ops, não foi possível encontrar seu registro!!!", entity);


            return new RequestResult(true, "Usuário encontrado com sucesso!!!", entity);
        }
    }
}
