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
       
    }
}
