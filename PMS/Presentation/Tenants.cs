using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

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
        private bool DisposeTenant(int id)
        {

            SqlConnection conn = new SqlConnection(Business.App.ConnectionString);
            conn.Open();
            String query = "delete from Tenant where Tenantid =@Tid";
            SqlCommand cmd = new SqlCommand(query, conn);
            cmd.Parameters.AddWithValue("@Tid", id);
            int disposed = cmd.ExecuteNonQuery();
            return true;

        }
        private void addANewTenantToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Controls.Clear();
            Controls.Add(Business.Tenant.LoadAddTenentForm());
        }

        private void modifyTenantToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form fm = null;
            try
            {
                int selectedRow = DGVTenants.CurrentCell.RowIndex;
                int id = int.Parse(DGVTenants.Rows[selectedRow].Cells[0].Value.ToString());
                fm = Business.Tenant.LoadModifyTenentForm(id);
            }
            catch
            {
                fm = Business.Tenant.LoadModifyTenentForm();
            }
            this.Controls.Clear();
            this.Controls.Add(fm);
        }

        private void deleteTenantToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                int selectedRow = DGVTenants.CurrentCell.RowIndex;
                int id = int.Parse(DGVTenants.Rows[selectedRow].Cells[0].Value.ToString());

                if (MessageBox.Show("Delete Action Cannot be reversed \nDelete Tenant with ID : " + id, "Dispose Tenant", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    bool disposed = DisposeTenant(id);
                    if (!disposed) { MessageBox.Show("Error Deleting Tenant with id " + id); }
                    else { LoadData(); }
                }
            }
            catch { }
        }

        private void deleteTenantToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            try
            {
                int selectedRow = DGVTenants.CurrentCell.RowIndex;
                int id = int.Parse(DGVTenants.Rows[selectedRow].Cells[0].Value.ToString());
                if (MessageBox.Show("Are you sure you want to delete Tenant with id " + id, "Confirm Delete", MessageBoxButtons.YesNo) == DialogResult.Yes)
                { DisposeTenant(id); LoadData(); }
                
                
            }
            catch { MessageBox.Show("Select a Tenant detail to Dispose!!", "Information Message"); }
        }

    }
}

