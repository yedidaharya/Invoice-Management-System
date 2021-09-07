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
    public partial class ucSettings1 : UserControl
    {
        
        
        private static ucSettings1 _instance;
        public static ucSettings1 Instance {
            get {
                if (_instance == null)
                    _instance = new ucSettings1();
                return _instance;
            }
        }
        public ucSettings1()
        {
           
        }

       

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            
        }
       

    }
}
