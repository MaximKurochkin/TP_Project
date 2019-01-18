namespace WindowsFormsApp
{
    partial class Login
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
            this.btnEnterView = new System.Windows.Forms.Button();
            this.grpBoxRolesView = new System.Windows.Forms.GroupBox();
            this.rbtnCashierView = new System.Windows.Forms.RadioButton();
            this.rbtnAdminView = new System.Windows.Forms.RadioButton();
            this.grpBoxCashiersView = new System.Windows.Forms.GroupBox();
            this.grpBoxRolesView.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnEnterView
            // 
            this.btnEnterView.Location = new System.Drawing.Point(248, 208);
            this.btnEnterView.Name = "btnEnterView";
            this.btnEnterView.Size = new System.Drawing.Size(254, 68);
            this.btnEnterView.TabIndex = 1;
            this.btnEnterView.Text = "Войти";
            this.btnEnterView.UseVisualStyleBackColor = true;
            this.btnEnterView.Click += new System.EventHandler(this.btnEnter);
            // 
            // grpBoxRolesView
            // 
            this.grpBoxRolesView.Controls.Add(this.rbtnCashierView);
            this.grpBoxRolesView.Controls.Add(this.rbtnAdminView);
            this.grpBoxRolesView.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.grpBoxRolesView.Location = new System.Drawing.Point(12, 12);
            this.grpBoxRolesView.Name = "grpBoxRolesView";
            this.grpBoxRolesView.Size = new System.Drawing.Size(223, 264);
            this.grpBoxRolesView.TabIndex = 2;
            this.grpBoxRolesView.TabStop = false;
            this.grpBoxRolesView.Enter += new System.EventHandler(this.grpBoxRoles);
            // 
            // rbtnCashierView
            // 
            this.rbtnCashierView.AutoSize = true;
            this.rbtnCashierView.Location = new System.Drawing.Point(7, 67);
            this.rbtnCashierView.Name = "rbtnCashierView";
            this.rbtnCashierView.Size = new System.Drawing.Size(92, 28);
            this.rbtnCashierView.TabIndex = 1;
            this.rbtnCashierView.TabStop = true;
            this.rbtnCashierView.Text = "Кассир";
            this.rbtnCashierView.UseVisualStyleBackColor = true;
            this.rbtnCashierView.CheckedChanged += new System.EventHandler(this.rbtnCashier);
            // 
            // rbtnAdminView
            // 
            this.rbtnAdminView.AutoSize = true;
            this.rbtnAdminView.Location = new System.Drawing.Point(7, 31);
            this.rbtnAdminView.Name = "rbtnAdminView";
            this.rbtnAdminView.Size = new System.Drawing.Size(172, 28);
            this.rbtnAdminView.TabIndex = 0;
            this.rbtnAdminView.TabStop = true;
            this.rbtnAdminView.Text = "Администратор";
            this.rbtnAdminView.UseVisualStyleBackColor = true;
            this.rbtnAdminView.CheckedChanged += new System.EventHandler(this.rbtnAdmin);
            // 
            // grpBoxCashiersView
            // 
            this.grpBoxCashiersView.Location = new System.Drawing.Point(241, 12);
            this.grpBoxCashiersView.Name = "grpBoxCashiersView";
            this.grpBoxCashiersView.Size = new System.Drawing.Size(261, 190);
            this.grpBoxCashiersView.TabIndex = 3;
            this.grpBoxCashiersView.TabStop = false;
            this.grpBoxCashiersView.Text = "Кассиры";
            this.grpBoxCashiersView.Enter += new System.EventHandler(this.grpBoxCashiers);
            // 
            // Login
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.SystemColors.Menu;
            this.ClientSize = new System.Drawing.Size(513, 285);
            this.Controls.Add(this.grpBoxCashiersView);
            this.Controls.Add(this.grpBoxRolesView);
            this.Controls.Add(this.btnEnterView);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ECS";
            this.Load += new System.EventHandler(this.Login_Load);
            this.grpBoxRolesView.ResumeLayout(false);
            this.grpBoxRolesView.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnEnterView;
        private System.Windows.Forms.GroupBox grpBoxRolesView;
        private System.Windows.Forms.RadioButton rbtnCashierView;
        private System.Windows.Forms.RadioButton rbtnAdminView;
        private System.Windows.Forms.GroupBox grpBoxCashiersView;
    }
}

