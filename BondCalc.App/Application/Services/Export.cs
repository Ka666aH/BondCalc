using System.Globalization;
using BondCalc.App.Domain.Entities;

namespace BondCalc.App.Application.Services
{
    public class Export
    {
        private readonly Bond _bond;
        private readonly Deal _deal;
        private readonly double _annualInflationRatePercent;
        private readonly Calculator _calculator;

        public Export(Bond bond, Deal deal, double annualInflationRatePercent, Calculator calculator)
        {
            _bond = bond;
            _deal = deal;
            _annualInflationRatePercent = annualInflationRatePercent;
            _calculator = calculator;
        }

        public void ToTxt(string filePath)
        {
            var lines = new List<string>();
            var t = Localization.GetString;
            var fmt = CultureInfo.CurrentCulture;

            var title = t("FormTitle");
            lines.Add(new string('=', title.Length));
            lines.Add(title);
            lines.Add(new string('=', title.Length));
            lines.Add("");

            WriteSection(lines, "GrpParameters", fmt,
                ("LblNominal", _bond.Value.ToString("N2", fmt)),
                ("LblPlacement", _bond.Placement.ToString("d", fmt)),
                ("LblRepayment", _bond.Repayment.ToString("d", fmt)),
                ("LblInflation", _annualInflationRatePercent.ToString("N2", fmt) + " %"));

            lines.Add(t("GrpCoupons"));
            if (_bond.Coupons.Count > 0)
            {
                var colDate = t("ColDate");
                var colAmount = t("ColAmount");
                int wNum = 2;
                int wDate = Math.Max(colDate.Length, 10);
                int wAmount = Math.Max(colAmount.Length, 10);
                lines.Add($"  {"".PadRight(wNum)}  {colDate.PadRight(wDate)}  {colAmount.PadLeft(wAmount)}");
                for (int i = 0; i < _bond.Coupons.Count; i++)
                {
                    var c = _bond.Coupons[i];
                    lines.Add($"  {(i + 1).ToString().PadRight(wNum)}  {c.Date.ToString("d", fmt).PadRight(wDate)}  {c.Amount.ToString("N2", fmt).PadLeft(wAmount)}");
                }
            }
            else
            {
                lines.Add("  \u2014");
            }
            lines.Add("");

            lines.Add(t("GrpAmortizations"));
            if (_bond.Amortizations.Count > 0)
            {
                var colDate = t("ColDate");
                var colAmount = t("ColAmount");
                int wNum = 2;
                int wDate = Math.Max(colDate.Length, 10);
                int wAmount = Math.Max(colAmount.Length, 10);
                lines.Add($"  {"".PadRight(wNum)}  {colDate.PadRight(wDate)}  {colAmount.PadLeft(wAmount)}");
                for (int i = 0; i < _bond.Amortizations.Count; i++)
                {
                    var a = _bond.Amortizations[i];
                    lines.Add($"  {(i + 1).ToString().PadRight(wNum)}  {a.Date.ToString("d", fmt).PadRight(wDate)}  {a.Amount.ToString("N2", fmt).PadLeft(wAmount)}");
                }
            }
            else
            {
                lines.Add("  \u2014");
            }
            lines.Add("");

            WriteSection(lines, "GrpDeal", fmt,
                ("LblPrice", _deal.Price.ToString("N2", fmt)),
                ("LblAccrued", _deal.ACI.ToString("N2", fmt)),
                ("LblPurchaseDate", _deal.Date.ToString("d", fmt)));

            WriteSection(lines, "GrpOutput", fmt,
                ("LblBuyPrice", _calculator.BuyPrice.ToString("N2", fmt)),
                ("LblRepayIncome", _calculator.RepaymentIncome.ToString("N2", fmt)),
                ("LblRealRepayIncome", _calculator.RealRepaymentIncome.ToString("N2", fmt)),
                ("LblCouponIncome", _calculator.TotalCouponIncome.ToString("N2", fmt)),
                ("LblRealCouponIncome", _calculator.RealTotalCouponIncome.ToString("N2", fmt)),
                ("LblTotalIncome", _calculator.TotalIncome.ToString("N2", fmt)),
                ("LblRealIncome", _calculator.RealTotalIncome.ToString("N2", fmt)),
                ("LblTotalYield", _calculator.TotalYield.ToString("P2", fmt)),
                ("LblRealTotalYield", _calculator.RealTotalYield.ToString("P2", fmt)),
                ("LblAnnualYield", _calculator.AnnualYield.ToString("P2", fmt)),
                ("LblRealAnnualYield", _calculator.RealAnnualYield.ToString("P2", fmt)));

            lines.Add(t("GrpSchedule"));
            if (_calculator.Schedule.Count > 0)
            {
                var colDate = t("ColDate");
                var colType = t("ColType");
                var colNominal = t("ColNominalAmount");
                var colCum = t("ColCumIncome");
                var colReal = t("ColRealAmount");
                var colCumReal = t("ColCumRealIncome");

                var allTypes = _calculator.Schedule.Select(r => TranslateType(r.Type));
                int wDate = Math.Max(colDate.Length, 10);
                int wType = Math.Max(allTypes.Concat([colType]).Max(s => s.Length), 8);
                int wNom = Math.Max(colNominal.Length, 10);
                int wCum = Math.Max(colCum.Length, 10);
                int wReal = Math.Max(colReal.Length, 10);
                int wCumReal = Math.Max(colCumReal.Length, 10);

                var header = $"  {colDate.PadRight(wDate)}  {colType.PadRight(wType)}  {colNominal.PadLeft(wNom)}  {colCum.PadLeft(wCum)}  {colReal.PadLeft(wReal)}  {colCumReal.PadLeft(wCumReal)}";
                lines.Add(header);

                foreach (var row in _calculator.Schedule)
                {
                    var date = row.Date.ToString("d", fmt);
                    var type = TranslateType(row.Type);
                    lines.Add($"  {date.PadRight(wDate)}  {type.PadRight(wType)}  {row.NominalAmount.ToString("N2", fmt).PadLeft(wNom)}  {row.CumulativeIncome.ToString("N2", fmt).PadLeft(wCum)}  {row.RealAmount.ToString("N2", fmt).PadLeft(wReal)}  {row.CumulativeRealIncome.ToString("N2", fmt).PadLeft(wCumReal)}");
                }
            }
            else
            {
                lines.Add("  \u2014");
            }

            File.WriteAllLines(filePath, lines);
        }

        private void WriteSection(List<string> lines, string titleKey, CultureInfo fmt, params (string labelKey, string value)[] items)
        {
            var t = Localization.GetString;
            lines.Add(t(titleKey));

            int maxLabelLen = items.Max(x => t(x.labelKey).TrimEnd(':').Length);
            foreach (var (labelKey, value) in items)
            {
                lines.Add($"  {t(labelKey).TrimEnd(':').PadRight(maxLabelLen)}:  {value}");
            }

            lines.Add("");
        }

        private static string TranslateType(string type)
        {
            return type switch
            {
                "Coupon" => Localization.GetString("TypeCoupon"),
                "Amortization" => Localization.GetString("TypeAmortization"),
                "Repayment" => Localization.GetString("TypeRepayment"),
                _ => type
            };
        }
    }
}
