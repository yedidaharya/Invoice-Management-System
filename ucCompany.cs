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
    public partial class ucCompany : UserControl
    {
        private static ucCompany _instance;
        public static ucCompany Instance {
            get {
                if (_instance == null)
                    _instance = new ucCompany();
                return _instance;
            }
        }
        public ucCompany()
        {
            InitializeComponent();
        }
    }
}
