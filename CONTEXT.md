# BondCalc — Project Context for AI Agents

This file serves as the single source of truth for AI agents working on the BondCalc project. Read it before making any changes or suggestions.

---

## 1. Project Overview

BondCalc is a Windows Forms desktop application that calculates **inflation-adjusted bond yield**.

- **Goal**: Input bond parameters, get inflation-adjusted yield
- **Scope**: Personal portfolio project + GitHub portfolio piece
- **Timeline**: 2-day delivery — keep it simple, avoid overengineering
- **User**: Single user, manual data input, no API/persistence
- **UI**: Windows Forms (no web, no MVC)

---

## 2. What This App Does

The user enters bond details manually and the app computes:

- **Full yield-to-maturity** adjusted for inflation rate
- **Coupon schedule table** with columns: date, coupon amount, inflation-adjusted coupon amount, running cumulative yield
- **Sell-by date** — the earliest date when cumulative inflation-adjusted return falls below the inflation curve (bond no longer beats inflation)

Calculation logic lives in `Application/Services`. The domain entities (`Bond`, `Coupon`, `Amortization`) hold the raw data; services perform the math.

---

## 3. Tech Stack

| Technology | Value |
|---|---|
| Language | C# (Nullable enabled, ImplicitUsings enabled) |
| Runtime | .NET 10 |
| UI | Windows Forms (`net10.0-windows`) |
| SDK | Microsoft.NET.Sdk |
| NuGet | **Zero** external packages — only what ships with the SDK |

Do **not** add NuGet packages unless the user explicitly requests it.

---

## 4. Architecture

Pragmatic three-layer structure. No DI containers, no interfaces unless clearly needed.

```
Presentation (Forms)
    ↓
Application (Services)
    ↓
Domain     (Entities)
```

- **Domain** — data-only entities with `{ get; init; }` properties
- **Application** — stateless calculation services
- **Presentation** — Windows Forms UI, receives user input and calls services

No repositories, no data access, no external APIs. No tests unless requested.

---

## 5. Project Structure

```
BondCalc/
├── BondCalc.slnx                  # Solution file (SLNX format)
├── CONTEXT.md                     # This file
├── README.md                      # GitHub readme
├── LICENSE.txt                    # MIT license (placeholder)
├── .gitattributes                 # Git line-ending config
├── .gitignore                     # VS gitignore
│
└── BondCalc.App/
    ├── BondCalc.App.csproj        # Project file (net10.0-windows, WinExe)
    ├── BondCalc.App.csproj.user   # VS user settings
    ├── Program.cs                 # Entry point, launches Form1
    │
    ├── Domain/
    │   └── Entities/
    │       ├── Bond.cs            # Bond entity (nominal, dates, coupons, amortizations)
    │       ├── Coupon.cs          # Coupon entity (amount, date)
    │       └── Amortization.cs    # Amortization entity (amount, date)
    │
    ├── Application/
    │   └── Services/              # (empty) Calculation services go here
    │
    └── Presentation/
        └── Forms/
            ├── Form1.cs           # Main form (currently empty)
            ├── Form1.Designer.cs  # Designer-generated layout
            └── Form1.resx         # Form resources
```

---

## 6. Current State

- Domain entities exist and are stable (Bond, Coupon, Amortization)
- Form1 is a blank placeholder (800x450, title "Form1")
- `Application/Services/` folder exists but is empty
- `Application/Interfaces/` was removed — do not recreate
- No calculation logic, no UI controls, no data entry, no comparison
- No tests
- README.md is just `# BondCalc`
- LICENSE.txt has unfilled placeholders `[year]` `[fullname]`

---

## 7. Development Setup

```powershell
# Build
dotnet build

# Run
dotnet run --project BondCalc.App/BondCalc.App.csproj

# Build in Release
dotnet build -c Release
```

Requires .NET 10 SDK. Can also build/run from Visual Studio 2022+ via `BondCalc.slnx`.

---

## 8. Coding Conventions

- **Language**: All code, comments, identifiers, and commit messages in **English**
- **Naming**: PascalCase for classes/methods/properties, camelCase for locals/parameters
- **File names**: Match the public class name (e.g. `BondService.cs` for `BondService`)
- **Indentation**: 4 spaces, no tabs
- **Braces**: Allman style (opening brace on new line)
- **Properties**: Use `{ get; init; }` for domain entities (immutable after construction)
- **Nullability**: Enabled at project level — annotate with `?` where needed
- **Comments**: Keep to a minimum; only where the "why" is not obvious
- **No regions** except Windows Forms designer-generated code
- No external packages without explicit user request
- No tests unless explicitly asked for

---

## 9. AI Agent Rules

1. **Stay within the architecture** — Domain → Application → Presentation. Don't invent new layers.
2. **Don't overengineer** — No DI, no interfaces, no patterns unless the problem clearly needs it. If unsure, ask the user.
3. **Don't remove existing code** — unless the user explicitly asks you to.
4. **Keep domain entities simple** — data holders with `{ get; init; }`. Business logic goes in services.
5. **Don't add NuGet packages** — the project intentionally has zero external dependencies.
6. **Don't write tests** — unless the user asks.
7. **Don't add documentation files** (README, wiki, etc.) — unless the user asks.
8. **Don't commit changes** — stage and commit only when instructed.
9. **Don't create files outside the project scope** — no config files, no CI scripts, no build scripts.
10. **When in doubt, ask the user** — especially about domain logic (inflation calculation method, data format, UI layout preferences).
