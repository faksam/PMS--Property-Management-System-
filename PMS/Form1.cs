using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PMS
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            me();
        }

        public void me()
        {
            string TheCommand = "select * from Manager";
            SqlConnection MyConnection = new SqlConnection("Data Source=FAKSAM;Initial Catalog=PMS;Integrated Security=True");
            SqlDataAdapter MyDataAdapter = new SqlDataAdapter(TheCommand, MyConnection);

            DataSet MyDataSet = new DataSet();
            MyConnection.Open();

            MyDataAdapter.Fill(MyDataSet, "FilterTable");
            MyConnection.Close();
            dataGridView1.DataSource = MyDataSet;
            dataGridView1.DataMember = "FilterTable";
            if (NetworkInterface.GetIsNetworkAvailable())
            {
                label1.Text = "Network";
            }
            else
                label1.Text = "No Network";
        }

        private void dataGridView1_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                ContextMenu m = new ContextMenu();
                m.MenuItems.Add(new MenuItem("Cut"));
                m.MenuItems.Add(new MenuItem("Copy"));
                m.MenuItems.Add(new MenuItem("Paste"));

                int currentMouseOverRow = dataGridView1.HitTest(e.X, e.Y).RowIndex;

                if (currentMouseOverRow >= 0)
                {
                    m.MenuItems.Add(new MenuItem(string.Format("Do something to row {0}", currentMouseOverRow.ToString())));
                }

                m.Show(dataGridView1, new Point(e.X, e.Y));

            }

        }
    }
}
