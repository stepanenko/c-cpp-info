using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;

var builder = WebApplication.CreateBuilder(args);

// Add services to container
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddDbContext<AppDbContext>(options =>
    options.UseInMemoryDatabase("FavoriteProgrammingLanguagesDb"));

var app = builder.Build();

// Configure the HTTP request pipeline
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

// CRUD Endpoints
// GET: Retrieve all languages
// claude
app.MapGet("/api/languages", async (AppDbContext db) =>
    await db.ProgrammingLanguages.ToListAsync())
    .WithName("GetAllLanguages");

// GET: Retrieve a specific language by ID
app.MapGet("/api/languages/{id}", async (int id, AppDbContext db) =>
    await db.ProgrammingLanguages.FindAsync(id) is ProgrammingLanguage language
        ? Results.Ok(language)
        : Results.NotFound())
    .WithName("GetLanguageById");

// POST: Create a new language
app.MapPost("/api/languages", async (ProgrammingLanguage language, AppDbContext db) =>
{
    db.ProgrammingLanguages.Add(language);
    await db.SaveChangesAsync();
    return Results.Created($"/api/languages/{language.Id}", language);
})
.WithName("CreateLanguage");

// PUT: Update an existing language
app.MapPut("/api/languages/{id}", async (int id, ProgrammingLanguage inputLanguage, AppDbContext db) =>
{
    var language = await db.ProgrammingLanguages.FindAsync(id);
    if (language == null) return Results.NotFound();
    
    language.Name = inputLanguage.Name;
    language.Description = inputLanguage.Description;
    language.YearCreated = inputLanguage.YearCreated;
    
    await db.SaveChangesAsync();
    return Results.NoContent();
})
.WithName("UpdateLanguage");

// DELETE: Delete a language
app.MapDelete("/api/languages/{id}", async (int id, AppDbContext db) =>
{
    var language = await db.ProgrammingLanguages.FindAsync(id);
    if (language == null) return Results.NotFound();
    
    db.ProgrammingLanguages.Remove(language);
    await db.SaveChangesAsync();
    return Results.NoContent();
})
.WithName("DeleteLanguage");

app.Run();

// Model class
public class ProgrammingLanguage
{
    public int Id { get; set; }
    
    [Required]
    public string Name { get; set; } = string.Empty;
    
    public string Description { get; set; } = string.Empty;
    
    public int? YearCreated { get; set; }
}

// DbContext
public class AppDbContext : DbContext
{
    public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }
    
    public DbSet<ProgrammingLanguage> ProgrammingLanguages => Set<ProgrammingLanguage>();
}
