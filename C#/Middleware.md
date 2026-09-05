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
- `WebApplication.CreateBuilder(args)` creates a new `WebApplicationBuilder` object.
- `builder.Build()` creates a new `WebApplication` object.
- The first `app.Run()` defines a delegate that takes a `HttpContext` object and returns a `Task`. The delegate writes "Hello world!" to the response.
- The second `app.Run()` starts the app.

When the app receives an `HTTP` request, the delegate is called. The delegate writes "Hello world!" to the response and completes the request.

### Chaining middleware

In most apps, you have multiple middleware components that run in sequence. The order in which you add middleware components to the pipeline is important. The components run in the order they were added.

### Terminal and nonterminal middleware

Each middleware can be thought of as terminal or nonterminal. Nonterminal middleware processes the request and then calls the next middleware in the pipeline. Terminal middleware is the last middleware in the pipeline and doesn't have a next middleware to call.

Delegates added with `app.Use()` can be terminal or nonterminal middleware. These delegates expect a HttpContext object and a RequestDelegate object as parameters. Typically the delegate includes `await next.Invoke();`. This passes control to the next middleware on the pipeline.

Delegates added with `app.Run()` are always terminal middleware. They don't call the next middleware in the pipeline. They're the last middleware component that runs. They only expect a `HttpContext` object as a parameter. `app.Run()` is a shortcut for adding terminal middleware.

```c#
var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

app.Use(async (context, next) =>
{
    await context.Response.WriteAsync("Hello from middleware 1. Passing to the next middleware!\r\n");

    // Call the next middleware in the pipeline
    await next.Invoke();

    await context.Response.WriteAsync("Hello from middleware 1 again!\r\n");
});

app.Run(async context =>
{
    await context.Response.WriteAsync("Hello from middleware 2!\r\n");
});

app.Run();
```
- `app.Use()` defines a middleware component that:
  - Writes "Hello from middleware 1. Passing to the next middleware!" to the response.
  - Passes the request to the next middleware component in the pipeline and waits for it to complete with `await next.Invoke()`.
  - After the next component in the pipeline completes, it writes "Hello from middleware 1 again!"
- The first `app.Run()` defines a middleware component that writes "Hello from middleware 2!" to the response.
- The second `app.Run()` starts the app.

At runtime, when a web browser sends a request to this app, the middleware components run in the order they were added to the pipeline. The app returns the following response:
```
Hello from middleware 1. Passing to the next middleware!
Hello from middleware 2!
Hello from middleware 1 again!
```

### Built-in middleware
