using devFglDemo.Application.Contracts;
using devFglDemo.Application.Responses;
using devFglDemo.Application.Responses.Contracts;
using devFglDemo.Domain.Entities;
using Flunt.Notifications;

namespace devFglDemo.Application.Requests.MarcaRequests
{
    public class CreateMarcaRequestHandler : Notifiable, IRequestHandler<CreateMarcaRequest>
    {

        private readonly IMarcaRepository _marcaRepository;
        private readonly IRepository<Marca> _repo;

        public CreateMarcaRequestHandler(IMarcaRepository marcaRepository, IRepository<Marca> repo)
        {
            _marcaRepository = marcaRepository;
            _repo = repo;
        }

        public IRequestResult Handle(CreateMarcaRequest request)
        {
            request.Validate();

            if (request.Invalid)
                return new RequestResult(false, "Ops, não foi possível realizar o cadastro.", request.Notifications);

            if (_marcaRepository.ExisteMarca(request.Name))
                return new RequestResult(false, "A marca informada já existe em  nossos registros!!!.", request);

            var entity = new Marca(request.Name, request.Description);

            AddNotifications(entity.Notifications);

            if (Invalid)
                return new RequestResult(false, "Ops, não foi possível cadastrar a marca!", request);

            _repo.Create(entity);
            _repo.SaveChanges();

            return new RequestResult(true, "Marca registrada com sucesso!!!", entity);
        }
    }
}
