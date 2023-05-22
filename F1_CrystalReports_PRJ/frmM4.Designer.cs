
namespace F1_CrystalReports_PRJ
{
    partial class frmM4
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmM4));
            this.menuStripM4 = new System.Windows.Forms.MenuStrip();
            this.informationOfEachGPToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.classificationOfEachGPToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.summaryOfEachPilotToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.m3ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStripM4.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStripM4
            // 
            this.menuStripM4.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.informationOfEachGPToolStripMenuItem,
            this.classificationOfEachGPToolStripMenuItem,
            this.summaryOfEachPilotToolStripMenuItem});
            this.menuStripM4.Location = new System.Drawing.Point(0, 24);
            this.menuStripM4.Name = "menuStripM4";
            this.menuStripM4.Size = new System.Drawing.Size(910, 24);
            this.menuStripM4.TabIndex = 1;
            this.menuStripM4.Text = "menuStrip1";
            this.menuStripM4.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked);
            // 
            // informationOfEachGPToolStripMenuItem
            // 
            this.informationOfEachGPToolStripMenuItem.Name = "informationOfEachGPToolStripMenuItem";
            this.informationOfEachGPToolStripMenuItem.Size = new System.Drawing.Size(142, 20);
            this.informationOfEachGPToolStripMenuItem.Text = "Information of Each GP";
            this.informationOfEachGPToolStripMenuItem.Click += new System.EventHandler(this.informationOfEachGPToolStripMenuItem_Click);
            // 
            // classificationOfEachGPToolStripMenuItem
            // 
            this.classificationOfEachGPToolStripMenuItem.Name = "classificationOfEachGPToolStripMenuItem";
            this.classificationOfEachGPToolStripMenuItem.Size = new System.Drawing.Size(149, 20);
            this.classificationOfEachGPToolStripMenuItem.Text = "Classification of Each GP";
            this.classificationOfEachGPToolStripMenuItem.Click += new System.EventHandler(this.classificationOfEachGPToolStripMenuItem_Click);
            // 
            // summaryOfEachPilotToolStripMenuItem
            // 
            this.summaryOfEachPilotToolStripMenuItem.Name = "summaryOfEachPilotToolStripMenuItem";
            this.summaryOfEachPilotToolStripMenuItem.Size = new System.Drawing.Size(139, 20);
            this.summaryOfEachPilotToolStripMenuItem.Text = "Summary of Each Pilot";
            this.summaryOfEachPilotToolStripMenuItem.Click += new System.EventHandler(this.summaryOfEachPilotToolStripMenuItem_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.m3ToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(910, 24);
            this.menuStrip1.TabIndex = 3;
            this.menuStrip1.Text = "menuStripM42";
            // 
            // m3ToolStripMenuItem
            // 
            this.m3ToolStripMenuItem.Name = "m3ToolStripMenuItem";
            this.m3ToolStripMenuItem.Size = new System.Drawing.Size(36, 20);
            this.m3ToolStripMenuItem.Text = "M3";
            this.m3ToolStripMenuItem.Click += new System.EventHandler(this.m3ToolStripMenuItem_Click);
            // 
            // frmM4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(910, 492);
            this.Controls.Add(this.menuStripM4);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStripM4;
            this.Name = "frmM4";
            this.Text = "F1 Reports";
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.menuStripM4.ResumeLayout(false);
            this.menuStripM4.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip menuStripM4;
        private System.Windows.Forms.ToolStripMenuItem informationOfEachGPToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem classificationOfEachGPToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem summaryOfEachPilotToolStripMenuItem;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem m3ToolStripMenuItem;
    }
}

