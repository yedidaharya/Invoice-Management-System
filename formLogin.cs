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
    public partial class formLogin : Form
    {
        Point lastPoint; 
        
        
        
        public formLogin()
        {
            InitializeComponent();
            
            txtboxPassword.PasswordChar = '*';
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (txtboxUsername.Text.Trim().Length == 0)
            {
                MessageBox.Show("Invalid Username");
                return;
            }
            if (txtboxPassword.Text.Trim().Length == 0)
            {
                MessageBox.Show("Invalid Password");
                return;
            }

            
            if (txtboxUsername.Text == "admin" && txtboxPassword.Text == "123")
            {
                this.Hide();
                formMain frm = new formMain();
                frm.Show();
            }
            else
            {
                MessageBox.Show("Invalid Username or Password");
            }
            

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
    }
}
