using CustomerManagamentAPI.Middlewares;

namespace Microsoft.AspNetCore.Builder
{
    public static class ExceptionMiddlewareExtension
    {
        public static IApplicationBuilder UseExceptionHandlingMiddleware(this IApplicationBuilder app)
        => app.UseMiddleware<ExceptionMiddleware>();
    }
}
