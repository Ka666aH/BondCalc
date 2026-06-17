using BondCalc.App.Domain.Entities;

namespace BondCalc.App.Presentation.Forms
{
    public partial class BondCacl : Form
    {
        public BondCacl()
        {
            InitializeComponent();
            UpdateAmortAmountLabel();
        }

        private void btnAddCoupon_Click(object? sender, EventArgs e)
        {
            dgvCoupons.Rows.Add(DateTime.Now.AddMonths(6), 0.0);
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

            dgvCoupons.Rows.Clear();

            for (var current = first; current <= last; current = current.AddDays(period))
            {
                dgvCoupons.Rows.Add(current, 0.0);
            }

            if (dgvCoupons.Rows.Count == 0)
            {
                MessageBox.Show("No coupons generated. Check the date range.", "Empty Result",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnAddAmortization_Click(object? sender, EventArgs e)
        {
            dgvAmortizations.Rows.Add(DateTime.Now, 0.0);
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
            GenerateAmortizations();
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

            dgvAmortizations.Rows.Clear();

            for (int i = 0; i < parts; i++)
            {
                var date = first.AddDays(i * period);
                if (i == parts - 1)
                {
                    date = last;
                }
                dgvAmortizations.Rows.Add(date, amount);
            }
        }

        private void btnReset_Click(object? sender, EventArgs e)
        {
            nudNominal.Value = 1000;
            nudPrice.Value = 1000;
            nudInflation.Value = 0;
            nudAccrued.Value = 0;
            dtpPlacement.Value = DateTime.Now;
            dtpRepayment.Value = DateTime.Now.AddYears(5);
            dtpFirstCoupon.Value = DateTime.Now;
            dtpLastCoupon.Value = DateTime.Now.AddYears(5);
            nudPeriod.Value = 182;
            nudAmortParts.Value = 5;
            dgvCoupons.Rows.Clear();
            dgvSchedule.Rows.Clear();
            lblYtmValue.Text = "-";
            lblSellByValue.Text = "-";
            UpdateAmortAmountLabel();
            GenerateAmortizations();
        }

        private void btnCalculate_Click(object? sender, EventArgs e)
        {
            try
            {
                var bond = BuildBond();
                var inflationRate = (double)nudInflation.Value / 100.0;

                // TODO: call BondService.Calculate(bond, inflationRate)
                // and populate results once the service is implemented

                lblYtmValue.Text = "Service not implemented";
                lblSellByValue.Text = "-";
                dgvSchedule.Rows.Clear();
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

        private Bond BuildBond()
        {
            var value = (double)nudNominal.Value;
            var placement = DateOnly.FromDateTime(dtpPlacement.Value);
            var repayment = DateOnly.FromDateTime(dtpRepayment.Value);

            var coupons = new List<Coupon>();
            foreach (DataGridViewRow row in dgvCoupons.Rows)
            {
                if (row.Cells[0].Value is DateTime date && row.Cells[1].Value is double amount)
                {
                    coupons.Add(new Coupon(amount, DateOnly.FromDateTime(date)));
                }
            }

            var amortizations = new List<Amortization>();
            foreach (DataGridViewRow row in dgvAmortizations.Rows)
            {
                if (row.Cells[0].Value is DateTime date && row.Cells[1].Value is double amount)
                {
                    amortizations.Add(new Amortization(amount, DateOnly.FromDateTime(date)));
                }
            }

            return new Bond(value, placement, repayment, coupons, amortizations);
        }

        private (double price, double accruedInterest) GetDealData()
        {
            return ((double)nudPrice.Value, (double)nudAccrued.Value);
        }
    }
}
