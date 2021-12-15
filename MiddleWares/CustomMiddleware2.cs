namespace WebApi_2022.MiddleWares
{
    public class CustomMiddleware2
    {
        private readonly RequestDelegate _next;
        public CustomMiddleware2(RequestDelegate next)
        {
            _next = next;
        }
        public async Task Invoke(HttpContext context)
        {
            var message = context.Items["customMessage"];
            Console.WriteLine(message);
            await _next.Invoke(context);
        }
    }
}
