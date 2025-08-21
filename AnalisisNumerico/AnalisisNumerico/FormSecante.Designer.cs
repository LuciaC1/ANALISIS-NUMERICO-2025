using System.Drawing.Drawing2D;

namespace AnalisisNumerico
{
    partial class FormSecante
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
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
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            textBox4 = new TextBox();
            textBox5 = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            SuspendLayout();
            // 
            // button1
            // 
            button1.BackColor = Color.DarkOrange;
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatAppearance.MouseOverBackColor = Color.FromArgb(255, 140, 0);
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point);
            button1.ForeColor = Color.White;
            button1.Location = new Point(354, 387);
            button1.Name = "button1";
            button1.Size = new Size(120, 40);
            button1.TabIndex = 0;
            button1.Text = "Resolver";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // textBox1
            // 
            textBox1.AccessibleName = "pp";
            textBox1.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            textBox1.Location = new Point(132, 57);
            textBox1.Name = "textBox1";
            textBox1.PlaceholderText = "Primer valor:";
            textBox1.Size = new Size(166, 43);
            textBox1.TabIndex = 1;
            // 
            // textBox2
            // 
            textBox2.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            textBox2.Location = new Point(450, 57);
            textBox2.Name = "textBox2";
            textBox2.PlaceholderText = "Segundo valor:";
            textBox2.Size = new Size(193, 43);
            textBox2.TabIndex = 2;
            // 
            // textBox3
            // 
            textBox3.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            textBox3.Location = new Point(12, 149);
            textBox3.Name = "textBox3";
            textBox3.PlaceholderText = "Iteraciones:";
            textBox3.Size = new Size(181, 43);
            textBox3.TabIndex = 3;
            // 
            // textBox4
            // 
            textBox4.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            textBox4.Location = new Point(199, 149);
            textBox4.Name = "textBox4";
            textBox4.PlaceholderText = "Error Relativo:";
            textBox4.Size = new Size(203, 43);
            textBox4.TabIndex = 4;
            // 
            // textBox5
            // 
            textBox5.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            textBox5.Location = new Point(408, 149);
            textBox5.Name = "textBox5";
            textBox5.PlaceholderText = "Función:";
            textBox5.Size = new Size(392, 43);
            textBox5.TabIndex = 5;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Arial", 14F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.White;
            label1.Location = new Point(75, 254);
            label1.Name = "label1";
            label1.Size = new Size(69, 29);
            label1.TabIndex = 6;
            label1.Text = "Raiz:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Arial", 14F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.White;
            label2.Location = new Point(75, 306);
            label2.Name = "label2";
            label2.Size = new Size(146, 29);
            label2.TabIndex = 7;
            label2.Text = "Iteraciones:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Arial", 14F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = Color.White;
            label3.Location = new Point(75, 354);
            label3.Name = "label3";
            label3.Size = new Size(178, 29);
            label3.TabIndex = 8;
            label3.Text = "Error Relativo:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Arial", 14F, FontStyle.Bold, GraphicsUnit.Point);
            label4.ForeColor = Color.White;
            label4.Location = new Point(75, 207);
            label4.Name = "label4";
            label4.Size = new Size(130, 29);
            label4.TabIndex = 9;
            label4.Text = "Converge:";
            // 
            // FormSecante
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(textBox5);
            Controls.Add(textBox4);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(button1);
            Name = "FormSecante";
            Text = "FormSecante";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        protected override void OnPaintBackground(PaintEventArgs e)
        {
            base.OnPaintBackground(e);
            using (LinearGradientBrush brush = new LinearGradientBrush(this.ClientRectangle, Color.Black, Color.Violet, 90F))
            {
                e.Graphics.FillRectangle(brush, this.ClientRectangle); 
            }
        }

        private Button button1;
        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox3;
        private TextBox textBox4;
        private TextBox textBox5;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
    }
}