namespace UIDemo
{
    partial class UC_Product
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
            this.LabelProduct = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // LabelProduct
            // 
            this.LabelProduct.AutoSize = true;
            this.LabelProduct.Location = new System.Drawing.Point(246, 211);
            this.LabelProduct.Name = "LabelProduct";
            this.LabelProduct.Size = new System.Drawing.Size(44, 13);
            this.LabelProduct.TabIndex = 1;
            this.LabelProduct.Text = "Produkt";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(195, 157);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(160, 20);
            this.textBox1.TabIndex = 2;
            // 
            // UC_Product
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.LabelProduct);
            this.Name = "UC_Product";
            this.Size = new System.Drawing.Size(545, 435);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LabelProduct;
        private System.Windows.Forms.TextBox textBox1;
    }
}
