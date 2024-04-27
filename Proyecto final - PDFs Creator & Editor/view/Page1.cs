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
            Page3 f1 = new Page3("Crear");
            f1.Show();
            this.Hide(); // Hide the current form

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Page3 f1 = new Page3("Editar");
            f1.Show();
            this.Hide(); // Hide the current form
        }
    }
}
