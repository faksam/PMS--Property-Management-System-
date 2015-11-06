using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PMS
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void lbRegister_Click(object sender, EventArgs e)
        {
            Process.Start("http://fakunlesamuel.com");
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            PMS pms = new PMS();
            pms.Show();
            pms.FormBorderStyle = FormBorderStyle.FixedSingle;
        }
    }
}
