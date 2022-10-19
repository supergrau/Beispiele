namespace DownloadGUI
{
    partial class FormDownload
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
            this.ListBoxLinks = new System.Windows.Forms.ListBox();
            this.LabelLinkList = new System.Windows.Forms.Label();
            this.LabelLink = new System.Windows.Forms.Label();
            this.TextBoxLink = new System.Windows.Forms.TextBox();
            this.ButtonAddLink = new System.Windows.Forms.Button();
            this.ButtonStartSync = new System.Windows.Forms.Button();
            this.ButtonStartASync = new System.Windows.Forms.Button();
            this.LabelTime = new System.Windows.Forms.Label();
            this.ProgressBarDownload = new System.Windows.Forms.ProgressBar();
            this.ButtonDelLink = new System.Windows.Forms.Button();
            this.LabelLog = new System.Windows.Forms.Label();
            this.ListBoxLog = new System.Windows.Forms.ListBox();
            this.ButtonClearLog = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ListBoxLinks
            // 
            this.ListBoxLinks.FormattingEnabled = true;
            this.ListBoxLinks.Items.AddRange(new object[] {
            "https://lincont.de/Programmieren_lernen.pdf",
            "https://lincont.de/EinstiegCSharp.pdf",
            "https://lincont.de/IllustratedCSharp.pdf",
            "https://lincont.de/HeadFirstCSharp.pdf"});
            this.ListBoxLinks.Location = new System.Drawing.Point(12, 80);
            this.ListBoxLinks.Name = "ListBoxLinks";
            this.ListBoxLinks.Size = new System.Drawing.Size(607, 95);
            this.ListBoxLinks.TabIndex = 0;
            // 
            // LabelLinkList
            // 
            this.LabelLinkList.AutoSize = true;
            this.LabelLinkList.Location = new System.Drawing.Point(13, 64);
            this.LabelLinkList.Name = "LabelLinkList";
            this.LabelLinkList.Size = new System.Drawing.Size(45, 13);
            this.LabelLinkList.TabIndex = 1;
            this.LabelLinkList.Text = "Linkliste";
            // 
            // LabelLink
            // 
            this.LabelLink.AutoSize = true;
            this.LabelLink.Location = new System.Drawing.Point(16, 13);
            this.LabelLink.Name = "LabelLink";
            this.LabelLink.Size = new System.Drawing.Size(27, 13);
            this.LabelLink.TabIndex = 2;
            this.LabelLink.Text = "Link";
            // 
            // TextBoxLink
            // 
            this.TextBoxLink.Location = new System.Drawing.Point(19, 31);
            this.TextBoxLink.Name = "TextBoxLink";
            this.TextBoxLink.Size = new System.Drawing.Size(600, 20);
            this.TextBoxLink.TabIndex = 3;
            // 
            // ButtonAddLink
            // 
            this.ButtonAddLink.Location = new System.Drawing.Point(625, 30);
            this.ButtonAddLink.Name = "ButtonAddLink";
            this.ButtonAddLink.Size = new System.Drawing.Size(140, 23);
            this.ButtonAddLink.TabIndex = 4;
            this.ButtonAddLink.Text = "Link hinzufügen";
            this.ButtonAddLink.UseVisualStyleBackColor = true;
            this.ButtonAddLink.Click += new System.EventHandler(this.ButtonAddLink_Click);
            // 
            // ButtonStartSync
            // 
            this.ButtonStartSync.Location = new System.Drawing.Point(626, 210);
            this.ButtonStartSync.Name = "ButtonStartSync";
            this.ButtonStartSync.Size = new System.Drawing.Size(139, 23);
            this.ButtonStartSync.TabIndex = 5;
            this.ButtonStartSync.Text = "Start Sync Download";
            this.ButtonStartSync.UseVisualStyleBackColor = true;
            this.ButtonStartSync.Click += new System.EventHandler(this.ButtonStartSync_Click);
            // 
            // ButtonStartASync
            // 
            this.ButtonStartASync.Location = new System.Drawing.Point(626, 239);
            this.ButtonStartASync.Name = "ButtonStartASync";
            this.ButtonStartASync.Size = new System.Drawing.Size(139, 23);
            this.ButtonStartASync.TabIndex = 6;
            this.ButtonStartASync.Text = "Start ASync Download";
            this.ButtonStartASync.UseVisualStyleBackColor = true;
            this.ButtonStartASync.Click += new System.EventHandler(this.ButtonStartASync_Click);
            // 
            // LabelTime
            // 
            this.LabelTime.AutoSize = true;
            this.LabelTime.Location = new System.Drawing.Point(12, 193);
            this.LabelTime.Name = "LabelTime";
            this.LabelTime.Size = new System.Drawing.Size(28, 13);
            this.LabelTime.TabIndex = 7;
            this.LabelTime.Text = "Zeit:";
            // 
            // ProgressBarDownload
            // 
            this.ProgressBarDownload.Location = new System.Drawing.Point(12, 210);
            this.ProgressBarDownload.Name = "ProgressBarDownload";
            this.ProgressBarDownload.Size = new System.Drawing.Size(607, 23);
            this.ProgressBarDownload.TabIndex = 8;
            // 
            // ButtonDelLink
            // 
            this.ButtonDelLink.Location = new System.Drawing.Point(626, 80);
            this.ButtonDelLink.Name = "ButtonDelLink";
            this.ButtonDelLink.Size = new System.Drawing.Size(140, 23);
            this.ButtonDelLink.TabIndex = 10;
            this.ButtonDelLink.Text = "Link entfernen";
            this.ButtonDelLink.UseVisualStyleBackColor = true;
            this.ButtonDelLink.Click += new System.EventHandler(this.ButtonDelLink_Click);
            // 
            // LabelLog
            // 
            this.LabelLog.AutoSize = true;
            this.LabelLog.Location = new System.Drawing.Point(13, 250);
            this.LabelLog.Name = "LabelLog";
            this.LabelLog.Size = new System.Drawing.Size(25, 13);
            this.LabelLog.TabIndex = 9;
            this.LabelLog.Text = "Log";
            // 
            // ListBoxLog
            // 
            this.ListBoxLog.FormattingEnabled = true;
            this.ListBoxLog.Location = new System.Drawing.Point(12, 267);
            this.ListBoxLog.Name = "ListBoxLog";
            this.ListBoxLog.Size = new System.Drawing.Size(608, 95);
            this.ListBoxLog.TabIndex = 11;
            // 
            // ButtonClearLog
            // 
            this.ButtonClearLog.Location = new System.Drawing.Point(626, 339);
            this.ButtonClearLog.Name = "ButtonClearLog";
            this.ButtonClearLog.Size = new System.Drawing.Size(139, 23);
            this.ButtonClearLog.TabIndex = 12;
            this.ButtonClearLog.Text = "Lösche Log";
            this.ButtonClearLog.UseVisualStyleBackColor = true;
            this.ButtonClearLog.Click += new System.EventHandler(this.ButtonClearLog_Click);
            // 
            // FormDownload
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(779, 382);
            this.Controls.Add(this.ButtonClearLog);
            this.Controls.Add(this.ListBoxLog);
            this.Controls.Add(this.ButtonDelLink);
            this.Controls.Add(this.LabelLog);
            this.Controls.Add(this.ProgressBarDownload);
            this.Controls.Add(this.LabelTime);
            this.Controls.Add(this.ButtonStartASync);
            this.Controls.Add(this.ButtonStartSync);
            this.Controls.Add(this.ButtonAddLink);
            this.Controls.Add(this.TextBoxLink);
            this.Controls.Add(this.LabelLink);
            this.Controls.Add(this.LabelLinkList);
            this.Controls.Add(this.ListBoxLinks);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FormDownload";
            this.Text = "Download Beispiel";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox ListBoxLinks;
        private System.Windows.Forms.Label LabelLinkList;
        private System.Windows.Forms.Label LabelLink;
        private System.Windows.Forms.TextBox TextBoxLink;
        private System.Windows.Forms.Button ButtonAddLink;
        private System.Windows.Forms.Button ButtonStartSync;
        private System.Windows.Forms.Button ButtonStartASync;
        private System.Windows.Forms.Label LabelTime;
        private System.Windows.Forms.ProgressBar ProgressBarDownload;
        private System.Windows.Forms.Button ButtonDelLink;
        private System.Windows.Forms.Label LabelLog;
        private System.Windows.Forms.ListBox ListBoxLog;
        private System.Windows.Forms.Button ButtonClearLog;
    }
}

