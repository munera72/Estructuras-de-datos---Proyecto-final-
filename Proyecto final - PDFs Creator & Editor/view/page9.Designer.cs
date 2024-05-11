namespace Proyecto_final___PDFs_Creator___Editor
{
    partial class page9
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
            textBox1 = new TextBox();
            button1 = new Button();
            label1 = new Label();
            GoBackButton = new Button();
            SuspendLayout();
            // 
            // textBox1
            // 
            textBox1.Location = new Point(37, 55);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(692, 327);
            textBox1.TabIndex = 0;
            // 
            // button1
            // 
            button1.Location = new Point(654, 402);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 1;
            button1.Text = "Guardar";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(37, 18);
            label1.Name = "label1";
            label1.Size = new Size(113, 21);
            label1.TabIndex = 2;
            label1.Text = "Codigo HTML";
            // 
            // GoBackButton
            // 
            GoBackButton.Location = new Point(37, 402);
            GoBackButton.Name = "GoBackButton";
            GoBackButton.Size = new Size(75, 23);
            GoBackButton.TabIndex = 7;
            GoBackButton.Text = "Atrás";
            GoBackButton.UseVisualStyleBackColor = true;
            GoBackButton.Click += GoBackButton_Click;
            // 
            // page9
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(GoBackButton);
            Controls.Add(label1);
            Controls.Add(button1);
            Controls.Add(textBox1);
            Name = "page9";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "page9";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox1;
        private Button button1;
        private Label label1;
        private Button GoBackButton;
    }
}