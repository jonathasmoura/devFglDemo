
using devFglDemo.Application.Responses.Contracts;

namespace devFglDemo.Application.Responses
{
    public class RequestResult : IRequestResult
    {
        public RequestResult() { }

        public RequestResult(bool success, string messsage, object data)
        {
            Success = success;
            Messsage = messsage;
            Data = data;
        }

        public bool Success { get; set; }
        public string Messsage { get; set; }
        public object Data { get; set; }
    }
}
