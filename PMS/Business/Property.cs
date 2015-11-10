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

    }
}
