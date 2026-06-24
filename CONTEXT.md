# BondCalc — Project Context for AI Agents

This file serves as the single source of truth for AI agents working on the BondCalc project. Read it before making any changes or suggestions.

---

## 1. Project Overview

BondCalc is a Windows Forms desktop application that calculates **inflation-adjusted bond yield**.

- **Goal**: Input bond parameters, get inflation-adjusted yield
- **Scope**: Personal portfolio project + GitHub portfolio piece
- **Timeline**: Evolving project — keep it simple, avoid overengineering
- **User**: Single user, manual data input, no API/persistence
- **UI**: Windows Forms (no web, no MVC)

---

## 2. What This App Does

The user enters bond details manually and the app computes:

- **Full yield-to-maturity** adjusted for inflation rate
- **Coupon schedule table** with columns: date, coupon amount, inflation-adjusted coupon amount, running cumulative yield
- **Cumulative yield chart** comparing nominal yield, real (inflation-adjusted) yield, and inflation curve

Calculation logic lives in `Application/Services`. The domain entities (`Bond`, `Coupon`, `Amortization`, `Deal`) hold the raw data; services perform the math.

---

## 3. Tech Stack

| Technology | Value |
|---|---|
| Language | C# (Nullable enabled, ImplicitUsings enabled) |
| Runtime | .NET 10 |
| UI | Windows Forms (`net10.0-windows`) |
| SDK | Microsoft.NET.Sdk |
| NuGet | `System.Windows.Forms.DataVisualization` (chart), `System.Data.SqlClient` (unused, legacy) |

Do **not** add new NuGet packages unless the user explicitly requests it.

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

- **Domain** — data-only entities with `{ get; init; }` properties and constructor
- **Application** — stateless calculation services
- **Presentation** — Windows Forms UI, receives user input and calls services

No repositories, no data access, no external APIs. No tests unless requested.

---

## 5. Project Structure

```
BondCalc/
├── BondCalc.slnx                  # Solution file (SLNX format)
├── CONTEXT.md                     # This file
├── README.md                      # GitHub readme (English)
├── README.ru.md                   # GitHub readme (Russian)
├── LICENSE.txt                    # MIT license (unfilled)
├── .gitattributes                 # Git line-ending config
├── .gitignore                     # VS gitignore
│
└── BondCalc.App/
    ├── BondCalc.App.csproj        # Project file (net10.0-windows, WinExe)
    ├── BondCalc.App.csproj.user   # VS user settings
    ├── Program.cs                 # Entry point, launches BondCalc form
    ├── bondCalc.ico               # Application icon
    ├── App.config                 # App config (Settings)
    │
    ├── Properties/
    │   ├── Settings.settings      # User settings (persists Localization)
    │   └── Settings.Designer.cs   # Auto-generated settings accessor
    │
    ├── Domain/
    │   └── Entities/
    │       ├── Bond.cs            # Bond entity (Value, Placement, Repayment, Coupons, Amortizations)
    │       ├── Coupon.cs          # Coupon entity (Amount, Date)
    │       ├── Amortization.cs    # Amortization entity (Amount, Date)
    │       ├── Deal.cs            # Purchase deal (Price, ACI, Date)
    │       ├── ScheduleRow.cs     # Record for schedule table rows
    │       └── ChartPoint.cs      # Record for chart data points
    │
    ├── Application/
    │   └── Services/
    │       ├── Calculator.cs      # Core calculation engine (inflation-adjusted yield)
    │       └── Localization.cs    # Static localization helper (ResourceManager)
    │
    ├── Resources/
    │   ├── Strings.resx           # English resources (~50 strings)
    │   └── Strings.ru.resx        # Russian resources (~50 strings)
    │
    └── Presentation/
        └── Forms/
            ├── BondCalc.cs        # Main form code-behind
            ├── BondCalc.Designer.cs # Designer-generated layout
            └── BondCalc.resx      # Form resources (empty)
```

---

## 6. Domain Model

### Bond
- `Value` (double) — face value
- `Placement` (DateOnly) — issue/placement date
- `Repayment` (DateOnly) — maturity date (also used for put/offer)
- `Coupons` (List\<Coupon\>) — coupon schedule
- `Amortizations` (List\<Amortization\>) — principal repayment schedule

### Coupon
- `Amount` (double) — payment amount
- `Date` (DateOnly) — payment date

### Amortization
- `Amount` (double) — partial principal repayment
- `Date` (DateOnly) — repayment date

### Deal
- `Price` (double) — purchase price
- `ACI` (double) — accrued interest (НКД)
- `Date` (DateOnly) — purchase date

