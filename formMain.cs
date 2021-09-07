using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Data.Models;


namespace LoginandRegister
{
    public partial class formMain : Form
    {
        
        Point lastPoint;
        public formMain()
        {
            InitializeComponent();
            
        }

        

        private void btnLogout_Click(object sender, EventArgs e)
        {
            this.Close();
            formLogin frm = new formLogin();
            frm.Show();
        }

        

        private void btnSettings_Click(object sender, EventArgs e)
        {
            panelClients.Visible = false;
            panelInvoices.Visible = false;
            panelCompany.Visible = false;
            panelAbout.Visible = false;
            panelSettings.Visible = true;
            if (!panelMain.Controls.Contains(ucSettings.Instance))
            {
                panelMain.Controls.Add(ucSettings.Instance);
                ucSettings.Instance.Dock = DockStyle.Fill;
                ucSettings.Instance.BringToFront();
            }
            else
                ucSettings.Instance.BringToFront();
            
        }

        

        private void btnExit_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void panelHeader_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - lastPoint.X;
                this.Top += e.Y - lastPoint.Y;
            }
        }

        private void panelHeader_MouseDown(object sender, MouseEventArgs e)
        {
            lastPoint = new Point(e.X, e.Y);
        }

        private void btnClients_Click(object sender, EventArgs e)
        {
            panelClients.Visible = true;
            panelInvoices.Visible = false;
            panelCompany.Visible = false;
            panelAbout.Visible = false;
            panelSettings.Visible = false;
            if (!panelMain.Controls.Contains(ucClients.Instance))
            {
                panelMain.Controls.Add(ucClients.Instance);
                ucClients.Instance.Dock = DockStyle.Fill;
                ucClients.Instance.BringToFront();
            }
            else
                ucClients.Instance.BringToFront();
        }

        private void btnInvoices_Click(object sender, EventArgs e)
        {
            panelClients.Visible = false;
            panelInvoices.Visible = true;
            panelCompany.Visible = false;
            panelAbout.Visible = false;
            panelSettings.Visible = false;
            if (!panelMain.Controls.Contains(ucInvoices.Instance))
            {
                panelMain.Controls.Add(ucInvoices.Instance);
                ucInvoices.Instance.Dock = DockStyle.Fill;
                ucInvoices.Instance.BringToFront();
            }
            else
                ucInvoices.Instance.BringToFront();
        }

        private void btnCompany_Click(object sender, EventArgs e)
        {
            panelClients.Visible = false;
            panelInvoices.Visible = false;
            panelCompany.Visible = true;
            panelAbout.Visible = false;
            panelSettings.Visible = false;
            if (!panelMain.Controls.Contains(ucCompany.Instance))
            {
                panelMain.Controls.Add(ucCompany.Instance);
                ucCompany.Instance.Dock = DockStyle.Fill;
                ucCompany.Instance.BringToFront();
            }
            else
                ucCompany.Instance.BringToFront();
        }

        private void btnAbout_Click(object sender, EventArgs e)
        {
            panelClients.Visible = false;
            panelInvoices.Visible = false;
            panelCompany.Visible = false;
            panelAbout.Visible = true;
            panelSettings.Visible = false;
            if (!panelMain.Controls.Contains(ucAbout.Instance))
            {
                panelMain.Controls.Add(ucAbout.Instance);
                ucAbout.Instance.Dock = DockStyle.Fill;
                ucAbout.Instance.BringToFront();
            }
            else
                ucAbout.Instance.BringToFront();

        }

        private void btnHelp_Click(object sender, EventArgs e)
        {
            if (!panelMain.Controls.Contains(ucHelp.Instance))
            {
                panelMain.Controls.Add(ucHelp.Instance);
                ucHelp.Instance.Dock = DockStyle.Fill;
                ucHelp.Instance.BringToFront();
            }
            else
                ucHelp.Instance.BringToFront();
        }
    }
}
