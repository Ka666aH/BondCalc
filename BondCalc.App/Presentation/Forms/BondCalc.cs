using System.Diagnostics;
using System.Globalization;
using System.Windows.Forms.DataVisualization.Charting;
using BondCalc.App.Application.Services;
using BondCalc.App.Domain.Entities;
namespace BondCalc.App.Presentation.Forms
{
    public partial class BondCalc : Form
    {
        private Chart chartSchedule = null!;
        private readonly Dictionary<string, string> _savedNudText = new();
        private CultureInfo? _oldCulture;

        public BondCalc()
        {
            var saved = Properties.Settings.Default.Localization;
            Localization.SetCulture(saved is "ru-RU" or "en-US" ? saved : "en-US");

            InitializeComponent();
            InitializeChart();
            ApplyLanguage();
            Reset();
        }
        private void InitializeChart()
        {
            chartSchedule = new Chart();
            chartSchedule.Dock = DockStyle.Fill;
            chartSchedule.BackColor = SystemColors.Control;
            chartSchedule.Name = "chartSchedule";

            var chartArea = new ChartArea("Default");
            chartArea.BackColor = Color.Transparent;
            chartArea.Position.Auto = false;
            chartArea.Position = new ElementPosition(0, 0, 100, 100);
            chartArea.InnerPlotPosition = new ElementPosition(7.5f, 5, 95, 90);
            chartArea.AxisX.IntervalAutoMode = IntervalAutoMode.VariableCount;
            chartArea.AxisX.MajorGrid.LineColor = Color.FromArgb(210, 210, 210);
            chartArea.AxisY.LabelStyle.Format = "{0:F1}%";
            chartArea.AxisY.MajorGrid.LineColor = Color.FromArgb(210, 210, 210);
            chartArea.AxisX.IsMarginVisible = false;
            chartArea.AxisY.IsMarginVisible = false;
            chartArea.AxisX.IsLabelAutoFit = false;
            chartArea.AxisY.IsLabelAutoFit = false;
            chartArea.AxisX.LabelStyle.Angle = 0;
            chartArea.AxisY.LabelStyle.Angle = 0;
            chartArea.AxisX.LabelStyle.Font = new Font(Font.FontFamily, 7);
            chartArea.AxisY.LabelStyle.Font = new Font(Font.FontFamily, 7);
            chartSchedule.ChartAreas.Add(chartArea);

            var legend = new Legend();
            legend.BackColor = Color.Transparent;
            legend.Docking = Docking.Bottom;
            legend.Alignment = StringAlignment.Center;
            chartSchedule.Legends.Add(legend);

            pnlChartContainer.Controls.Add(chartSchedule);
        }

        private void OnLanguageEnglish(object? sender, EventArgs e)
        {
            try
            {
                SaveNumericTexts();
                Localization.SetCulture("en-US");
                ApplyLanguage();
                UpdateChartSeriesLanguage();
                Properties.Settings.Default.Localization = "en-US";
                Properties.Settings.Default.Save();
            }
            catch (Exception ex)
            {
                ShowError(ex);
            }
        }

        private void OnLanguageRussian(object? sender, EventArgs e)
        {
            try
            {
                SaveNumericTexts();
                Localization.SetCulture("ru-RU");
                ApplyLanguage();
                UpdateChartSeriesLanguage();
                Properties.Settings.Default.Localization = "ru-RU";
                Properties.Settings.Default.Save();
            }
            catch (Exception ex)
            {
                ShowError(ex);
            }
        }

        private void OnAboutClick(object? sender, EventArgs e)
        {
            var result = MessageBox.Show(
                Localization.GetString("AboutText"),
                Localization.GetString("AboutTitle"),
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Information);
            if (result == DialogResult.Yes)
            {
                try
                {
                    Process.Start(new ProcessStartInfo("https://github.com/Ka666aH/BondCalc")
                        { UseShellExecute = true });
                }
                catch { }
            }
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
            aboutMenuItem.Text = t("MenuAbout");

            RefreshScheduleTypes();
            RefreshScheduleFormats();
            RefreshResultFormats();
            UpdateChartDateFormat();
            UpdateAmortAmountLabel();
            RefreshNumericFormats();
            RefreshDatePickerFormats();
        }

