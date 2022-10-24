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
    public partial class UC_Dashboard : UserControl
    {
        public UC_Dashboard()
        {
            InitializeComponent();
        }

        private void ButtonCategory_Click(object sender, EventArgs e)
        {
            if (!FormMain.Instance.MainContainer.Controls.ContainsKey("UC_Category"))
            {
                UC_Category uc = new UC_Category();
                uc.Dock = DockStyle.Fill;
                FormMain.Instance.MainContainer.Controls.Add(uc);
            }
            FormMain.Instance.MainContainer.Controls["UC_Category"].BringToFront();
            FormMain.Instance.BackButton.Visible = true;
        }

        private void ButtonProduct_Click(object sender, EventArgs e)
        {
            if (!FormMain.Instance.MainContainer.Controls.ContainsKey("UC_Product"))
            {
                UC_Product uc = new UC_Product();
                uc.Dock = DockStyle.Fill;
                FormMain.Instance.MainContainer.Controls.Add(uc);
            }
            FormMain.Instance.MainContainer.Controls["UC_Product"].BringToFront();
            FormMain.Instance.BackButton.Visible = true;

        }

        private void ButtonOrders_Click(object sender, EventArgs e)
        {
            if (!FormMain.Instance.MainContainer.Controls.ContainsKey("UC_Orders"))
            {
                UC_Orders uc = new UC_Orders();
                uc.Dock = DockStyle.Fill;
                FormMain.Instance.MainContainer.Controls.Add(uc);
            }
            FormMain.Instance.MainContainer.Controls["UC_Orders"].BringToFront();
            FormMain.Instance.BackButton.Visible = true;

        }
    }
}
