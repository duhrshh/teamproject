## Coding Style Guide

All developers must follow **Microsoft's official C# coding conventions** and the team guidelines below for consistency and maintainability.

### Official Guide

- [C# Coding Conventions (Microsoft Docs)](https://learn.microsoft.com/en-us/dotnet/csharp/fundamentals/coding-style/coding-conventions)

### Source Control & Branching

| Practice         | Description                                                                 |
|------------------|-----------------------------------------------------------------------------|
| Version Control  | Git                                                                          |
| Platform         | GitHub                                                                       |
| Branching Model  | [GitFlow Workflow](https://www.atlassian.com/git/tutorials/comparing-workflows/gitflow-workflow) |
| Pull Requests    | Required for merging into `main`                                             |

### Naming Conventions

| Type              | Convention            |
|-------------------|------------------------|
| Classes           | PascalCase             |
| Methods           | PascalCase             |
| Variables         | camelCase              |
| Constants         | PascalCase with `const` or `readonly` |
| File Names        | Match the class name   |
| Table Names       | Singular (e.g., `User`, not `Users`) |

### Commenting Guidelines

- Use XML documentation (`///`) for public methods and classes.
- Add inline comments only where logic is non-obvious.
- Avoid redundant comments.

### Code Best Practices

- Write clean, self-documenting code.
- Decompose logic into small, reusable methods.
- Use dependency injection when possible.
- Validate all user input.
- Use `dotnet format` or equivalent before committing code.
- Keep business logic out of the UI layer.

