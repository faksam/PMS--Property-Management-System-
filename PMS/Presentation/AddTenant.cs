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
        public bool checkProperty(int id) {
            SqlConnection conn = new SqlConnection(Business.App.ConnectionString);
            String query = "Select * from property";
            SqlCommand cmd = new SqlCommand(query,conn);
            conn.Open();
            SqlDataReader read = cmd.ExecuteReader();
            while (read.Read())
            {
                int getid = read.GetInt32(0);
                if (getid == id) { conn.Close(); return true; }
            }
            return false;
        }
        private void clearError()
        {
            emailerror.Text = ""; nameerror.Text = ""; phoneerror.Text = ""; piderror.Text = "";
        }
        private void button1_Click(object sender, EventArgs e)
        {
            clearError();
            SqlConnection conn = new SqlConnection(Business.App.ConnectionString);
            try
            {
                bool checkEmail = true; bool checkName = true; bool checkPhone = true; bool checkP = true;
                {
                   
                    if (!tbEmail.Text.Contains('@')) { emailerror.Text = "Unrecorgnised Server Domain Name"; checkEmail = false; }
                    if (tbName.Text.Trim() == "") { nameerror.Text = "Name column Cannot be Null"; checkName = false; }
                    if (tbPhone.Text.Trim() == "") { phoneerror.Text = "Phone Number Colmn Cannot be Null"; checkPhone = false; }
                    if (!checkProperty(int.Parse(tbPid.Text.Trim()))) { checkP = false; piderror.Text = "Property ID does not Exist"; }
                    if (tbPid.Text == "") { piderror.Text = "Property ID column cannot be Null"; }
                }

                if (checkEmail && checkPhone && checkName && checkP)
                {
                    try
                    {
                        String gender = "Female";
                        if (rbMale.Checked)
                            gender = "Male";

                        String query = "insert into Tenant(Fullname, Gender,DOB, PhoneNumber,EmailAddress,MovingDate, LeaseEndDate,Status,PropertyID)"
                                        + "values(@fullname, @gender,@dob,@phonenumber,@emailaddress,@MoveInDate,@leaseenddate,@status,@propertyid)";
                        SqlCommand cmd = new SqlCommand(query, conn);
                        conn.Open();
                        cmd.Parameters.AddWithValue("@fullname", tbName.Text.Trim());
                        cmd.Parameters.AddWithValue("@gender", gender);
                        cmd.Parameters.AddWithValue("@dob", dtpDob.Text);
                        cmd.Parameters.AddWithValue("@phonenumber", tbPhone.Text.Trim());
                        cmd.Parameters.AddWithValue("@emailaddress", tbEmail.Text.Trim());
                        cmd.Parameters.AddWithValue("@MoveInDate", dtpMovingDate.Text);
                        cmd.Parameters.AddWithValue("@leaseenddate", dtpEndDate.Text);
                        cmd.Parameters.AddWithValue("@status", tbStatus.Text.Trim());
                        cmd.Parameters.AddWithValue("@propertyid", tbPid.Text.Trim());

                        cmd.ExecuteNonQuery();
                        conn.Close();
                        btnClear.PerformClick();
                        viewToolStripMenuItem.PerformClick();
                    }
                    catch (Exception ex) { MessageBox.Show(""+ex.Message); }
                }

            }
            catch { 
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            clearError();
            //clearError();
            tbName.Text = "";
            tbEmail.Text = "";
            tbPhone.Text = "";
            tbPid.Text = "";
            tbStatus.Text = "";
        }

        private void viewToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Panel display = new Panel();
            Presentation.Tenants tenant = new Presentation.Tenants();
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
