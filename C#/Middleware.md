## Middleware

The purpose of a web application is to receive and respond to HTTP requests. A request is received, and then the server generates the appropriate response. Everything in ASP.NET Core is concerned with this request/response cycle.

When an ASP.NET Core app receives an HTTP request, it passes through a series of components to generate the response. These components are called middleware. Middleware can be thought of as a pipeline that the request flows through, and each middleware layer can run code before and after the next layer in the pipeline.


Middleware is implemented as a delegate that takes a `HttpContext` object and returns a `Task`. The `HttpContext` object represents the current request and response. The delegate is a function that processes the request and response.

For example, consider the following code:
```c#
var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

app.Run(async context =>
{
    await context.Response.WriteAsync("Hello world!");
});

app.Run();
```

In the preceding code:
- `WebApplication.CreateBuilder(args)` creates a new `WebApplicationBuilder` object.
- `builder.Build()` creates a new `WebApplication` object.
- The first `app.Run()` defines a delegate that takes a `HttpContext` object and returns a `Task`. The delegate writes "Hello world!" to the response.
- The second `app.Run()` starts the app.

When the app receives an `HTTP` request, the delegate is called. The delegate writes "Hello world!" to the response and completes the request.

### Chaining middleware

In most apps, you have multiple middleware components that run in sequence. The order in which you add middleware components to the pipeline is important. The components run in the order they were added.
