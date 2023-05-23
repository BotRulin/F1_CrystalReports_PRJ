using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

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
            SelectFile();
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            LoadFile();
        }

        private void btnSaveCsv_Click(object sender, EventArgs e)
        {

        }

        private void cmbBoxSelection1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cmbBoxSelection2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnSearch_Click(object sender, EventArgs e)
        {

        }

        private void btnAppend_Click(object sender, EventArgs e)
        {

        }

        private void btnStatistics_Click(object sender, EventArgs e)
        {

        }

        private void SelectFile()
        {
            // Declaration of Variables
            var filePath = string.Empty;
            var fileContent = string.Empty;

            //Shows the File Explorer to select the file
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.InitialDirectory = "c:\\";
            openFileDialog.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";
            openFileDialog.FilterIndex = 2;
            openFileDialog.RestoreDirectory = true;

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                //Get the path of specified file
                filePath = openFileDialog.FileName;
                txtBoxFile.Text = filePath;
                var fileStream = openFileDialog.OpenFile();
                StreamReader reader = new StreamReader(fileStream);
                fileContent = reader.ReadToEnd();
                lblMessageBox.Text = "Correctly File";
            }
            else
            {
                lblMessageBox.Text = "There's an error with the file.";
            }
        }

       
        private void LoadFile()
        {
            // Check if a file is already selected
            if (string.IsNullOrEmpty(txtBoxFile.Text))
            {
                lblMessageBox.Text = "Please select a file first.";
                return;
            }

            string filePath = txtBoxFile.Text;

            try
            {
                // Read the file content
                string fileContent = File.ReadAllText(filePath);

                // Display the content in the textbox
                txtBoxInfo.Text = fileContent;

                lblMessageBox.Text = "File loaded successfully.";
            }
            catch (Exception ex)
            {
                lblMessageBox.Text = "An error occurred while loading the file: " + ex.Message;
            }
        }
    }
}
