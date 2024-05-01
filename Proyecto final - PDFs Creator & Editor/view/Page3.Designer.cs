namespace Proyecto_final___PDFs_Creator___Editor
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
            textdirectory = new TextBox();
            Page3Button1 = new Button();
            btnopen = new Button();
            GoBackButton = new Button();
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
            // textdirectory
            // 
            textdirectory.Enabled = false;
            textdirectory.Location = new Point(93, 177);
            textdirectory.Name = "textdirectory";
            textdirectory.Size = new Size(567, 23);
            textdirectory.TabIndex = 1;
            // 
            // Page3Button1
            // 
            Page3Button1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Page3Button1.Location = new Point(315, 243);
            Page3Button1.Name = "Page3Button1";
            Page3Button1.Size = new Size(123, 60);
            Page3Button1.TabIndex = 2;
            Page3Button1.Text = "Crear PDF";
            Page3Button1.UseVisualStyleBackColor = true;
            Page3Button1.Click += CreatePdfButton_Click;
            // 
            // btnopen
            // 
            btnopen.Location = new Point(666, 177);
            btnopen.Name = "btnopen";
            btnopen.Size = new Size(38, 23);
            btnopen.TabIndex = 4;
            btnopen.Text = "...";
            btnopen.UseVisualStyleBackColor = true;
            btnopen.Click += btnopen_Click;
            // 
            // GoBackButton
            // 
            GoBackButton.Location = new Point(12, 415);
            GoBackButton.Name = "GoBackButton";
            GoBackButton.Size = new Size(75, 23);
            GoBackButton.TabIndex = 5;
            GoBackButton.Text = "Atrás";
            GoBackButton.UseVisualStyleBackColor = true;
            GoBackButton.Click += GoBackButton_Click;
            // 
            // Page3
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(GoBackButton);
            Controls.Add(btnopen);
            Controls.Add(Page3Button1);
            Controls.Add(textdirectory);
            Controls.Add(Page3Label1);
            Name = "Page3";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Page 3";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label Page3Label1;
        private TextBox textdirectory;
        private Button Page3Button1;
        private Button btnopen;
        private Button GoBackButton;
    }
}