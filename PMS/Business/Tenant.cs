using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PMS.Business
{
    class Tenant
    {
        public string Fullname { get; set; }
        public string Gender { get; set; }
        public string DOB { get; set; }
        public double PhoneNumber { get; set; }
        public string Email { get; set; }
        public string MovingDate { get; set; }
        public string LeaseEndDate { get; set; }
        public string Status { get; set; }
        
        public static DataSet LoadTenants()
        {
            string TheCommand = "select Tenantid as 'Tenant ID', Fullname,Gender,PhoneNumber,EmailAddress,MoveInDate,LeaseEndDate,Status from Tenant";
            SqlConnection MyConnection = new SqlConnection(Business.App.ConnectionString);
            SqlDataAdapter MyDataAdapter = new SqlDataAdapter(TheCommand, MyConnection);

            DataSet MyDataSet = new DataSet();
            MyConnection.Open();

            MyDataAdapter.Fill(MyDataSet, "FilterTable");
            MyConnection.Close();
            return MyDataSet;
        }

        public static Form LoadTenantsForm()
        {
            Presentation.Tenants frm = new Presentation.Tenants();
            frm.BringToFront();
            frm.TopLevel = false;
            frm.Visible = true;
            frm.FormBorderStyle = FormBorderStyle.None;
            frm.Dock = DockStyle.Fill;
            return frm;
        }
        public static bool PropertyExist(int id)
        {
            SqlConnection conn = new SqlConnection(Business.App.ConnectionString);
            String query = "Select * from property";
            SqlCommand cmd = new SqlCommand(query, conn);
            conn.Open();
            SqlDataReader read = cmd.ExecuteReader();
            while (read.Read())
            {
                int getid = read.GetInt32(0);
                if (getid == id) { conn.Close(); return true; }
            }
            return false;
        }

        public static Form LoadModifyTenentForm(int id)
        {
            Presentation.UpdateTenant frm = new Presentation.UpdateTenant(id);
            frm.BringToFront();
            frm.TopLevel = false;
            frm.Visible = true;
            frm.FormBorderStyle = FormBorderStyle.None;
            frm.Dock = DockStyle.Fill;
            return frm;
        }

        public static Form LoadModifyTenentForm()
        {
            Presentation.UpdateTenant Mod = new Presentation.UpdateTenant();
            Mod.BringToFront();
            Mod.TopLevel = false;
            Mod.Visible = true;
            Mod.FormBorderStyle = FormBorderStyle.None;
            Mod.Dock = DockStyle.Fill;
            return Mod;
        }

        public static Form LoadTenentMainForm()
        {
            Presentation.Tenants tenantMain = new Presentation.Tenants();
            tenantMain.BringToFront();
            tenantMain.TopLevel = false;
            tenantMain.Visible = true;
            tenantMain.FormBorderStyle = FormBorderStyle.None;
            tenantMain.Dock = DockStyle.Fill;
            return tenantMain;
        }

        public static Form LoadAddTenentForm()
        {
            AddTenant add = new AddTenant();
            add.BringToFront();
            add.TopLevel = false;
            add.Visible = true;
            add.FormBorderStyle = FormBorderStyle.None;
            add.Dock = DockStyle.Fill;
            return add;
        }


        public static void InsertNewTenant(string fullName, string gender,string dob, string phone, string email,
            string MID,string LED,string status, int pid) {
           
            String query = "insert into Tenant(Fullname, Gender,DOB, PhoneNumber,EmailAddress,MoveinDate, LeaseEndDate,Status,PropertyID)"
                                        + "values(@fullname, @gender,@dob,@phonenumber,@emailaddress,@MoveInDate,@leaseenddate,"
                                       + "@status,@propertyid)";
            SqlConnection conn = new SqlConnection(Business.App.ConnectionString);
            SqlCommand cmd = new SqlCommand(query, conn);
            conn.Open();
            cmd.Parameters.AddWithValue("@fullname", fullName);
            cmd.Parameters.AddWithValue("@gender", gender);
            cmd.Parameters.AddWithValue("@dob", dob);
            cmd.Parameters.AddWithValue("@phonenumber", phone);
            cmd.Parameters.AddWithValue("@emailaddress", email);
            cmd.Parameters.AddWithValue("@MoveInDate", MID);
            cmd.Parameters.AddWithValue("@leaseenddate", LED);
            cmd.Parameters.AddWithValue("@status", status);
            cmd.Parameters.AddWithValue("@propertyid", pid);

            cmd.ExecuteNonQuery();
            conn.Close();

        }

        public static bool TenantExist(int id)
        {
            SqlConnection conn = new SqlConnection(Business.App.ConnectionString);
            SqlCommand cmd = new SqlCommand("Select * from Tenant where Tenantid = @Tid", conn);
            conn.Open();
            cmd.Parameters.AddWithValue("@Tid", id);
            SqlDataReader read = cmd.ExecuteReader();
            int tid = -1;
 
            while (read.Read())
            {
                 tid = read.GetInt32(0);
            }
            return tid == id;
            
        }
        

    }
}
