using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UIDemo
{
    public partial class FormMain : Form
    {
        static FormMain _instance;

        /// <summary>
        /// Gibt die Instanz des Hauptformulars zurück
        /// </summary>
        public static FormMain Instance
        {
            get 
            { 
                if (_instance == null)
                    _instance = new FormMain();
                return _instance; 
            }
        }

        /// <summary>
        /// Liefert den Haupt-Container oder setzt ihn
        /// </summary>
        public Panel MainContainer
        {
            get { return ContainerPanel; }
            set { ContainerPanel = value; }
        }

        public Button BackButton
        {
            get { return ButtonBack; }
            set { ButtonBack = value; }
        }

        public FormMain()
        {
            InitializeComponent();
        }

        private void FormMain_Load(object sender, EventArgs e)
        {
            ButtonBack.Visible = false;
            _instance = this;
            UC_Dashboard uc = new UC_Dashboard();
            uc.Dock = DockStyle.Fill;
            ContainerPanel.Controls.Add(uc);
            TimerTest.Start();
        }

        private void ButtonBack_Click(object sender, EventArgs e)
        {
            ContainerPanel.Controls["UC_Dashboard"].BringToFront();
            ButtonBack.Visible=false;
        }

        private void TimerTest_Tick(object sender, EventArgs e)
        {
            LabelTime.Text = DateTime.Now.ToString("HH:mm:ss");
        }
    }
}
