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
            //GetElementName();
            //GetElementData();

        }

        private void btnSaveCsv_Click(object sender, EventArgs e)
        {

        }

        private void cmbBoxSelection1_SelectedIndexChanged(object sender, EventArgs e)
        {
            /*List<string> listSelection;

            cmbBoxSelection2.Enabled = true;
            cmbBoxSelection2.Items.Clear();
            cmbBoxSelection2.SelectedIndex = -1;

            switch (cmbBoxSelection1.SelectedIndex)
            {
                case 0:
                    listSelection = drivers;
                    break;
                case 1:
                    listSelection = grandPrix;
                    break;
                case 2:
                    listSelection = racingTeams;
                    break;
            }*/
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
            openFileDialog.Filter = "xml files (*.xml)|*.xml";
            openFileDialog.FilterIndex = 2;
            openFileDialog.RestoreDirectory = true;

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                //Get the path of specified file
                filePath = openFileDialog.FileName;
                txtBoxFile.Text = filePath;
                var fileStream = openFileDialog.OpenFile();
                using (StreamReader reader = new StreamReader(filePath))
                {
                    fileContent = reader.ReadToEnd();
                }

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
                List<string> elementXML = new List<string>();

                using (StreamReader reader = new StreamReader(filePath))
                {
                    string line;
                    while ((line = reader.ReadLine()) != null)
                    {
                        // Aquí puedes realizar cualquier operación o manipulación que necesites con las líneas del XML
                        // Por ejemplo, puedes agregar la línea a la lista directamente

                        elementXML.Add(line);
                    }
                }

                // Puedes utilizar la lista 'elementXML' como desees
                foreach (string line in elementXML)
                {
                    // Realiza alguna acción con cada línea del XML
                    Console.WriteLine(line);
                }

                lblMessageBox.Text = "File loaded successfully.";
            }
            catch (Exception ex)
            {
                lblMessageBox.Text = "An error occurred while loading the file: " + ex.Message;
            }

        }

        /*private void GetElementName(List<string> xmlContent)
        {
            int startIndex = xmlContent.IndexOf("<") + 1;
            int endIndex = xmlContent.IndexOf(">");
            if (startIndex != -1 && endIndex != -1 && endIndex > startIndex)
            {
                string elementName = xmlContent.Substring(startIndex, endIndex - startIndex);
                txtBoxInfo.Text = "Nombre del elemento: " + elementName;
            }
        }

        private void GetElementData(List<string> xmlContent)
        {
            int startIndex = xmlContent.IndexOf(">") + 1;
            int endIndex = xmlContent.LastIndexOf("<");
            if (startIndex != -1 && endIndex != -1 && endIndex > startIndex)
            {
                string elementData = xmlContent.Substring(startIndex, endIndex - startIndex);
                txtBoxInfo.Text = "Valor del elemento: " + elementData;
            }
            else
            {
                txtBoxInfo.Text = "Valor del elemento: ";
            }
        }*/
    }
}


/*Metodo compilar Datos
ciclar variable lista

 */