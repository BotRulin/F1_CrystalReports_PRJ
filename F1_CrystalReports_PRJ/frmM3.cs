using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace F1_CrystalReports_PRJ
{
    public partial class frmM3 : Form
    {
        public frmM3()
        {
            InitializeComponent();
        }

        private void m4ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmM4 form = new frmM4();
            form.Show();
            // Oculta el formulario principal
            Hide();
        }
    }
}
