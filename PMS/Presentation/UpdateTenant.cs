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

namespace PMS.Presentation
{
    public partial class UpdateTenant : Form
    {
        
        public void visible(bool value)
        {

            tbName.Enabled = value;
            tbEmail.Enabled = value;
            tbPhone.Enabled = value;
            tbStatus.Enabled = value;
            dtpDob.Enabled = value;
            dtpEndDate.Enabled = value;
            dtpMovingDate.Enabled = value;
            rbMale.Enabled = value;
            rbFemale.Enabled = value;
            tbPid.Enabled = value;
            btnCommit.Enabled = value;
        }
        private void set(String name, String email, String phone, String status, String dob, String EndDate, String movingDate, String gender, int propertyid)
        {
            visible(true);
            tbName.Text = name;
            tbEmail.Text = email;
            tbPhone.Text = phone;
            tbStatus.Text = status;
            dtpDob.Text = dob;
            dtpEndDate.Text = EndDate;
            dtpMovingDate.Text = movingDate;
            if (gender.ToUpper() == "MALE")
            {
                rbMale.Select();
            }
            else if (gender.ToUpper() == "FEMALE") rbFemale.Select();
            tbPid.Text = propertyid + "";
        }

        public UpdateTenant()
        {
            InitializeComponent();
            visible(false);
        }

        public UpdateTenant(int id)
        {
            InitializeComponent();
            visible(false);
            tbid.Text = "" + id;
            LoadTenantInfo();
        }
        private bool LoadTenantInfo()
        {
            if (!Business.Tenant.TenantExist(int.Parse(tbid.Text.Trim())))
            { iderror.Text = "Tenant with ID " + tbid.Text + " does not exist"; visible(false); return false; }
            
            SqlConnection conn = new SqlConnection(Business.App.ConnectionString);
            conn.Open();
            String query = "Select Tenantid,fullname,gender,DOB,PhoneNumber,emailaddress,moveindate,leaseEndDate,status,propertyid"
                            +" from tenant where Tenantid ='" + tbid.Text.Trim() + "' ";
            SqlCommand cmd = new SqlCommand(query, conn);
            SqlDataReader read = cmd.ExecuteReader();

            {

                if (read.Read())
                {
                    String fullname = read.GetString(1);
                    String gender = read.GetString(2);
                    String dob = read.GetDateTime(3).ToString();
                    int phone = read.GetInt32(4);
                    String email = read.GetString(5);
                    String movingDate = "Null";
                    if (read.GetDateTime(6) != null)
                    movingDate = read.GetDateTime(6).ToString();
                    String leaseEndDate = read.GetDateTime(7).ToString();
                    String status = read.GetString(8);
                    int propertyid = read.GetInt32(9);
                    visible(true);
                    set(fullname, email, phone + "", status, dob, leaseEndDate, movingDate, gender, propertyid);
                }
                iderror.Text ="";
            }
            return true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (tbid.Text == "") iderror.Text = "ID column Cannot be null";
            else
            {
                LoadTenantInfo();
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {

            try
            {
                String gender = "Female";
                if (rbMale.Checked)
                    gender = "Male";

                SqlConnection conn = new SqlConnection(Business.App.ConnectionString);
                String query = "update Tenant set Fullname=@fullname, gender=@gender,dob=@dob,phonenumber=@phonenumber,"
                                + "EmailAddress=@emailaddress,moveindate=@movingdate,LeaseEndDate=@leaseenddate , status=@status,"
                                + "propertyid=@propertyid where Tenantid=@Tid";
                SqlCommand cmd = new SqlCommand(query, conn);
                conn.Open();
                cmd.Parameters.AddWithValue("@fullname", tbName.Text.Trim());
                cmd.Parameters.AddWithValue("@gender", gender);
                cmd.Parameters.AddWithValue("@dob", dtpDob.Text);
                cmd.Parameters.AddWithValue("@phonenumber", tbPhone.Text.Trim());
                cmd.Parameters.AddWithValue("@emailaddress", tbEmail.Text.Trim());
                cmd.Parameters.AddWithValue("@movingdate", dtpMovingDate.Text);
                cmd.Parameters.AddWithValue("@leaseenddate", dtpEndDate.Text);
                cmd.Parameters.AddWithValue("@status", tbStatus.Text.Trim());
                cmd.Parameters.AddWithValue("@propertyid", tbPid.Text.Trim());
                cmd.Parameters.AddWithValue("@Tid", tbid.Text.Trim());

                cmd.ExecuteNonQuery();
                conn.Close();
                visible(false);
                viewToolStripMenuItem.PerformClick();


            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }

        private void viewToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Controls.Clear();
            this.Controls.Add(Business.Tenant.LoadTenentMainForm());
        }
    }
}
