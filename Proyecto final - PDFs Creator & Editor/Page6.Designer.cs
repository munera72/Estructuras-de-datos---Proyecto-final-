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
            CreatePdfButton = new Button();
            Page3Label1 = new Label();
            button1 = new Button();
            SuspendLayout();
            // 
            // CreatePdfButton
            // 
            CreatePdfButton.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            CreatePdfButton.Location = new Point(253, 231);
            CreatePdfButton.Name = "CreatePdfButton";
            CreatePdfButton.Size = new Size(123, 41);
            CreatePdfButton.TabIndex = 7;
            CreatePdfButton.Text = "Cerrar";
            CreatePdfButton.UseVisualStyleBackColor = true;
            CreatePdfButton.Click += this.CreatePdfButton_Click;
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
            // button1
            // 
            button1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button1.Location = new Point(423, 231);
            button1.Name = "button1";
            button1.Size = new Size(123, 41);
            button1.TabIndex = 8;
            button1.Text = "Volver al inicio";
            button1.UseVisualStyleBackColor = true;
            // 
            // Page6
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button1);
            Controls.Add(CreatePdfButton);
            Controls.Add(Page3Label1);
            Name = "Page6";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button CreatePdfButton;
        private Label Page3Label1;
        private Button button1;
    }
}