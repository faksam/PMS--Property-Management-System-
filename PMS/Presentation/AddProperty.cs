﻿using System;
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
    public partial class AddProperty : Form
    {
        public AddProperty()
        {
            InitializeComponent();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Controls.Clear();
            this.Controls.Add(Business.Property.LoadPropertiesForm());
        }

        private void btnProperty_Click(object sender, EventArgs e)
        {
            //Save propertydetails to database
            Business.Property.AddProperty(txtAddress.ToString(), txtPrice.ToString(), cbPropertyType.ToString(),
                                        txtSize.ToString(), txtDescription.ToString(), cbStatus.ToString()
                                        );
            this.Controls.Clear();
            this.Controls.Add(Business.Property.LoadPropertiesForm());
        }
    }
}
