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
    class Property
    {
        public string Address { get; set; }
        public double Price { get; set; }
        public string ProperityType { get; set; }
        public int Size { get; set; }
        public string Discription { get; set; }
        public string Status { get; set; }
        public string Building { get; set; }
        public string LivingArea { get; set; }
        public int NumberOfRooms { get; set; }
        public int NumberOfBathroom { get; set; }
        public string Imagefolder { get; set; }

        public static DataSet LoadProperties()
        {
            string TheCommand = "select PropertyType,Address,Status from property";
            SqlConnection MyConnection = new SqlConnection(Business.App.ConnectionString);
            SqlDataAdapter MyDataAdapter = new SqlDataAdapter(TheCommand, MyConnection);

            DataSet MyDataSet = new DataSet();
            MyConnection.Open();

            MyDataAdapter.Fill(MyDataSet, "FilterTable");
            MyConnection.Close();
            return MyDataSet;
        }
        public static void AddProperty(string Address,string Price,string PropertyType,string Size,
                                        string Description,string Status)
        {
            SqlConnection MyConnection = new SqlConnection(Business.App.ConnectionString);
            String query = "insert into Property(Address, Price,PropertyType,Size,Description,Status)"
                                        + "values(@address, @price,@propertyType,@size,@description,@status)";
            SqlCommand cmd = new SqlCommand(query, MyConnection);
            MyConnection.Open();
            cmd.Parameters.AddWithValue("@address", Address);
            cmd.Parameters.AddWithValue("@price", Price);
            cmd.Parameters.AddWithValue("@propertyType", PropertyType);
            cmd.Parameters.AddWithValue("@size", Size);
            cmd.Parameters.AddWithValue("@description", Description);
            cmd.Parameters.AddWithValue("@status", Status);
            cmd.ExecuteNonQuery();
            MyConnection.Close();


/*
            SqlConnection MyConnection = new SqlConnection(Business.App.ConnectionString);
            SqlCommand MyCommand;
            MyConnection.Open();
            MyCommand = new SqlCommand(PassedCommands, MyConnection);
            MyCommand.ExecuteNonQuery();
            MyConnection.Close();
              
             */
        }
        public static void AddNewTenant()
        {

        }
        public static void ViewCurrentTenants()
        {

        }
        public static void UpdateProperty(string Address, string Price, string PropertyType, string Size,
                                        string Description, string Status
         )
        {
            
        }
        public static void DeleteProperty()
        {

        }
        public static Form LoadPropertiesForm()
        {
            Presentation.Properties frm = new Presentation.Properties();
            frm.BringToFront();
            frm.TopLevel = false;
            frm.Visible = true;
            frm.FormBorderStyle = FormBorderStyle.None;
            frm.Dock = DockStyle.Fill;
            return frm;
        }
        public static Form LoadPropertyDetails()
        {
            Presentation.PropertyDetails pd = new Presentation.PropertyDetails();
            pd.BringToFront();
            pd.TopLevel = false;
            pd.Visible = true;
            pd.FormBorderStyle = FormBorderStyle.None;
            pd.Dock = DockStyle.Fill;
            return pd;
        }
        public static Form LoadAddPropertyForm()
        {
            Presentation.AddProperty frm = new Presentation.AddProperty();
            frm.BringToFront();
            frm.TopLevel = false;
            frm.Visible = true;
            frm.FormBorderStyle = FormBorderStyle.None;
            frm.Dock = DockStyle.Fill;
            return frm;
        }


        internal static Control LoadUpdatePropertyForm()
        {
            Presentation.UpdateProperty frm = new Presentation.UpdateProperty();
            frm.BringToFront();
            frm.TopLevel = false;
            frm.Visible = true;
            frm.FormBorderStyle = FormBorderStyle.None;
            frm.Dock = DockStyle.Fill;
            return frm;
        }
    }
}
