using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace PMS
{
    public partial class AddTenant : Form
    {
        public AddTenant()
        {
            InitializeComponent();
        }

        private void TenantHome()
        {
            this.Controls.Clear();
            this.Controls.Add(Business.Tenant.LoadTenentMainForm());
        }

        private void ClearAll()
        {
            clearError();
            tbName.Text = "";
            tbEmail.Text = "";
            tbPhone.Text = "";
            tbPid.Text = "";
            tbStatus.Text = "";
        }

        private void AddNewTenent()
        {
            clearError();
            try
            {
                bool checkEmail = true; bool checkName = true; bool checkPhone = true; bool checkP = true;
                {

                    if (!tbEmail.Text.Contains('@')) { emailerror.Text = "Unrecorgnised Server Domain Name"; checkEmail = false; }
                    if (tbName.Text.Trim() == "") { nameerror.Text = "Name column Cannot be Null"; checkName = false; }
                    if (tbPhone.Text.Trim() == "") { phoneerror.Text = "Phone Number Colmn Cannot be Null"; checkPhone = false; }
                    if (!Business.Tenant.PropertyExist(int.Parse(tbPid.Text.Trim()))) { checkP = false; piderror.Text = "Property ID does not Exist"; }
                    if (tbPid.Text == "") { piderror.Text = "Property ID column cannot be Null"; }
                }

                if (checkEmail && checkPhone && checkName && checkP)
                {
                    try
                    {
                        String gender = "Female";
                        if (rbMale.Checked)
                            gender = "Male";
       
                        int id = int.Parse(tbPid.Text.Trim());
                        Business.Tenant.InsertNewTenant(tbName.Text.Trim(), gender,dtpDob.Text,tbPhone.Text,tbEmail.Text.Trim(),
                            dtpMovingDate.Text,dtpEndDate.Text,tbStatus.Text.Trim(), id);
                        
                        viewToolStripMenuItem.PerformClick();
                    }
                    catch (Exception ex) { MessageBox.Show("" + ex.Message); }
                }

            }
            catch
            {
            }
        }



        private void clearError()
        {
            emailerror.Text = ""; nameerror.Text = ""; phoneerror.Text = ""; piderror.Text = "";
        }
        private void button1_Click(object sender, EventArgs e)
        {
            AddNewTenent();
        }
        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearAll();   
        }


        private void viewToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Controls.Clear();
            this.Controls.Add(Business.Tenant.LoadTenentMainForm());
        }

      
    }
}
