## Data Storage Plan

Our application will use **SQL** for persistent data storage to ensure all user and inventory data is maintained across application restarts.

### Chosen Stack

- **Database**: SQLite (embedded, file-based SQL database)
- **Language**: C#
- **ORM**: Entity Framework Core (EF Core)

### Technologies & Libraries

| Component         | Technology            | Purpose                                   |
| ----------------- | --------------------- | ----------------------------------------- |
| Backend Language  | C#                    | Core logic and entity modeling            |
| Database Engine   | SQLite                | Lightweight, serverless SQL-based storage |
| Data Access Layer | Entity Framework Core | Querying and persistence of entities      |
| Migrations        | EF Core Migrations    | Schema tracking and updates               |

### Implementation Steps

1. Define `User`, `Order`, and `InventoryItem` models as C# classes.
2. Use `DbContext` to manage database operations.
3. Apply code-first migrations using `dotnet ef migrations add` and `update`.
4. Store data in `app.db` (or equivalent), persisted across sessions.
5. Perform CRUD operations using EF Core LINQ queries.
6. Seed initial data such as an admin account and sample inventory.

### Why SQLite?

- Lightweight and serverless
- Ideal for prototyping and small-to-medium sized apps
- Fully SQL-compliant and easily embeddable in Blazor apps
- Compatible with EF Core and migration tooling
