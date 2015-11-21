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

namespace PMS.Presentation
{
    public partial class Properties : Form
    {
        public Properties()
        {
            InitializeComponent();
            LoadData();
        }

        public void LoadData()
        {
            
            DGVProperties.DataSource = Business.Property.LoadProperties();
            DGVProperties.DataMember = "FilterTable";
            //dataGridView1.Columns[3].Width = 660;
        }


        private void DGVProperties_MouseClick(object sender, MouseEventArgs e)
        {
            try
            {
                if (e.Button == MouseButtons.Right)
                {
                    ContextMenu m = new ContextMenu();
                    m.MenuItems.Add(new MenuItem("Cut"));
                    m.MenuItems.Add(new MenuItem("Copy"));
                    m.MenuItems.Add(new MenuItem("Paste"));

                    m.MenuItems[0].Click += DGVProperties_Cut;
                    int currentMouseOverRow = DGVProperties.HitTest(e.X, e.Y).RowIndex;

                    if (currentMouseOverRow >= 0)
                    {
                        m.MenuItems.Add(new MenuItem(string.Format("View property details", currentMouseOverRow.ToString())));
                        m.MenuItems.Add(new MenuItem(string.Format("Edit this property", currentMouseOverRow.ToString())));
                        m.MenuItems.Add(new MenuItem(string.Format("Delete this property", currentMouseOverRow.ToString())));
                        m.MenuItems.Add(new MenuItem(string.Format("Do something to row {0}", currentMouseOverRow.ToString())));
                        m.MenuItems.Add(new MenuItem(string.Format("Do something to row {0}", currentMouseOverRow.ToString())));
                        m.MenuItems.Add(new MenuItem(string.Format("Do something to row {0}", currentMouseOverRow.ToString())));

                    }
                    m.MenuItems[3].Click += DGVProperties_Details;
                    m.MenuItems[4].Click += DGVProperties_Edit;
                    m.MenuItems[5].Click += DGVProperties_Delete;

                    m.Show(DGVProperties, new Point(e.X, e.Y));

                }
            }catch
            { 
            
            }
        }

        private void DGVProperties_Details(object sender, EventArgs e)
        {
            this.Controls.Clear();
            this.Controls.Add(Business.Property.LoadPropertyDetails());
        }

        private void DGVProperties_Delete(object sender, EventArgs e)
        {
            //Call property delete
            Business.Property.DeleteProperty();
        }

        private void DGVProperties_Edit(object sender, EventArgs e)
        {
            this.Controls.Clear();
            this.Controls.Add(Business.Property.LoadUpdatePropertyForm());
        }

        void DGVProperties_Cut(object sender, EventArgs e)
        {
            //throw new NotImplementedException();
            MessageBox.Show("You clicked cut");
        }
    }
}
