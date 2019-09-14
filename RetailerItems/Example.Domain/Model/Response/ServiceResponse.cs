namespace Example.Domain.Model.Response
{
    public class ServiceResponse
    {
        public object Response { get; }
        public bool Success { get; }

        public ServiceResponse(object response, bool success)
        {
            Response = response;
            Success = success;
        }
    }
}