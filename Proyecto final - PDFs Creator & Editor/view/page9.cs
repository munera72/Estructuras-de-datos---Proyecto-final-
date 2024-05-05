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
    public partial class page9 : Form
    {
        private string filePath;
        private string operation_type;
        public page9(string operation_type, string filePath)
        {
            InitializeComponent();
            this.filePath = filePath;
            this.operation_type = operation_type;
        }

        private void GoBackButton_Click(object sender, EventArgs e)
        {
            page8 page8 = new page8(operation_type,filePath);
            page8.Show();
            this.Hide();
        }
    }
}
