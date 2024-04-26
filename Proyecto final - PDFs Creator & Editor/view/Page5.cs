using Proyecto_final___PDFs_Creator___Editor.util;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
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

        public Page5(string filePath, string title, string content, List<string> imagesList)
        {
            InitializeComponent();
            this.filePath = filePath;
            this.title = title;
            this.content = content;
            this.imagesList = imagesList;
        }

        private void CreatePdfButton_Click(object sender, EventArgs e)
        {
            PdfUtils.CreatePdfFile(filePath + Page5TextBox1.Text, title, content, imagesList);
        }
    }
}