        private void RefreshNumericFormats()
        {
            if (_oldCulture == null) return;
            foreach (var nud in new NumericUpDown[]
            {
                nudNominal, nudInflation, nudPrice, nudAccrued, nudCouponAmount,
                nudPeriod, nudAmortParts
            })
            {
                if (_savedNudText.TryGetValue(nud.Name, out var text)
                    && decimal.TryParse(text, NumberStyles.Any, _oldCulture, out var val))
                {
                    val = Math.Max(nud.Minimum, Math.Min(nud.Maximum, val));
                    nud.Value = nud.Minimum;
                    nud.Value = nud.Maximum;
                    nud.Value = val;
                }
            }
        }

        private void SaveNumericTexts()
        {
            _oldCulture = CultureInfo.CurrentCulture;
            _savedNudText.Clear();
            foreach (var nud in new NumericUpDown[]
            {
                nudNominal, nudInflation, nudPrice, nudAccrued, nudCouponAmount,
                nudPeriod, nudAmortParts
            })
            {
                _savedNudText[nud.Name] = nud.Text;
            }
        }

        private void RefreshDatePickerFormats()
        {
            var pattern = CultureInfo.CurrentCulture.DateTimeFormat.ShortDatePattern;
            dtpRepayment.ValueChanged -= dtpRepayment_ValueChanged;
            foreach (var dtp in new[]
            {
                dtpPlacement, dtpRepayment, dtpFirstCoupon, dtpLastCoupon, nudPurchase
            })
            {
                dtp.Format = DateTimePickerFormat.Custom;
                dtp.CustomFormat = pattern;
            }
            dtpRepayment.ValueChanged += dtpRepayment_ValueChanged;
        }

        private void UpdateChartSeriesLanguage()
        {
            foreach (Series series in chartSchedule.Series)
            {
                if (series.Tag is string key)
                {
                    series.Name = Localization.GetString(key);
                    series.LegendText = Localization.GetString(key);
                }
            }
        }

