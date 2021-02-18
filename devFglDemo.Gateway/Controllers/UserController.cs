
using System;
using System.Collections.Generic;
using devFglDemo.Application.Contracts;
using devFglDemo.Application.Requests.UserRequests;
using devFglDemo.Application.Responses;
using devFglDemo.Domain.Entities;
using Microsoft.AspNetCore.Mvc;

namespace devDemo.Gateway.Controllers
{
    [ApiController]
    [Route("v1/users")]
    public class UserController : ControllerBase
    {
        [Route("")]
        [HttpGet]
        public IEnumerable<User> AllUsers([FromServices] IUserRepository userRepository)
        {
            return userRepository.GetAll();
        }

        [Route("")]
        [HttpPost()]
        public RequestResult CreateUser([FromBody] CreateUserRequest request, [FromServices] CreateUserRequestHandler handler)
        {
            return (RequestResult)handler.Handle(request);
        }

        [Route("{id}")]
        [HttpGet]
        public RequestResult GetUserById([FromHeader] GetUserByIdRequest request, [FromServices] GetUserByIdRequestHandler handler)
        {
            return (RequestResult)handler.Handle(request);
        }

        [Route("inactivate/{id}")]
        [HttpPatch]
        public RequestResult Inactivated([FromHeader] InactiveUserByIdRequest request, [FromServices] InactiveUserByIdRequestHandler handler)
        {
            return (RequestResult)handler.Handle(request);
        }

        [Route("activate/{id}")]
        [HttpPatch]
        public RequestResult Activated([FromHeader] ActiveUserByIdRequest request, [FromServices] ActiveUserByIdRequestHandler handler)
        {
            return (RequestResult)handler.Handle(request);
        }

        [Route("{id}")]
        [HttpPut]
        public RequestResult EditUser([FromHeader] Guid id, [FromBody] UpdateUserRequest request, [FromServices] UpdateUserRequestHandler handler)
        {
            return (RequestResult)handler.Handle(request);
        }

        [Route("{id}")]
        [HttpDelete]
        public RequestResult DeleteUser([FromHeader] Guid id, [FromBody] DeleteUserRequest request, [FromServices] DeleteUserRequestHandler handler)
        {
            return (RequestResult)handler.Handle(request);
        }
    }
}
