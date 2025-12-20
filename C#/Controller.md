## Controller

In ASP.NET Core, APIs are organized into Controllers.
A Controller is simply a class that inherits from `ControllerBase`.
Each method inside is called an Action.

```cs
[ApiController] // Tells C# this class is for an API
[Route("api/[controller]")] // Sets the URL to: api/products
public class ProductsController : ControllerBase
{
    // This method handles GET requests to /api/products
    [HttpGet]
    public List<string> GetProducts()
    {
        return new List<string> { "Laptop", "Mouse", "Keyboard" };
    }
}
```

Building an API is essentially taking the Classes and Logic and wrapping them in Controllers so the rest of the world can talk to your code over the internet.

Web APIs almost exclusively use JSON to send and receive data. 
C# handles the conversion (Serialization) between these two formats automatically!

## Status Codes

When the server sends a response, it includes a Status Code to tell the client if the request was successful or why it failed.

**200 OK**: Everything worked!

**201 Created**: Success! A new record was made.

**400 Bad Request**: Client error (you sent bad data).

**401 Unauthorized**: You need to log in.

**404 Not Found**: The resource doesn't exist.

**500 Internal Server Error**: The "Kitchen" (server) crashed.

## Swagger

When you create a new C# Web API project, it comes built-in with a tool called Swagger.
It creates a webpage that lists all your endpoints and lets you click "Try it out" to test them without writing any front-end code.
