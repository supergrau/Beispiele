using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DownloadGUI
{
    public partial class FormDownload : Form
    {
        public FormDownload()
        {
            InitializeComponent();
        }

        private void ButtonAddLink_Click(object sender, EventArgs e)
        {
            if (TextBoxLink.Text != "")
            {
                ListBoxLinks.Items.Add(TextBoxLink.Text);
            }
        }

        private void ButtonDelLink_Click(object sender, EventArgs e)
        {
            try
            {
                ListBoxLinks.Items.RemoveAt(ListBoxLinks.SelectedIndex);
            }
            catch { }
        }

        private void ButtonStartSync_Click(object sender, EventArgs e)
        {
            ListBoxLog.Items.Clear();

            string msg;
            Stopwatch watch = new Stopwatch();
            watch.Start();
            foreach (string l in ListBoxLinks.Items)
            {
                

                ListBoxLog.Items.Add($"Download: {l}");
                if (!Download.ResDownload(l, out msg))
                {
                    ListBoxLog.Items.Add($@"Download fehlgeschlagen: {msg}");
                }

            }
            ListBoxLog.Items.Add("erledigt");
            ListBoxLog.Items.Add($"Verstrichene Zeit: {watch.ElapsedMilliseconds.ToString()} ms");

        }

        private void ButtonClearLog_Click(object sender, EventArgs e)
        {
            ListBoxLog.Items.Clear();
        }

        private async void ButtonStartASync_Click(object sender, EventArgs e)
        {
            ListBoxLog.Items.Clear();

            Stopwatch watch = new Stopwatch();
            watch.Start();
            await StartDownloadAsync();
            ListBoxLog.Items.Add($"Verstrichene Zeit: {watch.ElapsedMilliseconds.ToString()} ms");
        }

        private async Task StartDownloadAsync()
        {
            string msg;
            // Add some async stuff here :-)

            List<Task> allTasks = new List<Task>();
            foreach (string l in ListBoxLinks.Items)
            {
                allTasks.Add(Task.Run(() => Download.ResDownload(l, out msg)));
                ListBoxLog.Items.Add($"Download: {l}");
                //if (!Download.ResDownload(l, out msg))
                //{
                //    ListBoxLog.Items.Add($@"Download fehlgeschlagen: {msg}");
                //}

            }

            await Task.WhenAll(allTasks);
            ListBoxLog.Items.Add("erledigt");
        }

    }
}
