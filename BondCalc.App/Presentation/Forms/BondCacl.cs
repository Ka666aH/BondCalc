using System.Globalization;
using BondCalc.App.Application.Services;
using BondCalc.App.Domain.Entities;
namespace BondCalc.App.Presentation.Forms
{
    public partial class BondCacl : Form
    {
        public BondCacl()
        {
            InitializeComponent();
            Reset();
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
                MessageBox.Show("Period must be greater than 0.", "Invalid Input",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (first > last)
            {
                MessageBox.Show("First coupon date must be before last coupon date.", "Invalid Input",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            for (var current = first; current <= last; current = current.AddDays(period))
            {
                dgvCoupons.Rows.Add(DateOnly.FromDateTime(current), amount);
            }

            if (dgvCoupons.Rows.Count == 0)
            {
                MessageBox.Show("No coupons generated. Check the date range.", "Empty Result",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
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
            lblAmortAmount.Text = $"Amount: {amount:F2}";
        }

        private void GenerateAmortizations()
        {
            var parts = (int)nudAmortParts.Value;
            var first = dtpPlacement.Value;
            var last = dtpRepayment.Value;

            var nominal = (double)nudNominal.Value;
            var amount = nominal / parts;
            var totalDays = (last - first).Days;
            var period = parts > 1 ? totalDays / (parts - 1) : 0;

            for (int i = 0; i < parts; i++)
            {
                var date = first.AddDays(i * period);
                if (i == parts - 1)
                {
                    date = last;
                }
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
                        row.Type,
                        row.NominalAmount.ToString("N2"),
                        row.CumulativeIncome.ToString("N2"),
                        row.RealAmount.ToString("N2"),
                        row.CumulativeRealIncome.ToString("N2"));
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    ex.Message,
                    "Calculation Error",
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
    }
}
//TODO
// Шаг в дате купона
// Локализация
// Сделать удобную форму
// Дата погашения заменяет последний купон