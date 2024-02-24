using Microsoft.AspNetCore.Diagnostics;
using todo_backend.Errors;

namespace todo_backend.Middlewares
{
    public class ExceptionHandleMiddleware : IExceptionHandler
    {
        public async ValueTask<bool> TryHandleAsync(
            HttpContext httpContext, Exception exception, CancellationToken cancellationToken)
        {
            var response = new ErrorResponse()
            {
                StatusCode = StatusCodes.Status500InternalServerError,
                ExceptionMessage = exception.Message,
                Title = "Something went wrong"
            };

            await httpContext.Response.WriteAsJsonAsync(response,cancellationToken);
            httpContext.Response.StatusCode = StatusCodes.Status500InternalServerError;

            return true;
        }
    }
}
