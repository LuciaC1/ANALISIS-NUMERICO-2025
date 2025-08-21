using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace AnalisisNumerico
{
    partial class FormReglaFalsa : Form
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

        private void InitializeComponent()
        {
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            textBox4 = new TextBox();
            label1 = new Label();
            button1 = new Button();
            textBox5 = new TextBox();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            SuspendLayout();
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            textBox1.Location = new Point(156, 54);
            textBox1.Name = "textBox1";
            textBox1.PlaceholderText = "Primer valor:";
            textBox1.Size = new Size(166, 43);
            textBox1.TabIndex = 0;
            // 
            // textBox2
            // 
            textBox2.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            textBox2.Location = new Point(469, 54);
            textBox2.Name = "textBox2";
            textBox2.PlaceholderText = "Segundo valor:";
            textBox2.Size = new Size(190, 43);
            textBox2.TabIndex = 1;
            // 
            // textBox3
            // 
            textBox3.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            textBox3.Location = new Point(21, 145);
            textBox3.Name = "textBox3";
            textBox3.PlaceholderText = "Iteraciones:";
            textBox3.Size = new Size(146, 43);
            textBox3.TabIndex = 2;
            // 
            // textBox4
            // 
            textBox4.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            textBox4.Location = new Point(195, 145);
            textBox4.Name = "textBox4";
            textBox4.PlaceholderText = "Error Relativo:";
            textBox4.Size = new Size(179, 43);
            textBox4.TabIndex = 3;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Arial", 14F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.White;
            label1.Location = new Point(87, 247);
            label1.Name = "label1";
            label1.Size = new Size(69, 29);
            label1.TabIndex = 4;
            label1.Text = "Raíz:";
            // 
            // button1
            // 
            button1.BackColor = Color.DarkOrange;
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatAppearance.MouseOverBackColor = Color.FromArgb(255, 140, 0);
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point);
            button1.ForeColor = Color.White;
            button1.Location = new Point(345, 384);
            button1.Name = "button1";
            button1.Size = new Size(120, 40);
            button1.TabIndex = 5;
            button1.Text = "Resolver";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // textBox5
            // 
            textBox5.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            textBox5.Location = new Point(380, 145);
            textBox5.Name = "textBox5";
            textBox5.PlaceholderText = "Función:";
            textBox5.Size = new Size(421, 43);
            textBox5.TabIndex = 6;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Arial", 14F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.White;
            label2.Location = new Point(87, 294);
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
            label3.Location = new Point(87, 344);
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
            label4.Location = new Point(87, 203);
            label4.Name = "label4";
            label4.Size = new Size(130, 29);
            label4.TabIndex = 9;
            label4.Text = "Converge:";
            // 
            // FormReglaFalsa
            // 
            BackColor = Color.White;
            ClientSize = new Size(800, 450);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(textBox5);
            Controls.Add(button1);
            Controls.Add(label1);
            Controls.Add(textBox4);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            Name = "FormReglaFalsa";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Método de Regla Falsa";
            ResumeLayout(false);
            PerformLayout();
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            e.Graphics.DrawImage(CreateGradientBackground(), 0, 0);
        }

        private Image CreateGradientBackground()
        {
            Bitmap bmp = new Bitmap(ClientSize.Width, ClientSize.Height);
            using (Graphics g = Graphics.FromImage(bmp))
            {
                using (LinearGradientBrush brush = new LinearGradientBrush(new Rectangle(0, 0, bmp.Width, bmp.Height), Color.Black, Color.Violet, 90F))
                {
                    g.FillRectangle(brush, 0, 0, bmp.Width, bmp.Height);
                }
            }
            return bmp;
        }

        private void Button1_Paint(object sender, PaintEventArgs e)
        {
            Button btn = sender as Button;
            GraphicsPath path = new GraphicsPath();
            path.AddArc(0, 0, 20, 20, 180, 90); 
            path.AddArc(btn.Width - 20, 0, 20, 20, 270, 90); 
            path.AddArc(btn.Width - 20, btn.Height - 20, 20, 20, 0, 90); 
            path.AddArc(0, btn.Height - 20, 20, 20, 90, 90); 
            path.CloseFigure();
            btn.Region = new Region(path);
            e.Graphics.DrawString(btn.Text, btn.Font, new SolidBrush(btn.ForeColor), new PointF(2, 2));
        }

        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox3;
        private TextBox textBox4;
        private Label label1;
        private Button button1;
        private TextBox textBox5;
        private Label label2;
        private Label label3;
        private Label label4;
    }
}