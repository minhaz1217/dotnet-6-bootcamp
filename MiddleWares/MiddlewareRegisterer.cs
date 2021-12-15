namespace WebApi_2022.MiddleWares
{
    public static class MiddlewareRegisterer
    {
        public static IApplicationBuilder RegisterMiddlewares(
            this IApplicationBuilder builder)
        {
            builder.UseMiddleware<CustomMiddleware1>();
            builder.UseMiddleware<CustomMiddleware2>();
            return builder;
        }
    }
}
