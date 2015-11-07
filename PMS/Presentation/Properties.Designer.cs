namespace PMS.Presentation
{
    partial class Properties
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
            this.DGVProperties = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.DGVProperties)).BeginInit();
            this.SuspendLayout();
            // 
            // DGVProperties
            // 
            this.DGVProperties.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGVProperties.Location = new System.Drawing.Point(0, 0);
            this.DGVProperties.Name = "DGVProperties";
            this.DGVProperties.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DGVProperties.Size = new System.Drawing.Size(967, 541);
            this.DGVProperties.TabIndex = 1;
            this.DGVProperties.MouseClick += new System.Windows.Forms.MouseEventHandler(this.DGVProperties_MouseClick);
            // 
            // Properties
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(967, 541);
            this.Controls.Add(this.DGVProperties);
            this.Name = "Properties";
            this.Text = "Properties";
            ((System.ComponentModel.ISupportInitialize)(this.DGVProperties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView DGVProperties;
    }
}