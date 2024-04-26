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
        public Page3()
        {
            InitializeComponent();
        }

        private void CreatePdfButton_Click(object sender, EventArgs e)
        {

            if (string.IsNullOrEmpty(this.Page3TextBox1.Text.Trim()))
            {
                Debug.WriteLine("Please provide a pdf file or a folder path to create the pdf.");
            } else
            {
                Page4 page4 = new Page4("Create", this.Page3TextBox1.Text.Trim());
                page4.Show();
                this.Hide();
            }
        }

        private void EditPdfButton_Click(object sender, EventArgs e)
        {

            if (string.IsNullOrEmpty(this.Page3TextBox1.Text.Trim()))
            {
                Debug.WriteLine("Please provide a pdf file or a folder path to create the pdf.");
            }
            else
            {
                Page4 page4 = new Page4("Edit", this.Page3TextBox1.Text.Trim());
                page4.Show();
                this.Hide();
            }
        }
    }
}
