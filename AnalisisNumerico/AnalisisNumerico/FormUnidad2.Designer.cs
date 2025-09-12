using U1.Properties;

namespace U1
{
    partial class FormUnidad2
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
            panel2 = new Panel();
            button2 = new Button();
            comboBox1 = new ComboBox();
            richTextBoxResultado = new RichTextBox();
            label2 = new Label();
            textBoxError = new TextBox();
            label3 = new Label();
            button1 = new Button();
            textBox1 = new TextBox();
            label1 = new Label();
            panel1 = new Panel();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel2
            // 
            panel2.BackColor = Color.LightBlue;
            panel2.Font = new Font("Rockwell", 15F);
            panel2.Location = new Point(13, 165);
            panel2.Margin = new Padding(1);
            panel2.Name = "panel2";
            panel2.Size = new Size(640, 549);
            panel2.TabIndex = 3;
            // 
            // button2
            // 
            button2.BackColor = SystemColors.ActiveCaptionText;
            button2.Font = new Font("Rockwell", 15F);
            button2.ForeColor = Color.White;
            button2.Location = new Point(1252, 68);
            button2.Margin = new Padding(3, 4, 3, 4);
            button2.Name = "button2";
            button2.Size = new Size(149, 55);
            button2.TabIndex = 3;
            button2.Text = "Resolver";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // comboBox1
            // 
            comboBox1.BackColor = Color.FromArgb(233, 231, 235);
            comboBox1.Font = new Font("Rockwell", 15F);
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "Gauss Jordan", "Gauss Seidel" });
            comboBox1.Location = new Point(916, 47);
            comboBox1.Margin = new Padding(3, 4, 3, 4);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(255, 37);
            comboBox1.TabIndex = 4;
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // richTextBoxResultado
            // 
            richTextBoxResultado.BackColor = Color.LightBlue;
            richTextBoxResultado.Font = new Font("Rockwell", 15F);
            richTextBoxResultado.Location = new Point(709, 171);
            richTextBoxResultado.Margin = new Padding(3, 4, 3, 4);
            richTextBoxResultado.Name = "richTextBoxResultado";
            richTextBoxResultado.Size = new Size(792, 543);
            richTextBoxResultado.TabIndex = 5;
            richTextBoxResultado.Text = "";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = SystemColors.ActiveCaptionText;
            label2.BorderStyle = BorderStyle.FixedSingle;
            label2.Font = new Font("Rockwell", 15F);
            label2.ForeColor = Color.White;
            label2.Location = new Point(746, 53);
            label2.Name = "label2";
            label2.Size = new Size(110, 31);
            label2.TabIndex = 3;
            label2.Text = "Método:";
            // 
            // textBoxError
            // 
            textBoxError.BackColor = Color.FromArgb(233, 231, 235);
            textBoxError.Font = new Font("Rockwell", 15F);
            textBoxError.Location = new Point(1011, 102);
            textBoxError.Margin = new Padding(3, 4, 3, 4);
            textBoxError.Name = "textBoxError";
            textBoxError.Size = new Size(158, 37);
            textBoxError.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = SystemColors.ActiveCaptionText;
            label3.BorderStyle = BorderStyle.FixedSingle;
            label3.Font = new Font("Rockwell", 15F);
            label3.ForeColor = Color.White;
            label3.Location = new Point(746, 105);
            label3.Name = "label3";
            label3.Size = new Size(200, 31);
            label3.TabIndex = 6;
            label3.Text = "Error Permitido:";
            // 
            // button1
            // 
            button1.BackColor = SystemColors.ActiveCaptionText;
            button1.Font = new Font("Rockwell", 15F);
            button1.ForeColor = Color.White;
            button1.Location = new Point(489, 26);
            button1.Margin = new Padding(3, 4, 3, 4);
            button1.Name = "button1";
            button1.Size = new Size(125, 39);
            button1.TabIndex = 1;
            button1.Text = "Generar Matriz";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // textBox1
            // 
            textBox1.BackColor = Color.FromArgb(233, 231, 235);
            textBox1.Font = new Font("Rockwell", 15F);
            textBox1.Location = new Point(259, 25);
            textBox1.Margin = new Padding(3, 4, 3, 4);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(132, 37);
            textBox1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = SystemColors.ActiveCaptionText;
            label1.BorderStyle = BorderStyle.FixedSingle;
            label1.Font = new Font("Rockwell", 15F);
            label1.ForeColor = Color.White;
            label1.Location = new Point(11, 29);
            label1.Name = "label1";
            label1.Size = new Size(220, 31);
            label1.TabIndex = 2;
            label1.Text = "Dimensión Matriz:";
            // 
            // panel1
            // 
            panel1.Controls.Add(label1);
            panel1.Controls.Add(textBox1);
            panel1.Controls.Add(button1);
            panel1.Location = new Point(13, 68);
            panel1.Margin = new Padding(3, 4, 3, 4);
            panel1.Name = "panel1";
            panel1.Size = new Size(640, 91);
            panel1.TabIndex = 2;
            // 
            // FormUnidad2
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaptionText;
            ClientSize = new Size(1513, 768);
            Controls.Add(textBoxError);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(richTextBoxResultado);
            Controls.Add(comboBox1);
            Controls.Add(button2);
            Controls.Add(panel2);
            Controls.Add(panel1);
            ForeColor = Color.White;
            Margin = new Padding(3, 4, 3, 4);
            Name = "FormUnidad2";
            Text = "FormUnidad2";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel2;
        private Button button2;
        private ComboBox comboBox1;
        private RichTextBox richTextBoxResultado;
        private Label label2;
        private TextBox textBoxError;
        private Label label3;
        private Button button1;
        private TextBox textBox1;
        private Label label1;
        private Panel panel1;
    }
}
