namespace PMS
{
    partial class ProjectTeamLogin
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
            this.btnFakSam = new System.Windows.Forms.Button();
            this.btnAkoji = new System.Windows.Forms.Button();
            this.btnEzzy = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnFakSam
            // 
            this.btnFakSam.Location = new System.Drawing.Point(318, 191);
            this.btnFakSam.Name = "btnFakSam";
            this.btnFakSam.Size = new System.Drawing.Size(75, 23);
            this.btnFakSam.TabIndex = 0;
            this.btnFakSam.Text = "FakSam";
            this.btnFakSam.UseVisualStyleBackColor = true;
            this.btnFakSam.Click += new System.EventHandler(this.btnFakSam_Click);
            // 
            // btnAkoji
            // 
            this.btnAkoji.Location = new System.Drawing.Point(97, 56);
            this.btnAkoji.Name = "btnAkoji";
            this.btnAkoji.Size = new System.Drawing.Size(184, 23);
            this.btnAkoji.TabIndex = 1;
            this.btnAkoji.Text = "Akoji";
            this.btnAkoji.UseVisualStyleBackColor = true;
            this.btnAkoji.Click += new System.EventHandler(this.btnAkoji_Click);
            // 
            // btnEzzy
            // 
            this.btnEzzy.Location = new System.Drawing.Point(97, 136);
            this.btnEzzy.Name = "btnEzzy";
            this.btnEzzy.Size = new System.Drawing.Size(184, 23);
            this.btnEzzy.TabIndex = 2;
            this.btnEzzy.Text = "Star-Lowd";
            this.btnEzzy.UseVisualStyleBackColor = true;
            this.btnEzzy.Click += new System.EventHandler(this.btnEzzy_Click);
            // 
            // ProjectTeamLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(413, 316);
            this.Controls.Add(this.btnEzzy);
            this.Controls.Add(this.btnAkoji);
            this.Controls.Add(this.btnFakSam);
            this.Name = "ProjectTeamLogin";
            this.Text = "ProjectTeamLogin";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnFakSam;
        private System.Windows.Forms.Button btnAkoji;
        private System.Windows.Forms.Button btnEzzy;
    }
}