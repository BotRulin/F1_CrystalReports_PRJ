
namespace F1_CrystalReports_PRJ
{
    partial class frmM3
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
            this.menuStripM3 = new System.Windows.Forms.MenuStrip();
            this.m4ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lblFile = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.txtBoxFile = new System.Windows.Forms.TextBox();
            this.btnDots = new System.Windows.Forms.Button();
            this.btnLoad = new System.Windows.Forms.Button();
            this.btnSaveCsv = new System.Windows.Forms.Button();
            this.cmbBoxSelection1 = new System.Windows.Forms.ComboBox();
            this.cmbBoxSelection2 = new System.Windows.Forms.ComboBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.btnAppend = new System.Windows.Forms.Button();
            this.btnStatistics = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtBoxInfo = new System.Windows.Forms.TextBox();
            this.lblMessageBox = new System.Windows.Forms.Label();
            this.menuStripM3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStripM3
            // 
            this.menuStripM3.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.m4ToolStripMenuItem});
            this.menuStripM3.Location = new System.Drawing.Point(0, 0);
            this.menuStripM3.Name = "menuStripM3";
            this.menuStripM3.Size = new System.Drawing.Size(662, 24);
            this.menuStripM3.TabIndex = 0;
            this.menuStripM3.Text = "menuStripM3";
            // 
            // m4ToolStripMenuItem
            // 
            this.m4ToolStripMenuItem.Name = "m4ToolStripMenuItem";
            this.m4ToolStripMenuItem.Size = new System.Drawing.Size(36, 20);
            this.m4ToolStripMenuItem.Text = "M4";
            this.m4ToolStripMenuItem.Click += new System.EventHandler(this.m4ToolStripMenuItem_Click);
            // 
            // lblFile
            // 
            this.lblFile.AutoSize = true;
            this.lblFile.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblFile.Location = new System.Drawing.Point(51, 155);
            this.lblFile.Name = "lblFile";
            this.lblFile.Size = new System.Drawing.Size(38, 17);
            this.lblFile.TabIndex = 1;
            this.lblFile.Text = "File: ";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::F1_CrystalReports_PRJ.Properties.Resources.formula_1_logo_200;
            this.pictureBox1.Location = new System.Drawing.Point(34, 41);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(147, 82);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // txtBoxFile
            // 
            this.txtBoxFile.Location = new System.Drawing.Point(107, 155);
            this.txtBoxFile.Name = "txtBoxFile";
            this.txtBoxFile.Size = new System.Drawing.Size(294, 20);
            this.txtBoxFile.TabIndex = 3;
            // 
            // btnDots
            // 
            this.btnDots.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnDots.Location = new System.Drawing.Point(434, 155);
            this.btnDots.Name = "btnDots";
            this.btnDots.Size = new System.Drawing.Size(61, 23);
            this.btnDots.TabIndex = 4;
            this.btnDots.Text = "...";
            this.btnDots.UseVisualStyleBackColor = true;
            this.btnDots.Click += new System.EventHandler(this.btnDots_Click);
            // 
            // btnLoad
            // 
            this.btnLoad.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.btnLoad.Location = new System.Drawing.Point(521, 155);
            this.btnLoad.Name = "btnLoad";
            this.btnLoad.Size = new System.Drawing.Size(75, 23);
            this.btnLoad.TabIndex = 5;
            this.btnLoad.Text = "Load";
            this.btnLoad.UseVisualStyleBackColor = true;
            this.btnLoad.Click += new System.EventHandler(this.btnLoad_Click);
            // 
            // btnSaveCsv
            // 
            this.btnSaveCsv.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.btnSaveCsv.Location = new System.Drawing.Point(434, 210);
            this.btnSaveCsv.Name = "btnSaveCsv";
            this.btnSaveCsv.Size = new System.Drawing.Size(162, 23);
            this.btnSaveCsv.TabIndex = 6;
            this.btnSaveCsv.Text = "Save as CSV";
            this.btnSaveCsv.UseVisualStyleBackColor = true;
            this.btnSaveCsv.Click += new System.EventHandler(this.btnSaveCsv_Click);
            // 
            // cmbBoxSelection1
            // 
            this.cmbBoxSelection1.FormattingEnabled = true;
            this.cmbBoxSelection1.Items.AddRange(new object[] {
            "Grand Prix",
            "Racing Team",
            "Drivers"});
            this.cmbBoxSelection1.Location = new System.Drawing.Point(54, 223);
            this.cmbBoxSelection1.Name = "cmbBoxSelection1";
            this.cmbBoxSelection1.Size = new System.Drawing.Size(121, 21);
            this.cmbBoxSelection1.TabIndex = 7;
            this.cmbBoxSelection1.SelectedIndexChanged += new System.EventHandler(this.cmbBoxSelection1_SelectedIndexChanged);
            // 
            // cmbBoxSelection2
            // 
            this.cmbBoxSelection2.FormattingEnabled = true;
            this.cmbBoxSelection2.Location = new System.Drawing.Point(280, 223);
            this.cmbBoxSelection2.Name = "cmbBoxSelection2";
            this.cmbBoxSelection2.Size = new System.Drawing.Size(121, 21);
            this.cmbBoxSelection2.TabIndex = 8;
            this.cmbBoxSelection2.SelectedIndexChanged += new System.EventHandler(this.cmbBoxSelection2_SelectedIndexChanged);
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(434, 285);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 23);
            this.btnSearch.TabIndex = 9;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // btnAppend
            // 
            this.btnAppend.Location = new System.Drawing.Point(521, 284);
            this.btnAppend.Name = "btnAppend";
            this.btnAppend.Size = new System.Drawing.Size(75, 23);
            this.btnAppend.TabIndex = 10;
            this.btnAppend.Text = "Append";
            this.btnAppend.UseVisualStyleBackColor = true;
            this.btnAppend.Click += new System.EventHandler(this.btnAppend_Click);
            // 
            // btnStatistics
            // 
            this.btnStatistics.Location = new System.Drawing.Point(434, 419);
            this.btnStatistics.Name = "btnStatistics";
            this.btnStatistics.Size = new System.Drawing.Size(162, 23);
            this.btnStatistics.TabIndex = 11;
            this.btnStatistics.Text = "Statistics";
            this.btnStatistics.UseVisualStyleBackColor = true;
            this.btnStatistics.Click += new System.EventHandler(this.btnStatistics_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Cooper Black", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(255, 60);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(341, 31);
            this.label1.TabIndex = 13;
            this.label1.Text = "Grand Prix Information";
            // 
            // txtBoxInfo
            // 
            this.txtBoxInfo.Location = new System.Drawing.Point(54, 285);
            this.txtBoxInfo.Multiline = true;
            this.txtBoxInfo.Name = "txtBoxInfo";
            this.txtBoxInfo.Size = new System.Drawing.Size(347, 157);
            this.txtBoxInfo.TabIndex = 14;
            // 
            // lblMessageBox
            // 
            this.lblMessageBox.AutoSize = true;
            this.lblMessageBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblMessageBox.Location = new System.Drawing.Point(12, 468);
            this.lblMessageBox.Name = "lblMessageBox";
            this.lblMessageBox.Size = new System.Drawing.Size(0, 17);
            this.lblMessageBox.TabIndex = 16;
            // 
            // frmM3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(662, 494);
            this.Controls.Add(this.lblMessageBox);
            this.Controls.Add(this.txtBoxInfo);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnStatistics);
            this.Controls.Add(this.btnAppend);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.cmbBoxSelection2);
            this.Controls.Add(this.cmbBoxSelection1);
            this.Controls.Add(this.btnSaveCsv);
            this.Controls.Add(this.btnLoad);
            this.Controls.Add(this.btnDots);
            this.Controls.Add(this.txtBoxFile);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lblFile);
            this.Controls.Add(this.menuStripM3);
            this.MainMenuStrip = this.menuStripM3;
            this.Name = "frmM3";
            this.Text = "frmM3";
            this.menuStripM3.ResumeLayout(false);
            this.menuStripM3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStripM3;
        private System.Windows.Forms.ToolStripMenuItem m4ToolStripMenuItem;
        private System.Windows.Forms.Label lblFile;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox txtBoxFile;
        private System.Windows.Forms.Button btnDots;
        private System.Windows.Forms.Button btnLoad;
        private System.Windows.Forms.Button btnSaveCsv;
        private System.Windows.Forms.ComboBox cmbBoxSelection1;
        private System.Windows.Forms.ComboBox cmbBoxSelection2;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Button btnAppend;
        private System.Windows.Forms.Button btnStatistics;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtBoxInfo;
        private System.Windows.Forms.Label lblMessageBox;
    }
}