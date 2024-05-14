namespace Proyecto_final___PDFs_Creator___Editor
{
    partial class Page5
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            CreatePdfButton = new Button();
            Page5TextBox1 = new TextBox();
            Page3Label1 = new Label();
            GoBackButton = new Button();
            SuspendLayout();
            // 
            // CreatePdfButton
            // 
            CreatePdfButton.BackColor = Color.FromArgb(234, 216, 192);
            CreatePdfButton.Cursor = Cursors.Hand;
            CreatePdfButton.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            CreatePdfButton.Location = new Point(338, 227);
            CreatePdfButton.Name = "CreatePdfButton";
            CreatePdfButton.Size = new Size(123, 60);
            CreatePdfButton.TabIndex = 5;
            CreatePdfButton.Text = "Aceptar";
            CreatePdfButton.UseVisualStyleBackColor = false;
            CreatePdfButton.Click += CreatePdfButton_Click;
            // 
            // Page5TextBox1
            // 
            Page5TextBox1.Location = new Point(96, 181);
            Page5TextBox1.Name = "Page5TextBox1";
            Page5TextBox1.Size = new Size(609, 23);
            Page5TextBox1.TabIndex = 4;
            // 
            // Page3Label1
            // 
            Page3Label1.AutoSize = true;
            Page3Label1.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Page3Label1.Location = new Point(190, 139);
            Page3Label1.Name = "Page3Label1";
            Page3Label1.Size = new Size(409, 25);
            Page3Label1.TabIndex = 3;
            Page3Label1.Text = "Proporcione un nombre para el archivo PDF.";
            // 
            // GoBackButton
            // 
            GoBackButton.BackColor = Color.FromArgb(234, 216, 192);
            GoBackButton.Cursor = Cursors.Hand;
            GoBackButton.Location = new Point(12, 415);
            GoBackButton.Name = "GoBackButton";
            GoBackButton.Size = new Size(75, 23);
            GoBackButton.TabIndex = 6;
            GoBackButton.Text = "Atrás";
            GoBackButton.UseVisualStyleBackColor = false;
            GoBackButton.Click += GoBackButton_Click;
            // 
            // Page5
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(255, 242, 225);
            ClientSize = new Size(800, 450);
            Controls.Add(GoBackButton);
            Controls.Add(CreatePdfButton);
            Controls.Add(Page5TextBox1);
            Controls.Add(Page3Label1);
            Name = "Page5";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "PDF Magician";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button CreatePdfButton;
        private TextBox Page5TextBox1;
        private Label Page3Label1;
        private Button GoBackButton;
    }
}