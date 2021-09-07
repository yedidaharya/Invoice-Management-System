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
    public partial class ucSettings2 : UserControl
    {
        
        private static ucSettings2 _instance;
        public static ucSettings2 Instance {
            get {
                if (_instance == null)
                    _instance = new ucSettings2();
                return _instance;
            }
        }
        public ucSettings2()
        {
            InitializeComponent();
            textBoxPassword.PasswordChar = '*';
            textBoxConfirmPassword.PasswordChar = '*';
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            textBoxFullName.Text = "";
            textBoxPassword.Text = "";
            textBoxEmail.Text = "";
            textBoxUsername.Text = "";
            textBoxConfirmPassword.Text = "";
            textBoxPhone.Text = "";
            
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (textBoxFullName.Text.Trim().Length == 0)
            {
                MessageBox.Show("Required Full Name");
                return;
            }
            if (textBoxUsername.Text.Trim().Length == 0)
            {
                MessageBox.Show("Required Username");
                return;
            }

            if (textBoxPassword.Text.Trim().Length == 0)
            {
                MessageBox.Show("Required Password");
                return;
            }

            if (textBoxPassword.Text.Trim().Length < 5)
            {
                MessageBox.Show("Required too weak");
                return;
            }
            if (textBoxPassword.Text.Trim() != textBoxConfirmPassword.Text.Trim())
            {
                MessageBox.Show("Password do not match");
                return;
            }

            if (textBoxEmail.Text.Trim().Length == 0)
            {
                MessageBox.Show("Required Email");
                return;
            }

            if (textBoxPhone.Text.Trim().Length == 0)
            {
                MessageBox.Show("Required Phone Number");
                return;
            }

            

            

        }
        
    }
}
