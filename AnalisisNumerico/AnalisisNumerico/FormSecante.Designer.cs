using System.Drawing.Drawing2D;

namespace U1
{
    partial class FormSecante
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox3;
        private TextBox textBox4;
        private TextBox textBox5;
        private Button Resolver;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;

        private void InitializeComponent()
        {
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            textBox4 = new TextBox();
            textBox5 = new TextBox();
            Resolver = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            SuspendLayout();
            
            
            textBox1.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            textBox1.Location = new Point(109, 57);
            textBox1.Name = "textBox1";
            textBox1.PlaceholderText = "Primer valor:";
            textBox1.Size = new Size(184, 43);
            textBox1.TabIndex = 0;
            
            
            textBox2.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            textBox2.Location = new Point(421, 57);
            textBox2.Name = "textBox2";
            textBox2.PlaceholderText = "Segundo valor:";
            textBox2.Size = new Size(202, 43);
            textBox2.TabIndex = 1;
            

            textBox3.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            textBox3.Location = new Point(12, 133);
            textBox3.Name = "textBox3";
            textBox3.PlaceholderText = "Iteraciones:";
            textBox3.Size = new Size(191, 43);
            textBox3.TabIndex = 2;
            
            
            textBox4.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            textBox4.Location = new Point(219, 133);
            textBox4.Name = "textBox4";
            textBox4.PlaceholderText = "Error Relativo:";
            textBox4.Size = new Size(183, 43);
            textBox4.TabIndex = 3;
            
            
            textBox5.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            textBox5.Location = new Point(421, 133);
            textBox5.Name = "textBox5";
            textBox5.PlaceholderText = "Función:";
            textBox5.Size = new Size(378, 43);
            textBox5.TabIndex = 4;
            
            
            Resolver.BackColor = Color.DarkOrange;
            Resolver.FlatAppearance.BorderSize = 0;
            Resolver.FlatStyle = FlatStyle.Flat;
            Resolver.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point);
            Resolver.ForeColor = Color.White;
            Resolver.Location = new Point(323, 386);
            Resolver.Name = "Resolver";
            Resolver.Size = new Size(120, 40);
            Resolver.TabIndex = 5;
            Resolver.Text = "Resolver";
            Resolver.UseVisualStyleBackColor = false;
            Resolver.Click += button1_Click;
            
            
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Arial", 14F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.White;
            label1.Location = new Point(82, 250);
            label1.Name = "label1";
            label1.Size = new Size(69, 29);
            label1.TabIndex = 6;
            label1.Text = "Raíz:";
            
            
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Arial", 14F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.White;
            label2.Location = new Point(82, 294);
            label2.Name = "label2";
            label2.Size = new Size(146, 29);
            label2.TabIndex = 7;
            label2.Text = "Iteraciones:";
            
            
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Arial", 14F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = Color.White;
            label3.Location = new Point(82, 343);
            label3.Name = "label3";
            label3.Size = new Size(178, 29);
            label3.TabIndex = 8;
            label3.Text = "Error Relativo:";
            

            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label4.ForeColor = Color.White;
            label4.Location = new Point(82, 210);
            label4.Name = "label4";
            label4.Size = new Size(0, 24);
            label4.TabIndex = 9;
            
            
            label5.AutoSize = true;
            label5.Location = new Point(0, 0);
            label5.Name = "label5";
            label5.Size = new Size(0, 20);
            label5.TabIndex = 10;
            
            
            label6.AutoSize = true;
            label6.BackColor = Color.Transparent;
            label6.Font = new Font("Arial", 14F, FontStyle.Bold, GraphicsUnit.Point);
            label6.ForeColor = Color.White;
            label6.Location = new Point(82, 210);
            label6.Name = "label6";
            label6.Size = new Size(130, 29);
            label6.TabIndex = 11;
            label6.Text = "Converge:";
            
            
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(Resolver);
            Controls.Add(textBox5);
            Controls.Add(textBox4);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Name = "FormBiseccion";
            Text = "Método de Bisección";
            ResumeLayout(false);
            PerformLayout();
        }

        protected override void OnPaintBackground(PaintEventArgs e)
        {
            base.OnPaintBackground(e);
            using (LinearGradientBrush brush = new LinearGradientBrush(this.ClientRectangle, Color.Violet, Color.Black, 90F))
            {
                e.Graphics.FillRectangle(brush, this.ClientRectangle);
            }
        }

        
        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Text = "Form1";
        }

        #endregion
    }
}
