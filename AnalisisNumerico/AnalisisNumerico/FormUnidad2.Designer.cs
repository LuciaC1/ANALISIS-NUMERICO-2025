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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormUnidad2));
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
            buttonVolverMenu = new Button();
            label4 = new Label();
            SuspendLayout();
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(233, 231, 235);
            panel2.Font = new Font("Rockwell", 15F);
            panel2.Location = new Point(44, 186);
            panel2.Margin = new Padding(1);
            panel2.Name = "panel2";
            panel2.Size = new Size(560, 412);
            panel2.TabIndex = 3;
            // 
            // button2
            // 
            button2.BackColor = SystemColors.ActiveCaptionText;
            button2.Font = new Font("Rockwell", 15F);
            button2.ForeColor = Color.White;
            button2.Location = new Point(1117, 108);
            button2.Name = "button2";
            button2.Size = new Size(130, 41);
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
            comboBox1.Location = new Point(824, 93);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(224, 30);
            comboBox1.TabIndex = 4;
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // richTextBoxResultado
            // 
            richTextBoxResultado.BackColor = Color.FromArgb(233, 231, 235);
            richTextBoxResultado.Font = new Font("Rockwell", 15F);
            richTextBoxResultado.Location = new Point(642, 186);
            richTextBoxResultado.Name = "richTextBoxResultado";
            richTextBoxResultado.Size = new Size(694, 408);
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
            label2.Location = new Point(675, 98);
            label2.Name = "label2";
            label2.Size = new Size(88, 24);
            label2.TabIndex = 3;
            label2.Text = "Método:";
            // 
            // textBoxError
            // 
            textBoxError.BackColor = Color.FromArgb(233, 231, 235);
            textBoxError.Font = new Font("Rockwell", 15F);
            textBoxError.Location = new Point(825, 134);
            textBoxError.Name = "textBoxError";
            textBoxError.Size = new Size(222, 31);
            textBoxError.TabIndex = 3;
            textBoxError.TextChanged += textBoxError_TextChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = SystemColors.ActiveCaptionText;
            label3.BorderStyle = BorderStyle.FixedSingle;
            label3.Font = new Font("Rockwell", 15F);
            label3.ForeColor = Color.White;
            label3.Location = new Point(675, 137);
            label3.Name = "label3";
            label3.Size = new Size(114, 24);
            label3.TabIndex = 6;
            label3.Text = "Tolerancia:";
            label3.Click += label3_Click;
            // 
            // button1
            // 
            button1.BackColor = SystemColors.ActiveCaptionText;
            button1.Font = new Font("Rockwell", 15F);
            button1.ForeColor = Color.White;
            button1.Location = new Point(418, 108);
            button1.Name = "button1";
            button1.Size = new Size(143, 65);
            button1.TabIndex = 1;
            button1.Text = "Generar Matriz";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // textBox1
            // 
            textBox1.BackColor = Color.Black;
            textBox1.Font = new Font("Rockwell", 15F);
            textBox1.ForeColor = SystemColors.Window;
            textBox1.Location = new Point(244, 126);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(116, 31);
            textBox1.TabIndex = 0;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = SystemColors.ActiveCaptionText;
            label1.BorderStyle = BorderStyle.FixedSingle;
            label1.Font = new Font("Rockwell", 15F);
            label1.ForeColor = Color.White;
            label1.Location = new Point(44, 129);
            label1.Name = "label1";
            label1.Size = new Size(178, 24);
            label1.TabIndex = 2;
            label1.Text = "Dimensión Matriz:";
            // 
            // buttonVolverMenu
            // 
            buttonVolverMenu.BackColor = SystemColors.ActiveCaptionText;
            buttonVolverMenu.Font = new Font("Rockwell", 10F);
            buttonVolverMenu.Location = new Point(12, 12);
            buttonVolverMenu.Name = "buttonVolverMenu";
            buttonVolverMenu.Size = new Size(125, 28);
            buttonVolverMenu.TabIndex = 45;
            buttonVolverMenu.Text = "Volver al menú";
            buttonVolverMenu.UseVisualStyleBackColor = false;
            buttonVolverMenu.Click += buttonVolverMenu_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = SystemColors.ActiveCaptionText;
            label4.BorderStyle = BorderStyle.FixedSingle;
            label4.Font = new Font("Rockwell", 15F);
            label4.ForeColor = Color.White;
            label4.Location = new Point(936, 38);
            label4.Name = "label4";
            label4.Size = new Size(111, 24);
            label4.TabIndex = 46;
            label4.Text = "Resultados";
            label4.Click += label4_Click;
            // 
            // FormUnidad2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaptionText;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(1379, 706);
            Controls.Add(label4);
            Controls.Add(buttonVolverMenu);
            Controls.Add(button1);
            Controls.Add(label1);
            Controls.Add(textBoxError);
            Controls.Add(textBox1);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(richTextBoxResultado);
            Controls.Add(comboBox1);
            Controls.Add(button2);
            Controls.Add(panel2);
            ForeColor = Color.White;
            Name = "FormUnidad2";
            Text = "FormUnidad2";
            Load += FormUnidad2_Load;
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
        private Button buttonVolverMenu;
        private Label label4;
    }
}
