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
            Page7Button2 = new Button();
            Page7Button1 = new Button();
            Page3Label1 = new Label();
            SuspendLayout();
            // 
            // Page7Button2
            // 
            Page7Button2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Page7Button2.Location = new Point(427, 245);
            Page7Button2.Name = "Page7Button2";
            Page7Button2.Size = new Size(123, 41);
            Page7Button2.TabIndex = 11;
            Page7Button2.Text = "Volver al inicio";
            Page7Button2.UseVisualStyleBackColor = true;
            Page7Button2.Click += Page7Button2_Click;
            // 
            // Page7Button1
            // 
            Page7Button1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Page7Button1.Location = new Point(257, 245);
            Page7Button1.Name = "Page7Button1";
            Page7Button1.Size = new Size(123, 41);
            Page7Button1.TabIndex = 10;
            Page7Button1.Text = "Cerrar";
            Page7Button1.UseVisualStyleBackColor = true;
            Page7Button1.Click += Page7Button1_Click;
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
            Controls.Add(Page7Button2);
            Controls.Add(Page7Button1);
            Controls.Add(Page3Label1);
            Name = "Page7";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button Page7Button2;
        private Button Page7Button1;
        private Label Page3Label1;
    }
}