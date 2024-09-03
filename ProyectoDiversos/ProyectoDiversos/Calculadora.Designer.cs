namespace ProyectoDiversos
{
    partial class Calculadora
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            segundoValor = new TextBox();
            resultado = new TextBox();
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            pictureBox3 = new PictureBox();
            primerValor = new TextBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 24F, FontStyle.Bold);
            label1.Location = new Point(140, 68);
            label1.Name = "label1";
            label1.Size = new Size(206, 45);
            label1.TabIndex = 0;
            label1.Text = "Primer valor";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 24F, FontStyle.Bold);
            label2.Location = new Point(140, 134);
            label2.Name = "label2";
            label2.Size = new Size(238, 45);
            label2.TabIndex = 1;
            label2.Text = "Segundo valor";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 24F, FontStyle.Bold);
            label3.Location = new Point(140, 215);
            label3.Name = "label3";
            label3.Size = new Size(168, 45);
            label3.TabIndex = 2;
            label3.Text = "Resuldato";
            label3.Click += label3_Click;
            // 
            // segundoValor
            // 
            segundoValor.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
            segundoValor.Location = new Point(404, 156);
            segundoValor.Name = "segundoValor";
            segundoValor.Size = new Size(160, 25);
            segundoValor.TabIndex = 4;
            // 
            // resultado
            // 
            resultado.Enabled = false;
            resultado.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
            resultado.Location = new Point(404, 237);
            resultado.Name = "resultado";
            resultado.Size = new Size(160, 25);
            resultado.TabIndex = 5;
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImage = Properties.Resources.WhatsApp_Image_2024_08_26_at_8_01_22_PM__9_;
            pictureBox1.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox1.Location = new Point(363, 301);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(100, 50);
            pictureBox1.TabIndex = 6;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // pictureBox2
            // 
            pictureBox2.BackgroundImage = Properties.Resources.WhatsApp_Image_2024_08_26_at_8_01_21_PM;
            pictureBox2.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox2.Location = new Point(177, 301);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(100, 50);
            pictureBox2.TabIndex = 7;
            pictureBox2.TabStop = false;
            pictureBox2.Click += pictureBox2_Click;
            // 
            // pictureBox3
            // 
            pictureBox3.BackgroundImage = Properties.Resources.WhatsApp_Image_2024_08_26_at_8_01_22_PM__13_;
            pictureBox3.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox3.Location = new Point(551, 301);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(100, 50);
            pictureBox3.TabIndex = 8;
            pictureBox3.TabStop = false;
            pictureBox3.Click += pictureBox3_Click;
            // 
            // primerValor
            // 
            primerValor.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
            primerValor.Location = new Point(404, 90);
            primerValor.Name = "primerValor";
            primerValor.Size = new Size(160, 25);
            primerValor.TabIndex = 3;
            // 
            // Calculadora
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(pictureBox3);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            Controls.Add(resultado);
            Controls.Add(segundoValor);
            Controls.Add(primerValor);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Calculadora";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox segundoValor;
        private TextBox resultado;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private PictureBox pictureBox3;
        private TextBox primerValor;
    }
}
