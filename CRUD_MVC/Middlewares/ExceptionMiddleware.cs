using Microsoft.AspNetCore.Hosting;
namespace CRUD_MVC.Middlewares
{
    public class ExceptionMiddleware
    {
        private readonly RequestDelegate _next;
        private readonly IWebHostEnvironment _webHostEnvironment;
        public ExceptionMiddleware(RequestDelegate next, IWebHostEnvironment webHostEnvironment)
        {
            _next = next;
            _webHostEnvironment = webHostEnvironment;
        }

        public async Task InvokeAsync(HttpContext context)
        {
            try
            {
                await _next(context);
            }
            catch (Exception ex)
            {
                if (context.Request.Path.StartsWithSegments("/Home/Error"))
                {
                    await WriteFallbackErrorResponse(context, ex); 
                }
                else
                {

                    await HandleExceptionAsync(context, ex); // Redirect to error page
                }
            }

        }
        private async Task<Task> HandleExceptionAsync(HttpContext context, Exception exception)
        {
            // Set the response status code and content type
            context.Response.StatusCode = 500; // Internal Server Error
            context.Response.ContentType = "text/html";

            // Redirect to the custom error page

            if (_webHostEnvironment.IsProduction())
            {
                context.Response.Redirect($"/Home/Error?errorMessage=Something Went Wrong&ReturnURL={context.Request.Path}");
            }
            else
            {
                context.Response.Redirect($"/Home/Error?errorMessage={exception.Message}&ReturnURL={context.Request.Path}");
            }
            return Task.CompletedTask;
        }
        private async Task WriteFallbackErrorResponse(HttpContext context, Exception exception)
        {
            // Fallback error message when the error page itself fails
            context.Response.StatusCode = 500; // Internal Server Error
            context.Response.ContentType = "text/plain"; // Use plain text to avoid further rendering issues

            string errorMessage = _webHostEnvironment.IsProduction()
                ? "An unexpected error occurred. Please try again later."
                : $"An unexpected error occurred: {exception.Message}";

            await context.Response.WriteAsync(errorMessage); // Write a minimal response
        }
    }
}
