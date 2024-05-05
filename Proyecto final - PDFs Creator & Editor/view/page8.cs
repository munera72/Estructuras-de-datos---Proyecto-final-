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
    public partial class page8 : Form
    {
        private string filePath;
        private string operation_type;

        public page8(string operation_type, string filePath)
        {
            InitializeComponent();
            this.filePath = filePath;
            this.operation_type = operation_type;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Page4 page4 = new Page4(operation_type, filePath);
            page4.Show();
            this.Hide();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click_1(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            page9 page9 = new page9(operation_type, filePath);
            page9.Show();
            this.Hide();
        }

        private void GoBackButton_Click(object sender, EventArgs e)
        {
            Page3 page3 = new Page3(operation_type);
            page3.Show();
            this.Hide();
        }
    }
}
