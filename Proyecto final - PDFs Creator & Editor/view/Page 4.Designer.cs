namespace Proyecto_final___PDFs_Creator___Editor
{
    partial class Page4
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
            Page4Label1 = new Label();
            Page4TextBox1 = new TextBox();
            fileSystemWatcher1 = new FileSystemWatcher();
            Page4Label2 = new Label();
            Page4TextBox2 = new TextBox();
            Page4TextBox3 = new TextBox();
            Page4Button1 = new Button();
            Page4Button3 = new Button();
            Page4Label3 = new Label();
            GoBackButton = new Button();
            ((System.ComponentModel.ISupportInitialize)fileSystemWatcher1).BeginInit();
            SuspendLayout();
            // 
            // Page4Label1
            // 
            Page4Label1.AutoSize = true;
            Page4Label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Page4Label1.Location = new Point(88, 37);
            Page4Label1.Name = "Page4Label1";
            Page4Label1.Size = new Size(240, 21);
            Page4Label1.TabIndex = 0;
            Page4Label1.Text = "Ingrese el título del contenido";
            // 
            // Page4TextBox1
            // 
            Page4TextBox1.Location = new Point(88, 61);
            Page4TextBox1.Name = "Page4TextBox1";
            Page4TextBox1.Size = new Size(484, 23);
            Page4TextBox1.TabIndex = 1;
            // 
            // fileSystemWatcher1
            // 
            fileSystemWatcher1.EnableRaisingEvents = true;
            fileSystemWatcher1.SynchronizingObject = this;
            // 
            // Page4Label2
            // 
            Page4Label2.AutoSize = true;
            Page4Label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Page4Label2.Location = new Point(88, 124);
            Page4Label2.Name = "Page4Label2";
            Page4Label2.Size = new Size(233, 21);
            Page4Label2.TabIndex = 2;
            Page4Label2.Text = "Ingrese el contenido de texto";
            // 
            // Page4TextBox2
            // 
            Page4TextBox2.Location = new Point(88, 148);
            Page4TextBox2.Multiline = true;
            Page4TextBox2.Name = "Page4TextBox2";
            Page4TextBox2.Size = new Size(484, 216);
            Page4TextBox2.TabIndex = 3;
            // 
            // Page4TextBox3
            // 
            Page4TextBox3.Location = new Point(88, 417);
            Page4TextBox3.Name = "Page4TextBox3";
            Page4TextBox3.Size = new Size(380, 23);
            Page4TextBox3.TabIndex = 4;
            // 
            // Page4Button1
            // 
            Page4Button1.Location = new Point(485, 407);
            Page4Button1.Name = "Page4Button1";
            Page4Button1.Size = new Size(87, 41);
            Page4Button1.TabIndex = 5;
            Page4Button1.Text = "Añadir Imágenes";
            Page4Button1.UseVisualStyleBackColor = true;
            Page4Button1.Click += Page4Button1_Click;
            // 
            // Page4Button3
            // 
            Page4Button3.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Page4Button3.Location = new Point(266, 480);
            Page4Button3.Name = "Page4Button3";
            Page4Button3.Size = new Size(141, 47);
            Page4Button3.TabIndex = 7;
            Page4Button3.Text = "Guardar PDF";
            Page4Button3.UseVisualStyleBackColor = true;
            Page4Button3.Click += Page4Button3_Click;
            // 
            // Page4Label3
            // 
            Page4Label3.AutoSize = true;
            Page4Label3.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Page4Label3.Location = new Point(88, 393);
            Page4Label3.Name = "Page4Label3";
            Page4Label3.Size = new Size(290, 17);
            Page4Label3.TabIndex = 8;
            Page4Label3.Text = "Añadir ruta de imagen o carpeta de imágenes";
            // 
            // GoBackButton
            // 
            GoBackButton.Location = new Point(12, 526);
            GoBackButton.Name = "GoBackButton";
            GoBackButton.Size = new Size(75, 23);
            GoBackButton.TabIndex = 9;
            GoBackButton.Text = "Atrás";
            GoBackButton.UseVisualStyleBackColor = true;
            GoBackButton.Click += GoBackButton_Click;
            // 
            // Page4
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(675, 561);
            Controls.Add(GoBackButton);
            Controls.Add(Page4Label3);
            Controls.Add(Page4Button3);
            Controls.Add(Page4Button1);
            Controls.Add(Page4TextBox3);
            Controls.Add(Page4TextBox2);
            Controls.Add(Page4Label2);
            Controls.Add(Page4TextBox1);
            Controls.Add(Page4Label1);
            Name = "Page4";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Page 4";
            ((System.ComponentModel.ISupportInitialize)fileSystemWatcher1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label Page4Label1;
        private TextBox Page4TextBox1;
        private FileSystemWatcher fileSystemWatcher1;
        private TextBox Page4TextBox2;
        private Label Page4Label2;
        private Button Page4Button1;
        private TextBox Page4TextBox3;
        private Button Page4Button3;
        private Label Page4Label3;
        private Button GoBackButton;
    }
}