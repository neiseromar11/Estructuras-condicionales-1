namespace Estructuras_condicionales_1
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            txtedad = new TextBox();
            label1 = new Label();
            lblda = new Label();
            Calcular = new Button();
            SuspendLayout();
            // 
            // txtedad
            // 
            txtedad.Location = new Point(227, 28);
            txtedad.Name = "txtedad";
            txtedad.Size = new Size(66, 23);
            txtedad.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(12, 30);
            label1.Name = "label1";
            label1.Size = new Size(127, 21);
            label1.TabIndex = 1;
            label1.Text = "Ingrese su edad";
            // 
            // lblda
            // 
            lblda.AutoSize = true;
            lblda.Font = new Font("Times New Roman", 18F, FontStyle.Regular, GraphicsUnit.Point);
            lblda.Location = new Point(28, 129);
            lblda.Name = "lblda";
            lblda.Size = new Size(111, 27);
            lblda.TabIndex = 2;
            lblda.Text = "Usted es : ";
            // 
            // Calcular
            // 
            Calcular.Location = new Point(113, 188);
            Calcular.Name = "Calcular";
            Calcular.Size = new Size(107, 42);
            Calcular.TabIndex = 3;
            Calcular.Text = "Calcular";
            Calcular.UseVisualStyleBackColor = true;
            Calcular.Click += Calcular_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(337, 260);
            Controls.Add(Calcular);
            Controls.Add(lblda);
            Controls.Add(label1);
            Controls.Add(txtedad);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtedad;
        private Label label1;
        private Label lblda;
        private Button Calcular;
    }
}