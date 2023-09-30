namespace P222310540TM
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
            button1 = new Button();
            panel1 = new Panel();
            numericUpDown1 = new NumericUpDown();
            label1 = new Label();
            label2 = new Label();
            numericUpDown2 = new NumericUpDown();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            trackBar1 = new TrackBar();
            label3 = new Label();
            label4 = new Label();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)trackBar1).BeginInit();
            SuspendLayout();
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(24, 111, 101);
            button1.FlatStyle = FlatStyle.Popup;
            button1.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            button1.ForeColor = Color.FromArgb(181, 203, 153);
            button1.Location = new Point(12, 363);
            button1.Name = "button1";
            button1.Size = new Size(112, 68);
            button1.TabIndex = 0;
            button1.Text = "Dibujar circulos";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(252, 224, 155);
            panel1.Location = new Point(130, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(500, 500);
            panel1.TabIndex = 1;
            // 
            // numericUpDown1
            // 
            numericUpDown1.BackColor = Color.FromArgb(24, 111, 101);
            numericUpDown1.ForeColor = Color.FromArgb(181, 203, 153);
            numericUpDown1.Location = new Point(12, 47);
            numericUpDown1.Maximum = new decimal(new int[] { 8, 0, 0, 0 });
            numericUpDown1.Minimum = new decimal(new int[] { 2, 0, 0, 0 });
            numericUpDown1.Name = "numericUpDown1";
            numericUpDown1.Size = new Size(112, 23);
            numericUpDown1.TabIndex = 2;
            numericUpDown1.Value = new decimal(new int[] { 2, 0, 0, 0 });
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(12, 12);
            label1.Name = "label1";
            label1.Size = new Size(98, 32);
            label1.TabIndex = 3;
            label1.Text = "Circulos";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(12, 73);
            label2.Name = "label2";
            label2.Size = new Size(69, 32);
            label2.TabIndex = 5;
            label2.Text = "Nivel";
            // 
            // numericUpDown2
            // 
            numericUpDown2.BackColor = Color.FromArgb(24, 111, 101);
            numericUpDown2.ForeColor = Color.FromArgb(181, 203, 153);
            numericUpDown2.Location = new Point(12, 108);
            numericUpDown2.Maximum = new decimal(new int[] { 8, 0, 0, 0 });
            numericUpDown2.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            numericUpDown2.Name = "numericUpDown2";
            numericUpDown2.Size = new Size(112, 23);
            numericUpDown2.TabIndex = 4;
            numericUpDown2.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // button2
            // 
            button2.BackColor = Color.FromArgb(111, 24, 101);
            button2.FlatStyle = FlatStyle.Popup;
            button2.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            button2.ForeColor = Color.FromArgb(181, 203, 153);
            button2.Location = new Point(12, 437);
            button2.Name = "button2";
            button2.Size = new Size(112, 68);
            button2.TabIndex = 6;
            button2.Text = "Cancelar circulos";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.BackColor = Color.FromArgb(111, 101, 24);
            button3.FlatStyle = FlatStyle.Popup;
            button3.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            button3.ForeColor = Color.FromArgb(181, 203, 153);
            button3.Location = new Point(12, 511);
            button3.Name = "button3";
            button3.Size = new Size(112, 45);
            button3.TabIndex = 7;
            button3.Text = "Salir";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // button4
            // 
            button4.BackColor = Color.FromArgb(24, 111, 101);
            button4.FlatStyle = FlatStyle.Popup;
            button4.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            button4.ForeColor = Color.FromArgb(181, 203, 153);
            button4.Location = new Point(12, 137);
            button4.Name = "button4";
            button4.Size = new Size(112, 68);
            button4.TabIndex = 8;
            button4.Text = "Cambiar color";
            button4.UseVisualStyleBackColor = false;
            button4.Click += button4_Click;
            // 
            // trackBar1
            // 
            trackBar1.Location = new Point(253, 518);
            trackBar1.Maximum = 160;
            trackBar1.Minimum = 16;
            trackBar1.Name = "trackBar1";
            trackBar1.Size = new Size(177, 45);
            trackBar1.TabIndex = 9;
            trackBar1.Value = 160;
            trackBar1.Scroll += trackBar1_Scroll;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(130, 518);
            label3.Name = "label3";
            label3.Size = new Size(117, 32);
            label3.TabIndex = 10;
            label3.Text = "Velocidad";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(436, 515);
            label4.Name = "label4";
            label4.Size = new Size(0, 32);
            label4.TabIndex = 11;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(181, 203, 153);
            ClientSize = new Size(641, 576);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(button1);
            Controls.Add(trackBar1);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(label2);
            Controls.Add(numericUpDown2);
            Controls.Add(label1);
            Controls.Add(numericUpDown1);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.Fixed3D;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown2).EndInit();
            ((System.ComponentModel.ISupportInitialize)trackBar1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Panel panel1;
        private NumericUpDown numericUpDown1;
        private Label label1;
        private Label label2;
        private NumericUpDown numericUpDown2;
        private Button button2;
        private Button button3;
        private Button button4;
        private TrackBar trackBar1;
        private Label label3;
        private Label label4;
    }
}