namespace Proyecto_final___PDFs_Creator___Editor
{
    partial class Page7
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
            button1 = new Button();
            CreatePdfButton = new Button();
            Page3Label1 = new Label();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button1.Location = new Point(427, 245);
            button1.Name = "button1";
            button1.Size = new Size(123, 41);
            button1.TabIndex = 11;
            button1.Text = "Volver al inicio";
            button1.UseVisualStyleBackColor = true;
            // 
            // CreatePdfButton
            // 
            CreatePdfButton.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            CreatePdfButton.Location = new Point(257, 245);
            CreatePdfButton.Name = "CreatePdfButton";
            CreatePdfButton.Size = new Size(123, 41);
            CreatePdfButton.TabIndex = 10;
            CreatePdfButton.Text = "Cerrar";
            CreatePdfButton.UseVisualStyleBackColor = true;
            // 
            // Page3Label1
            // 
            Page3Label1.AutoSize = true;
            Page3Label1.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Page3Label1.Location = new Point(111, 165);
            Page3Label1.Name = "Page3Label1";
            Page3Label1.Size = new Size(588, 25);
            Page3Label1.TabIndex = 9;
            Page3Label1.Text = "Ha ocurrido un error. Su PDF no podido ser guardado con exito.\r\n";
            // 
            // Page7
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button1);
            Controls.Add(CreatePdfButton);
            Controls.Add(Page3Label1);
            Name = "Page7";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Button CreatePdfButton;
        private Label Page3Label1;
    }
}