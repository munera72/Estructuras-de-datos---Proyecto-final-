using Proyecto_final___PDFs_Creator___Editor.service;
using Proyecto_final___PDFs_Creator___Editor.util;
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
    public partial class Page4 : Form
    {

        private string filePath;
        private List<string> imageFiles = new List<string>();
        private string operation_type;

        public Page4(string operation_type, string filePath)
        {
            InitializeComponent();
            Page4Button3.Text = operation_type;
            this.filePath = filePath;
            this.operation_type = operation_type;
        }

        private void Page4Button3_Click(object sender, EventArgs e)
        {

            if (operation_type == "Crear")
            {
                Page5 page5 = new Page5(filePath, Page4TextBox1.Text, Page4TextBox2.Text, imageFiles);
                page5.Show();
                this.Hide();
            }
            else
            {
                try
                {
                    PdfService.AddContentPdfService(filePath, Page4TextBox1.Text, Page4TextBox2.Text, imageFiles);
                    Page6 page6 = new Page6();
                    page6.Show();
                    this.Hide();

                }
                catch (Exception ex)
                {
                    Debug.WriteLine(ex.Message);

                    Debug.WriteLine(ex.StackTrace);

                    Page7 page7 = new Page7();
                    page7.Show();
                    this.Hide();
                }
            }

        }

        private void Page4Button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog filepath = new OpenFileDialog();
            filepath.Multiselect = true;
            string[] rutasArchivos = new string[0];
            DialogResult result = filepath.ShowDialog();

            if (result == DialogResult.OK)
            {
                rutasArchivos = filepath.FileNames;
                Page4TextBox3.Text = string.Join(", ", rutasArchivos);
            }

            imageFiles.AddRange(rutasArchivos);
        }

        private void GoBackButton_Click(object sender, EventArgs e)
        {
            page8 page8 = new page8(operation_type, filePath);
            page8.Show();
            this.Hide();
        }
    }
}
