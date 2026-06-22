[Read in Russian](README.ru.md)

# BondCalc

**Inflation-adjusted bond yield calculator** — a Windows Forms desktop application for computing real (inflation-adjusted) yield-to-maturity on bonds with coupon and amortization schedules.

---

## Features

- Enter bond parameters: face value, placement date, maturity date, coupon schedule, amortization (principal repayment) schedule
- Enter purchase deal details: price, accrued interest, purchase date
- Compute **nominal** and **real (inflation-adjusted)** yield-to-maturity
- Inflation adjustment using daily compounding: `(1 + rate / 365.25)^days`
- **Coupon schedule table** — date, nominal amount, real amount, cumulative totals
- **Cumulative yield chart** — 3 series: nominal yield, real yield, inflation curve
- Manual add/remove of coupons and amortizations, or auto-generate by period (30/90/180 days)
- Dynamic amortization amount preview
- Localization: English (default) and Russian, switchable via Language menu
