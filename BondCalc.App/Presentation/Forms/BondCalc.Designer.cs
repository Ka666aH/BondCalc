namespace BondCalc.App.Presentation.Forms
{
    using System.Windows.Forms.DataVisualization.Charting;

    partial class BondCalc
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BondCalc));
            grpParameters = new GroupBox();
            nudNominal = new NumericUpDown();
            dtpRepayment = new DateTimePicker();
            dtpPlacement = new DateTimePicker();
            lblRepayment = new Label();
            lblPlacement = new Label();
            lblNominal = new Label();
            nudInflation = new NumericUpDown();
            lblInflation = new Label();
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
            btnPeriod30 = new Button();
            btnPeriod90 = new Button();
            btnPeriod180 = new Button();
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
            colSchDate = new DataGridViewTextBoxColumn();
            colSchType = new DataGridViewTextBoxColumn();
            colSchNominal = new DataGridViewTextBoxColumn();
            colSchCumNominal = new DataGridViewTextBoxColumn();
            colSchReal = new DataGridViewTextBoxColumn();
            colSchCumReal = new DataGridViewTextBoxColumn();
            pnlChartContainer = new Panel();
            splitMain = new SplitContainer();
            menuStrip = new MenuStrip();
            toolsMenuItem = new ToolStripMenuItem();
            englishItem = new ToolStripMenuItem();
            russianItem = new ToolStripMenuItem();
            aboutMenuItem = new ToolStripMenuItem();
            grpParameters.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)nudNominal).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudInflation).BeginInit();
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
            grpOutput.SuspendLayout();
            grpSchedule.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvSchedule).BeginInit();
            ((System.ComponentModel.ISupportInitialize)splitMain).BeginInit();
            splitMain.Panel1.SuspendLayout();
            splitMain.Panel2.SuspendLayout();
            splitMain.SuspendLayout();
            menuStrip.SuspendLayout();
            SuspendLayout();
            // 
            // grpParameters
            // 
            grpParameters.Controls.Add(nudNominal);
            grpParameters.Controls.Add(dtpRepayment);
            grpParameters.Controls.Add(dtpPlacement);
            grpParameters.Controls.Add(lblRepayment);
            grpParameters.Controls.Add(lblPlacement);
            grpParameters.Controls.Add(lblNominal);
            grpParameters.Dock = DockStyle.Top;
            grpParameters.Location = new Point(0, 0);
            grpParameters.Name = "grpParameters";
            grpParameters.Size = new Size(418, 104);
            grpParameters.TabIndex = 0;
            grpParameters.TabStop = false;
            grpParameters.Text = "Bond Parameters";
            // 
            // nudNominal
            // 
            nudNominal.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            nudNominal.DecimalPlaces = 2;
            nudNominal.Location = new Point(176, 22);
            nudNominal.Maximum = new decimal(new int[] { 999999999, 0, 0, 0 });
            nudNominal.Minimum = new decimal(new int[] { 1, 0, 0, 131072 });
            nudNominal.Name = "nudNominal";
            nudNominal.Size = new Size(230, 23);
            nudNominal.TabIndex = 1;
            nudNominal.ThousandsSeparator = true;
            nudNominal.Value = new decimal(new int[] { 1000, 0, 0, 0 });
            // 
            // dtpRepayment
            // 
            dtpRepayment.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            dtpRepayment.Format = DateTimePickerFormat.Short;
            dtpRepayment.Location = new Point(176, 74);
            dtpRepayment.Name = "dtpRepayment";
            dtpRepayment.Size = new Size(230, 23);
            dtpRepayment.TabIndex = 3;
            dtpRepayment.Value = new DateTime(2030, 1, 1, 0, 0, 0, 0);
            dtpRepayment.ValueChanged += dtpRepayment_ValueChanged;
            // 
            // dtpPlacement
            // 
            dtpPlacement.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            dtpPlacement.Format = DateTimePickerFormat.Short;
            dtpPlacement.Location = new Point(176, 48);
            dtpPlacement.Name = "dtpPlacement";
            dtpPlacement.Size = new Size(230, 23);
            dtpPlacement.TabIndex = 2;
            dtpPlacement.Value = new DateTime(2025, 1, 1, 0, 0, 0, 0);
            // 
            // lblRepayment
            // 
            lblRepayment.Location = new Point(12, 76);
            lblRepayment.Name = "lblRepayment";
            lblRepayment.Size = new Size(158, 20);
            lblRepayment.TabIndex = 4;
            lblRepayment.Text = "Repayment Date:";
            lblRepayment.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblPlacement
            // 
            lblPlacement.Location = new Point(12, 50);
            lblPlacement.Name = "lblPlacement";
            lblPlacement.Size = new Size(158, 20);
            lblPlacement.TabIndex = 2;
            lblPlacement.Text = "Placement Date:";
            lblPlacement.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblNominal
            // 
            lblNominal.Location = new Point(12, 24);
            lblNominal.Name = "lblNominal";
            lblNominal.Size = new Size(158, 20);
            lblNominal.TabIndex = 0;
            lblNominal.Text = "Nominal Value:";
            lblNominal.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // nudInflation
            // 
            nudInflation.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            nudInflation.DecimalPlaces = 2;
            nudInflation.Increment = new decimal(new int[] { 5, 0, 0, 65536 });
            nudInflation.Location = new Point(176, 102);
            nudInflation.Maximum = new decimal(new int[] { 100000, 0, 0, 0 });
            nudInflation.Name = "nudInflation";
            nudInflation.Size = new Size(230, 23);
            nudInflation.TabIndex = 25;
            nudInflation.ThousandsSeparator = true;
            nudInflation.Value = new decimal(new int[] { 15, 0, 0, 0 });
            // 
            // lblInflation
            // 
            lblInflation.Location = new Point(12, 102);
            lblInflation.Name = "lblInflation";
            lblInflation.Size = new Size(158, 20);
            lblInflation.TabIndex = 6;
            lblInflation.Text = "Inflation Rate (%):";
            lblInflation.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // grpDeal
            // 
            grpDeal.Controls.Add(nudInflation);
            grpDeal.Controls.Add(nudPurchase);
            grpDeal.Controls.Add(label1);
            grpDeal.Controls.Add(nudAccrued);
            grpDeal.Controls.Add(nudPrice);
            grpDeal.Controls.Add(lblAccrued);
            grpDeal.Controls.Add(lblPrice);
            grpDeal.Controls.Add(lblInflation);
            grpDeal.Dock = DockStyle.Top;
            grpDeal.Location = new Point(0, 584);
            grpDeal.Name = "grpDeal";
            grpDeal.Size = new Size(418, 135);
            grpDeal.TabIndex = 15;
            grpDeal.TabStop = false;
            grpDeal.Text = "Deal";
            // 
            // nudPurchase
            // 
            nudPurchase.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            nudPurchase.Format = DateTimePickerFormat.Short;
            nudPurchase.Location = new Point(176, 74);
            nudPurchase.Name = "nudPurchase";
            nudPurchase.Size = new Size(230, 23);
            nudPurchase.TabIndex = 24;
            // 
            // label1
            // 
            label1.Location = new Point(12, 76);
            label1.Name = "label1";
            label1.Size = new Size(158, 20);
            label1.TabIndex = 12;
            label1.Text = "Purchase Date:";
            label1.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // nudAccrued
            // 
            nudAccrued.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            nudAccrued.DecimalPlaces = 2;
            nudAccrued.Location = new Point(176, 48);
            nudAccrued.Maximum = new decimal(new int[] { 999999999, 0, 0, 0 });
            nudAccrued.Name = "nudAccrued";
            nudAccrued.Size = new Size(230, 23);
            nudAccrued.TabIndex = 23;
            nudAccrued.ThousandsSeparator = true;
            // 
            // nudPrice
            // 
            nudPrice.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            nudPrice.DecimalPlaces = 2;
            nudPrice.Location = new Point(176, 22);
            nudPrice.Maximum = new decimal(new int[] { 999999999, 0, 0, 0 });
            nudPrice.Minimum = new decimal(new int[] { 1, 0, 0, 131072 });
            nudPrice.Name = "nudPrice";
            nudPrice.Size = new Size(230, 23);
            nudPrice.TabIndex = 22;
            nudPrice.ThousandsSeparator = true;
            nudPrice.Value = new decimal(new int[] { 1000, 0, 0, 0 });
            // 
            // lblAccrued
            // 
            lblAccrued.Location = new Point(12, 50);
            lblAccrued.Name = "lblAccrued";
            lblAccrued.Size = new Size(158, 20);
            lblAccrued.TabIndex = 10;
            lblAccrued.Text = "Accrued Interest:";
            lblAccrued.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblPrice
            // 
            lblPrice.Location = new Point(12, 24);
            lblPrice.Name = "lblPrice";
            lblPrice.Size = new Size(158, 20);
            lblPrice.TabIndex = 8;
            lblPrice.Text = "Purchase Price:";
            lblPrice.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // grpCoupons
            // 
            grpCoupons.Controls.Add(dtpLastCoupon);
            grpCoupons.Controls.Add(dtpFirstCoupon);
            grpCoupons.Controls.Add(nudPeriod);
            grpCoupons.Controls.Add(btnPeriod30);
            grpCoupons.Controls.Add(btnPeriod90);
            grpCoupons.Controls.Add(btnPeriod180);
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
            grpCoupons.Location = new Point(0, 104);
            grpCoupons.Name = "grpCoupons";
            grpCoupons.Size = new Size(418, 285);
            grpCoupons.TabIndex = 1;
            grpCoupons.TabStop = false;
            grpCoupons.Text = "Coupons";
            // 
            // dtpLastCoupon
            // 
            dtpLastCoupon.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            dtpLastCoupon.Format = DateTimePickerFormat.Short;
            dtpLastCoupon.Location = new Point(176, 48);
            dtpLastCoupon.Name = "dtpLastCoupon";
            dtpLastCoupon.Size = new Size(230, 23);
            dtpLastCoupon.TabIndex = 5;
            // 
            // dtpFirstCoupon
            // 
            dtpFirstCoupon.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            dtpFirstCoupon.Format = DateTimePickerFormat.Short;
            dtpFirstCoupon.Location = new Point(176, 22);
            dtpFirstCoupon.Name = "dtpFirstCoupon";
            dtpFirstCoupon.Size = new Size(230, 23);
            dtpFirstCoupon.TabIndex = 4;
            // 
            // nudPeriod
            // 
            nudPeriod.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            nudPeriod.Location = new Point(279, 74);
            nudPeriod.Maximum = new decimal(new int[] { 9999, 0, 0, 0 });
            nudPeriod.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            nudPeriod.Name = "nudPeriod";
            nudPeriod.Size = new Size(127, 23);
            nudPeriod.TabIndex = 9;
            nudPeriod.Value = new decimal(new int[] { 30, 0, 0, 0 });
            // 
            // btnPeriod30
            // 
            btnPeriod30.Location = new Point(176, 74);
            btnPeriod30.Name = "btnPeriod30";
            btnPeriod30.Size = new Size(30, 23);
            btnPeriod30.TabIndex = 6;
            btnPeriod30.Text = "30";
            btnPeriod30.UseVisualStyleBackColor = true;
            btnPeriod30.Click += btnPeriod_Click;
            // 
            // btnPeriod90
            // 
            btnPeriod90.Location = new Point(208, 74);
            btnPeriod90.Name = "btnPeriod90";
            btnPeriod90.Size = new Size(30, 23);
            btnPeriod90.TabIndex = 7;
            btnPeriod90.Text = "90";
            btnPeriod90.UseVisualStyleBackColor = true;
            btnPeriod90.Click += btnPeriod_Click;
            // 
            // btnPeriod180
            // 
            btnPeriod180.Location = new Point(240, 74);
            btnPeriod180.Name = "btnPeriod180";
            btnPeriod180.Size = new Size(35, 23);
            btnPeriod180.TabIndex = 8;
            btnPeriod180.Text = "180";
            btnPeriod180.UseVisualStyleBackColor = true;
            btnPeriod180.Click += btnPeriod_Click;
            // 
            // btnGenerate
            // 
            btnGenerate.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            btnGenerate.Location = new Point(8, 252);
            btnGenerate.Name = "btnGenerate";
            btnGenerate.Size = new Size(170, 23);
            btnGenerate.TabIndex = 12;
            btnGenerate.Text = "Generate";
            btnGenerate.UseVisualStyleBackColor = true;
            btnGenerate.Click += btnGenerateCoupons_Click;
            // 
            // lblLastCoupon
            // 
            lblLastCoupon.Location = new Point(12, 50);
            lblLastCoupon.Name = "lblLastCoupon";
            lblLastCoupon.Size = new Size(158, 20);
            lblLastCoupon.TabIndex = 8;
            lblLastCoupon.Text = "Last Coupon Date:";
            lblLastCoupon.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblFirstCoupon
            // 
            lblFirstCoupon.Location = new Point(12, 24);
            lblFirstCoupon.Name = "lblFirstCoupon";
            lblFirstCoupon.Size = new Size(158, 20);
            lblFirstCoupon.TabIndex = 6;
            lblFirstCoupon.Text = "First Coupon Date:";
            lblFirstCoupon.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // btnClearCoupons
            // 
            btnClearCoupons.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnClearCoupons.Location = new Point(336, 252);
            btnClearCoupons.Name = "btnClearCoupons";
            btnClearCoupons.Size = new Size(70, 23);
            btnClearCoupons.TabIndex = 15;
            btnClearCoupons.Text = "Clear";
            btnClearCoupons.UseVisualStyleBackColor = true;
            btnClearCoupons.Click += btnClearCoupons_Click;
            // 
            // lblPeriod
            // 
            lblPeriod.Location = new Point(12, 76);
            lblPeriod.Name = "lblPeriod";
            lblPeriod.Size = new Size(158, 20);
            lblPeriod.TabIndex = 9;
            lblPeriod.Text = "Period (days):";
            lblPeriod.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // nudCouponAmount
            // 
            nudCouponAmount.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            nudCouponAmount.DecimalPlaces = 2;
            nudCouponAmount.Location = new Point(176, 100);
            nudCouponAmount.Maximum = new decimal(new int[] { 999999999, 0, 0, 0 });
            nudCouponAmount.Name = "nudCouponAmount";
            nudCouponAmount.Size = new Size(230, 23);
            nudCouponAmount.TabIndex = 10;
            nudCouponAmount.ThousandsSeparator = true;
            // 
            // lblCouponAmount
            // 
            lblCouponAmount.Location = new Point(12, 102);
            lblCouponAmount.Name = "lblCouponAmount";
            lblCouponAmount.Size = new Size(158, 20);
            lblCouponAmount.TabIndex = 21;
            lblCouponAmount.Text = "Coupon Amount:";
            lblCouponAmount.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // btnAddCoupon
            // 
            btnAddCoupon.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnAddCoupon.Location = new Point(184, 252);
            btnAddCoupon.Name = "btnAddCoupon";
            btnAddCoupon.Size = new Size(70, 23);
            btnAddCoupon.TabIndex = 13;
            btnAddCoupon.Text = "Add";
            btnAddCoupon.UseVisualStyleBackColor = true;
            btnAddCoupon.Click += btnAddCoupon_Click;
            // 
            // btnRemoveCoupon
            // 
            btnRemoveCoupon.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnRemoveCoupon.Location = new Point(260, 252);
            btnRemoveCoupon.Name = "btnRemoveCoupon";
            btnRemoveCoupon.Size = new Size(70, 23);
            btnRemoveCoupon.TabIndex = 14;
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
            dgvCoupons.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvCoupons.Size = new Size(398, 117);
            dgvCoupons.TabIndex = 11;
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
            grpAmortizations.Location = new Point(0, 389);
            grpAmortizations.Name = "grpAmortizations";
            grpAmortizations.Size = new Size(418, 195);
            grpAmortizations.TabIndex = 2;
            grpAmortizations.TabStop = false;
            grpAmortizations.Text = "Amortizations";
            // 
            // lblAmortAmount
            // 
            lblAmortAmount.Location = new Point(205, 24);
            lblAmortAmount.Name = "lblAmortAmount";
            lblAmortAmount.Size = new Size(146, 20);
            lblAmortAmount.TabIndex = 12;
            lblAmortAmount.Text = "Amount: -";
            lblAmortAmount.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // nudAmortParts
            // 
            nudAmortParts.Location = new Point(140, 22);
            nudAmortParts.Minimum = new decimal(new int[] { 2, 0, 0, 0 });
            nudAmortParts.Name = "nudAmortParts";
            nudAmortParts.Size = new Size(59, 23);
            nudAmortParts.TabIndex = 16;
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
            btnGenerateAmort.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            btnGenerateAmort.Location = new Point(8, 164);
            btnGenerateAmort.Name = "btnGenerateAmort";
            btnGenerateAmort.Size = new Size(170, 23);
            btnGenerateAmort.TabIndex = 18;
            btnGenerateAmort.Text = "Generate";
            btnGenerateAmort.UseVisualStyleBackColor = true;
            btnGenerateAmort.Click += btnGenerateAmort_Click;
            // 
            // btnClearAmortizations
            // 
            btnClearAmortizations.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnClearAmortizations.Location = new Point(336, 166);
            btnClearAmortizations.Name = "btnClearAmortizations";
            btnClearAmortizations.Size = new Size(70, 23);
            btnClearAmortizations.TabIndex = 21;
            btnClearAmortizations.Text = "Clear";
            btnClearAmortizations.UseVisualStyleBackColor = true;
            btnClearAmortizations.Click += btnClearAmortizations_Click;
            // 
            // btnRemoveAmortization
            // 
            btnRemoveAmortization.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnRemoveAmortization.Location = new Point(260, 166);
            btnRemoveAmortization.Name = "btnRemoveAmortization";
            btnRemoveAmortization.Size = new Size(70, 23);
            btnRemoveAmortization.TabIndex = 20;
            btnRemoveAmortization.Text = "Remove";
            btnRemoveAmortization.UseVisualStyleBackColor = true;
            btnRemoveAmortization.Click += btnRemoveAmortization_Click;
            // 
            // btnAddAmortization
            // 
            btnAddAmortization.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnAddAmortization.Location = new Point(184, 166);
            btnAddAmortization.Name = "btnAddAmortization";
            btnAddAmortization.Size = new Size(70, 23);
            btnAddAmortization.TabIndex = 19;
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
            dgvAmortizations.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvAmortizations.Size = new Size(398, 110);
            dgvAmortizations.TabIndex = 17;
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
            btnCalculate.Location = new Point(8, 724);
            btnCalculate.Name = "btnCalculate";
            btnCalculate.Size = new Size(335, 60);
            btnCalculate.TabIndex = 25;
            btnCalculate.Text = "Calculate";
            btnCalculate.UseVisualStyleBackColor = true;
            btnCalculate.Click += btnCalculate_Click;
            // 
            // btnReset
            // 
            btnReset.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            btnReset.Font = new Font("Segoe UI", 24F);
            btnReset.Location = new Point(347, 724);
            btnReset.Name = "btnReset";
            btnReset.Size = new Size(60, 60);
            btnReset.TabIndex = 26;
            btnReset.Text = "⟳";
            btnReset.UseVisualStyleBackColor = true;
            btnReset.Click += btnReset_Click;
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
            grpOutput.Dock = DockStyle.Top;
            grpOutput.Location = new Point(0, 0);
            grpOutput.Name = "grpOutput";
            grpOutput.Size = new Size(632, 200);
            grpOutput.TabIndex = 2;
            grpOutput.TabStop = false;
            grpOutput.Text = "Results";
            // 
            // lblRealRepayIncomeVal
            // 
            lblRealRepayIncomeVal.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblRealRepayIncomeVal.Location = new Point(528, 68);
            lblRealRepayIncomeVal.Name = "lblRealRepayIncomeVal";
            lblRealRepayIncomeVal.Size = new Size(100, 20);
            lblRealRepayIncomeVal.TabIndex = 23;
            lblRealRepayIncomeVal.Text = "-";
            lblRealRepayIncomeVal.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblRealRepayIncome
            // 
            lblRealRepayIncome.Location = new Point(296, 68);
            lblRealRepayIncome.Name = "lblRealRepayIncome";
            lblRealRepayIncome.Size = new Size(241, 20);
            lblRealRepayIncome.TabIndex = 22;
            lblRealRepayIncome.Text = "Real Repayment Income:";
            lblRealRepayIncome.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblRealCouponIncomeVal
            // 
            lblRealCouponIncomeVal.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblRealCouponIncomeVal.Location = new Point(528, 88);
            lblRealCouponIncomeVal.Name = "lblRealCouponIncomeVal";
            lblRealCouponIncomeVal.Size = new Size(100, 20);
            lblRealCouponIncomeVal.TabIndex = 21;
            lblRealCouponIncomeVal.Text = "-";
            lblRealCouponIncomeVal.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblRealCouponIncome
            // 
            lblRealCouponIncome.Location = new Point(296, 88);
            lblRealCouponIncome.Name = "lblRealCouponIncome";
            lblRealCouponIncome.Size = new Size(241, 20);
            lblRealCouponIncome.TabIndex = 20;
            lblRealCouponIncome.Text = "Real Total Coupon Income:";
            lblRealCouponIncome.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblRealAnnualYieldVal
            // 
            lblRealAnnualYieldVal.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblRealAnnualYieldVal.Location = new Point(528, 154);
            lblRealAnnualYieldVal.Name = "lblRealAnnualYieldVal";
            lblRealAnnualYieldVal.Size = new Size(100, 20);
            lblRealAnnualYieldVal.TabIndex = 19;
            lblRealAnnualYieldVal.Text = "-";
            lblRealAnnualYieldVal.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblRealAnnualYield
            // 
            lblRealAnnualYield.Location = new Point(296, 154);
            lblRealAnnualYield.Name = "lblRealAnnualYield";
            lblRealAnnualYield.Size = new Size(241, 20);
            lblRealAnnualYield.TabIndex = 18;
            lblRealAnnualYield.Text = "Real Annual Yield:";
            lblRealAnnualYield.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblRealYieldVal
            // 
            lblRealYieldVal.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblRealYieldVal.Location = new Point(528, 132);
            lblRealYieldVal.Name = "lblRealYieldVal";
            lblRealYieldVal.Size = new Size(100, 20);
            lblRealYieldVal.TabIndex = 17;
            lblRealYieldVal.Text = "-";
            lblRealYieldVal.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblRealYield
            // 
            lblRealYield.Location = new Point(296, 132);
            lblRealYield.Name = "lblRealYield";
            lblRealYield.Size = new Size(241, 20);
            lblRealYield.TabIndex = 16;
            lblRealYield.Text = "Real Total Yield:";
            lblRealYield.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblRealIncomeVal
            // 
            lblRealIncomeVal.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblRealIncomeVal.Location = new Point(528, 110);
            lblRealIncomeVal.Name = "lblRealIncomeVal";
            lblRealIncomeVal.Size = new Size(100, 20);
            lblRealIncomeVal.TabIndex = 15;
            lblRealIncomeVal.Text = "-";
            lblRealIncomeVal.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblRealIncome
            // 
            lblRealIncome.Location = new Point(296, 110);
            lblRealIncome.Name = "lblRealIncome";
            lblRealIncome.Size = new Size(241, 20);
            lblRealIncome.TabIndex = 14;
            lblRealIncome.Text = "Real Total Income:";
            lblRealIncome.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblRealHeader
            // 
            lblRealHeader.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblRealHeader.ForeColor = Color.DimGray;
            lblRealHeader.Location = new Point(296, 48);
            lblRealHeader.Name = "lblRealHeader";
            lblRealHeader.Size = new Size(324, 16);
            lblRealHeader.TabIndex = 13;
            lblRealHeader.Text = "── Real (Inflation-Adjusted) ──";
            // 
            // lblAnnualYieldVal
            // 
            lblAnnualYieldVal.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblAnnualYieldVal.Location = new Point(190, 156);
            lblAnnualYieldVal.Name = "lblAnnualYieldVal";
            lblAnnualYieldVal.Size = new Size(100, 20);
            lblAnnualYieldVal.TabIndex = 12;
            lblAnnualYieldVal.Text = "-";
            lblAnnualYieldVal.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblAnnualYield
            // 
            lblAnnualYield.Location = new Point(12, 156);
            lblAnnualYield.Name = "lblAnnualYield";
            lblAnnualYield.Size = new Size(195, 20);
            lblAnnualYield.TabIndex = 11;
            lblAnnualYield.Text = "Annual Yield:";
            lblAnnualYield.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblTotalYieldVal
            // 
            lblTotalYieldVal.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblTotalYieldVal.Location = new Point(190, 134);
            lblTotalYieldVal.Name = "lblTotalYieldVal";
            lblTotalYieldVal.Size = new Size(100, 20);
            lblTotalYieldVal.TabIndex = 10;
            lblTotalYieldVal.Text = "-";
            lblTotalYieldVal.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblTotalYield
            // 
            lblTotalYield.Location = new Point(12, 134);
            lblTotalYield.Name = "lblTotalYield";
            lblTotalYield.Size = new Size(195, 20);
            lblTotalYield.TabIndex = 9;
            lblTotalYield.Text = "Total Yield:";
            lblTotalYield.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblTotalIncomeVal
            // 
            lblTotalIncomeVal.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblTotalIncomeVal.Location = new Point(190, 112);
            lblTotalIncomeVal.Name = "lblTotalIncomeVal";
            lblTotalIncomeVal.Size = new Size(100, 20);
            lblTotalIncomeVal.TabIndex = 8;
            lblTotalIncomeVal.Text = "-";
            lblTotalIncomeVal.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblTotalIncome
            // 
            lblTotalIncome.Location = new Point(12, 112);
            lblTotalIncome.Name = "lblTotalIncome";
            lblTotalIncome.Size = new Size(195, 20);
            lblTotalIncome.TabIndex = 7;
            lblTotalIncome.Text = "Total Income:";
            lblTotalIncome.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblCouponIncomeVal
            // 
            lblCouponIncomeVal.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblCouponIncomeVal.Location = new Point(190, 90);
            lblCouponIncomeVal.Name = "lblCouponIncomeVal";
            lblCouponIncomeVal.Size = new Size(100, 20);
            lblCouponIncomeVal.TabIndex = 6;
            lblCouponIncomeVal.Text = "-";
            lblCouponIncomeVal.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblCouponIncome
            // 
            lblCouponIncome.Location = new Point(12, 90);
            lblCouponIncome.Name = "lblCouponIncome";
            lblCouponIncome.Size = new Size(195, 20);
            lblCouponIncome.TabIndex = 5;
            lblCouponIncome.Text = "Total Coupon Income:";
            lblCouponIncome.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblRepayIncomeVal
            // 
            lblRepayIncomeVal.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblRepayIncomeVal.Location = new Point(190, 68);
            lblRepayIncomeVal.Name = "lblRepayIncomeVal";
            lblRepayIncomeVal.Size = new Size(100, 20);
            lblRepayIncomeVal.TabIndex = 4;
            lblRepayIncomeVal.Text = "-";
            lblRepayIncomeVal.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblRepayIncome
            // 
            lblRepayIncome.Location = new Point(12, 68);
            lblRepayIncome.Name = "lblRepayIncome";
            lblRepayIncome.Size = new Size(195, 20);
            lblRepayIncome.TabIndex = 3;
            lblRepayIncome.Text = "Repayment Income:";
            lblRepayIncome.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblBuyPriceVal
            // 
            lblBuyPriceVal.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblBuyPriceVal.Location = new Point(190, 19);
            lblBuyPriceVal.Name = "lblBuyPriceVal";
            lblBuyPriceVal.Size = new Size(100, 20);
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
            lblNominalHeader.Size = new Size(278, 16);
            lblNominalHeader.TabIndex = 0;
            lblNominalHeader.Text = "── Nominal ──";
            // 
            // grpSchedule
            // 
            grpSchedule.Controls.Add(dgvSchedule);
            grpSchedule.Controls.Add(pnlChartContainer);
            grpSchedule.Dock = DockStyle.Fill;
            grpSchedule.Location = new Point(0, 200);
            grpSchedule.Name = "grpSchedule";
            grpSchedule.Size = new Size(632, 591);
            grpSchedule.TabIndex = 1;
            grpSchedule.TabStop = false;
            grpSchedule.Text = "Coupon Schedule";
            // 
            // dgvSchedule
            // 
            dgvSchedule.AllowUserToAddRows = false;
            dgvSchedule.AllowUserToDeleteRows = false;
            dgvSchedule.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvSchedule.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvSchedule.Columns.AddRange(new DataGridViewColumn[] { colSchDate, colSchType, colSchNominal, colSchCumNominal, colSchReal, colSchCumReal });
            dgvSchedule.Dock = DockStyle.Top;
            dgvSchedule.Location = new Point(3, 19);
            dgvSchedule.Name = "dgvSchedule";
            dgvSchedule.ReadOnly = true;
            dgvSchedule.RowHeadersVisible = false;
            dgvSchedule.Size = new Size(626, 250);
            dgvSchedule.TabIndex = 0;
            dgvSchedule.TabStop = false;
            // 
            // colSchDate
            // 
            colSchDate.HeaderText = "Date";
            colSchDate.Name = "colSchDate";
            colSchDate.ReadOnly = true;
            // 
            // colSchType
            // 
            colSchType.HeaderText = "Type";
            colSchType.Name = "colSchType";
            colSchType.ReadOnly = true;
            // 
            // colSchNominal
            // 
            colSchNominal.HeaderText = "Nominal Amount";
            colSchNominal.Name = "colSchNominal";
            colSchNominal.ReadOnly = true;
            // 
            // colSchCumNominal
            // 
            colSchCumNominal.HeaderText = "Cumulative Income";
            colSchCumNominal.Name = "colSchCumNominal";
            colSchCumNominal.ReadOnly = true;
            // 
            // colSchReal
            // 
            colSchReal.HeaderText = "Real Amount";
            colSchReal.Name = "colSchReal";
            colSchReal.ReadOnly = true;
            // 
            // colSchCumReal
            // 
            colSchCumReal.HeaderText = "Cumulative Real Income";
            colSchCumReal.Name = "colSchCumReal";
            colSchCumReal.ReadOnly = true;
            // 
            // pnlChartContainer
            // 
            pnlChartContainer.Dock = DockStyle.Bottom;
            pnlChartContainer.Location = new Point(3, 269);
            pnlChartContainer.Name = "pnlChartContainer";
            pnlChartContainer.Size = new Size(626, 319);
            pnlChartContainer.TabIndex = 0;
            // 
            // splitMain
            // 
            splitMain.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            splitMain.Location = new Point(0, 24);
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
            splitMain.Panel2.Controls.Add(grpSchedule);
            splitMain.Panel2.Controls.Add(grpOutput);
            splitMain.Panel2MinSize = 540;
            splitMain.Size = new Size(1054, 791);
            splitMain.SplitterDistance = 418;
            splitMain.TabIndex = 0;
            splitMain.TabStop = false;
            // 
            // menuStrip
            // 
            menuStrip.Items.AddRange(new ToolStripItem[] { aboutMenuItem, toolsMenuItem });
            menuStrip.Location = new Point(0, 0);
            menuStrip.Name = "menuStrip";
            menuStrip.Size = new Size(1054, 24);
            menuStrip.TabIndex = 16;
            menuStrip.Text = "menuStrip";
            // 
            // aboutMenuItem
            // 
            aboutMenuItem.Name = "aboutMenuItem";
            aboutMenuItem.Size = new Size(52, 20);
            aboutMenuItem.Text = "About";
            aboutMenuItem.Click += OnAboutClick;
            // 
            // toolsMenuItem
            // 
            toolsMenuItem.DropDownItems.AddRange(new ToolStripItem[] { englishItem, russianItem });
            toolsMenuItem.Name = "toolsMenuItem";
            toolsMenuItem.Size = new Size(71, 20);
            toolsMenuItem.Text = "Language";
            // 
            // englishItem
            // 
            englishItem.Name = "englishItem";
            englishItem.Size = new Size(119, 22);
            englishItem.Text = "English";
            englishItem.Click += OnLanguageEnglish;
            // 
            // russianItem
            // 
            russianItem.Name = "russianItem";
            russianItem.Size = new Size(119, 22);
            russianItem.Text = "Русский";
            russianItem.Click += OnLanguageRussian;
            // 
            // BondCalc
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1054, 815);
            Controls.Add(menuStrip);
            Controls.Add(splitMain);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MainMenuStrip = menuStrip;
            MinimumSize = new Size(1070, 844);
            Name = "BondCalc";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "BondCalc - Inflation-Adjusted Bond Yield Calculator";
            grpParameters.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)nudNominal).EndInit();
            ((System.ComponentModel.ISupportInitialize)nudInflation).EndInit();
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
            grpOutput.ResumeLayout(false);
            grpSchedule.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvSchedule).EndInit();
            splitMain.Panel1.ResumeLayout(false);
            splitMain.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitMain).EndInit();
            splitMain.ResumeLayout(false);
            menuStrip.ResumeLayout(false);
            menuStrip.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
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
        private Button btnPeriod30;
        private Button btnPeriod90;
        private Button btnPeriod180;
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

        private GroupBox grpSchedule;
        private Panel pnlChartContainer;
        private DataGridView dgvSchedule;

        private SplitContainer splitMain;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private DataGridViewTextBoxColumn colSchDate;
        private DataGridViewTextBoxColumn colSchType;
        private DataGridViewTextBoxColumn colSchNominal;
        private DataGridViewTextBoxColumn colSchCumNominal;
        private DataGridViewTextBoxColumn colSchReal;
        private DataGridViewTextBoxColumn colSchCumReal;
        private DateTimePicker nudPurchase;
        private Label label1;
        private Label lblRealRepayIncomeVal;
        private Label lblRealRepayIncome;
        private Label lblRealCouponIncomeVal;
        private Label lblRealCouponIncome;
        private MenuStrip menuStrip;
        private ToolStripMenuItem toolsMenuItem;
        private ToolStripMenuItem englishItem;
        private ToolStripMenuItem russianItem;
        private ToolStripMenuItem aboutMenuItem;
    }
}
