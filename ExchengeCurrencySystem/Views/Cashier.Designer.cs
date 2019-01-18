namespace WindowsFormsApp
{
    partial class Cashier
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
            this.grpBoxConsoleView = new System.Windows.Forms.GroupBox();
            this.txtBoxConsoleView = new System.Windows.Forms.TextBox();
            this.grpBoxCurrencyExchangeView = new System.Windows.Forms.GroupBox();
            this.panelMakeAnExchangeView = new System.Windows.Forms.Panel();
            this.btnMakeAnExchangeView = new System.Windows.Forms.Button();
            this.panelToConvertView = new System.Windows.Forms.Panel();
            this.btnToConvertView = new System.Windows.Forms.Button();
            this.tblLayoutCurrencyExchangeView = new System.Windows.Forms.TableLayoutPanel();
            this.CurrencyToBuyUpdownView = new System.Windows.Forms.DomainUpDown();
            this.txtBoxCurrencyForSaleView = new System.Windows.Forms.TextBox();
            this.txtBoxCurrencyToBuyView = new System.Windows.Forms.TextBox();
            this.CurrencyForSaleUpdownView = new System.Windows.Forms.DomainUpDown();
            this.grpBoxCheckClientInfView = new System.Windows.Forms.GroupBox();
            this.btnCreateNoteView = new System.Windows.Forms.Button();
            this.btnCheckClientInfView = new System.Windows.Forms.Button();
            this.panelToCompleteView = new System.Windows.Forms.Panel();
            this.btnToCompleteView = new System.Windows.Forms.Button();
            this.btnToKnowExchangeRatesView = new System.Windows.Forms.Button();
            this.panelOptionsView = new System.Windows.Forms.Panel();
            this.btnToExitView = new System.Windows.Forms.Button();
            this.btnToKnowRestrictionsView = new System.Windows.Forms.Button();
            this.txtBoxClientNameView = new System.Windows.Forms.TextBox();
            this.txtBoxClientSurnameView = new System.Windows.Forms.TextBox();
            this.txtBoxClientPasportView = new System.Windows.Forms.TextBox();
            this.lblClientNameView = new System.Windows.Forms.Label();
            this.lblClientSurnameView = new System.Windows.Forms.Label();
            this.lblPasport = new System.Windows.Forms.Label();
            this.grpBoxClientInfView = new System.Windows.Forms.GroupBox();
            this.grpBoxConsoleView.SuspendLayout();
            this.grpBoxCurrencyExchangeView.SuspendLayout();
            this.panelMakeAnExchangeView.SuspendLayout();
            this.panelToConvertView.SuspendLayout();
            this.tblLayoutCurrencyExchangeView.SuspendLayout();
            this.grpBoxCheckClientInfView.SuspendLayout();
            this.panelToCompleteView.SuspendLayout();
            this.panelOptionsView.SuspendLayout();
            this.grpBoxClientInfView.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpBoxConsoleView
            // 
            this.grpBoxConsoleView.Controls.Add(this.txtBoxConsoleView);
            this.grpBoxConsoleView.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.grpBoxConsoleView.Location = new System.Drawing.Point(12, 257);
            this.grpBoxConsoleView.Name = "grpBoxConsoleView";
            this.grpBoxConsoleView.Size = new System.Drawing.Size(538, 214);
            this.grpBoxConsoleView.TabIndex = 1;
            this.grpBoxConsoleView.TabStop = false;
            this.grpBoxConsoleView.Enter += new System.EventHandler(this.grpBoxConsoleView_Enter);
            // 
            // txtBoxConsoleView
            // 
            this.txtBoxConsoleView.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.txtBoxConsoleView.Location = new System.Drawing.Point(6, 16);
            this.txtBoxConsoleView.Multiline = true;
            this.txtBoxConsoleView.Name = "txtBoxConsoleView";
            this.txtBoxConsoleView.ReadOnly = true;
            this.txtBoxConsoleView.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtBoxConsoleView.Size = new System.Drawing.Size(526, 192);
            this.txtBoxConsoleView.TabIndex = 0;
            this.txtBoxConsoleView.TextChanged += new System.EventHandler(this.txtBoxConsole);
            // 
            // grpBoxCurrencyExchangeView
            // 
            this.grpBoxCurrencyExchangeView.Controls.Add(this.panelMakeAnExchangeView);
            this.grpBoxCurrencyExchangeView.Controls.Add(this.panelToConvertView);
            this.grpBoxCurrencyExchangeView.Controls.Add(this.tblLayoutCurrencyExchangeView);
            this.grpBoxCurrencyExchangeView.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.grpBoxCurrencyExchangeView.Location = new System.Drawing.Point(324, 12);
            this.grpBoxCurrencyExchangeView.Name = "grpBoxCurrencyExchangeView";
            this.grpBoxCurrencyExchangeView.Size = new System.Drawing.Size(431, 239);
            this.grpBoxCurrencyExchangeView.TabIndex = 2;
            this.grpBoxCurrencyExchangeView.TabStop = false;
            this.grpBoxCurrencyExchangeView.Text = "Обмен валюты";
            this.grpBoxCurrencyExchangeView.Enter += new System.EventHandler(this.grpBoxCurrencyExchange);
            // 
            // panelMakeAnExchangeView
            // 
            this.panelMakeAnExchangeView.Controls.Add(this.btnMakeAnExchangeView);
            this.panelMakeAnExchangeView.Location = new System.Drawing.Point(6, 180);
            this.panelMakeAnExchangeView.Name = "panelMakeAnExchangeView";
            this.panelMakeAnExchangeView.Size = new System.Drawing.Size(419, 53);
            this.panelMakeAnExchangeView.TabIndex = 2;
            // 
            // btnMakeAnExchangeView
            // 
            this.btnMakeAnExchangeView.Location = new System.Drawing.Point(3, 3);
            this.btnMakeAnExchangeView.Name = "btnMakeAnExchangeView";
            this.btnMakeAnExchangeView.Size = new System.Drawing.Size(413, 47);
            this.btnMakeAnExchangeView.TabIndex = 3;
            this.btnMakeAnExchangeView.Text = "совершить обмен";
            this.btnMakeAnExchangeView.UseVisualStyleBackColor = true;
            this.btnMakeAnExchangeView.Click += new System.EventHandler(this.btnMakeAnExchange);
            // 
            // panelToConvertView
            // 
            this.panelToConvertView.Controls.Add(this.btnToConvertView);
            this.panelToConvertView.Location = new System.Drawing.Point(6, 121);
            this.panelToConvertView.Name = "panelToConvertView";
            this.panelToConvertView.Size = new System.Drawing.Size(419, 53);
            this.panelToConvertView.TabIndex = 1;
            // 
            // btnToConvertView
            // 
            this.btnToConvertView.Location = new System.Drawing.Point(3, 3);
            this.btnToConvertView.Name = "btnToConvertView";
            this.btnToConvertView.Size = new System.Drawing.Size(413, 47);
            this.btnToConvertView.TabIndex = 3;
            this.btnToConvertView.Text = "конвертировать";
            this.btnToConvertView.UseVisualStyleBackColor = true;
            this.btnToConvertView.Click += new System.EventHandler(this.btnToConvert);
            // 
            // tblLayoutCurrencyExchangeView
            // 
            this.tblLayoutCurrencyExchangeView.ColumnCount = 2;
            this.tblLayoutCurrencyExchangeView.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tblLayoutCurrencyExchangeView.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tblLayoutCurrencyExchangeView.Controls.Add(this.CurrencyToBuyUpdownView, 1, 0);
            this.tblLayoutCurrencyExchangeView.Controls.Add(this.txtBoxCurrencyForSaleView, 0, 1);
            this.tblLayoutCurrencyExchangeView.Controls.Add(this.txtBoxCurrencyToBuyView, 1, 1);
            this.tblLayoutCurrencyExchangeView.Controls.Add(this.CurrencyForSaleUpdownView, 0, 0);
            this.tblLayoutCurrencyExchangeView.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tblLayoutCurrencyExchangeView.Location = new System.Drawing.Point(6, 28);
            this.tblLayoutCurrencyExchangeView.Name = "tblLayoutCurrencyExchangeView";
            this.tblLayoutCurrencyExchangeView.RowCount = 2;
            this.tblLayoutCurrencyExchangeView.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tblLayoutCurrencyExchangeView.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tblLayoutCurrencyExchangeView.Size = new System.Drawing.Size(419, 87);
            this.tblLayoutCurrencyExchangeView.TabIndex = 0;
            this.tblLayoutCurrencyExchangeView.Paint += new System.Windows.Forms.PaintEventHandler(this.tblLayoutCurrencyExchangeView_Paint);
            // 
            // CurrencyToBuyUpdownView
            // 
            this.CurrencyToBuyUpdownView.Items.Add("BYN");
            this.CurrencyToBuyUpdownView.Items.Add("RUB");
            this.CurrencyToBuyUpdownView.Items.Add("EUR");
            this.CurrencyToBuyUpdownView.Items.Add("USD");
            this.CurrencyToBuyUpdownView.Items.Add("JPU");
            this.CurrencyToBuyUpdownView.Items.Add("GBR");
            this.CurrencyToBuyUpdownView.Items.Add("CHF");
            this.CurrencyToBuyUpdownView.Location = new System.Drawing.Point(212, 3);
            this.CurrencyToBuyUpdownView.Name = "CurrencyToBuyUpdownView";
            this.CurrencyToBuyUpdownView.Size = new System.Drawing.Size(204, 26);
            this.CurrencyToBuyUpdownView.TabIndex = 5;
            this.CurrencyToBuyUpdownView.Text = "Валюта для покупки";
            this.CurrencyToBuyUpdownView.SelectedItemChanged += new System.EventHandler(this.CurrencyToBuyUpdown);
            // 
            // txtBoxCurrencyForSaleView
            // 
            this.txtBoxCurrencyForSaleView.Location = new System.Drawing.Point(3, 46);
            this.txtBoxCurrencyForSaleView.Name = "txtBoxCurrencyForSaleView";
            this.txtBoxCurrencyForSaleView.Size = new System.Drawing.Size(203, 26);
            this.txtBoxCurrencyForSaleView.TabIndex = 2;
            this.txtBoxCurrencyForSaleView.TextChanged += new System.EventHandler(this.txtBoxCurrencyForSale);
            // 
            // txtBoxCurrencyToBuyView
            // 
            this.txtBoxCurrencyToBuyView.Location = new System.Drawing.Point(212, 46);
            this.txtBoxCurrencyToBuyView.Name = "txtBoxCurrencyToBuyView";
            this.txtBoxCurrencyToBuyView.Size = new System.Drawing.Size(204, 26);
            this.txtBoxCurrencyToBuyView.TabIndex = 3;
            this.txtBoxCurrencyToBuyView.TextChanged += new System.EventHandler(this.txtBoxCurrencyToBuy);
            // 
            // CurrencyForSaleUpdownView
            // 
            this.CurrencyForSaleUpdownView.Items.Add("BYN");
            this.CurrencyForSaleUpdownView.Items.Add("RUB");
            this.CurrencyForSaleUpdownView.Items.Add("EUR");
            this.CurrencyForSaleUpdownView.Items.Add("USD");
            this.CurrencyForSaleUpdownView.Items.Add("JPU");
            this.CurrencyForSaleUpdownView.Items.Add("GBR");
            this.CurrencyForSaleUpdownView.Items.Add("CHF");
            this.CurrencyForSaleUpdownView.Location = new System.Drawing.Point(3, 3);
            this.CurrencyForSaleUpdownView.Name = "CurrencyForSaleUpdownView";
            this.CurrencyForSaleUpdownView.Size = new System.Drawing.Size(203, 26);
            this.CurrencyForSaleUpdownView.TabIndex = 4;
            this.CurrencyForSaleUpdownView.Text = "Валюта для продажи";
            this.CurrencyForSaleUpdownView.SelectedItemChanged += new System.EventHandler(this.CurrencyForSaleUpdown);
            // 
            // grpBoxCheckClientInfView
            // 
            this.grpBoxCheckClientInfView.Controls.Add(this.btnCreateNoteView);
            this.grpBoxCheckClientInfView.Controls.Add(this.btnCheckClientInfView);
            this.grpBoxCheckClientInfView.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.grpBoxCheckClientInfView.Location = new System.Drawing.Point(12, 198);
            this.grpBoxCheckClientInfView.Name = "grpBoxCheckClientInfView";
            this.grpBoxCheckClientInfView.Size = new System.Drawing.Size(306, 53);
            this.grpBoxCheckClientInfView.TabIndex = 3;
            this.grpBoxCheckClientInfView.TabStop = false;
            this.grpBoxCheckClientInfView.Enter += new System.EventHandler(this.grpBoxCheckClientInfView_Enter);
            // 
            // btnCreateNoteView
            // 
            this.btnCreateNoteView.Location = new System.Drawing.Point(157, 14);
            this.btnCreateNoteView.Name = "btnCreateNoteView";
            this.btnCreateNoteView.Size = new System.Drawing.Size(143, 33);
            this.btnCreateNoteView.TabIndex = 4;
            this.btnCreateNoteView.Text = "создать";
            this.btnCreateNoteView.UseVisualStyleBackColor = true;
            this.btnCreateNoteView.Click += new System.EventHandler(this.btnCreateNote);
            // 
            // btnCheckClientInfView
            // 
            this.btnCheckClientInfView.Location = new System.Drawing.Point(6, 14);
            this.btnCheckClientInfView.Name = "btnCheckClientInfView";
            this.btnCheckClientInfView.Size = new System.Drawing.Size(145, 33);
            this.btnCheckClientInfView.TabIndex = 4;
            this.btnCheckClientInfView.Text = "проверить";
            this.btnCheckClientInfView.UseVisualStyleBackColor = true;
            this.btnCheckClientInfView.Click += new System.EventHandler(this.btnCheckClientInf);
            // 
            // panelToCompleteView
            // 
            this.panelToCompleteView.Controls.Add(this.btnToCompleteView);
            this.panelToCompleteView.Location = new System.Drawing.Point(556, 385);
            this.panelToCompleteView.Name = "panelToCompleteView";
            this.panelToCompleteView.Size = new System.Drawing.Size(186, 86);
            this.panelToCompleteView.TabIndex = 4;
            // 
            // btnToCompleteView
            // 
            this.btnToCompleteView.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnToCompleteView.Location = new System.Drawing.Point(3, 3);
            this.btnToCompleteView.Name = "btnToCompleteView";
            this.btnToCompleteView.Size = new System.Drawing.Size(177, 77);
            this.btnToCompleteView.TabIndex = 0;
            this.btnToCompleteView.Text = "завершить операцию";
            this.btnToCompleteView.UseVisualStyleBackColor = true;
            this.btnToCompleteView.Click += new System.EventHandler(this.btnToComplete);
            // 
            // btnToKnowExchangeRatesView
            // 
            this.btnToKnowExchangeRatesView.Location = new System.Drawing.Point(3, 39);
            this.btnToKnowExchangeRatesView.Name = "btnToKnowExchangeRatesView";
            this.btnToKnowExchangeRatesView.Size = new System.Drawing.Size(177, 29);
            this.btnToKnowExchangeRatesView.TabIndex = 0;
            this.btnToKnowExchangeRatesView.Text = "узнать курс";
            this.btnToKnowExchangeRatesView.UseVisualStyleBackColor = true;
            this.btnToKnowExchangeRatesView.Click += new System.EventHandler(this.btnToKnowExchangeRates);
            // 
            // panelOptionsView
            // 
            this.panelOptionsView.Controls.Add(this.btnToExitView);
            this.panelOptionsView.Controls.Add(this.btnToKnowExchangeRatesView);
            this.panelOptionsView.Controls.Add(this.btnToKnowRestrictionsView);
            this.panelOptionsView.Location = new System.Drawing.Point(556, 273);
            this.panelOptionsView.Name = "panelOptionsView";
            this.panelOptionsView.Size = new System.Drawing.Size(186, 106);
            this.panelOptionsView.TabIndex = 6;
            this.panelOptionsView.Paint += new System.Windows.Forms.PaintEventHandler(this.panelOptions_Paint);
            // 
            // btnToExitView
            // 
            this.btnToExitView.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnToExitView.Location = new System.Drawing.Point(3, 74);
            this.btnToExitView.Name = "btnToExitView";
            this.btnToExitView.Size = new System.Drawing.Size(176, 28);
            this.btnToExitView.TabIndex = 0;
            this.btnToExitView.Text = "выйти";
            this.btnToExitView.UseVisualStyleBackColor = true;
            this.btnToExitView.Click += new System.EventHandler(this.btnToExit);
            // 
            // btnToKnowRestrictionsView
            // 
            this.btnToKnowRestrictionsView.Location = new System.Drawing.Point(3, 3);
            this.btnToKnowRestrictionsView.Name = "btnToKnowRestrictionsView";
            this.btnToKnowRestrictionsView.Size = new System.Drawing.Size(177, 30);
            this.btnToKnowRestrictionsView.TabIndex = 0;
            this.btnToKnowRestrictionsView.Text = "посмотреть ограничения";
            this.btnToKnowRestrictionsView.UseVisualStyleBackColor = true;
            this.btnToKnowRestrictionsView.Click += new System.EventHandler(this.btnToKnowRestrictions);
            // 
            // txtBoxClientNameView
            // 
            this.txtBoxClientNameView.Location = new System.Drawing.Point(109, 54);
            this.txtBoxClientNameView.Name = "txtBoxClientNameView";
            this.txtBoxClientNameView.Size = new System.Drawing.Size(191, 29);
            this.txtBoxClientNameView.TabIndex = 0;
            this.txtBoxClientNameView.TextChanged += new System.EventHandler(this.txtBoxClientName);
            // 
            // txtBoxClientSurnameView
            // 
            this.txtBoxClientSurnameView.Location = new System.Drawing.Point(109, 95);
            this.txtBoxClientSurnameView.Name = "txtBoxClientSurnameView";
            this.txtBoxClientSurnameView.Size = new System.Drawing.Size(191, 29);
            this.txtBoxClientSurnameView.TabIndex = 1;
            this.txtBoxClientSurnameView.TextChanged += new System.EventHandler(this.txtBoxClientSurname);
            // 
            // txtBoxClientPasportView
            // 
            this.txtBoxClientPasportView.Location = new System.Drawing.Point(109, 132);
            this.txtBoxClientPasportView.Name = "txtBoxClientPasportView";
            this.txtBoxClientPasportView.Size = new System.Drawing.Size(191, 29);
            this.txtBoxClientPasportView.TabIndex = 2;
            this.txtBoxClientPasportView.TextChanged += new System.EventHandler(this.txtBoxClientPasport);
            // 
            // lblClientNameView
            // 
            this.lblClientNameView.AutoSize = true;
            this.lblClientNameView.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblClientNameView.Location = new System.Drawing.Point(63, 54);
            this.lblClientNameView.Name = "lblClientNameView";
            this.lblClientNameView.Size = new System.Drawing.Size(40, 20);
            this.lblClientNameView.TabIndex = 3;
            this.lblClientNameView.Text = "Имя";
            this.lblClientNameView.Click += new System.EventHandler(this.lblClientNameView_Click);
            // 
            // lblClientSurnameView
            // 
            this.lblClientSurnameView.AutoSize = true;
            this.lblClientSurnameView.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblClientSurnameView.Location = new System.Drawing.Point(23, 95);
            this.lblClientSurnameView.Name = "lblClientSurnameView";
            this.lblClientSurnameView.Size = new System.Drawing.Size(81, 20);
            this.lblClientSurnameView.TabIndex = 4;
            this.lblClientSurnameView.Text = "Фамилия";
            this.lblClientSurnameView.Click += new System.EventHandler(this.lblClientSurnameView_Click);
            // 
            // lblPasport
            // 
            this.lblPasport.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblPasport.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblPasport.Location = new System.Drawing.Point(23, 132);
            this.lblPasport.Name = "lblPasport";
            this.lblPasport.Size = new System.Drawing.Size(86, 45);
            this.lblPasport.TabIndex = 5;
            this.lblPasport.Text = "Номер паспорта";
            this.lblPasport.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // grpBoxClientInfView
            // 
            this.grpBoxClientInfView.Controls.Add(this.lblPasport);
            this.grpBoxClientInfView.Controls.Add(this.lblClientSurnameView);
            this.grpBoxClientInfView.Controls.Add(this.lblClientNameView);
            this.grpBoxClientInfView.Controls.Add(this.txtBoxClientPasportView);
            this.grpBoxClientInfView.Controls.Add(this.txtBoxClientSurnameView);
            this.grpBoxClientInfView.Controls.Add(this.txtBoxClientNameView);
            this.grpBoxClientInfView.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.grpBoxClientInfView.Location = new System.Drawing.Point(12, 12);
            this.grpBoxClientInfView.Name = "grpBoxClientInfView";
            this.grpBoxClientInfView.Size = new System.Drawing.Size(306, 180);
            this.grpBoxClientInfView.TabIndex = 0;
            this.grpBoxClientInfView.TabStop = false;
            this.grpBoxClientInfView.Text = "Информация о клиенте";
            this.grpBoxClientInfView.Enter += new System.EventHandler(this.grpBoxClientInf);
            // 
            // Cashier
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.ClientSize = new System.Drawing.Size(767, 483);
            this.Controls.Add(this.panelOptionsView);
            this.Controls.Add(this.panelToCompleteView);
            this.Controls.Add(this.grpBoxCheckClientInfView);
            this.Controls.Add(this.grpBoxCurrencyExchangeView);
            this.Controls.Add(this.grpBoxConsoleView);
            this.Controls.Add(this.grpBoxClientInfView);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "Cashier";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cashier";
            this.Load += new System.EventHandler(this.Cashier_Load);
            this.grpBoxConsoleView.ResumeLayout(false);
            this.grpBoxConsoleView.PerformLayout();
            this.grpBoxCurrencyExchangeView.ResumeLayout(false);
            this.panelMakeAnExchangeView.ResumeLayout(false);
            this.panelToConvertView.ResumeLayout(false);
            this.tblLayoutCurrencyExchangeView.ResumeLayout(false);
            this.tblLayoutCurrencyExchangeView.PerformLayout();
            this.grpBoxCheckClientInfView.ResumeLayout(false);
            this.panelToCompleteView.ResumeLayout(false);
            this.panelOptionsView.ResumeLayout(false);
            this.grpBoxClientInfView.ResumeLayout(false);
            this.grpBoxClientInfView.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox grpBoxConsoleView;
        private System.Windows.Forms.GroupBox grpBoxCurrencyExchangeView;
        private System.Windows.Forms.Button btnToConvertView;
        private System.Windows.Forms.TableLayoutPanel tblLayoutCurrencyExchangeView;
        private System.Windows.Forms.TextBox txtBoxCurrencyForSaleView;
        private System.Windows.Forms.TextBox txtBoxCurrencyToBuyView;
        private System.Windows.Forms.Panel panelToConvertView;
        private System.Windows.Forms.TextBox txtBoxConsoleView;
        private System.Windows.Forms.GroupBox grpBoxCheckClientInfView;
        private System.Windows.Forms.Button btnCheckClientInfView;
        private System.Windows.Forms.Panel panelToCompleteView;
        private System.Windows.Forms.Button btnToCompleteView;
        private System.Windows.Forms.Button btnToKnowExchangeRatesView;
        private System.Windows.Forms.Panel panelOptionsView;
        private System.Windows.Forms.Button btnToKnowRestrictionsView;
        private System.Windows.Forms.Panel panelMakeAnExchangeView;
        private System.Windows.Forms.Button btnMakeAnExchangeView;
        private System.Windows.Forms.DomainUpDown CurrencyForSaleUpdownView;
        private System.Windows.Forms.DomainUpDown CurrencyToBuyUpdownView;
        private System.Windows.Forms.TextBox txtBoxClientNameView;
        private System.Windows.Forms.TextBox txtBoxClientSurnameView;
        private System.Windows.Forms.TextBox txtBoxClientPasportView;
        private System.Windows.Forms.Label lblClientNameView;
        private System.Windows.Forms.Label lblClientSurnameView;
        private System.Windows.Forms.Label lblPasport;
        private System.Windows.Forms.GroupBox grpBoxClientInfView;
        private System.Windows.Forms.Button btnToExitView;
        private System.Windows.Forms.Button btnCreateNoteView;
    }
}