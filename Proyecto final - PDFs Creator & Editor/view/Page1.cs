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
    public partial class Page1 : Form
    {
        public Page1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Page2 f1 = new Page2();
            f1.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Page4 f1 = new Page4();
            f1.Show();
        }
    }
}
