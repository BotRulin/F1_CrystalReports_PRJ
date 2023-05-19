
namespace F1_CrystalReports_PRJ
{
    partial class frmMain
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
            this.btnM3 = new System.Windows.Forms.Button();
            this.btnM4 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnM3
            // 
            this.btnM3.Location = new System.Drawing.Point(105, 36);
            this.btnM3.Name = "btnM3";
            this.btnM3.Size = new System.Drawing.Size(170, 60);
            this.btnM3.TabIndex = 0;
            this.btnM3.Text = "M3";
            this.btnM3.UseVisualStyleBackColor = true;
            this.btnM3.Click += new System.EventHandler(this.btnM3_Click);
            // 
            // btnM4
            // 
            this.btnM4.Location = new System.Drawing.Point(105, 130);
            this.btnM4.Name = "btnM4";
            this.btnM4.Size = new System.Drawing.Size(170, 60);
            this.btnM4.TabIndex = 1;
            this.btnM4.Text = "M4";
            this.btnM4.UseVisualStyleBackColor = true;
            this.btnM4.Click += new System.EventHandler(this.btnM4_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(396, 254);
            this.Controls.Add(this.btnM4);
            this.Controls.Add(this.btnM3);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "frmMain";
            this.Text = "frmMain";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnM3;
        private System.Windows.Forms.Button btnM4;
    }
}