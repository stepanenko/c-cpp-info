## Middleware

The purpose of a web application is to receive and respond to HTTP requests. A request is received, and then the server generates the appropriate response. Everything in ASP.NET Core is concerned with this request/response cycle.

When an ASP.NET Core app receives an HTTP request, it passes through a series of components to generate the response. These components are called middleware. Middleware can be thought of as a pipeline that the request flows through, and each middleware layer can run code before and after the next layer in the pipeline.
