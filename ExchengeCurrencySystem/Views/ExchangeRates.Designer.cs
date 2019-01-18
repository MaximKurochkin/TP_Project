namespace WindowsFormsApp
{
    partial class ExchangeRates
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.grpBoxRatesView = new System.Windows.Forms.GroupBox();
            this.rbtPurchView = new System.Windows.Forms.RadioButton();
            this.rbtnSaleView = new System.Windows.Forms.RadioButton();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.lblGBR = new System.Windows.Forms.Label();
            this.lblJPU = new System.Windows.Forms.Label();
            this.lblCHF = new System.Windows.Forms.Label();
            this.txtBoxCHFView = new System.Windows.Forms.TextBox();
            this.txtBoxGBRView = new System.Windows.Forms.TextBox();
            this.txtBoxJPUView = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.txtBoxUSDView = new System.Windows.Forms.TextBox();
            this.txtBoxEURView = new System.Windows.Forms.TextBox();
            this.txtBoxRUBView = new System.Windows.Forms.TextBox();
            this.lblRUB = new System.Windows.Forms.Label();
            this.lblBYN = new System.Windows.Forms.Label();
            this.lblEUR = new System.Windows.Forms.Label();
            this.lblUSD = new System.Windows.Forms.Label();
            this.txtBoxBYNView = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.CurrecnyUpDownView = new System.Windows.Forms.DomainUpDown();
            this.btnToShowRatesView = new System.Windows.Forms.Button();
            this.grpBoxRatesView.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpBoxRatesView
            // 
            this.grpBoxRatesView.Controls.Add(this.btnToShowRatesView);
            this.grpBoxRatesView.Controls.Add(this.rbtPurchView);
            this.grpBoxRatesView.Controls.Add(this.rbtnSaleView);
            this.grpBoxRatesView.Controls.Add(this.tableLayoutPanel2);
            this.grpBoxRatesView.Controls.Add(this.tableLayoutPanel1);
            this.grpBoxRatesView.Controls.Add(this.label1);
            this.grpBoxRatesView.Controls.Add(this.CurrecnyUpDownView);
            this.grpBoxRatesView.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.grpBoxRatesView.Location = new System.Drawing.Point(12, 12);
            this.grpBoxRatesView.Name = "grpBoxRatesView";
            this.grpBoxRatesView.Size = new System.Drawing.Size(369, 258);
            this.grpBoxRatesView.TabIndex = 0;
            this.grpBoxRatesView.TabStop = false;
            this.grpBoxRatesView.Text = "Курс валют";
            this.grpBoxRatesView.Enter += new System.EventHandler(this.grpBoxRatesView_Enter);
            // 
            // rbtPurchView
            // 
            this.rbtPurchView.AutoSize = true;
            this.rbtPurchView.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.rbtPurchView.Location = new System.Drawing.Point(216, 20);
            this.rbtPurchView.Name = "rbtPurchView";
            this.rbtPurchView.Size = new System.Drawing.Size(86, 24);
            this.rbtPurchView.TabIndex = 10;
            this.rbtPurchView.TabStop = true;
            this.rbtPurchView.Text = "покупка";
            this.rbtPurchView.UseVisualStyleBackColor = true;
            this.rbtPurchView.CheckedChanged += new System.EventHandler(this.rbtPurch);
            // 
            // rbtnSaleView
            // 
            this.rbtnSaleView.AutoSize = true;
            this.rbtnSaleView.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.rbtnSaleView.Location = new System.Drawing.Point(216, 50);
            this.rbtnSaleView.Name = "rbtnSaleView";
            this.rbtnSaleView.Size = new System.Drawing.Size(94, 24);
            this.rbtnSaleView.TabIndex = 9;
            this.rbtnSaleView.TabStop = true;
            this.rbtnSaleView.Text = "продажа";
            this.rbtnSaleView.UseVisualStyleBackColor = true;
            this.rbtnSaleView.CheckedChanged += new System.EventHandler(this.rbtnSale);
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.14286F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 66.85714F));
            this.tableLayoutPanel2.Controls.Add(this.lblGBR, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.lblJPU, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.lblCHF, 0, 2);
            this.tableLayoutPanel2.Controls.Add(this.txtBoxCHFView, 1, 2);
            this.tableLayoutPanel2.Controls.Add(this.txtBoxGBRView, 1, 1);
            this.tableLayoutPanel2.Controls.Add(this.txtBoxJPUView, 1, 0);
            this.tableLayoutPanel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tableLayoutPanel2.Location = new System.Drawing.Point(187, 77);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 3;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(175, 131);
            this.tableLayoutPanel2.TabIndex = 8;
            // 
            // lblGBR
            // 
            this.lblGBR.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblGBR.AutoSize = true;
            this.lblGBR.Location = new System.Drawing.Point(6, 52);
            this.lblGBR.Name = "lblGBR";
            this.lblGBR.Size = new System.Drawing.Size(49, 24);
            this.lblGBR.TabIndex = 12;
            this.lblGBR.Text = "GBR";
            // 
            // lblJPU
            // 
            this.lblJPU.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblJPU.AutoSize = true;
            this.lblJPU.Location = new System.Drawing.Point(11, 9);
            this.lblJPU.Name = "lblJPU";
            this.lblJPU.Size = new System.Drawing.Size(44, 24);
            this.lblJPU.TabIndex = 11;
            this.lblJPU.Text = "JPU";
            // 
            // lblCHF
            // 
            this.lblCHF.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblCHF.AutoSize = true;
            this.lblCHF.Location = new System.Drawing.Point(6, 96);
            this.lblCHF.Name = "lblCHF";
            this.lblCHF.Size = new System.Drawing.Size(49, 24);
            this.lblCHF.TabIndex = 13;
            this.lblCHF.Text = "CHF";
            // 
            // txtBoxCHFView
            // 
            this.txtBoxCHFView.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txtBoxCHFView.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.txtBoxCHFView.Location = new System.Drawing.Point(61, 94);
            this.txtBoxCHFView.Name = "txtBoxCHFView";
            this.txtBoxCHFView.ReadOnly = true;
            this.txtBoxCHFView.Size = new System.Drawing.Size(111, 29);
            this.txtBoxCHFView.TabIndex = 20;
            // 
            // txtBoxGBRView
            // 
            this.txtBoxGBRView.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txtBoxGBRView.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.txtBoxGBRView.Location = new System.Drawing.Point(61, 50);
            this.txtBoxGBRView.Name = "txtBoxGBRView";
            this.txtBoxGBRView.ReadOnly = true;
            this.txtBoxGBRView.Size = new System.Drawing.Size(111, 29);
            this.txtBoxGBRView.TabIndex = 19;
            // 
            // txtBoxJPUView
            // 
            this.txtBoxJPUView.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txtBoxJPUView.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.txtBoxJPUView.Location = new System.Drawing.Point(61, 7);
            this.txtBoxJPUView.Name = "txtBoxJPUView";
            this.txtBoxJPUView.ReadOnly = true;
            this.txtBoxJPUView.Size = new System.Drawing.Size(111, 29);
            this.txtBoxJPUView.TabIndex = 18;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 32F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 68F));
            this.tableLayoutPanel1.Controls.Add(this.txtBoxUSDView, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.txtBoxEURView, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.txtBoxRUBView, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.lblRUB, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.lblBYN, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.lblEUR, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.lblUSD, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.txtBoxBYNView, 1, 0);
            this.tableLayoutPanel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tableLayoutPanel1.Location = new System.Drawing.Point(6, 77);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 4;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(175, 174);
            this.tableLayoutPanel1.TabIndex = 7;
            // 
            // txtBoxUSDView
            // 
            this.txtBoxUSDView.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txtBoxUSDView.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.txtBoxUSDView.Location = new System.Drawing.Point(59, 137);
            this.txtBoxUSDView.Name = "txtBoxUSDView";
            this.txtBoxUSDView.ReadOnly = true;
            this.txtBoxUSDView.Size = new System.Drawing.Size(112, 29);
            this.txtBoxUSDView.TabIndex = 17;
            // 
            // txtBoxEURView
            // 
            this.txtBoxEURView.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txtBoxEURView.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.txtBoxEURView.Location = new System.Drawing.Point(59, 93);
            this.txtBoxEURView.Name = "txtBoxEURView";
            this.txtBoxEURView.ReadOnly = true;
            this.txtBoxEURView.Size = new System.Drawing.Size(112, 29);
            this.txtBoxEURView.TabIndex = 16;
            // 
            // txtBoxRUBView
            // 
            this.txtBoxRUBView.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txtBoxRUBView.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.txtBoxRUBView.Location = new System.Drawing.Point(59, 50);
            this.txtBoxRUBView.Name = "txtBoxRUBView";
            this.txtBoxRUBView.ReadOnly = true;
            this.txtBoxRUBView.Size = new System.Drawing.Size(112, 29);
            this.txtBoxRUBView.TabIndex = 15;
            // 
            // lblRUB
            // 
            this.lblRUB.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblRUB.AutoSize = true;
            this.lblRUB.Location = new System.Drawing.Point(5, 52);
            this.lblRUB.Name = "lblRUB";
            this.lblRUB.Size = new System.Drawing.Size(48, 24);
            this.lblRUB.TabIndex = 8;
            this.lblRUB.Text = "RUB";
            // 
            // lblBYN
            // 
            this.lblBYN.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblBYN.AutoSize = true;
            this.lblBYN.Location = new System.Drawing.Point(5, 9);
            this.lblBYN.Name = "lblBYN";
            this.lblBYN.Size = new System.Drawing.Size(48, 24);
            this.lblBYN.TabIndex = 0;
            this.lblBYN.Text = "BYN";
            // 
            // lblEUR
            // 
            this.lblEUR.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblEUR.AutoSize = true;
            this.lblEUR.Location = new System.Drawing.Point(4, 95);
            this.lblEUR.Name = "lblEUR";
            this.lblEUR.Size = new System.Drawing.Size(49, 24);
            this.lblEUR.TabIndex = 9;
            this.lblEUR.Text = "EUR";
            // 
            // lblUSD
            // 
            this.lblUSD.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblUSD.AutoSize = true;
            this.lblUSD.Location = new System.Drawing.Point(5, 139);
            this.lblUSD.Name = "lblUSD";
            this.lblUSD.Size = new System.Drawing.Size(48, 24);
            this.lblUSD.TabIndex = 10;
            this.lblUSD.Text = "USD";
            // 
            // txtBoxBYNView
            // 
            this.txtBoxBYNView.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txtBoxBYNView.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.txtBoxBYNView.Location = new System.Drawing.Point(59, 7);
            this.txtBoxBYNView.Name = "txtBoxBYNView";
            this.txtBoxBYNView.ReadOnly = true;
            this.txtBoxBYNView.Size = new System.Drawing.Size(112, 29);
            this.txtBoxBYNView.TabIndex = 14;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(6, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 41);
            this.label1.TabIndex = 6;
            this.label1.Text = "выберите      валюту";
            // 
            // CurrecnyUpDownView
            // 
            this.CurrecnyUpDownView.Items.Add("BYN");
            this.CurrecnyUpDownView.Items.Add("RUB");
            this.CurrecnyUpDownView.Items.Add("EUR");
            this.CurrecnyUpDownView.Items.Add("USD");
            this.CurrecnyUpDownView.Items.Add("JPU");
            this.CurrecnyUpDownView.Items.Add("GBR");
            this.CurrecnyUpDownView.Items.Add("CHF");
            this.CurrecnyUpDownView.Location = new System.Drawing.Point(97, 40);
            this.CurrecnyUpDownView.Name = "CurrecnyUpDownView";
            this.CurrecnyUpDownView.Size = new System.Drawing.Size(113, 31);
            this.CurrecnyUpDownView.TabIndex = 5;
            this.CurrecnyUpDownView.SelectedItemChanged += new System.EventHandler(this.CurrecnyUpDown);
            // 
            // btnToShowRatesView
            // 
            this.btnToShowRatesView.Location = new System.Drawing.Point(187, 214);
            this.btnToShowRatesView.Name = "btnToShowRatesView";
            this.btnToShowRatesView.Size = new System.Drawing.Size(175, 38);
            this.btnToShowRatesView.TabIndex = 11;
            this.btnToShowRatesView.Text = "показать";
            this.btnToShowRatesView.UseVisualStyleBackColor = true;
            this.btnToShowRatesView.Click += new System.EventHandler(this.btnToShowRates);
            // 
            // ExchangeRates
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 271);
            this.Controls.Add(this.grpBoxRatesView);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "ExchangeRates";
            this.Text = "ExchangeRates";
            this.grpBoxRatesView.ResumeLayout(false);
            this.grpBoxRatesView.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpBoxRatesView;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TextBox txtBoxCHFView;
        private System.Windows.Forms.TextBox txtBoxGBRView;
        private System.Windows.Forms.TextBox txtBoxJPUView;
        private System.Windows.Forms.TextBox txtBoxUSDView;
        private System.Windows.Forms.TextBox txtBoxEURView;
        private System.Windows.Forms.TextBox txtBoxRUBView;
        private System.Windows.Forms.Label lblRUB;
        private System.Windows.Forms.Label lblBYN;
        private System.Windows.Forms.Label lblEUR;
        private System.Windows.Forms.Label lblUSD;
        private System.Windows.Forms.Label lblJPU;
        private System.Windows.Forms.Label lblGBR;
        private System.Windows.Forms.Label lblCHF;
        private System.Windows.Forms.TextBox txtBoxBYNView;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DomainUpDown CurrecnyUpDownView;
        private System.Windows.Forms.RadioButton rbtPurchView;
        private System.Windows.Forms.RadioButton rbtnSaleView;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Button btnToShowRatesView;
    }
}