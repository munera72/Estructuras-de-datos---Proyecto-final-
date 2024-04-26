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
    public partial class Page4 : Form
    {

        private string filePath;
        private List<string> imageFiles = new List<string>();

        public Page4(string operation_type, string filePath)
        {
            InitializeComponent();
            Page4Button3.Text = operation_type;
        }

        private void Page4Button3_Click(object sender, EventArgs e)
        {
            Page5 page5 = new Page5(filePath, Page4TextBox1.Text, Page4TextBox2.Text, imageFiles);
            page5.Show();
            this.Hide();
        }

        private void Page4Button1_Click(object sender, EventArgs e)
        {
            imageFiles.Add(Page4TextBox3.Text.Trim());
        }
    }
}
