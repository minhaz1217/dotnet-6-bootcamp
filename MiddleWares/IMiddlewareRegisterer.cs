namespace WebApi_2022.MiddleWares
{
    public interface IMiddlewareRegisterer
    {
        IApplicationBuilder RegisterMiddlewares(IApplicationBuilder builder);
    }
}
