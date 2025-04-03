# Favorite Programming Languages API

A minimal RESTful API built with ASP.NET Core to manage favorite programming languages. This project demonstrates modern C# best practices with a minimal API approach.

## Features

- Complete CRUD operations for programming languages
- Minimal API design pattern (ASP.NET Core)
- Entity Framework Core with in-memory database
- Swagger/OpenAPI documentation
- Proper HTTP status code responses
- Asynchronous operations

## Requirements

- .NET 7.0 SDK or later
- Visual Studio 2022, VS Code, or Rider (optional)

## Getting Started

### Installation

1. Clone the repository:
   ```
   git clone https://github.com/yourusername/favorite-programming-languages-api.git
   cd favorite-programming-languages-api
   ```

2. Restore dependencies:
   ```
   dotnet restore
   ```

3. Run the application:
   ```
   dotnet run
   ```

The API will be available at:
- https://localhost:7042 (HTTPS)
- http://localhost:5042 (HTTP)

Swagger UI will be available at: https://localhost:7042/swagger

### Using Docker

```bash
# Build the Docker image
docker build -t favorite-languages-api .

# Run the container
docker run -p 8080:80 favorite-languages-api
```

## API Endpoints

| Method | Endpoint | Description |
|--------|----------|-------------|
| GET    | /api/languages | Retrieve all programming languages |
| GET    | /api/languages/{id} | Retrieve a specific programming language by ID |
| POST   | /api/languages | Create a new programming language |
| PUT    | /api/languages/{id} | Update an existing programming language |
| DELETE | /api/languages/{id} | Delete a programming language |

## Data Model

The `ProgrammingLanguage` model includes the following properties:

```csharp
public class ProgrammingLanguage
{
    public int Id { get; set; }
    [Required]
    public string Name { get; set; } = string.Empty;
    public string Description { get; set; } = string.Empty;
    public int? YearCreated { get; set; }
}
```

## Example Requests

### Create a programming language

```http
POST /api/languages
Content-Type: application/json

{
  "name": "C#",
  "description": "A modern, object-oriented language developed by Microsoft",
  "yearCreated": 2000
}
```

### Get all languages

```http
GET /api/languages
```

### Update a language

```http
PUT /api/languages/1
Content-Type: application/json

{
  "name": "C#",
  "description": "A modern, versatile language part of the .NET ecosystem",
  "yearCreated": 2000
}
```

## Project Structure

```
favorite-programming-languages-api/
├── Program.cs             # All application logic (minimal API)
├── appsettings.json       # Configuration settings
├── appsettings.Development.json # Development-specific settings
├── Dockerfile             # Docker configuration
├── .gitignore
└── README.md
```

## Adding a Persistent Database

To switch from the in-memory database to a persistent SQL Server database:

1. Add the required package:
   ```
   dotnet add package Microsoft.EntityFrameworkCore.SqlServer
   ```

2. Modify the DbContext registration:
   ```csharp
   builder.Services.AddDbContext<AppDbContext>(options =>
       options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));
   ```

3. Add the connection string to `appsettings.json`:
   ```json
   {
     "ConnectionStrings": {
       "DefaultConnection": "Server=(localdb)\\mssqllocaldb;Database=FavoriteProgrammingLanguagesDb;Trusted_Connection=True;MultipleActiveResultSets=true"
     }
   }
   ```

## Best Practices Implemented

- **Minimal API Pattern**: Clean, concise syntax for APIs
- **Asynchronous Operations**: All database operations use async/await
- **Proper HTTP Status Codes**: 200, 201, 204, 404 responses as appropriate
- **Data Validation**: Using DataAnnotations attributes
- **Swagger Documentation**: Auto-generated API docs with endpoint naming
- **Repository Pattern**: Implemented via EF Core DbContext
