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
            this.components = new System.ComponentModel.Container();
            this.DGVTenants = new System.Windows.Forms.DataGridView();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.addANewTenantToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.modifyTenantToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteTenantToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.DGVTenants)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // DGVTenants
            // 
            this.DGVTenants.AllowUserToOrderColumns = true;
            this.DGVTenants.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DGVTenants.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.DGVTenants.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGVTenants.ContextMenuStrip = this.contextMenuStrip1;
            this.DGVTenants.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DGVTenants.Location = new System.Drawing.Point(0, 0);
            this.DGVTenants.MultiSelect = false;
            this.DGVTenants.Name = "DGVTenants";
            this.DGVTenants.ReadOnly = true;
            this.DGVTenants.RowHeadersWidth = 60;
            this.DGVTenants.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.DGVTenants.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DGVTenants.ShowEditingIcon = false;
            this.DGVTenants.Size = new System.Drawing.Size(967, 541);
            this.DGVTenants.TabIndex = 0;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addANewTenantToolStripMenuItem,
            this.modifyTenantToolStripMenuItem,
            this.deleteTenantToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(207, 70);
            // 
            // addANewTenantToolStripMenuItem
            // 
            this.addANewTenantToolStripMenuItem.Name = "addANewTenantToolStripMenuItem";
            this.addANewTenantToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.A)));
            this.addANewTenantToolStripMenuItem.Size = new System.Drawing.Size(206, 22);
            this.addANewTenantToolStripMenuItem.Text = " Add new Tenant";
            this.addANewTenantToolStripMenuItem.Click += new System.EventHandler(this.addANewTenantToolStripMenuItem_Click);
            // 
            // modifyTenantToolStripMenuItem
            // 
            this.modifyTenantToolStripMenuItem.Name = "modifyTenantToolStripMenuItem";
            this.modifyTenantToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.M)));
            this.modifyTenantToolStripMenuItem.Size = new System.Drawing.Size(206, 22);
            this.modifyTenantToolStripMenuItem.Text = "Modify Tenant";
            this.modifyTenantToolStripMenuItem.Click += new System.EventHandler(this.modifyTenantToolStripMenuItem_Click);
            // 
            // deleteTenantToolStripMenuItem
            // 
            this.deleteTenantToolStripMenuItem.Name = "deleteTenantToolStripMenuItem";
            this.deleteTenantToolStripMenuItem.Size = new System.Drawing.Size(206, 22);
            this.deleteTenantToolStripMenuItem.Text = "Delete Tenant";
            this.deleteTenantToolStripMenuItem.Click += new System.EventHandler(this.deleteTenantToolStripMenuItem_Click_1);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.panel1.Controls.Add(this.DGVTenants);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(967, 541);
            this.panel1.TabIndex = 2;
            // 
            // Tenants
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(967, 541);
            this.Controls.Add(this.panel1);
            this.Name = "Tenants";
            this.Text = "Tenants";
            ((System.ComponentModel.ISupportInitialize)(this.DGVTenants)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView DGVTenants;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem addANewTenantToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem modifyTenantToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteTenantToolStripMenuItem;
        private System.Windows.Forms.Panel panel1;
    }
}