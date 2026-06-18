namespace BondCalc.App.Presentation.Forms
{
    partial class BondCacl
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            grpParameters = new GroupBox();
            nudInflation = new NumericUpDown();
            nudNominal = new NumericUpDown();
            dtpRepayment = new DateTimePicker();
            dtpPlacement = new DateTimePicker();
            lblInflation = new Label();
            lblRepayment = new Label();
            lblPlacement = new Label();
            lblNominal = new Label();
            grpDeal = new GroupBox();
            nudPurchase = new DateTimePicker();
            label1 = new Label();
            nudAccrued = new NumericUpDown();
            nudPrice = new NumericUpDown();
            lblAccrued = new Label();
            lblPrice = new Label();
            grpCoupons = new GroupBox();
            dtpLastCoupon = new DateTimePicker();
            dtpFirstCoupon = new DateTimePicker();
            nudPeriod = new NumericUpDown();
            btnGenerate = new Button();
            lblLastCoupon = new Label();
            lblFirstCoupon = new Label();
            btnClearCoupons = new Button();
            lblPeriod = new Label();
            nudCouponAmount = new NumericUpDown();
            lblCouponAmount = new Label();
            btnAddCoupon = new Button();
            btnRemoveCoupon = new Button();
            dgvCoupons = new DataGridView();
            dataGridViewTextBoxColumn3 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn4 = new DataGridViewTextBoxColumn();
            grpAmortizations = new GroupBox();
            lblAmortAmount = new Label();
            nudAmortParts = new NumericUpDown();
            lblAmortParts = new Label();
            btnGenerateAmort = new Button();
            btnClearAmortizations = new Button();
            btnRemoveAmortization = new Button();
            btnAddAmortization = new Button();
            dgvAmortizations = new DataGridView();
            dataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn2 = new DataGridViewTextBoxColumn();
            btnCalculate = new Button();
            btnReset = new Button();
            grpResults = new GroupBox();
            lblSellByValue = new Label();
            lblSellByLabel = new Label();
            lblYtmValue = new Label();
            lblYtmLabel = new Label();
            grpOutput = new GroupBox();
            lblRealRepayIncomeVal = new Label();
            lblRealRepayIncome = new Label();
            lblRealCouponIncomeVal = new Label();
            lblRealCouponIncome = new Label();
            lblRealAnnualYieldVal = new Label();
            lblRealAnnualYield = new Label();
            lblRealYieldVal = new Label();
            lblRealYield = new Label();
            lblRealIncomeVal = new Label();
            lblRealIncome = new Label();
            lblRealHeader = new Label();
            lblAnnualYieldVal = new Label();
            lblAnnualYield = new Label();
            lblTotalYieldVal = new Label();
            lblTotalYield = new Label();
            lblTotalIncomeVal = new Label();
            lblTotalIncome = new Label();
            lblCouponIncomeVal = new Label();
            lblCouponIncome = new Label();
            lblRepayIncomeVal = new Label();
            lblRepayIncome = new Label();
            lblBuyPriceVal = new Label();
            lblBuyPrice = new Label();
            lblNominalHeader = new Label();
            grpSchedule = new GroupBox();
            dgvSchedule = new DataGridView();
            dataGridViewTextBoxColumn5 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn6 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn7 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn8 = new DataGridViewTextBoxColumn();
            splitMain = new SplitContainer();
            grpParameters.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)nudInflation).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudNominal).BeginInit();
            grpDeal.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)nudAccrued).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudPrice).BeginInit();
            grpCoupons.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)nudPeriod).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudCouponAmount).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvCoupons).BeginInit();
            grpAmortizations.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)nudAmortParts).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvAmortizations).BeginInit();
            grpResults.SuspendLayout();
            grpOutput.SuspendLayout();
            grpSchedule.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvSchedule).BeginInit();
            ((System.ComponentModel.ISupportInitialize)splitMain).BeginInit();
            splitMain.Panel1.SuspendLayout();
            splitMain.Panel2.SuspendLayout();
            splitMain.SuspendLayout();
            SuspendLayout();
            // 
            // grpParameters
            // 
            grpParameters.Controls.Add(nudInflation);
            grpParameters.Controls.Add(nudNominal);
            grpParameters.Controls.Add(dtpRepayment);
            grpParameters.Controls.Add(dtpPlacement);
            grpParameters.Controls.Add(lblInflation);
            grpParameters.Controls.Add(lblRepayment);
            grpParameters.Controls.Add(lblPlacement);
            grpParameters.Controls.Add(lblNominal);
            grpParameters.Dock = DockStyle.Top;
            grpParameters.Location = new Point(0, 0);
            grpParameters.Name = "grpParameters";
            grpParameters.Size = new Size(368, 129);
            grpParameters.TabIndex = 0;
            grpParameters.TabStop = false;
            grpParameters.Text = "Bond Parameters";
            // 
            // nudInflation
            // 
            nudInflation.DecimalPlaces = 2;
            nudInflation.Location = new Point(140, 100);
            nudInflation.Name = "nudInflation";
            nudInflation.Size = new Size(211, 23);
            nudInflation.TabIndex = 7;
            nudInflation.Value = new decimal(new int[] { 15, 0, 0, 0 });
            // 
            // nudNominal
            // 
            nudNominal.DecimalPlaces = 2;
            nudNominal.Location = new Point(140, 22);
            nudNominal.Maximum = new decimal(new int[] { 999999999, 0, 0, 0 });
            nudNominal.Minimum = new decimal(new int[] { 1, 0, 0, 131072 });
            nudNominal.Name = "nudNominal";
            nudNominal.Size = new Size(211, 23);
            nudNominal.TabIndex = 1;
            nudNominal.Value = new decimal(new int[] { 1000, 0, 0, 0 });
            // 
            // dtpRepayment
            // 
            dtpRepayment.Format = DateTimePickerFormat.Short;
            dtpRepayment.Location = new Point(140, 74);
            dtpRepayment.Name = "dtpRepayment";
            dtpRepayment.Size = new Size(211, 23);
            dtpRepayment.TabIndex = 5;
            dtpRepayment.Value = new DateTime(2030, 1, 1, 0, 0, 0, 0);
            // 
            // dtpPlacement
            // 
            dtpPlacement.Format = DateTimePickerFormat.Short;
            dtpPlacement.Location = new Point(140, 48);
            dtpPlacement.Name = "dtpPlacement";
            dtpPlacement.Size = new Size(211, 23);
            dtpPlacement.TabIndex = 3;
            dtpPlacement.Value = new DateTime(2025, 1, 1, 0, 0, 0, 0);
            // 
            // lblInflation
            // 
            lblInflation.Location = new Point(12, 102);
            lblInflation.Name = "lblInflation";
            lblInflation.Size = new Size(120, 20);
            lblInflation.TabIndex = 6;
            lblInflation.Text = "Inflation Rate (%):";
            lblInflation.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblRepayment
            // 
            lblRepayment.Location = new Point(12, 76);
            lblRepayment.Name = "lblRepayment";
            lblRepayment.Size = new Size(120, 20);
            lblRepayment.TabIndex = 4;
            lblRepayment.Text = "Repayment Date:";
            lblRepayment.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblPlacement
            // 
            lblPlacement.Location = new Point(12, 50);
            lblPlacement.Name = "lblPlacement";
            lblPlacement.Size = new Size(120, 20);
            lblPlacement.TabIndex = 2;
            lblPlacement.Text = "Placement Date:";
            lblPlacement.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblNominal
            // 
            lblNominal.Location = new Point(12, 24);
            lblNominal.Name = "lblNominal";
            lblNominal.Size = new Size(120, 20);
            lblNominal.TabIndex = 0;
            lblNominal.Text = "Nominal Value:";
            lblNominal.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // grpDeal
            // 
            grpDeal.Controls.Add(nudPurchase);
            grpDeal.Controls.Add(label1);
            grpDeal.Controls.Add(nudAccrued);
            grpDeal.Controls.Add(nudPrice);
            grpDeal.Controls.Add(lblAccrued);
            grpDeal.Controls.Add(lblPrice);
            grpDeal.Dock = DockStyle.Top;
            grpDeal.Location = new Point(0, 414);
            grpDeal.Name = "grpDeal";
            grpDeal.Size = new Size(368, 110);
            grpDeal.TabIndex = 15;
            grpDeal.TabStop = false;
            grpDeal.Text = "Deal";
            // 
            // nudPurchase
            // 
            nudPurchase.Format = DateTimePickerFormat.Short;
            nudPurchase.Location = new Point(140, 74);
            nudPurchase.Name = "nudPurchase";
            nudPurchase.Size = new Size(211, 23);
            nudPurchase.TabIndex = 13;
            // 
            // label1
            // 
            label1.Location = new Point(12, 76);
            label1.Name = "label1";
            label1.Size = new Size(120, 20);
            label1.TabIndex = 12;
            label1.Text = "Purchase Date:";
            label1.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // nudAccrued
            // 
            nudAccrued.DecimalPlaces = 2;
            nudAccrued.Location = new Point(140, 48);
            nudAccrued.Maximum = new decimal(new int[] { 999999999, 0, 0, 0 });
            nudAccrued.Name = "nudAccrued";
            nudAccrued.Size = new Size(211, 23);
            nudAccrued.TabIndex = 11;
            // 
            // nudPrice
            // 
            nudPrice.DecimalPlaces = 2;
            nudPrice.Location = new Point(140, 22);
            nudPrice.Maximum = new decimal(new int[] { 999999999, 0, 0, 0 });
            nudPrice.Minimum = new decimal(new int[] { 1, 0, 0, 131072 });
            nudPrice.Name = "nudPrice";
            nudPrice.Size = new Size(211, 23);
            nudPrice.TabIndex = 9;
            nudPrice.Value = new decimal(new int[] { 1000, 0, 0, 0 });
            // 
            // lblAccrued
            // 
            lblAccrued.Location = new Point(12, 50);
            lblAccrued.Name = "lblAccrued";
            lblAccrued.Size = new Size(120, 20);
            lblAccrued.TabIndex = 10;
            lblAccrued.Text = "Accrued Interest (НКД):";
            lblAccrued.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblPrice
            // 
            lblPrice.Location = new Point(12, 24);
            lblPrice.Name = "lblPrice";
            lblPrice.Size = new Size(120, 20);
            lblPrice.TabIndex = 8;
            lblPrice.Text = "Purchase Price:";
            lblPrice.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // grpCoupons
            // 
            grpCoupons.Controls.Add(dtpLastCoupon);
            grpCoupons.Controls.Add(dtpFirstCoupon);
            grpCoupons.Controls.Add(nudPeriod);
            grpCoupons.Controls.Add(btnGenerate);
            grpCoupons.Controls.Add(lblLastCoupon);
            grpCoupons.Controls.Add(lblFirstCoupon);
            grpCoupons.Controls.Add(btnClearCoupons);
            grpCoupons.Controls.Add(lblPeriod);
            grpCoupons.Controls.Add(nudCouponAmount);
            grpCoupons.Controls.Add(lblCouponAmount);
            grpCoupons.Controls.Add(btnAddCoupon);
            grpCoupons.Controls.Add(btnRemoveCoupon);
            grpCoupons.Controls.Add(dgvCoupons);
            grpCoupons.Dock = DockStyle.Top;
            grpCoupons.Location = new Point(0, 129);
            grpCoupons.Name = "grpCoupons";
            grpCoupons.Size = new Size(368, 285);
            grpCoupons.TabIndex = 1;
            grpCoupons.TabStop = false;
            grpCoupons.Text = "Coupons";
            // 
            // dtpLastCoupon
            // 
            dtpLastCoupon.Format = DateTimePickerFormat.Short;
            dtpLastCoupon.Location = new Point(140, 48);
            dtpLastCoupon.Name = "dtpLastCoupon";
            dtpLastCoupon.Size = new Size(211, 23);
            dtpLastCoupon.TabIndex = 9;
            // 
            // dtpFirstCoupon
            // 
            dtpFirstCoupon.Format = DateTimePickerFormat.Short;
            dtpFirstCoupon.Location = new Point(140, 22);
            dtpFirstCoupon.Name = "dtpFirstCoupon";
            dtpFirstCoupon.Size = new Size(211, 23);
            dtpFirstCoupon.TabIndex = 7;
            // 
            // nudPeriod
            // 
            nudPeriod.Location = new Point(140, 74);
            nudPeriod.Maximum = new decimal(new int[] { 9999, 0, 0, 0 });
            nudPeriod.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            nudPeriod.Name = "nudPeriod";
            nudPeriod.Size = new Size(211, 23);
            nudPeriod.TabIndex = 10;
            nudPeriod.Value = new decimal(new int[] { 30, 0, 0, 0 });
            // 
            // btnGenerate
            // 
            btnGenerate.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btnGenerate.Location = new Point(8, 252);
            btnGenerate.Name = "btnGenerate";
            btnGenerate.Size = new Size(93, 23);
            btnGenerate.TabIndex = 11;
            btnGenerate.Text = "Generate";
            btnGenerate.UseVisualStyleBackColor = true;
            btnGenerate.Click += btnGenerateCoupons_Click;
            // 
            // lblLastCoupon
            // 
            lblLastCoupon.Location = new Point(12, 50);
            lblLastCoupon.Name = "lblLastCoupon";
            lblLastCoupon.Size = new Size(120, 20);
            lblLastCoupon.TabIndex = 8;
            lblLastCoupon.Text = "Last Coupon Date:";
            lblLastCoupon.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblFirstCoupon
            // 
            lblFirstCoupon.Location = new Point(12, 24);
            lblFirstCoupon.Name = "lblFirstCoupon";
            lblFirstCoupon.Size = new Size(120, 20);
            lblFirstCoupon.TabIndex = 6;
            lblFirstCoupon.Text = "First Coupon Date:";
            lblFirstCoupon.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // btnClearCoupons
            // 
            btnClearCoupons.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btnClearCoupons.Location = new Point(279, 252);
            btnClearCoupons.Name = "btnClearCoupons";
            btnClearCoupons.Size = new Size(80, 23);
            btnClearCoupons.TabIndex = 12;
            btnClearCoupons.Text = "Clear";
            btnClearCoupons.UseVisualStyleBackColor = true;
            btnClearCoupons.Click += btnClearCoupons_Click;
            // 
            // lblPeriod
            // 
            lblPeriod.Location = new Point(12, 76);
            lblPeriod.Name = "lblPeriod";
            lblPeriod.Size = new Size(120, 20);
            lblPeriod.TabIndex = 9;
            lblPeriod.Text = "Period (days):";
            lblPeriod.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // nudCouponAmount
            // 
            nudCouponAmount.DecimalPlaces = 2;
            nudCouponAmount.Location = new Point(140, 100);
            nudCouponAmount.Maximum = new decimal(new int[] { 999999999, 0, 0, 0 });
            nudCouponAmount.Name = "nudCouponAmount";
            nudCouponAmount.Size = new Size(211, 23);
            nudCouponAmount.TabIndex = 20;
            // 
            // lblCouponAmount
            // 
            lblCouponAmount.Location = new Point(12, 102);
            lblCouponAmount.Name = "lblCouponAmount";
            lblCouponAmount.Size = new Size(120, 20);
            lblCouponAmount.TabIndex = 21;
            lblCouponAmount.Text = "Coupon Amount:";
            lblCouponAmount.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // btnAddCoupon
            // 
            btnAddCoupon.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btnAddCoupon.Location = new Point(107, 252);
            btnAddCoupon.Name = "btnAddCoupon";
            btnAddCoupon.Size = new Size(80, 23);
            btnAddCoupon.TabIndex = 1;
            btnAddCoupon.Text = "Add";
            btnAddCoupon.UseVisualStyleBackColor = true;
            btnAddCoupon.Click += btnAddCoupon_Click;
            // 
            // btnRemoveCoupon
            // 
            btnRemoveCoupon.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btnRemoveCoupon.Location = new Point(193, 252);
            btnRemoveCoupon.Name = "btnRemoveCoupon";
            btnRemoveCoupon.Size = new Size(80, 23);
            btnRemoveCoupon.TabIndex = 2;
            btnRemoveCoupon.Text = "Remove";
            btnRemoveCoupon.UseVisualStyleBackColor = true;
            btnRemoveCoupon.Click += btnRemoveCoupon_Click;
            // 
            // dgvCoupons
            // 
            dgvCoupons.AllowUserToAddRows = false;
            dgvCoupons.AllowUserToDeleteRows = false;
            dgvCoupons.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvCoupons.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvCoupons.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvCoupons.Columns.AddRange(new DataGridViewColumn[] { dataGridViewTextBoxColumn3, dataGridViewTextBoxColumn4 });
            dgvCoupons.Location = new Point(8, 129);
            dgvCoupons.Name = "dgvCoupons";
            dgvCoupons.RowHeadersVisible = false;
            dgvCoupons.Size = new Size(351, 117);
            dgvCoupons.TabIndex = 0;
            // 
            // dataGridViewTextBoxColumn3
            // 
            dataGridViewTextBoxColumn3.HeaderText = "Date";
            dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            dataGridViewTextBoxColumn4.HeaderText = "Amount";
            dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // grpAmortizations
            // 
            grpAmortizations.Controls.Add(lblAmortAmount);
            grpAmortizations.Controls.Add(nudAmortParts);
            grpAmortizations.Controls.Add(lblAmortParts);
            grpAmortizations.Controls.Add(btnGenerateAmort);
            grpAmortizations.Controls.Add(btnClearAmortizations);
            grpAmortizations.Controls.Add(btnRemoveAmortization);
            grpAmortizations.Controls.Add(btnAddAmortization);
            grpAmortizations.Controls.Add(dgvAmortizations);
            grpAmortizations.Dock = DockStyle.Top;
            grpAmortizations.Location = new Point(0, 524);
            grpAmortizations.Name = "grpAmortizations";
            grpAmortizations.Size = new Size(368, 195);
            grpAmortizations.TabIndex = 2;
            grpAmortizations.TabStop = false;
            grpAmortizations.Text = "Amortizations";
            // 
            // lblAmortAmount
            // 
            lblAmortAmount.Location = new Point(230, 24);
            lblAmortAmount.Name = "lblAmortAmount";
            lblAmortAmount.Size = new Size(129, 20);
            lblAmortAmount.TabIndex = 12;
            lblAmortAmount.Text = "Amount: -";
            lblAmortAmount.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // nudAmortParts
            // 
            nudAmortParts.Location = new Point(140, 22);
            nudAmortParts.Minimum = new decimal(new int[] { 2, 0, 0, 0 });
            nudAmortParts.Name = "nudAmortParts";
            nudAmortParts.Size = new Size(80, 23);
            nudAmortParts.TabIndex = 10;
            nudAmortParts.Value = new decimal(new int[] { 5, 0, 0, 0 });
            nudAmortParts.ValueChanged += nudAmortParts_ValueChanged;
            // 
            // lblAmortParts
            // 
            lblAmortParts.Location = new Point(12, 24);
            lblAmortParts.Name = "lblAmortParts";
            lblAmortParts.Size = new Size(120, 20);
            lblAmortParts.TabIndex = 9;
            lblAmortParts.Text = "Number of Parts:";
            lblAmortParts.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // btnGenerateAmort
            // 
            btnGenerateAmort.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btnGenerateAmort.Location = new Point(8, 164);
            btnGenerateAmort.Name = "btnGenerateAmort";
            btnGenerateAmort.Size = new Size(93, 23);
            btnGenerateAmort.TabIndex = 11;
            btnGenerateAmort.Text = "Generate";
            btnGenerateAmort.UseVisualStyleBackColor = true;
            btnGenerateAmort.Click += btnGenerateAmort_Click;
            // 
            // btnClearAmortizations
            // 
            btnClearAmortizations.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btnClearAmortizations.Location = new Point(279, 164);
            btnClearAmortizations.Name = "btnClearAmortizations";
            btnClearAmortizations.Size = new Size(80, 23);
            btnClearAmortizations.TabIndex = 13;
            btnClearAmortizations.Text = "Clear";
            btnClearAmortizations.UseVisualStyleBackColor = true;
            btnClearAmortizations.Click += btnClearAmortizations_Click;
            // 
            // btnRemoveAmortization
            // 
            btnRemoveAmortization.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btnRemoveAmortization.Location = new Point(193, 164);
            btnRemoveAmortization.Name = "btnRemoveAmortization";
            btnRemoveAmortization.Size = new Size(80, 23);
            btnRemoveAmortization.TabIndex = 2;
            btnRemoveAmortization.Text = "Remove";
            btnRemoveAmortization.UseVisualStyleBackColor = true;
            btnRemoveAmortization.Click += btnRemoveAmortization_Click;
            // 
            // btnAddAmortization
            // 
            btnAddAmortization.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btnAddAmortization.Location = new Point(107, 164);
            btnAddAmortization.Name = "btnAddAmortization";
            btnAddAmortization.Size = new Size(80, 23);
            btnAddAmortization.TabIndex = 1;
            btnAddAmortization.Text = "Add";
            btnAddAmortization.UseVisualStyleBackColor = true;
            btnAddAmortization.Click += btnAddAmortization_Click;
            // 
            // dgvAmortizations
            // 
            dgvAmortizations.AllowUserToAddRows = false;
            dgvAmortizations.AllowUserToDeleteRows = false;
            dgvAmortizations.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvAmortizations.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvAmortizations.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvAmortizations.Columns.AddRange(new DataGridViewColumn[] { dataGridViewTextBoxColumn1, dataGridViewTextBoxColumn2 });
            dgvAmortizations.Location = new Point(8, 48);
            dgvAmortizations.Name = "dgvAmortizations";
            dgvAmortizations.RowHeadersVisible = false;
            dgvAmortizations.Size = new Size(351, 110);
            dgvAmortizations.TabIndex = 0;
            // 
            // dataGridViewTextBoxColumn1
            // 
            dataGridViewTextBoxColumn1.HeaderText = "Date";
            dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            dataGridViewTextBoxColumn2.HeaderText = "Amount";
            dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // btnCalculate
            // 
            btnCalculate.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            btnCalculate.Font = new Font("Segoe UI", 20F, FontStyle.Bold);
            btnCalculate.Location = new Point(8, 728);
            btnCalculate.Name = "btnCalculate";
            btnCalculate.Size = new Size(285, 60);
            btnCalculate.TabIndex = 3;
            btnCalculate.Text = "Calculate";
            btnCalculate.UseVisualStyleBackColor = true;
            btnCalculate.Click += btnCalculate_Click;
            // 
            // btnReset
            // 
            btnReset.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            btnReset.Font = new Font("Segoe UI", 24F);
            btnReset.Location = new Point(299, 728);
            btnReset.Name = "btnReset";
            btnReset.Size = new Size(60, 60);
            btnReset.TabIndex = 14;
            btnReset.Text = "⟳";
            btnReset.UseVisualStyleBackColor = true;
            btnReset.Click += btnReset_Click;
            // 
            // grpResults
            // 
            grpResults.Controls.Add(lblSellByValue);
            grpResults.Controls.Add(lblSellByLabel);
            grpResults.Controls.Add(lblYtmValue);
            grpResults.Controls.Add(lblYtmLabel);
            grpResults.Location = new Point(0, 800);
            grpResults.Name = "grpResults";
            grpResults.Size = new Size(475, 80);
            grpResults.TabIndex = 0;
            grpResults.TabStop = false;
            grpResults.Text = "Results";
            grpResults.Visible = false;
            // 
            // lblSellByValue
            // 
            lblSellByValue.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblSellByValue.Location = new Point(200, 48);
            lblSellByValue.Name = "lblSellByValue";
            lblSellByValue.Size = new Size(200, 20);
            lblSellByValue.TabIndex = 3;
            lblSellByValue.Text = "-";
            lblSellByValue.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblSellByLabel
            // 
            lblSellByLabel.Location = new Point(12, 48);
            lblSellByLabel.Name = "lblSellByLabel";
            lblSellByLabel.Size = new Size(180, 20);
            lblSellByLabel.TabIndex = 2;
            lblSellByLabel.Text = "Sell-By Date:";
            lblSellByLabel.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblYtmValue
            // 
            lblYtmValue.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblYtmValue.Location = new Point(200, 24);
            lblYtmValue.Name = "lblYtmValue";
            lblYtmValue.Size = new Size(200, 20);
            lblYtmValue.TabIndex = 1;
            lblYtmValue.Text = "-";
            lblYtmValue.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblYtmLabel
            // 
            lblYtmLabel.Location = new Point(12, 24);
            lblYtmLabel.Name = "lblYtmLabel";
            lblYtmLabel.Size = new Size(180, 20);
            lblYtmLabel.TabIndex = 0;
            lblYtmLabel.Text = "Inflation-Adjusted YTM:";
            lblYtmLabel.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // grpOutput
            // 
            grpOutput.Controls.Add(lblRealRepayIncomeVal);
            grpOutput.Controls.Add(lblRealRepayIncome);
            grpOutput.Controls.Add(lblRealCouponIncomeVal);
            grpOutput.Controls.Add(lblRealCouponIncome);
            grpOutput.Controls.Add(lblRealAnnualYieldVal);
            grpOutput.Controls.Add(lblRealAnnualYield);
            grpOutput.Controls.Add(lblRealYieldVal);
            grpOutput.Controls.Add(lblRealYield);
            grpOutput.Controls.Add(lblRealIncomeVal);
            grpOutput.Controls.Add(lblRealIncome);
            grpOutput.Controls.Add(lblRealHeader);
            grpOutput.Controls.Add(lblAnnualYieldVal);
            grpOutput.Controls.Add(lblAnnualYield);
            grpOutput.Controls.Add(lblTotalYieldVal);
            grpOutput.Controls.Add(lblTotalYield);
            grpOutput.Controls.Add(lblTotalIncomeVal);
            grpOutput.Controls.Add(lblTotalIncome);
            grpOutput.Controls.Add(lblCouponIncomeVal);
            grpOutput.Controls.Add(lblCouponIncome);
            grpOutput.Controls.Add(lblRepayIncomeVal);
            grpOutput.Controls.Add(lblRepayIncome);
            grpOutput.Controls.Add(lblBuyPriceVal);
            grpOutput.Controls.Add(lblBuyPrice);
            grpOutput.Controls.Add(lblNominalHeader);
            grpOutput.Dock = DockStyle.Fill;
            grpOutput.Location = new Point(0, 0);
            grpOutput.Name = "grpOutput";
            grpOutput.Size = new Size(486, 791);
            grpOutput.TabIndex = 2;
            grpOutput.TabStop = false;
            grpOutput.Text = "Results";
            // 
            // lblRealRepayIncomeVal
            // 
            lblRealRepayIncomeVal.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblRealRepayIncomeVal.Location = new Point(367, 68);
            lblRealRepayIncomeVal.Name = "lblRealRepayIncomeVal";
            lblRealRepayIncomeVal.Size = new Size(120, 20);
            lblRealRepayIncomeVal.TabIndex = 23;
            lblRealRepayIncomeVal.Text = "-";
            lblRealRepayIncomeVal.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblRealRepayIncome
            // 
            lblRealRepayIncome.Location = new Point(218, 68);
            lblRealRepayIncome.Name = "lblRealRepayIncome";
            lblRealRepayIncome.Size = new Size(158, 20);
            lblRealRepayIncome.TabIndex = 22;
            lblRealRepayIncome.Text = "Real Repayment Income:";
            lblRealRepayIncome.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblRealCouponIncomeVal
            // 
            lblRealCouponIncomeVal.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblRealCouponIncomeVal.Location = new Point(367, 88);
            lblRealCouponIncomeVal.Name = "lblRealCouponIncomeVal";
            lblRealCouponIncomeVal.Size = new Size(120, 20);
            lblRealCouponIncomeVal.TabIndex = 21;
            lblRealCouponIncomeVal.Text = "-";
            lblRealCouponIncomeVal.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblRealCouponIncome
            // 
            lblRealCouponIncome.Location = new Point(218, 88);
            lblRealCouponIncome.Name = "lblRealCouponIncome";
            lblRealCouponIncome.Size = new Size(158, 20);
            lblRealCouponIncome.TabIndex = 20;
            lblRealCouponIncome.Text = "Real Total Coupon Income:";
            lblRealCouponIncome.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblRealAnnualYieldVal
            // 
            lblRealAnnualYieldVal.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblRealAnnualYieldVal.Location = new Point(367, 154);
            lblRealAnnualYieldVal.Name = "lblRealAnnualYieldVal";
            lblRealAnnualYieldVal.Size = new Size(120, 20);
            lblRealAnnualYieldVal.TabIndex = 19;
            lblRealAnnualYieldVal.Text = "-";
            lblRealAnnualYieldVal.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblRealAnnualYield
            // 
            lblRealAnnualYield.Location = new Point(218, 154);
            lblRealAnnualYield.Name = "lblRealAnnualYield";
            lblRealAnnualYield.Size = new Size(158, 20);
            lblRealAnnualYield.TabIndex = 18;
            lblRealAnnualYield.Text = "Real Annual Yield:";
            lblRealAnnualYield.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblRealYieldVal
            // 
            lblRealYieldVal.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblRealYieldVal.Location = new Point(367, 132);
            lblRealYieldVal.Name = "lblRealYieldVal";
            lblRealYieldVal.Size = new Size(120, 20);
            lblRealYieldVal.TabIndex = 17;
            lblRealYieldVal.Text = "-";
            lblRealYieldVal.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblRealYield
            // 
            lblRealYield.Location = new Point(218, 132);
            lblRealYield.Name = "lblRealYield";
            lblRealYield.Size = new Size(158, 20);
            lblRealYield.TabIndex = 16;
            lblRealYield.Text = "Real Total Yield:";
            lblRealYield.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblRealIncomeVal
            // 
            lblRealIncomeVal.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblRealIncomeVal.Location = new Point(367, 110);
            lblRealIncomeVal.Name = "lblRealIncomeVal";
            lblRealIncomeVal.Size = new Size(120, 20);
            lblRealIncomeVal.TabIndex = 15;
            lblRealIncomeVal.Text = "-";
            lblRealIncomeVal.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblRealIncome
            // 
            lblRealIncome.Location = new Point(218, 110);
            lblRealIncome.Name = "lblRealIncome";
            lblRealIncome.Size = new Size(158, 20);
            lblRealIncome.TabIndex = 14;
            lblRealIncome.Text = "Real Total Income:";
            lblRealIncome.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblRealHeader
            // 
            lblRealHeader.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblRealHeader.ForeColor = Color.DimGray;
            lblRealHeader.Location = new Point(218, 48);
            lblRealHeader.Name = "lblRealHeader";
            lblRealHeader.Size = new Size(185, 16);
            lblRealHeader.TabIndex = 13;
            lblRealHeader.Text = "── Real (Inflation-Adjusted) ──";
            // 
            // lblAnnualYieldVal
            // 
            lblAnnualYieldVal.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblAnnualYieldVal.Location = new Point(137, 156);
            lblAnnualYieldVal.Name = "lblAnnualYieldVal";
            lblAnnualYieldVal.Size = new Size(120, 20);
            lblAnnualYieldVal.TabIndex = 12;
            lblAnnualYieldVal.Text = "-";
            lblAnnualYieldVal.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblAnnualYield
            // 
            lblAnnualYield.Location = new Point(12, 156);
            lblAnnualYield.Name = "lblAnnualYield";
            lblAnnualYield.Size = new Size(140, 20);
            lblAnnualYield.TabIndex = 11;
            lblAnnualYield.Text = "Annual Yield:";
            lblAnnualYield.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblTotalYieldVal
            // 
            lblTotalYieldVal.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblTotalYieldVal.Location = new Point(137, 134);
            lblTotalYieldVal.Name = "lblTotalYieldVal";
            lblTotalYieldVal.Size = new Size(120, 20);
            lblTotalYieldVal.TabIndex = 10;
            lblTotalYieldVal.Text = "-";
            lblTotalYieldVal.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblTotalYield
            // 
            lblTotalYield.Location = new Point(12, 134);
            lblTotalYield.Name = "lblTotalYield";
            lblTotalYield.Size = new Size(140, 20);
            lblTotalYield.TabIndex = 9;
            lblTotalYield.Text = "Total Yield:";
            lblTotalYield.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblTotalIncomeVal
            // 
            lblTotalIncomeVal.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblTotalIncomeVal.Location = new Point(137, 112);
            lblTotalIncomeVal.Name = "lblTotalIncomeVal";
            lblTotalIncomeVal.Size = new Size(120, 20);
            lblTotalIncomeVal.TabIndex = 8;
            lblTotalIncomeVal.Text = "-";
            lblTotalIncomeVal.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblTotalIncome
            // 
            lblTotalIncome.Location = new Point(12, 112);
            lblTotalIncome.Name = "lblTotalIncome";
            lblTotalIncome.Size = new Size(140, 20);
            lblTotalIncome.TabIndex = 7;
            lblTotalIncome.Text = "Total Income:";
            lblTotalIncome.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblCouponIncomeVal
            // 
            lblCouponIncomeVal.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblCouponIncomeVal.Location = new Point(137, 90);
            lblCouponIncomeVal.Name = "lblCouponIncomeVal";
            lblCouponIncomeVal.Size = new Size(120, 20);
            lblCouponIncomeVal.TabIndex = 6;
            lblCouponIncomeVal.Text = "-";
            lblCouponIncomeVal.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblCouponIncome
            // 
            lblCouponIncome.Location = new Point(12, 90);
            lblCouponIncome.Name = "lblCouponIncome";
            lblCouponIncome.Size = new Size(140, 20);
            lblCouponIncome.TabIndex = 5;
            lblCouponIncome.Text = "Total Coupon Income:";
            lblCouponIncome.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblRepayIncomeVal
            // 
            lblRepayIncomeVal.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblRepayIncomeVal.Location = new Point(137, 68);
            lblRepayIncomeVal.Name = "lblRepayIncomeVal";
            lblRepayIncomeVal.Size = new Size(120, 20);
            lblRepayIncomeVal.TabIndex = 4;
            lblRepayIncomeVal.Text = "-";
            lblRepayIncomeVal.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblRepayIncome
            // 
            lblRepayIncome.Location = new Point(12, 68);
            lblRepayIncome.Name = "lblRepayIncome";
            lblRepayIncome.Size = new Size(140, 20);
            lblRepayIncome.TabIndex = 3;
            lblRepayIncome.Text = "Repayment Income:";
            lblRepayIncome.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblBuyPriceVal
            // 
            lblBuyPriceVal.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblBuyPriceVal.Location = new Point(137, 19);
            lblBuyPriceVal.Name = "lblBuyPriceVal";
            lblBuyPriceVal.Size = new Size(120, 20);
            lblBuyPriceVal.TabIndex = 2;
            lblBuyPriceVal.Text = "-";
            lblBuyPriceVal.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblBuyPrice
            // 
            lblBuyPrice.Location = new Point(12, 19);
            lblBuyPrice.Name = "lblBuyPrice";
            lblBuyPrice.Size = new Size(140, 20);
            lblBuyPrice.TabIndex = 1;
            lblBuyPrice.Text = "Buy Price:";
            lblBuyPrice.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblNominalHeader
            // 
            lblNominalHeader.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblNominalHeader.ForeColor = Color.DimGray;
            lblNominalHeader.Location = new Point(12, 48);
            lblNominalHeader.Name = "lblNominalHeader";
            lblNominalHeader.Size = new Size(200, 16);
            lblNominalHeader.TabIndex = 0;
            lblNominalHeader.Text = "── Nominal ──";
            // 
            // grpSchedule
            // 
            grpSchedule.Controls.Add(dgvSchedule);
            grpSchedule.Location = new Point(0, 80);
            grpSchedule.Name = "grpSchedule";
            grpSchedule.Size = new Size(475, 686);
            grpSchedule.TabIndex = 1;
            grpSchedule.TabStop = false;
            grpSchedule.Text = "Coupon Schedule";
            grpSchedule.Visible = false;
            // 
            // dgvSchedule
            // 
            dgvSchedule.AllowUserToAddRows = false;
            dgvSchedule.AllowUserToDeleteRows = false;
            dgvSchedule.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvSchedule.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvSchedule.Columns.AddRange(new DataGridViewColumn[] { dataGridViewTextBoxColumn5, dataGridViewTextBoxColumn6, dataGridViewTextBoxColumn7, dataGridViewTextBoxColumn8 });
            dgvSchedule.Dock = DockStyle.Fill;
            dgvSchedule.Location = new Point(3, 19);
            dgvSchedule.Name = "dgvSchedule";
            dgvSchedule.ReadOnly = true;
            dgvSchedule.RowHeadersVisible = false;
            dgvSchedule.Size = new Size(469, 664);
            dgvSchedule.TabIndex = 0;
            // 
            // dataGridViewTextBoxColumn5
            // 
            dataGridViewTextBoxColumn5.HeaderText = "Date";
            dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            dataGridViewTextBoxColumn5.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn6
            // 
            dataGridViewTextBoxColumn6.HeaderText = "Coupon";
            dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            dataGridViewTextBoxColumn6.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn7
            // 
            dataGridViewTextBoxColumn7.HeaderText = "Inflation-Adj.";
            dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            dataGridViewTextBoxColumn7.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn8
            // 
            dataGridViewTextBoxColumn8.HeaderText = "Cumulative Yield";
            dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            dataGridViewTextBoxColumn8.ReadOnly = true;
            // 
            // splitMain
            // 
            splitMain.Dock = DockStyle.Fill;
            splitMain.Location = new Point(0, 0);
            splitMain.Name = "splitMain";
            // 
            // splitMain.Panel1
            // 
            splitMain.Panel1.Controls.Add(btnReset);
            splitMain.Panel1.Controls.Add(grpDeal);
            splitMain.Panel1.Controls.Add(grpAmortizations);
            splitMain.Panel1.Controls.Add(grpCoupons);
            splitMain.Panel1.Controls.Add(grpParameters);
            splitMain.Panel1.Controls.Add(btnCalculate);
            splitMain.Panel1MinSize = 360;
            // 
            // splitMain.Panel2
            // 
            splitMain.Panel2.Controls.Add(grpOutput);
            splitMain.Panel2.Controls.Add(grpResults);
            splitMain.Panel2.Controls.Add(grpSchedule);
            splitMain.Size = new Size(859, 791);
            splitMain.SplitterDistance = 368;
            splitMain.SplitterWidth = 5;
            splitMain.TabIndex = 0;
            splitMain.TabStop = false;
            // 
            // BondCacl
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(859, 791);
            Controls.Add(splitMain);
            MinimumSize = new Size(700, 500);
            Name = "BondCacl";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "BondCalc - Inflation-Adjusted Bond Yield Calculator";
            grpParameters.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)nudInflation).EndInit();
            ((System.ComponentModel.ISupportInitialize)nudNominal).EndInit();
            grpDeal.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)nudAccrued).EndInit();
            ((System.ComponentModel.ISupportInitialize)nudPrice).EndInit();
            grpCoupons.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)nudPeriod).EndInit();
            ((System.ComponentModel.ISupportInitialize)nudCouponAmount).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvCoupons).EndInit();
            grpAmortizations.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)nudAmortParts).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvAmortizations).EndInit();
            grpResults.ResumeLayout(false);
            grpOutput.ResumeLayout(false);
            grpSchedule.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvSchedule).EndInit();
            splitMain.Panel1.ResumeLayout(false);
            splitMain.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitMain).EndInit();
            splitMain.ResumeLayout(false);
            ResumeLayout(false);
        }

        private GroupBox grpOutput;
        private Label lblNominalHeader;
        private Label lblBuyPrice; private Label lblBuyPriceVal;
        private Label lblRepayIncome; private Label lblRepayIncomeVal;
        private Label lblCouponIncome; private Label lblCouponIncomeVal;
        private Label lblTotalIncome; private Label lblTotalIncomeVal;
        private Label lblTotalYield; private Label lblTotalYieldVal;
        private Label lblAnnualYield; private Label lblAnnualYieldVal;
        private Label lblRealHeader;
        private Label lblRealIncome; private Label lblRealIncomeVal;
        private Label lblRealYield; private Label lblRealYieldVal;
        private Label lblRealAnnualYield; private Label lblRealAnnualYieldVal;

        private GroupBox grpParameters;
        private NumericUpDown nudInflation;
        private NumericUpDown nudNominal;
        private DateTimePicker dtpRepayment;
        private DateTimePicker dtpPlacement;
        private Label lblInflation;
        private Label lblRepayment;
        private Label lblPlacement;
        private Label lblNominal;

        private GroupBox grpDeal;
        private NumericUpDown nudAccrued;
        private NumericUpDown nudPrice;
        private Label lblAccrued;
        private Label lblPrice;

        private GroupBox grpCoupons;
        private DateTimePicker dtpLastCoupon;
        private DateTimePicker dtpFirstCoupon;
        private NumericUpDown nudPeriod;
        private Button btnGenerate;
        private Label lblLastCoupon;
        private Label lblFirstCoupon;
        private Label lblPeriod;
        private Button btnClearCoupons;
        private Button btnRemoveCoupon;
        private Button btnAddCoupon;
        private DataGridView dgvCoupons;
        private NumericUpDown nudCouponAmount;
        private Label lblCouponAmount;

        private GroupBox grpAmortizations;
        private Label lblAmortAmount;
        private NumericUpDown nudAmortParts;
        private Label lblAmortParts;
        private Button btnGenerateAmort;
        private Button btnClearAmortizations;
        private Button btnRemoveAmortization;
        private Button btnAddAmortization;
        private DataGridView dgvAmortizations;

        private Button btnCalculate;
        private Button btnReset;

        private GroupBox grpResults;
        private Label lblSellByValue;
        private Label lblSellByLabel;
        private Label lblYtmValue;
        private Label lblYtmLabel;

        private GroupBox grpSchedule;
        private DataGridView dgvSchedule;

        private SplitContainer splitMain;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private DateTimePicker nudPurchase;
        private Label label1;
        private Label lblRealRepayIncomeVal;
        private Label lblRealRepayIncome;
        private Label lblRealCouponIncomeVal;
        private Label lblRealCouponIncome;
    }
}
