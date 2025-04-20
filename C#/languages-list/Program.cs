var builder = WebApplication.CreateBuilder(args);

builder.Services.AddCors(options =>
{
    options.AddDefaultPolicy(policy =>
    {
        policy.WithOrigins("http://localhost:3344") // frontend origin
            .AllowAnyHeader()
            .AllowAnyMethod();
    });
});

// add services to the container
// learn more about Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// configure the HTTP request pipeline
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

// app.UseHttpsRedirection(); // use for production
app.UseCors();

// Languages endpoint
app.MapGet("/languages", () => DataStore.TopLanguages)
    .WithName("GetLanguages")
    .WithOpenApi();

app.Run();

public static class DataStore
{
    public static readonly Language[] TopLanguages =
    {
        new(1, "C++", 1985),
        new(2, "Python", 1991),
        new(3, "JavaScript", 1995),
        new(4, "Java", 1995),
        new(5, "C#", 2000),
        new(6, "Go", 2009),
        new(7, "Rust", 2010),
    };
}

public record Language(int Id, string Name, int YearCreated);
