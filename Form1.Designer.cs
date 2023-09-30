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
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown2).BeginInit();
            SuspendLayout();
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(24, 111, 101);
            button1.FlatStyle = FlatStyle.Popup;
            button1.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            button1.ForeColor = Color.FromArgb(181, 203, 153);
            button1.Location = new Point(12, 444);
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
            numericUpDown1.Maximum = new decimal(new int[] { 20, 0, 0, 0 });
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
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(181, 203, 153);
            ClientSize = new Size(641, 521);
            Controls.Add(label2);
            Controls.Add(numericUpDown2);
            Controls.Add(label1);
            Controls.Add(numericUpDown1);
            Controls.Add(panel1);
            Controls.Add(button1);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown2).EndInit();
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
    }
}