
namespace devFglDemo.Application.Responses.Contracts
{
    public interface IRequestHandler<T> where T : IRequest
    {
        IRequestResult Handle(T request);
    }
}
