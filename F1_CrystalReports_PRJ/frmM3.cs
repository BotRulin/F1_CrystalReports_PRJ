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

        //This method open the Windows File Explorer and takes the Path of the file you pick
        private void btnDots_Click(object sender, EventArgs e)
        {
            // Declaration of Variables
            var fileContent = string.Empty;
            var filePath = string.Empty;

            //Shows the File Explorer to select the file
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.InitialDirectory = "c:\\";
            openFileDialog.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";
            openFileDialog.FilterIndex = 2;
            openFileDialog.RestoreDirectory = true;

            if(openFileDialog.ShowDialog() == DialogResult.OK)
            {
                //Get the path of specified file
                filePath = openFileDialog.FileName;

                txtBoxFile.Text = filePath;
            }
        }


    }
}
