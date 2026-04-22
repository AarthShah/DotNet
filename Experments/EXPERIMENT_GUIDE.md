# DOT NET Experiment Guide (Simple 1 to 10)

This guide is arranged exactly in order from Experiment 1 to Experiment 10.
Each experiment is kept very basic and uses one main code file: `Program.cs`.

## Ordered Mapping

1. `Experment_1` -> Basic arithmetic operations in C#
2. `Experment_2` -> OOP basics (class, object, encapsulation)
3. `Experment_3` -> SOLID (Single Responsibility Principle)
4. `Experment_4` -> Delegates and lambda expressions
5. `Experment_5` -> Async and await
6. `Experment_6` -> Basic ASP.NET Core MVC concept (single-file demo)
7. `Experment_7` -> Data annotation validation
8. `Experment_8` -> CRUD with EF Core (Code First style, in-memory)
9. `Experment_9` -> Basic ASP.NET Core Web API (CRUD)
10. `Experment_10` -> Logging and caching in ASP.NET Core

## What Is Simplified

- Code is intentionally basic and short.
- Main learning concept is shown directly.
- Complex project structure is avoided where possible.
- For new experiments (7, 8, 10), only `Program.cs` + minimal `.csproj` are used.

## How To Run

### Console experiments
- `Experment_1`
- `Experment_2`
- `Experment_3`
- `Experment_4`
- `Experment_5`
- `Experment_7`
- `Experment_8`

Run with:

```powershell
dotnet run --project .\Experment_X\
```

Replace `X` with the experiment number.

### Web experiments
- `Experment_6` (open `/`)
- `Experment_9` (use `/api/products` endpoints)
- `Experment_10` (open `/time`)

Run with:

```powershell
dotnet run --project .\Experment_X\
```

Then open the localhost URL shown in terminal.

## Notes from DOCX Alignment

- The topics exactly follow your DOCX sequence from 1 to 10.
- The implementation is intentionally easy, so you can explain each concept quickly in practicals.
