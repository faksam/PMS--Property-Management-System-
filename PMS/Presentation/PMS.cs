using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PMS
{
    public partial class PMS : Form
    {
        public PMS()
        {
            InitializeComponent();
            LoadTabPages();
        }

       public void LoadTabPages()
        {
           //Summary and Settings pages are constant
           //Clearing Current TabPage Controls
            tbcPMS.TabPages[1].Controls.Clear();
            tbcPMS.TabPages[2].Controls.Clear();

           //Load Properties
            tbcPMS.TabPages[1].Controls.Add(Business.Property.LoadPropertiesForm());

           //Load Tenants
            tbcPMS.TabPages[2].Controls.Add(Business.Tenant.LoadTenantsForm());
        }

       private void PMS_Load(object sender, EventArgs e)
       {

       }



    }
}
