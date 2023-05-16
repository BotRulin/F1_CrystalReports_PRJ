using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CrystalDecisions.CrystalReports.Engine;
using CrystalDecisions.Shared;
using CrystalDecisions.Windows.Forms;

namespace F1_CrystalReports_PRJ
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void informationOfEachGPToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ReportDocument reporte = new ReportDocument();
            reporte.Load(@"C:\Users\rexpo\OneDrive - INSPECTORIA SALESIANA MARIA AUXILIADORA\Grado Superior\S1AM\PRJ\2a Setmana\M4 Crystal Reports\F1_CrystalReports_PRJ\F1_CrystalReports_PRJ\rptExercici1.rpt");
            
            CrystalReportViewer crystalReportViewer = new CrystalReportViewer();
            crystalReportViewer.ReportSource = reporte;

            // Muestra el reporte en ventana
            Form form = new Form();
            form.MdiParent = this;
            form.Controls.Add(crystalReportViewer);
            crystalReportViewer.Dock = DockStyle.Fill;
            form.Show();
        }

        private void classificationOfEachGPToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ReportDocument reporte = new ReportDocument();
            reporte.Load(@"C:\Users\rexpo\OneDrive - INSPECTORIA SALESIANA MARIA AUXILIADORA\Grado Superior\S1AM\PRJ\2a Setmana\M4 Crystal Reports\F1_CrystalReports_PRJ\F1_CrystalReports_PRJ\rptExercici2.rpt");

            CrystalReportViewer crystalReportViewer = new CrystalReportViewer();
            crystalReportViewer.ReportSource = reporte;

            // Muestra el reporte en ventana
            Form form = new Form();
            form.MdiParent = this;
            form.Controls.Add(crystalReportViewer);
            crystalReportViewer.Dock = DockStyle.Fill;
            form.Show();
        }

        private void summaryOfEachPilotToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ReportDocument reporte = new ReportDocument();
            reporte.Load(@"C:\Users\rexpo\OneDrive - INSPECTORIA SALESIANA MARIA AUXILIADORA\Grado Superior\S1AM\PRJ\2a Setmana\M4 Crystal Reports\F1_CrystalReports_PRJ\F1_CrystalReports_PRJ\rptExercici3.rpt");

            CrystalReportViewer crystalReportViewer = new CrystalReportViewer();
            crystalReportViewer.ReportSource = reporte;

            // Muestra el reporte en ventana
            Form form = new Form();
            form.MdiParent = this;
            form.Controls.Add(crystalReportViewer);
            crystalReportViewer.Dock = DockStyle.Fill;
            form.Show();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {

        }
    }
}
