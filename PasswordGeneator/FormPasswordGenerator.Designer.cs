namespace PasswordGeneator
{
    partial class FormPasswordGenerator
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

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.LabelPasswordLength = new System.Windows.Forms.Label();
            this.NumericUpDownPasswordLength = new System.Windows.Forms.NumericUpDown();
            this.ButtonPasswordGenerate = new System.Windows.Forms.Button();
            this.ButtonClose = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.NumericUpDownPasswordLength)).BeginInit();
            this.SuspendLayout();
            // 
            // LabelPasswordLength
            // 
            this.LabelPasswordLength.AutoSize = true;
            this.LabelPasswordLength.Location = new System.Drawing.Point(12, 9);
            this.LabelPasswordLength.Name = "LabelPasswordLength";
            this.LabelPasswordLength.Size = new System.Drawing.Size(76, 13);
            this.LabelPasswordLength.TabIndex = 0;
            this.LabelPasswordLength.Text = "Passwortlänge";
            // 
            // NumericUpDownPasswordLength
            // 
            this.NumericUpDownPasswordLength.Location = new System.Drawing.Point(99, 5);
            this.NumericUpDownPasswordLength.Minimum = new decimal(new int[] {
            8,
            0,
            0,
            0});
            this.NumericUpDownPasswordLength.Name = "NumericUpDownPasswordLength";
            this.NumericUpDownPasswordLength.Size = new System.Drawing.Size(120, 20);
            this.NumericUpDownPasswordLength.TabIndex = 1;
            this.NumericUpDownPasswordLength.Value = new decimal(new int[] {
            8,
            0,
            0,
            0});
            // 
            // ButtonPasswordGenerate
            // 
            this.ButtonPasswordGenerate.Location = new System.Drawing.Point(15, 31);
            this.ButtonPasswordGenerate.Name = "ButtonPasswordGenerate";
            this.ButtonPasswordGenerate.Size = new System.Drawing.Size(117, 23);
            this.ButtonPasswordGenerate.TabIndex = 2;
            this.ButtonPasswordGenerate.Text = "Passwort generieren";
            this.ButtonPasswordGenerate.UseVisualStyleBackColor = true;
            this.ButtonPasswordGenerate.Click += new System.EventHandler(this.ButtonPasswordGenerate_Click);
            // 
            // ButtonClose
            // 
            this.ButtonClose.Location = new System.Drawing.Point(144, 31);
            this.ButtonClose.Name = "ButtonClose";
            this.ButtonClose.Size = new System.Drawing.Size(75, 23);
            this.ButtonClose.TabIndex = 3;
            this.ButtonClose.Text = "Schließen";
            this.ButtonClose.UseVisualStyleBackColor = true;
            this.ButtonClose.Click += new System.EventHandler(this.ButtonClose_Click);
            // 
            // FormPasswordGenerator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(240, 67);
            this.Controls.Add(this.ButtonClose);
            this.Controls.Add(this.ButtonPasswordGenerate);
            this.Controls.Add(this.NumericUpDownPasswordLength);
            this.Controls.Add(this.LabelPasswordLength);
            this.Name = "FormPasswordGenerator";
            this.Text = "Passwort-Generator";
            ((System.ComponentModel.ISupportInitialize)(this.NumericUpDownPasswordLength)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LabelPasswordLength;
        private System.Windows.Forms.NumericUpDown NumericUpDownPasswordLength;
        private System.Windows.Forms.Button ButtonPasswordGenerate;
        private System.Windows.Forms.Button ButtonClose;
    }
}

