﻿namespace Proyecto_final___PDFs_Creator___Editor
{
    partial class Page3
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
            Page3Label1 = new Label();
            textBox1 = new TextBox();
            CreatePdfButton = new Button();
            EditPdfButton = new Button();
            SuspendLayout();
            // 
            // Page3Label1
            // 
            Page3Label1.AutoSize = true;
            Page3Label1.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Page3Label1.Location = new Point(93, 139);
            Page3Label1.Name = "Page3Label1";
            Page3Label1.Size = new Size(609, 25);
            Page3Label1.TabIndex = 0;
            Page3Label1.Text = "Ingrese la ruta del archivo o de guardado para crear o editar su pdf";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(93, 177);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(609, 23);
            textBox1.TabIndex = 1;
            // 
            // CreatePdfButton
            // 
            CreatePdfButton.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            CreatePdfButton.Location = new Point(207, 243);
            CreatePdfButton.Name = "CreatePdfButton";
            CreatePdfButton.Size = new Size(123, 60);
            CreatePdfButton.TabIndex = 2;
            CreatePdfButton.Text = "Crear PDF";
            CreatePdfButton.UseVisualStyleBackColor = true;
            // 
            // EditPdfButton
            // 
            EditPdfButton.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            EditPdfButton.Location = new Point(470, 243);
            EditPdfButton.Name = "EditPdfButton";
            EditPdfButton.Size = new Size(129, 60);
            EditPdfButton.TabIndex = 3;
            EditPdfButton.Text = "Editar PDF";
            EditPdfButton.UseVisualStyleBackColor = true;
            // 
            // Page3
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(EditPdfButton);
            Controls.Add(CreatePdfButton);
            Controls.Add(textBox1);
            Controls.Add(Page3Label1);
            Name = "Page3";
            Text = "Page 3";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label Page3Label1;
        private TextBox textBox1;
        private Button CreatePdfButton;
        private Button EditPdfButton;
    }
}