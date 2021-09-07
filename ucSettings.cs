using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LoginandRegister
{
    public partial class ucSettings : UserControl
    {
        
        
        private static ucSettings _instance;
        public static ucSettings Instance {
            get {
                if (_instance == null)
                    _instance = new ucSettings();
                return _instance;
            }
        }
        public ucSettings()
        {

            InitializeComponent();
            btnUsers.PerformClick();
            txtPasswordAdmin.PasswordChar = '*';

        }

        private void btnUsers_Click(object sender, EventArgs e)
        {
            panelUsers.Visible = true;
            panelAddUser.Visible = false;
            if (!panelMain.Controls.Contains(ucSettings1.Instance))
            {
                panelMain.Controls.Add(ucSettings1.Instance);
                ucSettings1.Instance.Dock = DockStyle.Fill;
                ucSettings1.Instance.BringToFront();
            }
            else
                ucSettings1.Instance.BringToFront();
        }

        private void btnAddUser_Click(object sender, EventArgs e)
        {
            panelAddUser.Visible = true;
            panelUsers.Visible = false;
            if (!panelMain.Controls.Contains(ucSettings2.Instance))
            {
                panelMain.Controls.Add(ucSettings2.Instance);
                ucSettings2.Instance.Dock = DockStyle.Fill;
                ucSettings2.Instance.BringToFront();
            }
            else
                ucSettings2.Instance.BringToFront();
        }


        private void btnLoginAdmin_Click(object sender, EventArgs e)
        {
            if (txtUsernameAdmin.Text == "admin" && txtPasswordAdmin.Text == "123")
            {
                panelLoginAdmin.Visible = false;

            }
            else
            {
                MessageBox.Show("Invalid Username or Password");
            }
        }
    }
}
