using Amazon.Runtime.Internal;
using System.Net;
using System.Text.Json;

namespace Books_Shop_Management_System.CustomMiddlewares
{
    public class ExceptionHandlingMiddleware
    {
        private readonly RequestDelegate _next;
        private readonly ILogger<ExceptionHandlingMiddleware> _logger;

        public ExceptionHandlingMiddleware(RequestDelegate next, ILogger<ExceptionHandlingMiddleware> logger)
        {
            _next = next;
            _logger = logger;
        }

        public async Task InvokeAsync(HttpContext context)
        {
            try
            {
                await _next(context);
            }
            catch (Exception exception)
            {
                await HandleExceptionAsync(context, exception);
            }
        }

        private async Task HandleExceptionAsync(HttpContext context, Exception exception)
        {
            context.Response.ContentType = "application/json";
            var response = context.Response;

            var errorResponse = new ErrorResponse()
            {
                Message = exception.Message,
            };
            switch (exception)
            {
                case ArgumentNullException error:
                    if (error.Message.Contains("The result is null!!!"))
                    {
                        response.StatusCode = (int)HttpStatusCode.Forbidden;
                        errorResponse.Message = error.Message;
                        break;
                    }
                    response.StatusCode = (int)HttpStatusCode.BadRequest;
                    errorResponse.Message = error.Message;
                    break;
                    
                default:
                    response.StatusCode = (int)HttpStatusCode.InternalServerError;
                    errorResponse.Message = "Internal server error!";
                    break;
            }

            _logger.LogError(exception.Message);
            var result = JsonSerializer.Serialize(errorResponse);
            await context.Response.WriteAsync(result);
        }
    }
}
