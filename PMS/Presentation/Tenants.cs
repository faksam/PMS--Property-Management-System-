using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PMS.Presentation
{
    public partial class Tenants : Form
    {
        public Tenants()
        {
            InitializeComponent(); 
            LoadData();
        }

        public void LoadData()
        {

            DGVTenants.DataSource = Business.Tenant.LoadTenants();
            DGVTenants.DataMember = "FilterTable";
            //dataGridView1.Columns[3].Width = 660;
        }
    }
}
