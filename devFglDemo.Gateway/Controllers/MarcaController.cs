using devFglDemo.Application.Requests.MarcaRequests;
using devFglDemo.Application.Responses;
using Microsoft.AspNetCore.Mvc;

namespace devDemo.Gateway.Controllers
{
    [ApiController]
    [Route("v1/marcas")]
    public class MarcaController : ControllerBase
    {

        [Route("")]
        [HttpPost()]
        public RequestResult CreateUser([FromBody] CreateMarcaRequest request, [FromServices] CreateMarcaRequestHandler handler)
        {
            return (RequestResult)handler.Handle(request);
        }
    }
}
