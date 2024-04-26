namespace Proyecto_final___PDFs_Creator___Editor
{
    partial class Home
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            HomeButton1 = new Button();
            HomeLabel1 = new Label();
            HomeLabel2 = new Label();
            SuspendLayout();
            // 
            // HomeButton1
            // 
            HomeButton1.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            HomeButton1.Location = new Point(311, 272);
            HomeButton1.Name = "HomeButton1";
            HomeButton1.Size = new Size(181, 55);
            HomeButton1.TabIndex = 0;
            HomeButton1.Text = "Empezar";
            HomeButton1.UseVisualStyleBackColor = true;
            HomeButton1.Click += HomeButton1_Click;
            // 
            // HomeLabel1
            // 
            HomeLabel1.AutoSize = true;
            HomeLabel1.Font = new Font("Showcard Gothic", 36F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            HomeLabel1.Location = new Point(38, 87);
            HomeLabel1.Name = "HomeLabel1";
            HomeLabel1.Size = new Size(718, 60);
            HomeLabel1.TabIndex = 1;
            HomeLabel1.Text = "Bienvenido a PDF Magician";
            // 
            // HomeLabel2
            // 
            HomeLabel2.AutoSize = true;
            HomeLabel2.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            HomeLabel2.Location = new Point(60, 186);
            HomeLabel2.Name = "HomeLabel2";
            HomeLabel2.Size = new Size(668, 30);
            HomeLabel2.TabIndex = 2;
            HomeLabel2.Text = "Crea tus PDF, añade imágenes y contenid. O edita PDF ya existentes.";
            // 
            // Home
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(HomeLabel2);
            Controls.Add(HomeLabel1);
            Controls.Add(HomeButton1);
            Name = "Home";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Home";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button HomeButton1;
        private Label HomeLabel1;
        private Label HomeLabel2;
    }
}
