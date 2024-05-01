var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

//app.MapGet("/", () => "Hello World!");

app.Use(async (context, next) =>
{
    await context.Response.WriteAsync("Custom Middleware 1 request");
    await next();
    await context.Response.WriteAsync("Custom Middleware 1 response");
});

app.Use(async (context, next) =>
{
    await context.Response.WriteAsync("Custom Middleware 2 request");
    await next();
});

app.Use(async (context, next) =>
{
    await context.Response.WriteAsync("Custom Middleware 3 request");
    await next();
});

app.Run();
