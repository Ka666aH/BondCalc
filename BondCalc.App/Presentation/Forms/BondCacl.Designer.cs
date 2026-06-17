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
            lblPeriod = new Label();
            btnClearCoupons = new Button();
            btnRemoveCoupon = new Button();
            btnAddCoupon = new Button();
            dgvCoupons = new DataGridView();
            grpAmortizations = new GroupBox();
            lblAmortAmount = new Label();
            nudAmortParts = new NumericUpDown();
            lblAmortParts = new Label();
            btnGenerateAmort = new Button();
            btnClearAmortizations = new Button();
            btnRemoveAmortization = new Button();
            btnAddAmortization = new Button();
            dgvAmortizations = new DataGridView();
            btnCalculate = new Button();
            btnReset = new Button();
            grpResults = new GroupBox();
            lblSellByValue = new Label();
            lblSellByLabel = new Label();
            lblYtmValue = new Label();
            lblYtmLabel = new Label();
            grpSchedule = new GroupBox();
            dgvSchedule = new DataGridView();
            splitMain = new SplitContainer();

            grpParameters.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)nudInflation).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudNominal).BeginInit();
            grpDeal.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)nudAccrued).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudPrice).BeginInit();
            grpCoupons.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)nudPeriod).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvCoupons).BeginInit();
            grpAmortizations.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)nudAmortParts).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvAmortizations).BeginInit();
            grpResults.SuspendLayout();
            grpSchedule.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvSchedule).BeginInit();
            ((System.ComponentModel.ISupportInitialize)splitMain).BeginInit();
            splitMain.Panel1.SuspendLayout();
            splitMain.Panel2.SuspendLayout();
            splitMain.SuspendLayout();
            SuspendLayout();

            // grpParameters
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
            grpParameters.Size = new Size(400, 152);
            grpParameters.TabIndex = 0;
            grpParameters.TabStop = false;
            grpParameters.Text = "Bond Parameters";

            // nudInflation
            nudInflation.DecimalPlaces = 2;
            nudInflation.Location = new Point(140, 100);
            nudInflation.Maximum = new decimal(new int[] { 100, 0, 0, 0 });
            nudInflation.Name = "nudInflation";
            nudInflation.Size = new Size(120, 23);
            nudInflation.TabIndex = 7;
            // lblInflation
            lblInflation.Location = new Point(12, 102);
            lblInflation.Name = "lblInflation";
            lblInflation.Size = new Size(120, 20);
            lblInflation.TabIndex = 6;
            lblInflation.Text = "Inflation Rate (%):";
            lblInflation.TextAlign = ContentAlignment.MiddleLeft;

            // nudNominal
            nudNominal.DecimalPlaces = 2;
            nudNominal.Location = new Point(140, 22);
            nudNominal.Maximum = new decimal(new int[] { 999999999, 0, 0, 0 });
            nudNominal.Minimum = new decimal(new int[] { 1, 0, 0, 131072 });
            nudNominal.Name = "nudNominal";
            nudNominal.Size = new Size(120, 23);
            nudNominal.TabIndex = 1;
            nudNominal.Value = new decimal(new int[] { 1000, 0, 0, 0 });

            // dtpPlacement
            dtpPlacement.Format = DateTimePickerFormat.Short;
            dtpPlacement.Location = new Point(140, 48);
            dtpPlacement.Name = "dtpPlacement";
            dtpPlacement.Size = new Size(120, 23);
            dtpPlacement.TabIndex = 3;
            dtpPlacement.Value = new DateTime(2025, 1, 1, 0, 0, 0, 0);

            // dtpRepayment
            dtpRepayment.Format = DateTimePickerFormat.Short;
            dtpRepayment.Location = new Point(140, 74);
            dtpRepayment.Name = "dtpRepayment";
            dtpRepayment.Size = new Size(120, 23);
            dtpRepayment.TabIndex = 5;
            dtpRepayment.Value = new DateTime(2030, 1, 1, 0, 0, 0, 0);

            // lblNominal
            lblNominal.Location = new Point(12, 24);
            lblNominal.Name = "lblNominal";
            lblNominal.Size = new Size(120, 20);
            lblNominal.TabIndex = 0;
            lblNominal.Text = "Nominal Value:";
            lblNominal.TextAlign = ContentAlignment.MiddleLeft;

            // lblPlacement
            lblPlacement.Location = new Point(12, 50);
            lblPlacement.Name = "lblPlacement";
            lblPlacement.Size = new Size(120, 20);
            lblPlacement.TabIndex = 2;
            lblPlacement.Text = "Placement Date:";
            lblPlacement.TextAlign = ContentAlignment.MiddleLeft;

            // lblRepayment
            lblRepayment.Location = new Point(12, 76);
            lblRepayment.Name = "lblRepayment";
            lblRepayment.Size = new Size(120, 20);
            lblRepayment.TabIndex = 4;
            lblRepayment.Text = "Repayment Date:";
            lblRepayment.TextAlign = ContentAlignment.MiddleLeft;

            // grpDeal
            grpDeal.Controls.Add(nudAccrued);
            grpDeal.Controls.Add(nudPrice);
            grpDeal.Controls.Add(lblAccrued);
            grpDeal.Controls.Add(lblPrice);
            grpDeal.Dock = DockStyle.Top;
            grpDeal.Location = new Point(0, 152);
            grpDeal.Name = "grpDeal";
            grpDeal.Size = new Size(400, 80);
            grpDeal.TabIndex = 15;
            grpDeal.TabStop = false;
            grpDeal.Text = "Deal";

            // nudAccrued
            nudAccrued.DecimalPlaces = 2;
            nudAccrued.Location = new Point(140, 48);
            nudAccrued.Maximum = new decimal(new int[] { 999999999, 0, 0, 0 });
            nudAccrued.Name = "nudAccrued";
            nudAccrued.Size = new Size(120, 23);
            nudAccrued.TabIndex = 11;
            // lblAccrued
            lblAccrued.Location = new Point(12, 50);
            lblAccrued.Name = "lblAccrued";
            lblAccrued.Size = new Size(120, 20);
            lblAccrued.TabIndex = 10;
            lblAccrued.Text = "Accrued Interest (НКД):";
            lblAccrued.TextAlign = ContentAlignment.MiddleLeft;

            // nudPrice
            nudPrice.DecimalPlaces = 2;
            nudPrice.Location = new Point(140, 22);
            nudPrice.Maximum = new decimal(new int[] { 999999999, 0, 0, 0 });
            nudPrice.Minimum = new decimal(new int[] { 1, 0, 0, 131072 });
            nudPrice.Name = "nudPrice";
            nudPrice.Size = new Size(120, 23);
            nudPrice.TabIndex = 9;
            nudPrice.Value = new decimal(new int[] { 1000, 0, 0, 0 });
            // lblPrice
            lblPrice.Location = new Point(12, 24);
            lblPrice.Name = "lblPrice";
            lblPrice.Size = new Size(120, 20);
            lblPrice.TabIndex = 8;
            lblPrice.Text = "Purchase Price:";
            lblPrice.TextAlign = ContentAlignment.MiddleLeft;

            // grpCoupons
            grpCoupons.Controls.Add(dtpLastCoupon);
            grpCoupons.Controls.Add(dtpFirstCoupon);
            grpCoupons.Controls.Add(nudPeriod);
            grpCoupons.Controls.Add(btnGenerate);
            grpCoupons.Controls.Add(lblLastCoupon);
            grpCoupons.Controls.Add(lblFirstCoupon);
            grpCoupons.Controls.Add(lblPeriod);
            grpCoupons.Controls.Add(btnClearCoupons);
            grpCoupons.Controls.Add(btnRemoveCoupon);
            grpCoupons.Controls.Add(btnAddCoupon);
            grpCoupons.Controls.Add(dgvCoupons);
            grpCoupons.Dock = DockStyle.Top;
            grpCoupons.Location = new Point(0, 232);
            grpCoupons.Name = "grpCoupons";
            grpCoupons.Size = new Size(400, 280);
            grpCoupons.TabIndex = 1;
            grpCoupons.TabStop = false;
            grpCoupons.Text = "Coupons";

            // dtpFirstCoupon
            dtpFirstCoupon.Format = DateTimePickerFormat.Short;
            dtpFirstCoupon.Location = new Point(140, 22);
            dtpFirstCoupon.Name = "dtpFirstCoupon";
            dtpFirstCoupon.Size = new Size(120, 23);
            dtpFirstCoupon.TabIndex = 7;
            // lblFirstCoupon
            lblFirstCoupon.Location = new Point(12, 24);
            lblFirstCoupon.Name = "lblFirstCoupon";
            lblFirstCoupon.Size = new Size(120, 20);
            lblFirstCoupon.TabIndex = 6;
            lblFirstCoupon.Text = "First Coupon Date:";
            lblFirstCoupon.TextAlign = ContentAlignment.MiddleLeft;

            // dtpLastCoupon
            dtpLastCoupon.Format = DateTimePickerFormat.Short;
            dtpLastCoupon.Location = new Point(140, 48);
            dtpLastCoupon.Name = "dtpLastCoupon";
            dtpLastCoupon.Size = new Size(120, 23);
            dtpLastCoupon.TabIndex = 9;
            // lblLastCoupon
            lblLastCoupon.Location = new Point(12, 50);
            lblLastCoupon.Name = "lblLastCoupon";
            lblLastCoupon.Size = new Size(120, 20);
            lblLastCoupon.TabIndex = 8;
            lblLastCoupon.Text = "Last Coupon Date:";
            lblLastCoupon.TextAlign = ContentAlignment.MiddleLeft;

            // nudPeriod
            nudPeriod.Location = new Point(140, 74);
            nudPeriod.Maximum = new decimal(new int[] { 9999, 0, 0, 0 });
            nudPeriod.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            nudPeriod.Name = "nudPeriod";
            nudPeriod.Size = new Size(80, 23);
            nudPeriod.TabIndex = 10;
            nudPeriod.Value = new decimal(new int[] { 182, 0, 0, 0 });
            // lblPeriod
            lblPeriod.Location = new Point(12, 76);
            lblPeriod.Name = "lblPeriod";
            lblPeriod.Size = new Size(120, 20);
            lblPeriod.TabIndex = 9;
            lblPeriod.Text = "Period (days):";
            lblPeriod.TextAlign = ContentAlignment.MiddleLeft;

            // btnGenerate
            btnGenerate.Location = new Point(230, 72);
            btnGenerate.Name = "btnGenerate";
            btnGenerate.Size = new Size(100, 25);
            btnGenerate.TabIndex = 11;
            btnGenerate.Text = "Generate";
            btnGenerate.UseVisualStyleBackColor = true;
            btnGenerate.Click += btnGenerateCoupons_Click;

            // dgvCoupons
            dgvCoupons.AllowUserToAddRows = false;
            dgvCoupons.AllowUserToDeleteRows = false;
            dgvCoupons.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvCoupons.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvCoupons.Location = new Point(8, 104);
            dgvCoupons.Name = "dgvCoupons";
            dgvCoupons.RowHeadersVisible = false;
            dgvCoupons.Size = new Size(384, 138);
            dgvCoupons.TabIndex = 0;
            dgvCoupons.Columns.Add("colCouponDate", "Date");
            dgvCoupons.Columns.Add("colCouponAmount", "Amount");
            dgvCoupons.Columns[0].ValueType = typeof(DateTime);
            dgvCoupons.Columns[1].ValueType = typeof(double);

            // btnAddCoupon
            btnAddCoupon.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btnAddCoupon.Location = new Point(8, 250);
            btnAddCoupon.Name = "btnAddCoupon";
            btnAddCoupon.Size = new Size(80, 23);
            btnAddCoupon.TabIndex = 1;
            btnAddCoupon.Text = "Add";
            btnAddCoupon.UseVisualStyleBackColor = true;
            btnAddCoupon.Click += btnAddCoupon_Click;

            // btnRemoveCoupon
            btnRemoveCoupon.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btnRemoveCoupon.Location = new Point(94, 250);
            btnRemoveCoupon.Name = "btnRemoveCoupon";
            btnRemoveCoupon.Size = new Size(80, 23);
            btnRemoveCoupon.TabIndex = 2;
            btnRemoveCoupon.Text = "Remove";
            btnRemoveCoupon.UseVisualStyleBackColor = true;
            btnRemoveCoupon.Click += btnRemoveCoupon_Click;

            // btnClearCoupons
            btnClearCoupons.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btnClearCoupons.Location = new Point(180, 250);
            btnClearCoupons.Name = "btnClearCoupons";
            btnClearCoupons.Size = new Size(80, 23);
            btnClearCoupons.TabIndex = 12;
            btnClearCoupons.Text = "Clear";
            btnClearCoupons.UseVisualStyleBackColor = true;
            btnClearCoupons.Click += btnClearCoupons_Click;

            // grpAmortizations
            grpAmortizations.Controls.Add(lblAmortAmount);
            grpAmortizations.Controls.Add(nudAmortParts);
            grpAmortizations.Controls.Add(lblAmortParts);
            grpAmortizations.Controls.Add(btnGenerateAmort);
            grpAmortizations.Controls.Add(btnClearAmortizations);
            grpAmortizations.Controls.Add(btnRemoveAmortization);
            grpAmortizations.Controls.Add(btnAddAmortization);
            grpAmortizations.Controls.Add(dgvAmortizations);
            grpAmortizations.Dock = DockStyle.Top;
            grpAmortizations.Location = new Point(0, 512);
            grpAmortizations.Name = "grpAmortizations";
            grpAmortizations.Size = new Size(400, 180);
            grpAmortizations.TabIndex = 2;
            grpAmortizations.TabStop = false;
            grpAmortizations.Text = "Amortizations";

            // nudAmortParts
            nudAmortParts.Location = new Point(140, 22);
            nudAmortParts.Minimum = new decimal(new int[] { 2, 0, 0, 0 });
            nudAmortParts.Name = "nudAmortParts";
            nudAmortParts.Size = new Size(80, 23);
            nudAmortParts.TabIndex = 10;
            nudAmortParts.Value = new decimal(new int[] { 5, 0, 0, 0 });
            nudAmortParts.ValueChanged += nudAmortParts_ValueChanged;
            // lblAmortParts
            lblAmortParts.Location = new Point(12, 24);
            lblAmortParts.Name = "lblAmortParts";
            lblAmortParts.Size = new Size(120, 20);
            lblAmortParts.TabIndex = 9;
            lblAmortParts.Text = "Number of Parts:";
            lblAmortParts.TextAlign = ContentAlignment.MiddleLeft;

            // lblAmortAmount
            lblAmortAmount.Location = new Point(230, 24);
            lblAmortAmount.Name = "lblAmortAmount";
            lblAmortAmount.Size = new Size(70, 20);
            lblAmortAmount.TabIndex = 12;
            lblAmortAmount.Text = "Amount: -";
            lblAmortAmount.TextAlign = ContentAlignment.MiddleLeft;

            // btnGenerateAmort
            btnGenerateAmort.Location = new Point(306, 20);
            btnGenerateAmort.Name = "btnGenerateAmort";
            btnGenerateAmort.Size = new Size(85, 25);
            btnGenerateAmort.TabIndex = 11;
            btnGenerateAmort.Text = "Generate";
            btnGenerateAmort.UseVisualStyleBackColor = true;
            btnGenerateAmort.Click += btnGenerateAmort_Click;

            // dgvAmortizations
            dgvAmortizations.AllowUserToAddRows = false;
            dgvAmortizations.AllowUserToDeleteRows = false;
            dgvAmortizations.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvAmortizations.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvAmortizations.Location = new Point(8, 48);
            dgvAmortizations.Name = "dgvAmortizations";
            dgvAmortizations.RowHeadersVisible = false;
            dgvAmortizations.Size = new Size(384, 95);
            dgvAmortizations.TabIndex = 0;
            dgvAmortizations.Columns.Add("colAmortDate", "Date");
            dgvAmortizations.Columns.Add("colAmortAmount", "Amount");
            dgvAmortizations.Columns[0].ValueType = typeof(DateTime);
            dgvAmortizations.Columns[1].ValueType = typeof(double);

            // btnAddAmortization
            btnAddAmortization.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btnAddAmortization.Location = new Point(8, 150);
            btnAddAmortization.Name = "btnAddAmortization";
            btnAddAmortization.Size = new Size(80, 23);
            btnAddAmortization.TabIndex = 1;
            btnAddAmortization.Text = "Add";
            btnAddAmortization.UseVisualStyleBackColor = true;
            btnAddAmortization.Click += btnAddAmortization_Click;

            // btnRemoveAmortization
            btnRemoveAmortization.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btnRemoveAmortization.Location = new Point(94, 150);
            btnRemoveAmortization.Name = "btnRemoveAmortization";
            btnRemoveAmortization.Size = new Size(80, 23);
            btnRemoveAmortization.TabIndex = 2;
            btnRemoveAmortization.Text = "Remove";
            btnRemoveAmortization.UseVisualStyleBackColor = true;
            btnRemoveAmortization.Click += btnRemoveAmortization_Click;

            // btnClearAmortizations
            btnClearAmortizations.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btnClearAmortizations.Location = new Point(180, 150);
            btnClearAmortizations.Name = "btnClearAmortizations";
            btnClearAmortizations.Size = new Size(80, 23);
            btnClearAmortizations.TabIndex = 13;
            btnClearAmortizations.Text = "Clear";
            btnClearAmortizations.UseVisualStyleBackColor = true;
            btnClearAmortizations.Click += btnClearAmortizations_Click;

            // btnCalculate
            btnCalculate.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btnCalculate.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnCalculate.Location = new Point(12, 696);
            btnCalculate.Name = "btnCalculate";
            btnCalculate.Size = new Size(160, 32);
            btnCalculate.TabIndex = 3;
            btnCalculate.Text = "Calculate";
            btnCalculate.UseVisualStyleBackColor = true;
            btnCalculate.Click += btnCalculate_Click;

            // btnReset
            btnReset.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btnReset.Location = new Point(180, 696);
            btnReset.Name = "btnReset";
            btnReset.Size = new Size(100, 32);
            btnReset.TabIndex = 14;
            btnReset.Text = "Reset All";
            btnReset.UseVisualStyleBackColor = true;
            btnReset.Click += btnReset_Click;

            // grpResults
            grpResults.Controls.Add(lblSellByValue);
            grpResults.Controls.Add(lblSellByLabel);
            grpResults.Controls.Add(lblYtmValue);
            grpResults.Controls.Add(lblYtmLabel);
            grpResults.Dock = DockStyle.Top;
            grpResults.Location = new Point(0, 0);
            grpResults.Name = "grpResults";
            grpResults.Size = new Size(420, 80);
            grpResults.TabIndex = 0;
            grpResults.TabStop = false;
            grpResults.Text = "Results";

            // lblYtmLabel
            lblYtmLabel.Location = new Point(12, 24);
            lblYtmLabel.Name = "lblYtmLabel";
            lblYtmLabel.Size = new Size(180, 20);
            lblYtmLabel.TabIndex = 0;
            lblYtmLabel.Text = "Inflation-Adjusted YTM:";
            lblYtmLabel.TextAlign = ContentAlignment.MiddleLeft;

            // lblYtmValue
            lblYtmValue.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblYtmValue.Location = new Point(200, 24);
            lblYtmValue.Name = "lblYtmValue";
            lblYtmValue.Size = new Size(200, 20);
            lblYtmValue.TabIndex = 1;
            lblYtmValue.Text = "-";
            lblYtmValue.TextAlign = ContentAlignment.MiddleLeft;

            // lblSellByLabel
            lblSellByLabel.Location = new Point(12, 48);
            lblSellByLabel.Name = "lblSellByLabel";
            lblSellByLabel.Size = new Size(180, 20);
            lblSellByLabel.TabIndex = 2;
            lblSellByLabel.Text = "Sell-By Date:";
            lblSellByLabel.TextAlign = ContentAlignment.MiddleLeft;

            // lblSellByValue
            lblSellByValue.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblSellByValue.Location = new Point(200, 48);
            lblSellByValue.Name = "lblSellByValue";
            lblSellByValue.Size = new Size(200, 20);
            lblSellByValue.TabIndex = 3;
            lblSellByValue.Text = "-";
            lblSellByValue.TextAlign = ContentAlignment.MiddleLeft;

            // grpSchedule
            grpSchedule.Controls.Add(dgvSchedule);
            grpSchedule.Dock = DockStyle.Fill;
            grpSchedule.Location = new Point(0, 80);
            grpSchedule.Name = "grpSchedule";
            grpSchedule.Size = new Size(420, 720);
            grpSchedule.TabIndex = 1;
            grpSchedule.TabStop = false;
            grpSchedule.Text = "Coupon Schedule";

            // dgvSchedule
            dgvSchedule.AllowUserToAddRows = false;
            dgvSchedule.AllowUserToDeleteRows = false;
            dgvSchedule.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvSchedule.Dock = DockStyle.Fill;
            dgvSchedule.Location = new Point(3, 19);
            dgvSchedule.Name = "dgvSchedule";
            dgvSchedule.ReadOnly = true;
            dgvSchedule.RowHeadersVisible = false;
            dgvSchedule.Size = new Size(414, 698);
            dgvSchedule.TabIndex = 0;
            dgvSchedule.Columns.Add("colSchDate", "Date");
            dgvSchedule.Columns.Add("colSchCoupon", "Coupon");
            dgvSchedule.Columns.Add("colSchAdjusted", "Inflation-Adj.");
            dgvSchedule.Columns.Add("colSchCumulative", "Cumulative Yield");
            dgvSchedule.Columns[0].ValueType = typeof(string);
            dgvSchedule.Columns[1].ValueType = typeof(double);
            dgvSchedule.Columns[2].ValueType = typeof(double);
            dgvSchedule.Columns[3].ValueType = typeof(double);

            // splitMain
            splitMain.Dock = DockStyle.Fill;
            splitMain.Location = new Point(0, 0);
            splitMain.Name = "splitMain";
            splitMain.Panel1.Controls.Add(btnReset);
            splitMain.Panel1.Controls.Add(grpAmortizations);
            splitMain.Panel1.Controls.Add(grpCoupons);
            splitMain.Panel1.Controls.Add(grpDeal);
            splitMain.Panel1.Controls.Add(grpParameters);
            splitMain.Panel1.Controls.Add(btnCalculate);
            splitMain.Panel1MinSize = 400;
            splitMain.Size = new Size(840, 800);
            splitMain.SplitterDistance = 400;
            splitMain.SplitterWidth = 5;
            splitMain.TabIndex = 0;
            splitMain.TabStop = false;
            splitMain.Panel2.Controls.Add(grpSchedule);
            splitMain.Panel2.Controls.Add(grpResults);

            // BondCacl
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(840, 800);
            Controls.Add(splitMain);
            MinimumSize = new Size(700, 500);
            Name = "BondCacl";
            Text = "BondCalc - Inflation-Adjusted Bond Yield Calculator";

            grpParameters.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)nudInflation).EndInit();
            ((System.ComponentModel.ISupportInitialize)nudNominal).EndInit();
            grpDeal.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)nudAccrued).EndInit();
            ((System.ComponentModel.ISupportInitialize)nudPrice).EndInit();
            grpCoupons.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)nudPeriod).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvCoupons).EndInit();
            grpAmortizations.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)nudAmortParts).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvAmortizations).EndInit();
            grpResults.ResumeLayout(false);
            grpSchedule.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvSchedule).EndInit();
            splitMain.Panel1.ResumeLayout(false);
            splitMain.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitMain).EndInit();
            splitMain.ResumeLayout(false);
            ResumeLayout(false);
        }

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
    }
}
