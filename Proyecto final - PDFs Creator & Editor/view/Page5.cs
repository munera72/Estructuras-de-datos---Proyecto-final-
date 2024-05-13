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
    public partial class Page5 : Form
    {

        private string filePath;
        private string title;
        private string content;
        private List<string> imagesList;
        private bool isHtml = false;

        public Page5(string filePath, string title, string content, List<string> imagesList)
        {
            InitializeComponent();
            this.filePath = filePath;
            this.title = title;
            this.content = content;
            this.imagesList = imagesList;
        }

        public Page5(string filePath, string content, bool isHtml)
        {
            InitializeComponent();
            this.filePath = filePath;
            this.content = content;
            this.isHtml = isHtml;

        }

        private void CreatePdfButton_Click(object sender, EventArgs e)
        {
            try
            {

                if (isHtml)
                {
                    PdfService.CreatePdfService(filePath + "\\" + Page5TextBox1.Text.Trim() + ".pdf", content);
                    Page6 page6 = new Page6();
                    page6.Show();
                    this.Hide();

                } else
                {
                    PdfService.CreatePdfService(filePath + "\\" + Page5TextBox1.Text.Trim() + ".pdf", title, content, imagesList);
                    Page6 page6 = new Page6();
                    page6.Show();
                    this.Hide();
                }

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

        private void GoBackButton_Click(object sender, EventArgs e)
        {
          if (isHtml)
            {
                page9 page9 = new page9("Crear", filePath);
                page9.Show();
                this.Hide();
            }
          else
            {
                Page4 page4 = new Page4("Crear", filePath);
                page4.Show();
                this.Hide();
            }
        }
    }
}
