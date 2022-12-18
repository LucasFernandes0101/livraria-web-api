namespace livraria_api.v1.Helpers
{
    public class ErrorResponse
    {
        public ErrorResponse()
        {
            ErrorId = Guid.NewGuid().ToString();
            Errors = new List<ErrorDetails>();
        }

        public ErrorResponse(string message)
        {
            ErrorId = Guid.NewGuid().ToString();
            Errors = new List<ErrorDetails>();
            AddError(message);
        }

        public string ErrorId { get; private set; }
        public List<ErrorDetails> Errors { get; private set; }

        public class ErrorDetails
        {
            public ErrorDetails(string message)
            {
                Message = message;
            }

            public string Message { get; private set; }
        }

        public void AddError(string message)
        {
            Errors.Add(new ErrorDetails(message));
        }
    }
}