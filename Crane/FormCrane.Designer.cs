namespace Crane
{
    partial class FormCrane
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
            this.ButtonHookOut = new System.Windows.Forms.Button();
            this.ButtonHookIn = new System.Windows.Forms.Button();
            this.ButtonOutriggerOut = new System.Windows.Forms.Button();
            this.ButtonOutriggerIn = new System.Windows.Forms.Button();
            this.ButtonCraneRight = new System.Windows.Forms.Button();
            this.ButtonCraneLeft = new System.Windows.Forms.Button();
            this.ButtonCraneOut = new System.Windows.Forms.Button();
            this.ButtonCraneIn = new System.Windows.Forms.Button();
            this.PanelHook = new System.Windows.Forms.Panel();
            this.PanelOutrigger = new System.Windows.Forms.Panel();
            this.PanelCrane = new System.Windows.Forms.Panel();
            this.PanelCraneBase = new System.Windows.Forms.Panel();
            this.PanelEarth = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // ButtonHookOut
            // 
            this.ButtonHookOut.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ButtonHookOut.BackColor = System.Drawing.Color.Green;
            this.ButtonHookOut.ForeColor = System.Drawing.Color.White;
            this.ButtonHookOut.Location = new System.Drawing.Point(578, 12);
            this.ButtonHookOut.Name = "ButtonHookOut";
            this.ButtonHookOut.Size = new System.Drawing.Size(103, 23);
            this.ButtonHookOut.TabIndex = 0;
            this.ButtonHookOut.Text = "Haken aus";
            this.ButtonHookOut.UseVisualStyleBackColor = false;
            this.ButtonHookOut.Click += new System.EventHandler(this.ButtonHookOut_Click);
            // 
            // ButtonHookIn
            // 
            this.ButtonHookIn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ButtonHookIn.BackColor = System.Drawing.Color.Green;
            this.ButtonHookIn.ForeColor = System.Drawing.Color.White;
            this.ButtonHookIn.Location = new System.Drawing.Point(578, 41);
            this.ButtonHookIn.Name = "ButtonHookIn";
            this.ButtonHookIn.Size = new System.Drawing.Size(103, 23);
            this.ButtonHookIn.TabIndex = 1;
            this.ButtonHookIn.Text = "Haken ein";
            this.ButtonHookIn.UseVisualStyleBackColor = false;
            this.ButtonHookIn.Click += new System.EventHandler(this.ButtonHookIn_Click);
            // 
            // ButtonOutriggerOut
            // 
            this.ButtonOutriggerOut.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ButtonOutriggerOut.BackColor = System.Drawing.Color.Blue;
            this.ButtonOutriggerOut.ForeColor = System.Drawing.Color.White;
            this.ButtonOutriggerOut.Location = new System.Drawing.Point(578, 70);
            this.ButtonOutriggerOut.Name = "ButtonOutriggerOut";
            this.ButtonOutriggerOut.Size = new System.Drawing.Size(103, 23);
            this.ButtonOutriggerOut.TabIndex = 2;
            this.ButtonOutriggerOut.Text = "Ausleger aus";
            this.ButtonOutriggerOut.UseVisualStyleBackColor = false;
            this.ButtonOutriggerOut.Click += new System.EventHandler(this.ButtonOutriggerOut_Click);
            // 
            // ButtonOutriggerIn
            // 
            this.ButtonOutriggerIn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ButtonOutriggerIn.BackColor = System.Drawing.Color.Blue;
            this.ButtonOutriggerIn.ForeColor = System.Drawing.Color.White;
            this.ButtonOutriggerIn.Location = new System.Drawing.Point(578, 99);
            this.ButtonOutriggerIn.Name = "ButtonOutriggerIn";
            this.ButtonOutriggerIn.Size = new System.Drawing.Size(103, 23);
            this.ButtonOutriggerIn.TabIndex = 3;
            this.ButtonOutriggerIn.Text = "Ausleger ein";
            this.ButtonOutriggerIn.UseVisualStyleBackColor = false;
            this.ButtonOutriggerIn.Click += new System.EventHandler(this.ButtonOutriggerIn_Click);
            // 
            // ButtonCraneRight
            // 
            this.ButtonCraneRight.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ButtonCraneRight.BackColor = System.Drawing.Color.Red;
            this.ButtonCraneRight.Location = new System.Drawing.Point(578, 128);
            this.ButtonCraneRight.Name = "ButtonCraneRight";
            this.ButtonCraneRight.Size = new System.Drawing.Size(103, 23);
            this.ButtonCraneRight.TabIndex = 4;
            this.ButtonCraneRight.Text = "Kran rechts";
            this.ButtonCraneRight.UseVisualStyleBackColor = false;
            this.ButtonCraneRight.Click += new System.EventHandler(this.ButtonCraneRight_Click);
            // 
            // ButtonCraneLeft
            // 
            this.ButtonCraneLeft.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ButtonCraneLeft.BackColor = System.Drawing.Color.Red;
            this.ButtonCraneLeft.Location = new System.Drawing.Point(578, 157);
            this.ButtonCraneLeft.Name = "ButtonCraneLeft";
            this.ButtonCraneLeft.Size = new System.Drawing.Size(103, 23);
            this.ButtonCraneLeft.TabIndex = 5;
            this.ButtonCraneLeft.Text = "Kran links";
            this.ButtonCraneLeft.UseVisualStyleBackColor = false;
            this.ButtonCraneLeft.Click += new System.EventHandler(this.ButtonCraneLeft_Click);
            // 
            // ButtonCraneOut
            // 
            this.ButtonCraneOut.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ButtonCraneOut.BackColor = System.Drawing.Color.Yellow;
            this.ButtonCraneOut.Location = new System.Drawing.Point(578, 186);
            this.ButtonCraneOut.Name = "ButtonCraneOut";
            this.ButtonCraneOut.Size = new System.Drawing.Size(103, 23);
            this.ButtonCraneOut.TabIndex = 6;
            this.ButtonCraneOut.Text = "Kran aus";
            this.ButtonCraneOut.UseVisualStyleBackColor = false;
            this.ButtonCraneOut.Click += new System.EventHandler(this.ButtonCraneOut_Click);
            // 
            // ButtonCraneIn
            // 
            this.ButtonCraneIn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ButtonCraneIn.BackColor = System.Drawing.Color.Yellow;
            this.ButtonCraneIn.Location = new System.Drawing.Point(578, 215);
            this.ButtonCraneIn.Name = "ButtonCraneIn";
            this.ButtonCraneIn.Size = new System.Drawing.Size(103, 23);
            this.ButtonCraneIn.TabIndex = 7;
            this.ButtonCraneIn.Text = "Kran ein";
            this.ButtonCraneIn.UseVisualStyleBackColor = false;
            this.ButtonCraneIn.Click += new System.EventHandler(this.ButtonCraneIn_Click);
            // 
            // PanelHook
            // 
            this.PanelHook.BackColor = System.Drawing.Color.Green;
            this.PanelHook.Location = new System.Drawing.Point(160, 210);
            this.PanelHook.Name = "PanelHook";
            this.PanelHook.Size = new System.Drawing.Size(10, 30);
            this.PanelHook.TabIndex = 8;
            // 
            // PanelOutrigger
            // 
            this.PanelOutrigger.BackColor = System.Drawing.Color.Blue;
            this.PanelOutrigger.Location = new System.Drawing.Point(160, 200);
            this.PanelOutrigger.Name = "PanelOutrigger";
            this.PanelOutrigger.Size = new System.Drawing.Size(60, 10);
            this.PanelOutrigger.TabIndex = 9;
            // 
            // PanelCrane
            // 
            this.PanelCrane.BackColor = System.Drawing.Color.Yellow;
            this.PanelCrane.Location = new System.Drawing.Point(220, 200);
            this.PanelCrane.Name = "PanelCrane";
            this.PanelCrane.Size = new System.Drawing.Size(20, 100);
            this.PanelCrane.TabIndex = 9;
            // 
            // PanelCraneBase
            // 
            this.PanelCraneBase.BackColor = System.Drawing.Color.Red;
            this.PanelCraneBase.Location = new System.Drawing.Point(200, 300);
            this.PanelCraneBase.Name = "PanelCraneBase";
            this.PanelCraneBase.Size = new System.Drawing.Size(60, 10);
            this.PanelCraneBase.TabIndex = 9;
            // 
            // PanelEarth
            // 
            this.PanelEarth.BackColor = System.Drawing.Color.Cornsilk;
            this.PanelEarth.Location = new System.Drawing.Point(1, 310);
            this.PanelEarth.Name = "PanelEarth";
            this.PanelEarth.Size = new System.Drawing.Size(690, 35);
            this.PanelEarth.TabIndex = 10;
            // 
            // FormCrane
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(692, 338);
            this.Controls.Add(this.PanelEarth);
            this.Controls.Add(this.PanelCraneBase);
            this.Controls.Add(this.PanelCrane);
            this.Controls.Add(this.PanelOutrigger);
            this.Controls.Add(this.PanelHook);
            this.Controls.Add(this.ButtonCraneIn);
            this.Controls.Add(this.ButtonCraneOut);
            this.Controls.Add(this.ButtonCraneLeft);
            this.Controls.Add(this.ButtonCraneRight);
            this.Controls.Add(this.ButtonOutriggerIn);
            this.Controls.Add(this.ButtonOutriggerOut);
            this.Controls.Add(this.ButtonHookIn);
            this.Controls.Add(this.ButtonHookOut);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FormCrane";
            this.Text = "Kran";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button ButtonHookOut;
        private System.Windows.Forms.Button ButtonHookIn;
        private System.Windows.Forms.Button ButtonOutriggerOut;
        private System.Windows.Forms.Button ButtonOutriggerIn;
        private System.Windows.Forms.Button ButtonCraneRight;
        private System.Windows.Forms.Button ButtonCraneLeft;
        private System.Windows.Forms.Button ButtonCraneOut;
        private System.Windows.Forms.Button ButtonCraneIn;
        private System.Windows.Forms.Panel PanelHook;
        private System.Windows.Forms.Panel PanelOutrigger;
        private System.Windows.Forms.Panel PanelCrane;
        private System.Windows.Forms.Panel PanelCraneBase;
        private System.Windows.Forms.Panel PanelEarth;
    }
}

