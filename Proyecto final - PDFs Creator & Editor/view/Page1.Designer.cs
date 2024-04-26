namespace Proyecto_final___PDFs_Creator___Editor
{
    partial class Page1
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
            button2 = new Button();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(290, 106);
            button1.Name = "button1";
            button1.Size = new Size(187, 59);
            button1.TabIndex = 0;
            button1.Text = "Ver historial";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(290, 238);
            button2.Name = "button2";
            button2.Size = new Size(187, 59);
            button2.TabIndex = 1;
            button2.Text = "Crear o editar PDF";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // Page1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button2);
            Controls.Add(button1);
            Name = "Page1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Page1";
            ResumeLayout(false);
        }

        #endregion

        private Button button1;
        private Button button2;
    }
}