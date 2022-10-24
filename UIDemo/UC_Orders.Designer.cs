namespace UIDemo
{
    partial class UC_Orders
    {
        /// <summary> 
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Komponenten-Designer generierter Code

        /// <summary> 
        /// Erforderliche Methode für die Designerunterstützung. 
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.LabelOrders = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // LabelOrders
            // 
            this.LabelOrders.AutoSize = true;
            this.LabelOrders.Location = new System.Drawing.Point(297, 214);
            this.LabelOrders.Name = "LabelOrders";
            this.LabelOrders.Size = new System.Drawing.Size(68, 13);
            this.LabelOrders.TabIndex = 0;
            this.LabelOrders.Text = "Bestellungen";
            // 
            // UC_Orders
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.LabelOrders);
            this.Name = "UC_Orders";
            this.Size = new System.Drawing.Size(651, 464);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LabelOrders;
    }
}
