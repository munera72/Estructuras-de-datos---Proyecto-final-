﻿using System;
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
    public partial class Page7 : Form
    {
        public Page7()
        {
            InitializeComponent();
        }

        private void Page7Button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Page7Button2_Click(object sender, EventArgs e)
        {
            Page1 page1 = new Page1();
            page1.Show();
            this.Hide();
        }
    }
}
