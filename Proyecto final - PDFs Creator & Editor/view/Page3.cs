using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto_final___PDFs_Creator___Editor
{
    public partial class Page3 : Form
    {

        private string operationType;

        public Page3(string operationType)
        {
            InitializeComponent();
            this.operationType = operationType;

            if (operationType == "Crear")
            {
                this.Page3Button1.Text = "Crear";
            } else
            {
                this.Page3Button1.Text = "Editar";
            }

        }



        private void CreatePdfButton_Click(object sender, EventArgs e)
        {

            if (string.IsNullOrEmpty(this.textdirectory.Text.Trim()))
            {
                Debug.WriteLine("Please provide a pdf file or a folder path to create the pdf.");
            }
            else
            {   
                if (operationType == "Crear")
                {
                    Page4 page4 = new Page4("Crear", this.textdirectory.Text.Trim());
                    page4.Show();
                    this.Hide();
                } else
                {
                    Page4 page4 = new Page4("Editar", this.textdirectory.Text.Trim());
                    page4.Show();
                    this.Hide();
                }
            }
        }


        private void btnopen_Click(object sender, EventArgs e)
        {

            if(operationType == "Editar")
            {
                OpenFileDialog filepath = new OpenFileDialog();
                DialogResult result = filepath.ShowDialog();
                if (result == DialogResult.OK)
                {
                    textdirectory.Text = Path.GetFullPath(filepath.FileName);
                }

            } else
            {
                FolderBrowserDialog filepath = new FolderBrowserDialog();
                DialogResult result = filepath.ShowDialog();
                if (result == DialogResult.OK)
                {
                    textdirectory.Text = filepath.SelectedPath;
                }
            }


        }
    }
}
