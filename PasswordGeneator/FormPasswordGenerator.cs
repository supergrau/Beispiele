using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PasswordGeneator
{
    public partial class FormPasswordGenerator : Form
    {
        public FormPasswordGenerator()
        {
            InitializeComponent();
        }

        private void ButtonPasswordGenerate_Click(object sender, EventArgs e)
        {
            PasswordGeneator.PasswordGenerator pg = 
                new PasswordGeneator.PasswordGenerator((int)NumericUpDownPasswordLength.Value);
            string password = pg.generate();
            MessageBox.Show(password);
        }

        private void ButtonClose_Click(object sender, EventArgs e)
        {
            //this.Close();
            // bzw.
            Application.Exit();
        }
    }
}
