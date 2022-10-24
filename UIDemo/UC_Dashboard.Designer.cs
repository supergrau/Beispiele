namespace UIDemo
{
    partial class UC_Dashboard
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
            this.ButtonCategory = new System.Windows.Forms.Button();
            this.ButtonProduct = new System.Windows.Forms.Button();
            this.ButtonOrders = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ButtonCategory
            // 
            this.ButtonCategory.BackColor = System.Drawing.Color.Cyan;
            this.ButtonCategory.Location = new System.Drawing.Point(62, 46);
            this.ButtonCategory.Name = "ButtonCategory";
            this.ButtonCategory.Size = new System.Drawing.Size(99, 41);
            this.ButtonCategory.TabIndex = 0;
            this.ButtonCategory.Text = "Kategorie";
            this.ButtonCategory.UseVisualStyleBackColor = false;
            this.ButtonCategory.Click += new System.EventHandler(this.ButtonCategory_Click);
            // 
            // ButtonProduct
            // 
            this.ButtonProduct.BackColor = System.Drawing.Color.Cyan;
            this.ButtonProduct.Location = new System.Drawing.Point(62, 118);
            this.ButtonProduct.Name = "ButtonProduct";
            this.ButtonProduct.Size = new System.Drawing.Size(99, 41);
            this.ButtonProduct.TabIndex = 1;
            this.ButtonProduct.Text = "Produkt";
            this.ButtonProduct.UseVisualStyleBackColor = false;
            this.ButtonProduct.Click += new System.EventHandler(this.ButtonProduct_Click);
            // 
            // ButtonOrders
            // 
            this.ButtonOrders.BackColor = System.Drawing.Color.Cyan;
            this.ButtonOrders.Location = new System.Drawing.Point(62, 190);
            this.ButtonOrders.Name = "ButtonOrders";
            this.ButtonOrders.Size = new System.Drawing.Size(99, 41);
            this.ButtonOrders.TabIndex = 2;
            this.ButtonOrders.Text = "Bestellungen";
            this.ButtonOrders.UseVisualStyleBackColor = false;
            this.ButtonOrders.Click += new System.EventHandler(this.ButtonOrders_Click);
            // 
            // button1
            // 
            this.button1.Image = global::UIDemo.Properties.Resources.folder_document_multimedia_icon;
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button1.Location = new System.Drawing.Point(467, 135);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(86, 50);
            this.button1.TabIndex = 3;
            this.button1.Text = "button1";
            this.button1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.UseVisualStyleBackColor = true;
            // 
            // UC_Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.button1);
            this.Controls.Add(this.ButtonOrders);
            this.Controls.Add(this.ButtonProduct);
            this.Controls.Add(this.ButtonCategory);
            this.Name = "UC_Dashboard";
            this.Size = new System.Drawing.Size(593, 400);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button ButtonCategory;
        private System.Windows.Forms.Button ButtonProduct;
        private System.Windows.Forms.Button ButtonOrders;
        private System.Windows.Forms.Button button1;
    }
}
