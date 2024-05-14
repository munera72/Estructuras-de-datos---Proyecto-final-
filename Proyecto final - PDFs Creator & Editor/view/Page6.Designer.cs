namespace Proyecto_final___PDFs_Creator___Editor
{
    partial class Page6
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
            Page6Button1 = new Button();
            Page3Label1 = new Label();
            Page6Button2 = new Button();
            SuspendLayout();
            // 
            // Page6Button1
            // 
            Page6Button1.BackColor = Color.FromArgb(234, 216, 192);
            Page6Button1.Cursor = Cursors.Hand;
            Page6Button1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Page6Button1.Location = new Point(253, 231);
            Page6Button1.Name = "Page6Button1";
            Page6Button1.Size = new Size(123, 41);
            Page6Button1.TabIndex = 7;
            Page6Button1.Text = "Cerrar";
            Page6Button1.UseVisualStyleBackColor = false;
            Page6Button1.Click += Page6Button1_Click;
            // 
            // Page3Label1
            // 
            Page3Label1.AutoSize = true;
            Page3Label1.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Page3Label1.Location = new Point(181, 151);
            Page3Label1.Name = "Page3Label1";
            Page3Label1.Size = new Size(436, 25);
            Page3Label1.TabIndex = 6;
            Page3Label1.Text = "Su archivo PDF ha sido guardado exitosamente.";
            // 
            // Page6Button2
            // 
            Page6Button2.BackColor = Color.FromArgb(234, 216, 192);
            Page6Button2.Cursor = Cursors.Hand;
            Page6Button2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Page6Button2.Location = new Point(423, 231);
            Page6Button2.Name = "Page6Button2";
            Page6Button2.Size = new Size(123, 41);
            Page6Button2.TabIndex = 8;
            Page6Button2.Text = "Volver al inicio";
            Page6Button2.UseVisualStyleBackColor = false;
            Page6Button2.Click += Page6Button2_Click;
            // 
            // Page6
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(255, 242, 225);
            ClientSize = new Size(800, 450);
            Controls.Add(Page6Button2);
            Controls.Add(Page6Button1);
            Controls.Add(Page3Label1);
            Name = "Page6";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "PDF Magician";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button Page6Button1;
        private Label Page3Label1;
        private Button Page6Button2;
    }
}