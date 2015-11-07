namespace PMS.Presentation
{
    partial class Tenants
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.DGVTenants = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.DGVTenants)).BeginInit();
            this.SuspendLayout();
            // 
            // DGVTenants
            // 
            this.DGVTenants.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGVTenants.Location = new System.Drawing.Point(0, -2);
            this.DGVTenants.Name = "DGVTenants";
            this.DGVTenants.Size = new System.Drawing.Size(967, 541);
            this.DGVTenants.TabIndex = 0;
            // 
            // Tenants
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(967, 541);
            this.Controls.Add(this.DGVTenants);
            this.Name = "Tenants";
            this.Text = "Tenants";
            ((System.ComponentModel.ISupportInitialize)(this.DGVTenants)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView DGVTenants;
    }
}