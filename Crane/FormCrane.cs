using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Crane
{
    public partial class FormCrane : Form
    {
        const int jump = 10;

        public FormCrane()
        {
            InitializeComponent();
        }

        private void ButtonHookOut_Click(object sender, EventArgs e)
        {
            // Wenn die Höhe + Y-Wert des Panles den Wert des PanelEarth nicht überschreitet
            if (PanelHook.Size.Height + PanelHook.Location.Y < PanelEarth.Location.Y)
            {
                Size size = PanelHook.Size;
                size.Height += jump;
                PanelHook.Size = size; 
            }
        }

        private void ButtonHookIn_Click(object sender, EventArgs e)
        {
            // Wenn die Höhe - Y-Wert des Panles den Wert des PanelOutrigger nicht unterschreitet
            if (PanelHook.Size.Height + PanelHook.Location.Y > PanelOutrigger.Location.Y + PanelOutrigger.Size.Height)
            {
                Size size = PanelHook.Size;
                size.Height -= jump;
                PanelHook.Size = size;
            }
        }

        private void ButtonOutriggerOut_Click(object sender, EventArgs e)
        {
            // max. Breite => Location.X = 0
            if (PanelOutrigger.Location.X > 0)
            {
                Size size = PanelOutrigger.Size;
                size.Width += jump;
                PanelOutrigger.Size = size;
                Point point = PanelOutrigger.Location;
                point.X -= jump;  
                PanelOutrigger.Location = point;
                point = PanelHook.Location;
                point.X -= jump;
                PanelHook.Location = point;
            }
        }

        private void ButtonOutriggerIn_Click(object sender, EventArgs e)
        {
            // min. Breite => Location.X = Crane.Location.X - Hook.Size.Width 
            if (PanelOutrigger.Location.X < PanelCrane.Location.X - PanelHook.Size.Width)
            {
                Size size = PanelOutrigger.Size;
                size.Width -= jump;
                PanelOutrigger.Size = size;
                Point point = PanelOutrigger.Location;
                point.X += jump;
                PanelOutrigger.Location = point;
                point = PanelHook.Location;
                point.X += jump;
                PanelHook.Location = point;
            }

        }

        private void ButtonCraneRight_Click(object sender, EventArgs e)
        {
            // max rechte Position = 560 für Crane.Location.X
            if (PanelCrane.Location.X < 550)
            {
                Point point = PanelCrane.Location;
                point.X += jump;
                PanelCrane.Location = point;

                point = PanelCraneBase.Location;
                point.X += jump;
                PanelCraneBase.Location = point;

                point = PanelHook.Location;
                point.X += jump;
                PanelHook.Location = point;

                point = PanelOutrigger.Location;
                point.X += jump;
                PanelOutrigger.Location = point;
            }
        }

        private void ButtonCraneLeft_Click(object sender, EventArgs e)
        {
            // max. linke Position = 0 für Outrigger.Location.X
            if (PanelOutrigger.Location.X > 0)
            {
                Point point = PanelCrane.Location;
                point.X -= jump;
                PanelCrane.Location = point;

                point = PanelCraneBase.Location;
                point.X -= jump;
                PanelCraneBase.Location = point;

                point = PanelHook.Location;
                point.X -= jump;
                PanelHook.Location = point;

                point = PanelOutrigger.Location;
                point.X -= jump;
                PanelOutrigger.Location = point;
            }

        }

        private void ButtonCraneOut_Click(object sender, EventArgs e)
        {
            // max. Höhe = Crane.Location.Y = 0
            if (PanelCrane.Location.Y > 0)
            {
                Point point = PanelCrane.Location;
                point.Y -= jump;
                PanelCrane.Location = point;

                Size size = PanelCrane.Size;
                size.Height += jump;
                PanelCrane.Size = size;

                point = PanelOutrigger.Location;
                point.Y -= jump;
                PanelOutrigger.Location = point;

                point = PanelHook.Location;
                point.Y -= jump;
                PanelHook.Location = point;
            }
        }

        private void ButtonCraneIn_Click(object sender, EventArgs e)
        {
            // min. Höhe = Crane.Location.Y = Hook.Location.Y - Hook.Size.Height 
            if (PanelCrane.Location.Y < PanelCraneBase.Location.Y - PanelHook.Size.Height)
            {
                Point point = PanelCrane.Location;
                point.Y += jump;
                PanelCrane.Location = point;

                Size size = PanelCrane.Size;
                size.Height -= jump;
                PanelCrane.Size = size;

                point = PanelOutrigger.Location;
                point.Y += jump;
                PanelOutrigger.Location = point;

                point = PanelHook.Location;
                point.Y += jump;
                PanelHook.Location = point;
            }

        }
    }
}
