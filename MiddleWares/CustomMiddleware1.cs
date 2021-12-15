namespace WebApi_2022.MiddleWares
{
    public class CustomMiddleware1
    {
        private readonly RequestDelegate _next;
        public CustomMiddleware1(RequestDelegate next)
        {
            _next = next;
        }

        public async Task Invoke(HttpContext context)
        {
            context.Items["customMessage"] = "Hello from middlewar 1";
            Console.WriteLine("Middleware 1 received.");
            await _next.Invoke(context);
        }
    }
}
