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
            DGVTenants.ReadOnly = true;
        }

        public void LoadData()
        {

            DGVTenants.DataSource = Business.Tenant.LoadTenants();
            DGVTenants.DataMember = "FilterTable";
            //dataGridView1.Columns[3].Width = 660;
        }

        private void addANewTenantToolStripMenuItem_Click(object sender, EventArgs e)
        {
             AddTenant tenant = new AddTenant();
            tenant.BringToFront();
            tenant.TopLevel = false;
            tenant.Visible = true;
            tenant.FormBorderStyle = FormBorderStyle.None;
            tenant.Dock = DockStyle.Fill;
            panel1.Controls.Add(tenant);
            tenant.Show();
            DGVTenants.Hide();
        }

        private void modifyTenantToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Panel display = new Panel();
            Presentation.UpdateTenant tenant = new Presentation.UpdateTenant();
            tenant.BringToFront();
            tenant.TopLevel = false;
            tenant.Visible = true;
            tenant.FormBorderStyle = FormBorderStyle.None;
            tenant.Dock = DockStyle.Fill;
            display.Controls.Add(tenant);
            display.Size = panel1.Size;
            panel1.Controls.Add(display);
            display.Show();
            display.BringToFront();
            tenant.Show();
        }

      
    }
}