### ScheduleRow (record)
- `Date`, `Type`, `NominalAmount`, `CumulativeIncome`, `RealAmount`, `CumulativeRealIncome`

### ChartPoint (record)
- `Date`, `Value`

---

## 7. Current State

### What works
- Full calculation pipeline: input → Calculator → results + schedule + chart
- Inflation adjustment using daily compounding: `(1 + rate/365.25)^days`
- Coupon schedule with manual add/remove/generate by period
- Amortization schedule with manual add/remove/generate (split nominal into N equal parts)
- Three period presets: 30, 90, 180 days
- Dynamic amortization amount preview
- Coupon entry via rate (%) or amount — two-way sync
- Coupon generation considers amortizations (reducing nominal for future coupons)
- Results: Dirty Price, Redemption Income, Coupon Income, Total Income, Total/Annual Yield (nominal + real)
- Schedule table (read-only DataGridView): Date, Type, Nominal, Cumulative, Real, Cumulative Real
- Chart with 3 series: Nominal Yield (green spline), Real Yield (blue line), Inflation (red spline)
- Dynamic Y-axis scaling based on data range
- Localization: English (default) and Russian, switchable via Language menu
- User setting persists selected language across sessions
- Date formats, number formats, and chart formats adapt to culture
- About dialog with GitHub project link
- Typo `Name = "BondCacl"` fixed → `Name = "BondCalc"`
- Application icon
- README in English and Russian

### Calculation details
- `BuyPrice` = Clean Price + Accrued Interest
- `RepaymentIncome` = Face Value − Clean Price
- `RealRepaymentIncome` = amortizations and remaining face discounted individually by daily inflation from each payment date back to purchase date, minus BuyPrice
- `RealTotalCouponIncome` = each coupon discounted individually
- Daily compounding formula: `(1 + annualRate / 365.25)^days`
- Annual yield = total yield / days to repayment × 365.25
- Chart series calculated as daily wealth: cash received + clean price + accrued interest, relative to BuyPrice
- Inflation series: `(dailyInflation^days − 1) × 100`

### What exists but is incomplete
- **Export functionality**: Not yet implemented (About dialog suggests possible future feature)

### Known issues / technical debt
- Resource files contain unused keys: `GrpResults`, `LblYtmLabel`, `LblSellByLabel` (UI was removed)
- `System.Data.SqlClient` package is referenced but unused
- `Application/Interfaces/` removal artifacts in csproj (Compile/EmbeddedResource/None Remove)
- Chart axis titles are commented out in the chart code

---

## 8. Planned Work (TODO)

1. **Remove dead resource keys** — delete `GrpResults`, `LblYtmLabel`, `LblSellByLabel` from both `Strings.resx` and `Strings.ru.resx`
2. **Add Export functionality** — export schedule table and/or chart to TXT/CSV

---

## 9. Development Setup

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

## 10. Coding Conventions

- **Language**: All code, comments, identifiers in **English** (commit messages may be in Russian)
- **Naming**: PascalCase for classes/methods/properties, camelCase for locals/parameters
- **File names**: Match the public class name
- **Indentation**: 4 spaces, no tabs
- **Braces**: Allman style (opening brace on new line)
- **Properties**: Use `{ get; init; }` for domain entities (immutable after construction)
- **Nullability**: Enabled at project level — annotate with `?` where needed
- **Comments**: Keep to a minimum; only where the "why" is not obvious
- **No regions** except Windows Forms designer-generated code
- No new NuGet packages without explicit user request
- No tests unless explicitly asked for

---

## 11. AI Agent Rules

1. **Stay within the architecture** — Domain → Application → Presentation. Don't invent new layers.
2. **Don't overengineer** — No DI, no interfaces, no patterns unless the problem clearly needs it. If unsure, ask the user.
3. **Don't remove existing code** — unless the user explicitly asks you to.
4. **Keep domain entities simple** — data holders with `{ get; init; }`. Business logic goes in services.
5. **Don't add NuGet packages** — the project intentionally avoids external dependencies beyond what's already there.
6. **Don't write tests** — unless the user asks.
7. **Don't create user-facing documentation** (README, wiki, etc.) — unless the user asks.
8. **Don't commit changes** — stage and commit only when instructed.
9. **Don't create files outside the project scope** — no config files, no CI scripts, no build scripts.
10. **Align with the TODO** — check Section 8 for planned work before suggesting major changes.
11. **When in doubt, ask the user** — especially about domain logic (inflation calculation method, UI layout preferences).