        private void UpdateChartDateFormat()
        {
            if (chartSchedule.ChartAreas.Count == 0) return;
            var format = CultureInfo.CurrentCulture.DateTimeFormat.ShortDatePattern
                .Replace("yyyy", "yy");
            chartSchedule.ChartAreas[0].AxisX.LabelStyle.Format = format;
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

        private void RefreshScheduleTypes()
        {
            foreach (DataGridViewRow row in dgvSchedule.Rows)
            {
                if (row.Cells[1].Tag is string originalType)
                {
                    row.Cells[1].Value = TranslateType(originalType);
                }
            }
        }

        private void RefreshScheduleFormats()
        {
            foreach (DataGridViewRow row in dgvSchedule.Rows)
            {
                if (row.Cells[0].Tag is DateOnly date)
                    row.Cells[0].Value = date.ToString("d");
                if (row.Cells[2].Tag is double d2)
                    row.Cells[2].Value = d2.ToString("N2");
                if (row.Cells[3].Tag is double d3)
                    row.Cells[3].Value = d3.ToString("N2");
                if (row.Cells[4].Tag is double d4)
                    row.Cells[4].Value = d4.ToString("N2");
                if (row.Cells[5].Tag is double d5)
                    row.Cells[5].Value = d5.ToString("N2");
            }
        }

        private void btnAddCoupon_Click(object? sender, EventArgs e)
        {
            try
            {
                dgvCoupons.Rows.Add(DateOnly.FromDateTime(DateTime.Now), (double)nudCouponAmount.Value);
            }
            catch (Exception ex)
            {
                ShowError(ex);
            }
        }

        private void btnRemoveCoupon_Click(object? sender, EventArgs e)
        {
            try
            {
                if (dgvCoupons.SelectedRows.Count > 0)
                {
                    var index = dgvCoupons.SelectedRows[0].Index;
                    if (index >= 0 && index < dgvCoupons.Rows.Count)
                    {
                        dgvCoupons.Rows.RemoveAt(index);
                    }
                }
            }
            catch (Exception ex)
            {
                ShowError(ex);
            }
        }

        private void btnClearCoupons_Click(object? sender, EventArgs e)
        {
            dgvCoupons.Rows.Clear();
        }

        private void btnGenerateCoupons_Click(object? sender, EventArgs e)
        {
            try
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
            catch (Exception ex)
            {
                ShowError(ex);
            }
        }

        private void btnPeriod_Click(object? sender, EventArgs e)
        {
            try
            {
                if (sender is Button btn && int.TryParse(btn.Text, out var days))
                {
                    days = Math.Max((int)nudPeriod.Minimum, Math.Min((int)nudPeriod.Maximum, days));
                    nudPeriod.Value = days;
                }
            }
            catch (Exception ex)
            {
                ShowError(ex);
            }
        }

        private void btnAddAmortization_Click(object? sender, EventArgs e)
        {
            try
            {
                dgvAmortizations.Rows.Add(DateOnly.FromDateTime(DateTime.Now), 0.0);
            }
            catch (Exception ex)
            {
                ShowError(ex);
            }
        }

        private void btnRemoveAmortization_Click(object? sender, EventArgs e)
        {
            try
            {
                if (dgvAmortizations.SelectedRows.Count > 0)
                {
                    var index = dgvAmortizations.SelectedRows[0].Index;
                    if (index >= 0 && index < dgvAmortizations.Rows.Count)
                    {
                        dgvAmortizations.Rows.RemoveAt(index);
                    }
                }
            }
            catch (Exception ex)
            {
                ShowError(ex);
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
            try
            {
                var parts = (int)nudAmortParts.Value;
                var nominal = (double)nudNominal.Value;
                var amount = nominal / parts;
                lblAmortAmount.Text = $"{Localization.GetString("AmortAmountPrefix")} {amount:F2}";
            }
            catch (Exception ex)
            {
                ShowError(ex);
            }
        }

        private void GenerateAmortizations()
        {
            try
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
            catch (Exception ex)
            {
                ShowError(ex);
            }
        }

        private void btnReset_Click(object? sender, EventArgs e)
        {
            try
            {
                Reset();
            }
            catch (Exception ex)
            {
                ShowError(ex);
            }
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

                if (DateOnly.FromDateTime(nudPurchase.Value) >= DateOnly.FromDateTime(dtpRepayment.Value))
                {
                    MessageBox.Show(
                        Localization.GetString("MsgDaysToRepaymentZero"),
                        Localization.GetString("MsgInvalidInputTitle"),
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);
                    return;
                }

                var bond = BuildBond();
                var deal = BuildDeal();
                var inflationRate = (double)nudInflation.Value / 100.0;

                var result = new Calculator(bond, deal, inflationRate);

                SetResultValue(lblBuyPriceVal, result.BuyPrice, "N2");
                SetResultValue(lblRepayIncomeVal, result.RepaymentIncome, "N2");
                SetResultValue(lblCouponIncomeVal, result.TotalCouponIncome, "N2");
                SetResultValue(lblTotalIncomeVal, result.TotalIncome, "N2");
                SetResultValue(lblTotalYieldVal, result.TotalYield, "P2");
                SetResultValue(lblAnnualYieldVal, result.AnnualYield, "P2");
                SetResultValue(lblRealRepayIncomeVal, result.RealRepaymentIncome, "N2");
                SetResultValue(lblRealCouponIncomeVal, result.RealTotalCouponIncome, "N2");
                SetResultValue(lblRealIncomeVal, result.RealTotalIncome, "N2");
                SetResultValue(lblRealYieldVal, result.RealTotalYield, "P2");
                SetResultValue(lblRealAnnualYieldVal, result.RealAnnualYield, "P2");

                dgvSchedule.Rows.Clear();
                foreach (var row in result.Schedule)
                {
                    var idx = dgvSchedule.Rows.Add(
                        row.Date.ToString("d"),
                        TranslateType(row.Type),
                        row.NominalAmount.ToString("N2"),
                        row.CumulativeIncome.ToString("N2"),
                        row.RealAmount.ToString("N2"),
                        row.CumulativeRealIncome.ToString("N2"));
                    dgvSchedule.Rows[idx].Cells[0].Tag = row.Date;
                    dgvSchedule.Rows[idx].Cells[1].Tag = row.Type;
                    dgvSchedule.Rows[idx].Cells[2].Tag = row.NominalAmount;
                    dgvSchedule.Rows[idx].Cells[3].Tag = row.CumulativeIncome;
                    dgvSchedule.Rows[idx].Cells[4].Tag = row.RealAmount;
                    dgvSchedule.Rows[idx].Cells[5].Tag = row.CumulativeRealIncome;
                }

                chartSchedule.Series.Clear();
                var nominalSeries = new Series
                {
                    Tag = "ChartNominalYield",
                    Name = Localization.GetString("ChartNominalYield"),
                    ChartType = SeriesChartType.Line,
                    Color = Color.FromArgb(180, Color.Green),
                    BorderWidth = 1,
                    IsVisibleInLegend = true
                };
                var realSeries = new Series
                {
                    Tag = "ChartRealYield",
                    Name = Localization.GetString("ChartRealYield"),
                    ChartType = SeriesChartType.Line,
                    Color = Color.FromArgb(180, Color.DodgerBlue),
                    BorderWidth = 1,
                    //BorderDashStyle = ChartDashStyle.Dash,
                    IsVisibleInLegend = true
                };
                var inflationSeries = new Series
                {
                    Tag = "ChartInflation",
                    Name = Localization.GetString("ChartInflation"),
                    ChartType = SeriesChartType.Line,
                    Color = Color.FromArgb(180, Color.Red),
                    BorderWidth = 1,
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

                double yMin = double.MaxValue, yMax = double.MinValue;
                foreach (var s in new[] { nominalSeries, realSeries, inflationSeries })
                {
                    foreach (var pt in s.Points)
                    {
                        double v = pt.YValues[0];
                        yMin = Math.Min(yMin, v);
                        yMax = Math.Max(yMax, v);
                    }
                }
                double lo = Math.Min(yMin, 0);
                double hi = Math.Max(yMax, 0);
                double range = hi - lo;
                double target = range <= 3 ? 0.5 : range <= 8 ? 1 : range <= 20 ? 2 : range <= 50 ? 5 : 10;
                var axis = chartSchedule.ChartAreas[0].AxisY;
                axis.Minimum = Math.Floor(lo / target) * target;
                axis.Maximum = Math.Ceiling(hi / target) * target;
                axis.Interval = target;
            }
            catch (InvalidOperationException ex)
            {
                MessageBox.Show(
                    ex.Message,
                    Localization.GetString("MsgCalcErrorTitle"),
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
            }
            catch (OverflowException)
            {
                MessageBox.Show(
                    Localization.GetString("MsgOverflowError"),
                    Localization.GetString("MsgCalcErrorTitle"),
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                ShowError(ex);
            }
        }

        private static void ShowError(Exception ex)
        {
            var message = ex is InvalidOperationException
                ? ex.Message
                : string.Format(Localization.GetString("MsgUnexpectedError"), ex.Message);
            MessageBox.Show(
                message,
                Localization.GetString("MsgCalcErrorTitle"),
                MessageBoxButtons.OK,
                MessageBoxIcon.Error);
        }

        private static void SetResultValue(Label label, double value, string format)
        {
            label.Tag = (value, format);
            label.Text = value.ToString(format);
        }

        private void RefreshResultFormats()
        {
            foreach (var label in new[]
            {
                lblBuyPriceVal, lblRepayIncomeVal, lblCouponIncomeVal,
                lblTotalIncomeVal, lblTotalYieldVal, lblAnnualYieldVal,
                lblRealRepayIncomeVal, lblRealCouponIncomeVal, lblRealIncomeVal,
                lblRealYieldVal, lblRealAnnualYieldVal
            })
            {
                if (label.Tag is (double value, string format))
                {
                    label.Text = value.ToString(format);
                }
            }
        }

        private void ClearResults()
        {
            foreach (var label in new[]
            {
                lblBuyPriceVal, lblRepayIncomeVal, lblCouponIncomeVal,
                lblTotalIncomeVal, lblTotalYieldVal, lblAnnualYieldVal,
                lblRealRepayIncomeVal, lblRealCouponIncomeVal, lblRealIncomeVal,
                lblRealYieldVal, lblRealAnnualYieldVal
            })
            {
                label.Tag = null;
                label.Text = "-";
            }
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

        private void dtpRepayment_ValueChanged(object? sender, EventArgs e)
        {
            dtpLastCoupon.Value = dtpRepayment.Value;
        }
    }
}
