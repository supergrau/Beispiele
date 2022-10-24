namespace UIDemo
{
    partial class FormMain
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
            this.components = new System.ComponentModel.Container();
            this.ContainerPanel = new System.Windows.Forms.Panel();
            this.LabelTitel = new System.Windows.Forms.Label();
            this.LabelTime = new System.Windows.Forms.Label();
            this.TimerTest = new System.Windows.Forms.Timer(this.components);
            this.ButtonBack = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ContainerPanel
            // 
            this.ContainerPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ContainerPanel.Location = new System.Drawing.Point(12, 57);
            this.ContainerPanel.Name = "ContainerPanel";
            this.ContainerPanel.Size = new System.Drawing.Size(838, 439);
            this.ContainerPanel.TabIndex = 0;
            // 
            // LabelTitel
            // 
            this.LabelTitel.AutoSize = true;
            this.LabelTitel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelTitel.Location = new System.Drawing.Point(73, 19);
            this.LabelTitel.Name = "LabelTitel";
            this.LabelTitel.Size = new System.Drawing.Size(101, 24);
            this.LabelTitel.TabIndex = 1;
            this.LabelTitel.Text = "LabelTitel";
            // 
            // LabelTime
            // 
            this.LabelTime.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.LabelTime.AutoSize = true;
            this.LabelTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelTime.ForeColor = System.Drawing.Color.Blue;
            this.LabelTime.Location = new System.Drawing.Point(737, 19);
            this.LabelTime.Name = "LabelTime";
            this.LabelTime.Size = new System.Drawing.Size(63, 25);
            this.LabelTime.TabIndex = 3;
            this.LabelTime.Text = "Time";
            this.LabelTime.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // TimerTest
            // 
            this.TimerTest.Tick += new System.EventHandler(this.TimerTest_Tick);
            // 
            // ButtonBack
            // 
            this.ButtonBack.FlatAppearance.BorderSize = 0;
            this.ButtonBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonBack.Image = global::UIDemo.Properties.Resources.back_botton_left_icon;
            this.ButtonBack.Location = new System.Drawing.Point(12, 11);
            this.ButtonBack.Name = "ButtonBack";
            this.ButtonBack.Size = new System.Drawing.Size(52, 40);
            this.ButtonBack.TabIndex = 2;
            this.ButtonBack.UseVisualStyleBackColor = true;
            this.ButtonBack.Click += new System.EventHandler(this.ButtonBack_Click);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(862, 508);
            this.Controls.Add(this.LabelTime);
            this.Controls.Add(this.ButtonBack);
            this.Controls.Add(this.LabelTitel);
            this.Controls.Add(this.ContainerPanel);
            this.Name = "FormMain";
            this.Text = "UI - Demo";
            this.Load += new System.EventHandler(this.FormMain_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel ContainerPanel;
        private System.Windows.Forms.Label LabelTitel;
        private System.Windows.Forms.Button ButtonBack;
        private System.Windows.Forms.Label LabelTime;
        private System.Windows.Forms.Timer TimerTest;
    }
}

