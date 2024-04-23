namespace Proyecto_final___PDFs_Creator___Editor
{
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
        }

        private void HomeButton1_Click(object sender, EventArgs e)
        {
            Page1 f1 = new Page1();
            f1.Show();
            this.Hide(); // Hide the current form
        }
    }
}
