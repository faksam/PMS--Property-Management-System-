using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PMS
{
    public partial class ProjectTeamLogin : Form
    {
        public ProjectTeamLogin()
        {
            InitializeComponent();
        }

        private void btnFakSam_Click(object sender, EventArgs e)
        {
            Business.App.ConnectionString = "Data Source=FAKSAM;Initial Catalog=PMS;Integrated Security=True";
            Load();
        }

        private void btnEzzy_Click(object sender, EventArgs e)
        {
            Business.App.ConnectionString = "Data Source=StarBlaz;Initial Catalog=PMS;Integrated Security=True";
            Load();
        }

        private void btnAkoji_Click(object sender, EventArgs e)
        {
            Business.App.ConnectionString = "Data Source=desktop-6qd49hv\\ibrahim;Initial Catalog=PMS;Integrated Security=True";
            Load();
        }
        private new void Load()
        {
            Login lgn = new Login();
            lgn.Show();
            lgn.FormBorderStyle = FormBorderStyle.FixedSingle;
        }
    }
}
