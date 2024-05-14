namespace Proyecto_final___PDFs_Creator___Editor
{
    partial class page8
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
            label2 = new Label();
            GoBackButton = new Button();
            SuspendLayout();
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(234, 216, 192);
            button1.Cursor = Cursors.Hand;
            button1.Location = new Point(142, 209);
            button1.Name = "button1";
            button1.Size = new Size(151, 59);
            button1.TabIndex = 0;
            button1.Text = "Crear con Texto e Imagen";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.FromArgb(234, 216, 192);
            button2.Cursor = Cursors.Hand;
            button2.Location = new Point(470, 209);
            button2.Name = "button2";
            button2.Size = new Size(151, 59);
            button2.TabIndex = 1;
            button2.Text = "Crear con HTML";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(171, 118);
            label2.Name = "label2";
            label2.Size = new Size(424, 21);
            label2.TabIndex = 2;
            label2.Text = "Seleccione con que herramienta desea crear el archivo";
            label2.Click += label2_Click_1;
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
            // page8
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(255, 242, 225);
            ClientSize = new Size(800, 450);
            Controls.Add(GoBackButton);
            Controls.Add(label2);
            Controls.Add(button2);
            Controls.Add(button1);
            Name = "page8";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "PDF Magician";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Button button2;
        private Label label2;
        private Button GoBackButton;
    }
}