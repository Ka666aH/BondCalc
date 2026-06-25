[Русский](README.ru.md)

# BondCalc

**Inflation-adjusted bond yield calculator** — a Windows Forms desktop application for computing real (inflation-adjusted) yield-to-maturity on bonds with coupon and amortization schedules.

---

## Features

- **Bond parameters**: face value, issue date, maturity date
- **Amortization schedule**: manual add/remove/clear, or auto-generate by splitting nominal into N equal parts with dynamic amount preview
- **Coupon schedule**: manual add/remove/clear, or auto-generate by period (30/90/180 day presets); generation respects amortizations (reducing nominal); rate (%) and amount two-way sync
- **Deal entry**: clean price, accrued interest (ACI), purchase date, annual inflation rate
- **Results** — nominal (left) and real/inflation-adjusted (right):
  - Dirty Price, Redemption Income, Coupon Income, Total Income, Total Yield, Annual Yield
- **Payment schedule table**: read-only grid with Date, Type, Nominal, Cumulative, Real, Cumulative Real columns
- **Cumulative yield chart**: 3 smoothed spline series — Nominal Yield (green), Real Yield (blue), Inflation (red); dynamic Y-axis scaling
- **Export**: schedule, parameters, and results to a formatted TXT file
- **Localization**: English (default) and Russian, switchable via Language menu; persists between sessions
- **Keyboard shortcuts**: Ctrl+A (About), Ctrl+E (Export), Ctrl+L (Language); access keys on all menu items
- **About dialog**: app info with a link to the GitHub project page
- **Reset**: one-click reset of all inputs to defaults

---

## Usage Guide

### 1. Bond Parameters
Enter the bond's **face value** (nominal), **issue date**, and **maturity date**.

### 2. Amortizations (optional)
If the bond has partial principal repayments before maturity:
- Click **Add** to add rows manually, or set the number of parts and click **Generate** to split the nominal into equal payments spread between issue and maturity
- Multi-select rows, press **F2**, and edit one cell to update all selected rows at once
- Click **Remove** to delete all selected rows

### 3. Coupons
- Set the **first** and **last** coupon dates and the **period** in days (or use the 30/90/180 presets)
- Enter a coupon **rate (%)** or a fixed **amount** — they sync automatically
- Click **Generate** to create the schedule, or **Add** to insert rows manually
- When amortizations exist, coupon amounts automatically adjust for the reduced nominal

### 4. Deal
Enter the **clean price** you paid, **accrued interest** **purchase date**, and the expected **annual inflation rate** (in percent).

### 5. Calculate
Press **Calculate** to compute all results, the schedule table, and the chart.

### 6. Export
Use **Export > As TXT** from the menu (**Ctrl+E**) to save a formatted report.

### 7. Language
Switch between English and Russian via the **Language** menu (**Ctrl+L**). The choice is saved and restored on next launch.
