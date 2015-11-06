namespace PMS
{
    partial class PMS
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
            this.tbpSetting = new System.Windows.Forms.TabPage();
            this.tbpTenant = new System.Windows.Forms.TabPage();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.tbpProperty = new System.Windows.Forms.TabPage();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.tbpSummary = new System.Windows.Forms.TabPage();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.tbcPMS = new System.Windows.Forms.TabControl();
            this.tbpTenant.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.tbpProperty.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.tbpSummary.SuspendLayout();
            this.tbcPMS.SuspendLayout();
            this.SuspendLayout();
            // 
            // tbpSetting
            // 
            this.tbpSetting.Location = new System.Drawing.Point(4, 27);
            this.tbpSetting.Name = "tbpSetting";
            this.tbpSetting.Padding = new System.Windows.Forms.Padding(3);
            this.tbpSetting.Size = new System.Drawing.Size(1023, 586);
            this.tbpSetting.TabIndex = 3;
            this.tbpSetting.Text = "Settings";
            this.tbpSetting.UseVisualStyleBackColor = true;
            // 
            // tbpTenant
            // 
            this.tbpTenant.Controls.Add(this.dataGridView2);
            this.tbpTenant.Location = new System.Drawing.Point(4, 27);
            this.tbpTenant.Name = "tbpTenant";
            this.tbpTenant.Padding = new System.Windows.Forms.Padding(3);
            this.tbpTenant.Size = new System.Drawing.Size(1023, 586);
            this.tbpTenant.TabIndex = 2;
            this.tbpTenant.Text = "Tenant";
            this.tbpTenant.UseVisualStyleBackColor = true;
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(3, 0);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(1024, 588);
            this.dataGridView2.TabIndex = 0;
            // 
            // tbpProperty
            // 
            this.tbpProperty.Controls.Add(this.dataGridView1);
            this.tbpProperty.Location = new System.Drawing.Point(4, 27);
            this.tbpProperty.Name = "tbpProperty";
            this.tbpProperty.Padding = new System.Windows.Forms.Padding(3);
            this.tbpProperty.Size = new System.Drawing.Size(1023, 586);
            this.tbpProperty.TabIndex = 1;
            this.tbpProperty.Text = "Properties";
            this.tbpProperty.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(1023, 592);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.dataGridView1_MouseClick);
            // 
            // tbpSummary
            // 
            this.tbpSummary.Controls.Add(this.label1);
            this.tbpSummary.Controls.Add(this.button1);
            this.tbpSummary.Location = new System.Drawing.Point(4, 27);
            this.tbpSummary.Name = "tbpSummary";
            this.tbpSummary.Padding = new System.Windows.Forms.Padding(3);
            this.tbpSummary.Size = new System.Drawing.Size(1023, 586);
            this.tbpSummary.TabIndex = 0;
            this.tbpSummary.Text = "Summary";
            this.tbpSummary.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(170, 126);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(104, 68);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "label1";
            // 
            // tbcPMS
            // 
            this.tbcPMS.Appearance = System.Windows.Forms.TabAppearance.FlatButtons;
            this.tbcPMS.Controls.Add(this.tbpSummary);
            this.tbcPMS.Controls.Add(this.tbpProperty);
            this.tbcPMS.Controls.Add(this.tbpTenant);
            this.tbcPMS.Controls.Add(this.tbpSetting);
            this.tbcPMS.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbcPMS.Location = new System.Drawing.Point(12, 83);
            this.tbcPMS.Name = "tbcPMS";
            this.tbcPMS.Padding = new System.Drawing.Point(10, 3);
            this.tbcPMS.SelectedIndex = 0;
            this.tbcPMS.Size = new System.Drawing.Size(1031, 617);
            this.tbcPMS.TabIndex = 0;
            // 
            // PMS
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1055, 739);
            this.Controls.Add(this.tbcPMS);
            this.Name = "PMS";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Property Management System";
            this.tbpTenant.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.tbpProperty.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.tbpSummary.ResumeLayout(false);
            this.tbpSummary.PerformLayout();
            this.tbcPMS.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabPage tbpSetting;
        private System.Windows.Forms.TabPage tbpTenant;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.TabPage tbpProperty;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TabPage tbpSummary;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TabControl tbcPMS;

    }
}

