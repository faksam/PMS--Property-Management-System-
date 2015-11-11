using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PMS.Presentation
{
    public partial class PropertyDetails : Form
    {
        public PropertyDetails()
        {
            InitializeComponent();
        }


        private void btnProperty_Click(object sender, EventArgs e)
        {
            //Save propertydetails to database

            this.Controls.Clear();
            this.Controls.Add(Business.Property.LoadUpdatePropertyForm());
        }

        private void btnBackToList_Click(object sender, EventArgs e)
        {
            this.Controls.Clear();
            this.Controls.Add(Business.Property.LoadPropertiesForm());
        }
    }
}
