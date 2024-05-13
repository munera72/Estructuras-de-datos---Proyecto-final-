using Proyecto_final___PDFs_Creator___Editor.controller;
using Proyecto_final___PDFs_Creator___Editor.model;
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
    public partial class Page2 : Form
    {

        private List<Pdf> pdfs;
        private static PdfController controller;

        public Page2()
        {
            pdfs = GetPdfs();
            InitializeComponent();
        }

        private static PdfController GetController()
        {
            if (controller == null)
            {
                controller = new PdfController();
            }

            return controller;
        }

        private List<Pdf> GetPdfs()
        {
            return GetController().getAll();
        }


        private void Page2_Load(object sender, EventArgs e)
        {
            var pdfs = this.pdfs;

            dataGridView1.DataSource = pdfs;
        }
    }
}
