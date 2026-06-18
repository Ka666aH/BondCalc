using System.Globalization;
using System.Windows.Forms.DataVisualization.Charting;
using BondCalc.App.Application.Services;
using BondCalc.App.Domain.Entities;
namespace BondCalc.App.Presentation.Forms
{
    public partial class BondCacl : Form
    {
        public BondCacl()
        {
            Localization.SetCulture("en-US");
            InitializeComponent();
            ApplyLanguage();
            Reset();
        }

        private void OnLanguageEnglish(object? sender, EventArgs e)
        {
            Localization.SetCulture("en-US");
            ApplyLanguage();
            Reset();
        }

        private void OnLanguageRussian(object? sender, EventArgs e)
        {
            Localization.SetCulture("ru-RU");
            ApplyLanguage();
            Reset();
        }

        private void ApplyLanguage()
        {
            var t = Localization.GetString;

            Text = t("FormTitle");

            grpParameters.Text = t("GrpParameters");
            grpCoupons.Text = t("GrpCoupons");
            grpAmortizations.Text = t("GrpAmortizations");
            grpDeal.Text = t("GrpDeal");
            grpOutput.Text = t("GrpOutput");
            grpSchedule.Text = t("GrpSchedule");
            grpResults.Text = t("GrpResults");

            lblNominal.Text = t("LblNominal");
            lblPlacement.Text = t("LblPlacement");
            lblRepayment.Text = t("LblRepayment");
            lblInflation.Text = t("LblInflation");
            lblPrice.Text = t("LblPrice");
            lblAccrued.Text = t("LblAccrued");
            label1.Text = t("LblPurchaseDate");

            lblFirstCoupon.Text = t("LblFirstCoupon");
            lblLastCoupon.Text = t("LblLastCoupon");
            lblPeriod.Text = t("LblPeriod");
            lblCouponAmount.Text = t("LblCouponAmount");

            lblAmortParts.Text = t("LblAmortParts");

            btnCalculate.Text = t("BtnCalculate");
            btnAddCoupon.Text = t("BtnAdd");
            btnRemoveCoupon.Text = t("BtnRemove");
            btnClearCoupons.Text = t("BtnClear");
            btnGenerate.Text = t("BtnGenerate");
            btnAddAmortization.Text = t("BtnAdd");
            btnRemoveAmortization.Text = t("BtnRemove");
            btnClearAmortizations.Text = t("BtnClear");
            btnGenerateAmort.Text = t("BtnGenerate");

            lblNominalHeader.Text = t("LblNominalHeader");
            lblBuyPrice.Text = t("LblBuyPrice");
            lblRepayIncome.Text = t("LblRepayIncome");
            lblCouponIncome.Text = t("LblCouponIncome");
            lblTotalIncome.Text = t("LblTotalIncome");
            lblTotalYield.Text = t("LblTotalYield");
            lblAnnualYield.Text = t("LblAnnualYield");
            lblRealHeader.Text = t("LblRealHeader");
            lblRealIncome.Text = t("LblRealIncome");
            lblRealYield.Text = t("LblRealYield");
            lblRealAnnualYield.Text = t("LblRealAnnualYield");
            lblRealRepayIncome.Text = t("LblRealRepayIncome");
            lblRealCouponIncome.Text = t("LblRealCouponIncome");

            lblYtmLabel.Text = t("LblYtmLabel");
            lblSellByLabel.Text = t("LblSellByLabel");

            dataGridViewTextBoxColumn3.HeaderText = t("ColDate");
            dataGridViewTextBoxColumn4.HeaderText = t("ColAmount");
            dataGridViewTextBoxColumn1.HeaderText = t("ColDate");
            dataGridViewTextBoxColumn2.HeaderText = t("ColAmount");
            colSchDate.HeaderText = t("ColDate");
            colSchType.HeaderText = t("ColType");
            colSchNominal.HeaderText = t("ColNominalAmount");
            colSchCumNominal.HeaderText = t("ColCumIncome");
            colSchReal.HeaderText = t("ColRealAmount");
            colSchCumReal.HeaderText = t("ColCumRealIncome");

            toolsMenuItem.Text = t("MenuLanguage");
            englishItem.Text = t("MenuEnglish");
            russianItem.Text = t("MenuRussian");

            UpdateAmortAmountLabel();
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

        private void btnAddCoupon_Click(object? sender, EventArgs e)
        {
            dgvCoupons.Rows.Add(DateOnly.FromDateTime(DateTime.Now), (double)nudCouponAmount.Value);
        }

        private void btnRemoveCoupon_Click(object? sender, EventArgs e)
        {
            if (dgvCoupons.SelectedRows.Count > 0)
            {
                dgvCoupons.Rows.RemoveAt(dgvCoupons.SelectedRows[0].Index);
            }
        }

        private void btnClearCoupons_Click(object? sender, EventArgs e)
        {
            dgvCoupons.Rows.Clear();
        }

        private void btnGenerateCoupons_Click(object? sender, EventArgs e)
        {
            var first = dtpFirstCoupon.Value;
            var last = dtpLastCoupon.Value;
            var period = (int)nudPeriod.Value;
            var amount = (double)nudCouponAmount.Value;

            if (period <= 0)
            {
                MessageBox.Show(Localization.GetString("MsgPeriodInvalid"), Localization.GetString("MsgPeriodInvalidTitle"),
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (first > last)
            {
                MessageBox.Show(Localization.GetString("MsgDateOrderInvalid"), Localization.GetString("MsgDateOrderInvalidTitle"),
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            for (var current = first; current <= last; current = current.AddDays(period))
            {
                dgvCoupons.Rows.Add(DateOnly.FromDateTime(current), amount);
            }

            if (dgvCoupons.Rows.Count == 0)
            {
                MessageBox.Show(Localization.GetString("MsgNoCoupons"), Localization.GetString("MsgNoCouponsTitle"),
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnPeriod_Click(object? sender, EventArgs e)
        {
            if (sender is Button btn && int.TryParse(btn.Text, out var days))
            {
                nudPeriod.Value = days;
            }
        }

        private void btnAddAmortization_Click(object? sender, EventArgs e)
        {
            dgvAmortizations.Rows.Add(DateOnly.FromDateTime(DateTime.Now), 0.0);
        }

        private void btnRemoveAmortization_Click(object? sender, EventArgs e)
        {
            if (dgvAmortizations.SelectedRows.Count > 0)
            {
                dgvAmortizations.Rows.RemoveAt(dgvAmortizations.SelectedRows[0].Index);
            }
        }

        private void btnClearAmortizations_Click(object? sender, EventArgs e)
        {
            dgvAmortizations.Rows.Clear();
        }

        private void btnGenerateAmort_Click(object? sender, EventArgs e)
        {
            GenerateAmortizations();
        }

        private void nudAmortParts_ValueChanged(object? sender, EventArgs e)
        {
            UpdateAmortAmountLabel();
        }

        private void UpdateAmortAmountLabel()
        {
            var parts = (int)nudAmortParts.Value;
            var nominal = (double)nudNominal.Value;
            var amount = nominal / parts;
            lblAmortAmount.Text = $"{Localization.GetString("AmortAmountPrefix")} {amount:F2}";
        }

        private void GenerateAmortizations()
        {
            var parts = (int)nudAmortParts.Value;
            var first = dtpPlacement.Value;
            var last = dtpRepayment.Value;

            var nominal = (double)nudNominal.Value;
            var amount = nominal / parts;
            var totalDays = (last - first).Days;
            var period = parts > 1 ? totalDays / parts : 0;

            for (int i = 1; i <= parts; i++)
            {
                var date = i == parts ? last : first.AddDays(i * period);
                dgvAmortizations.Rows.Add(DateOnly.FromDateTime(date), amount);
            }
        }

        private void btnReset_Click(object? sender, EventArgs e)
        {
            Reset();
        }
        private void Reset()
        {
            nudNominal.Value = 1000;
            nudPrice.Value = 1000;
            nudPurchase.Value = DateTime.Now;
            nudInflation.Value = 15;
            nudAccrued.Value = 0;
            dtpPlacement.Value = DateTime.Now;
            dtpRepayment.Value = DateTime.Now.AddYears(5);
            dtpFirstCoupon.Value = DateTime.Now;
            dtpLastCoupon.Value = DateTime.Now.AddYears(5);
            nudPeriod.Value = 30;
            nudCouponAmount.Value = 0;
            nudAmortParts.Value = 5;
            dgvCoupons.Rows.Clear();
            dgvAmortizations.Rows.Clear();
            dgvSchedule.Rows.Clear();
            chartSchedule.Series.Clear();
            ClearResults();
            UpdateAmortAmountLabel();
        }

        private void btnCalculate_Click(object? sender, EventArgs e)
        {
            try
            {
                dgvCoupons.EndEdit();
                dgvAmortizations.EndEdit();

                var bond = BuildBond();
                var deal = BuildDeal();
                var inflationRate = (double)nudInflation.Value / 100.0;

                var result = new Calculator(bond, deal, inflationRate);

                lblBuyPriceVal.Text = result.BuyPrice.ToString("N2");

                lblRepayIncomeVal.Text = result.RepaymentIncome.ToString("N2");
                lblCouponIncomeVal.Text = result.TotalCouponIncome.ToString("N2");
                lblTotalIncomeVal.Text = result.TotalIncome.ToString("N2");
                lblTotalYieldVal.Text = result.TotalYield.ToString("P2");
                lblAnnualYieldVal.Text = result.AnnualYield.ToString("P2");
                lblRealRepayIncomeVal.Text = result.RealRepaymentIncome.ToString("N2");
                lblRealCouponIncomeVal.Text = result.RealTotalCouponIncome.ToString("N2");
                lblRealIncomeVal.Text = result.RealTotalIncome.ToString("N2");
                lblRealYieldVal.Text = result.RealTotalYield.ToString("P2");
                lblRealAnnualYieldVal.Text = result.RealAnnualYield.ToString("P2");

                dgvSchedule.Rows.Clear();
                foreach (var row in result.Schedule)
                {
                    dgvSchedule.Rows.Add(
                        row.Date.ToString("dd.MM.yyyy"),
                        TranslateType(row.Type),
                        row.NominalAmount.ToString("N2"),
                        row.CumulativeIncome.ToString("N2"),
                        row.RealAmount.ToString("N2"),
                        row.CumulativeRealIncome.ToString("N2"));
                }

                chartSchedule.Series.Clear();
                var nominalSeries = new Series(Localization.GetString("ChartNominalYield"))
                {
                    ChartType = SeriesChartType.Line,
                    Color = Color.FromArgb(180, Color.Green),
                    BorderWidth = 2,
                    IsVisibleInLegend = true
                };
                var realSeries = new Series(Localization.GetString("ChartRealYield"))
                {
                    ChartType = SeriesChartType.Line,
                    Color = Color.FromArgb(180, Color.DodgerBlue),
                    BorderWidth = 2,
                    BorderDashStyle = ChartDashStyle.Dash,
                    IsVisibleInLegend = true
                };
                var inflationSeries = new Series(Localization.GetString("ChartInflation"))
                {
                    ChartType = SeriesChartType.Line,
                    Color = Color.FromArgb(180, Color.Red),
                    BorderWidth = 2,
                    IsVisibleInLegend = true
                };
                foreach (var p in result.NominalYieldSeries)
                    nominalSeries.Points.AddXY(p.Date.ToDateTime(TimeOnly.MinValue), p.Value);
                foreach (var p in result.RealYieldSeries)
                    realSeries.Points.AddXY(p.Date.ToDateTime(TimeOnly.MinValue), p.Value);
                foreach (var p in result.InflationSeries)
                    inflationSeries.Points.AddXY(p.Date.ToDateTime(TimeOnly.MinValue), p.Value);
                chartSchedule.Series.Add(nominalSeries);
                chartSchedule.Series.Add(realSeries);
                chartSchedule.Series.Add(inflationSeries);
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    ex.Message,
                    Localization.GetString("MsgCalcErrorTitle"),
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        private void ClearResults()
        {
            lblBuyPriceVal.Text = "-";
            lblRepayIncomeVal.Text = "-";
            lblCouponIncomeVal.Text = "-";
            lblTotalIncomeVal.Text = "-";
            lblTotalYieldVal.Text = "-";
            lblAnnualYieldVal.Text = "-";
            lblRealRepayIncomeVal.Text = "-";
            lblRealCouponIncomeVal.Text = "-";
            lblRealIncomeVal.Text = "-";
            lblRealYieldVal.Text = "-";
            lblRealAnnualYieldVal.Text = "-";
        }

        private Bond BuildBond()
        {
            var value = (double)nudNominal.Value;
            var placement = DateOnly.FromDateTime(dtpPlacement.Value);
            var repayment = DateOnly.FromDateTime(dtpRepayment.Value);
            var purchaseDate = DateOnly.FromDateTime(nudPurchase.Value);

            var coupons = new List<Coupon>();
            foreach (DataGridViewRow row in dgvCoupons.Rows)
            {
                if (TryGetDate(row.Cells[0], out var date)
                    && TryGetDouble(row.Cells[1], out var amount)
                    && date >= purchaseDate)
                {
                    coupons.Add(new Coupon(amount, date));
                }
            }

            var amortizations = new List<Amortization>();
            foreach (DataGridViewRow row in dgvAmortizations.Rows)
            {
                if (TryGetDate(row.Cells[0], out var date)
                    && TryGetDouble(row.Cells[1], out var amount)
                    && date >= purchaseDate)
                {
                    amortizations.Add(new Amortization(amount, date));
                }
            }

            return new Bond(value, placement, repayment, coupons, amortizations);
        }

        private static bool TryGetDate(DataGridViewCell cell, out DateOnly result)
        {
            if (cell.Value is DateTime dt)
            {
                result = DateOnly.FromDateTime(dt);
                return true;
            }
            if (cell.Value is DateOnly do1)
            {
                result = do1;
                return true;
            }
            if (cell.Value is string s
                && (DateOnly.TryParse(s, CultureInfo.CurrentCulture, DateTimeStyles.None, out var parsed)
                    || DateOnly.TryParse(s, CultureInfo.InvariantCulture, DateTimeStyles.None, out parsed)))
            {
                result = parsed;
                return true;
            }
            result = default;
            return false;
        }

        private static bool TryGetDouble(DataGridViewCell cell, out double result)
        {
            if (cell.Value is double d)
            {
                result = d;
                return true;
            }
            if (cell.Value is string s
                && (double.TryParse(s, NumberStyles.Any, CultureInfo.CurrentCulture, out var parsed)
                    || double.TryParse(s, NumberStyles.Any, CultureInfo.InvariantCulture, out parsed)))
            {
                result = parsed;
                return true;
            }
            result = 0;
            return false;
        }
        private Deal BuildDeal()
        {
            var price = (double)nudPrice.Value;
            var aci = (double)nudAccrued.Value;
            var date = nudPurchase.Value;
            return new Deal(price, aci, DateOnly.FromDateTime(date));
        }

        private void dtpRepayment_ValueChanged(object sender, EventArgs e)
        {
            dtpLastCoupon.Value = dtpRepayment.Value;
        }
    }
}
