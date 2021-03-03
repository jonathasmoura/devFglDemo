using devFglDemo.Application.Contracts;
using devFglDemo.Application.Responses;
using devFglDemo.Application.Responses.Contracts;
using devFglDemo.Domain.Entities;
using Flunt.Notifications;

namespace devFglDemo.Application.Requests.UserRequests
{
    public class CreateUserRequestHandler : Notifiable, IRequestHandler<CreateUserRequest>
    {

        private readonly IUserRepository _userRepository;
        private readonly IRepository <User> _repo;

        public CreateUserRequestHandler(IUserRepository userRepository,IRepository <User> repo)
        {
            _userRepository = userRepository;
            _repo = repo;
        }

        public IRequestResult Handle(CreateUserRequest request)
        {
            request.Validate();

            if (request.Invalid)
                return new RequestResult(false, "Ops, não foi possível realizar o cadastro de usuário.", request.Notifications);

            if (_userRepository.EmailExists(request.Email))
                return new RequestResult(false, "O e-mail informado já existe em nossos registros!!!", request);

            var entity = new User(request.Name,
                                  request.Email,
                                  request.Gender);

            AddNotifications(entity.Notifications);

            if (Invalid)
                return new RequestResult(false, "Ops, não foi possível cadastrar o usuário", request);

            _repo.Create(entity);
            _repo.SaveChanges();

            return new RequestResult(true, "Usuário registrado com sucesso!!!", entity);

        }
    }
}
