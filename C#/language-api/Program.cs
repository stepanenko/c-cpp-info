using Microsoft.AspNetCore.Mvc;

var builder = WebApplication.CreateBuilder(args);
// Add services to the container (dependency injection)
builder.Services.AddSingleton<ILanguageService, LanguageService>();

var app = builder.Build();

// Configure the HTTP request pipeline
app.UseHttpsRedirection();

// In-memory list for simplicity (replace with a database in production)
List<string> languages = new() { "C#", "Python", "JavaScript" };

// Endpoints
app.MapGet("/languages", ([FromServices] ILanguageService service) => 
    Results.Ok(service.GetAll()));

app.MapGet("/languages/{name}", ([FromServices] ILanguageService service, string name) => 
    service.GetByName(name) is string language 
        ? Results.Ok(language) 
        : Results.NotFound());

app.MapPost("/languages", ([FromServices] ILanguageService service, [FromBody] LanguageRequest request) =>
{
    if (string.IsNullOrWhiteSpace(request.Name))
        return Results.BadRequest("Language name cannot be empty.");
    
    service.Add(request.Name);
    return Results.Created($"/languages/{request.Name}", request.Name);
});

app.MapPut("/languages/{name}", ([FromServices] ILanguageService service, string name, [FromBody] LanguageRequest request) =>
{
    if (string.IsNullOrWhiteSpace(request.Name))
        return Results.BadRequest("New language name cannot be empty.");
    
    if (service.Update(name, request.Name))
        return Results.NoContent();
    return Results.NotFound();
});

app.MapDelete("/languages/{name}", ([FromServices] ILanguageService service, string name) => 
    service.Delete(name) 
        ? Results.NoContent() 
        : Results.NotFound());

app.Run();

// Service Interface
public interface ILanguageService
{
    List<string> GetAll();
    string? GetByName(string name);
    void Add(string name);
    bool Update(string oldName, string newName);
    bool Delete(string name);
}

// Service Implementation
public class LanguageService : ILanguageService
{
    private readonly List<string> _languages = new() { "C#", "Python", "JavaScript" };

    public List<string> GetAll() => _languages;

    public string? GetByName(string name) => 
        _languages.FirstOrDefault(l => l.Equals(name, StringComparison.OrdinalIgnoreCase));

    public void Add(string name) => 
        _languages.Add(name);

    public bool Update(string oldName, string newName)
    {
        int index = _languages.FindIndex(l => l.Equals(oldName, StringComparison.OrdinalIgnoreCase));
        if (index == -1) return false;
        _languages[index] = newName;
        return true;
    }

    public bool Delete(string name)
    {
        return _languages.RemoveAll(l => l.Equals(name, StringComparison.OrdinalIgnoreCase)) > 0;
    }
}

// Data Transfer Object (DTO)
public record LanguageRequest(string Name);
