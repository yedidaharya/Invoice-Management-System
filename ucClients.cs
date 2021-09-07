﻿using System;
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
    public partial class ucClients : UserControl
    {
        private static ucClients _instance;
        public static ucClients Instance {
            get {
                if (_instance == null)
                    _instance = new ucClients();
                return _instance;
            }
        }
        public ucClients()
        {
            InitializeComponent();
        }
    }
}
