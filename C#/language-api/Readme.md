# Favorite Languages REST API

This is a minimal REST API built with C# and ASP.NET Core to manage a list of favorite programming languages. It provides CRUD (Create, Read, Update, Delete) endpoints, following C# best practices like dependency injection and proper HTTP conventions.

## Project Setup

### Prerequisites
- **.NET SDK**: Version 6.0 or later (as of April 2025, .NET 9 might be available).
- **IDE**: Visual Studio, VS Code, or command-line tools.

### Create the Project
```bash
dotnet new web -n FavoriteLanguagesApi
cd FavoriteLanguagesApi
```

## Explanation

- **Minimal API**: Uses ASP.NET Core's minimal API approach (introduced in .NET 6) with `app.Map*` methods for a lightweight setup without controllers.
- **Dependency Injection**: Implements an `ILanguageService` interface and `LanguageService` class, registered as a singleton to manage the list, adhering to SOLID principles.
- **Best Practices**:
  - **HTTP Status Codes**: Returns appropriate responses (e.g., `Results.Ok`, `Results.NotFound`, `Results.Created`).
  - **Input Validation**: Ensures language names are not empty or whitespace in `POST` and `PUT` requests.
  - **Case Insensitivity**: Uses `StringComparison.OrdinalIgnoreCase` for flexible comparisons.
  - **DTO**: Employs a `LanguageRequest` record for clean data transfer.
- **In-Memory Storage**: Uses a simple `List<string>` for demonstration. In a production environment, this should be replaced with a database (e.g., Entity Framework Core with SQLite or SQL Server).
- **Routing**: Follows RESTful conventions (e.g., `/languages` for the list, `/languages/{name}` for specific items).

## Endpoints

| Method | Endpoint             | Description                          | Response Example                  |
|--------|----------------------|--------------------------------------|------------------------------------|
| GET    | `/languages`         | Get all languages                   | `["C#", "Python", "JavaScript"]` |
| GET    | `/languages/C#`      | Get a specific language             | `"C#"` or 404                    |
| POST   | `/languages`         | Add a new language                  | 201 with `"Rust"`                |
| PUT    | `/languages/Python`  | Update an existing language         | 204 or 404                       |
| DELETE | `/languages/JavaScript` | Delete a language                | 204 or 404                       |

## How to Run

1. `cd FavoriteLanguagesApi`
2. `dotnet run`
3. test at `https://localhost:5001` (or a similar port, check the console output)

## Test API

Use tools like Postman, cURL, or a browser:
- GET `https://localhost:5001/languages`
- POST `https://localhost:5001/languages` with JSON: `{ "name": "Rust" }`
- PUT `https://localhost:5001/languages/Python` with JSON: `{ "name": "Py" }`
- DELETE `https://localhost:5001/languages/JavaScript`

## Notes

- **Minimalism**: Avoids boilerplate (e.g., controllers, startup classes) while maintaining functionality.
- **Scalability**: For a production app, consider adding a database, error handling (e.g., try-catch), logging, and authentication.
- **C# Features**: Leverages records (C# 9+), minimal APIs (C# 10+), and modern syntax for conciseness.
