##  Technical Design

### Implementation Language(s)

| Language | Purpose | Why Selected | Docs & Resources |
|----------|---------|---------------|------------------|
| **C#** | Primary backend logic and component development | Strongly typed, modern OOP language with full support in .NET ecosystem; great for web apps and server-side rendering in Blazor | [C# Docs](https://learn.microsoft.com/en-us/dotnet/csharp/) · [C# Programming Guide](https://learn.microsoft.com/en-us/dotnet/csharp/programming-guide/) · [C# Crash Course](https://www.youtube.com/watch?v=GhQdlIFylQ8) |
| **HTML** | Frontend structure and layout | Works seamlessly with Razor components in Blazor and allows fine-grained UI control | [HTML Docs (MDN)](https://developer.mozilla.org/en-US/docs/Web/HTML) |
| **CSS** | Styling and responsive layout | Used with Bootstrap to enhance UI/UX appearance, consistency, and responsiveness | [CSS Docs (MDN)](https://developer.mozilla.org/en-US/docs/Web/CSS) |

---

###  Implementation Frameworks

| Framework                 | Purpose                         | Why Selected                                                                                                                             | Docs & Resources                                                                                                                                                                            |
| ------------------------- | ------------------------------- | ---------------------------------------------------------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------- |
| **Blazor (Server-side)**  | Web application framework       | Built on .NET using C#. Enables rich, modern, component-based UI without JavaScript. Supports real-time UI updates and great IDE support | [Blazor Docs](https://learn.microsoft.com/en-us/aspnet/core/blazor/) · [Blazor Tutorial](https://www.youtube.com/watch?v=jHDhaSSKmB0) · [Blazor University](https://blazor-university.com/) |
| **Entity Framework Core** | ORM for data access             | Maps C# classes to SQLite tables with migrations and easy CRUD operations                                                                | [EF Core Docs](https://learn.microsoft.com/en-us/ef/core/) · [EF Core Getting Started](https://www.entityframeworktutorial.net/efcore/entity-framework-core.aspx)                           |
| **SQLite**                | Lightweight relational database | Serverless, fast, and perfect for small web apps without heavy hosting requirements                                                      | [SQLite Docs](https://www.sqlite.org/docs.html) · [Using SQLite with EF Core](https://learn.microsoft.com/en-us/ef/core/providers/sqlite/?tabs=dotnet-core-cli)                             |
| **Bootstrap**             | CSS Framework                   | Rapid UI design with pre-built components. Ensures mobile responsiveness and consistent design                                           | [Bootstrap Docs](https://getbootstrap.com/docs/5.3/getting-started/introduction/) · [Bootstrap Tutorial](https://www.youtube.com/watch?v=4sosXZsdy-s)                                       |
