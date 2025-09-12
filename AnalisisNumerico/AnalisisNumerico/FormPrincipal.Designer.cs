namespace U1
{
    partial class FormPrincipal
    {
        private Panel panel1;
        private Button buttonUnidad1;
        private Panel panel2;
        private Button button3;
        private Button button2;
        private Button button1;
        private Button button4;
        private Panel panel4;
        private Panel panel3;

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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormPrincipal));
            panel1 = new Panel();
            panel2 = new Panel();
            buttonUnidad1 = new Button();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            this.panel3 = new Panel();
            this.panel4 = new Panel();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(233, 231, 235);
            panel1.Controls.Add(this.panel4);
            panel1.Controls.Add(button4);
            panel1.Controls.Add(button3);
            panel1.Controls.Add(button2);
            panel1.Controls.Add(button1);
            panel1.Controls.Add(buttonUnidad1);
            panel1.Controls.Add(panel2);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(251, 642);
            panel1.TabIndex = 0;
            // 
            // panel2
            // 
            panel2.BackColor = Color.LightSeaGreen;
            panel2.BackgroundImage = (Image)resources.GetObject("panel2.BackgroundImage");
            panel2.Controls.Add(this.panel3);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(251, 79);
            panel2.TabIndex = 1;
            panel2.Paint += panel2_Paint;
            // 
            // buttonUnidad1
            // 
            buttonUnidad1.BackColor = Color.LightSeaGreen;
            buttonUnidad1.Dock = DockStyle.Top;
            buttonUnidad1.FlatAppearance.BorderColor = Color.White;
            buttonUnidad1.FlatAppearance.BorderSize = 0;
            buttonUnidad1.FlatStyle = FlatStyle.Flat;
            buttonUnidad1.Font = new Font("Palatino Linotype", 14.5F, FontStyle.Regular, GraphicsUnit.Point, 0);
            buttonUnidad1.ForeColor = SystemColors.ButtonHighlight;
            buttonUnidad1.Image = (Image)resources.GetObject("buttonUnidad1.Image");
            buttonUnidad1.ImageAlign = ContentAlignment.MiddleLeft;
            buttonUnidad1.Location = new Point(0, 79);
            buttonUnidad1.Name = "buttonUnidad1";
            buttonUnidad1.Size = new Size(251, 96);
            buttonUnidad1.TabIndex = 0;
            buttonUnidad1.Text = "Raíces de funciones\r\n";
            buttonUnidad1.TextAlign = ContentAlignment.MiddleRight;
            buttonUnidad1.TextImageRelation = TextImageRelation.TextBeforeImage;
            buttonUnidad1.UseVisualStyleBackColor = false;
            buttonUnidad1.Click += buttonUnidad1_Click;
            // 
            // button1
            // 
            button1.BackColor = Color.Teal;
            button1.Dock = DockStyle.Top;
            button1.FlatAppearance.BorderColor = Color.White;
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Palatino Linotype", 14.25F);
            button1.ForeColor = SystemColors.ButtonHighlight;
            button1.Image = (Image)resources.GetObject("button1.Image");
            button1.ImageAlign = ContentAlignment.MiddleLeft;
            button1.Location = new Point(0, 175);
            button1.Name = "button1";
            button1.Size = new Size(251, 96);
            button1.TabIndex = 5;
            button1.Text = "Sistema de ecuaciones";
            button1.TextAlign = ContentAlignment.MiddleRight;
            button1.TextImageRelation = TextImageRelation.TextBeforeImage;
            button1.UseVisualStyleBackColor = false;
            button1.Click += buttonUnidad2_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.LightSeaGreen;
            button2.Dock = DockStyle.Top;
            button2.FlatAppearance.BorderSize = 0;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("Palatino Linotype", 14.25F);
            button2.ForeColor = SystemColors.ButtonHighlight;
            button2.Image = (Image)resources.GetObject("button2.Image");
            button2.ImageAlign = ContentAlignment.MiddleLeft;
            button2.Location = new Point(0, 271);
            button2.Name = "button2";
            button2.Size = new Size(251, 96);
            button2.TabIndex = 6;
            button2.Text = "Regresión Polinomial";
            button2.TextAlign = ContentAlignment.MiddleRight;
            button2.TextImageRelation = TextImageRelation.TextBeforeImage;
            button2.UseVisualStyleBackColor = false;
            // 
            // button3
            // 
            button3.BackColor = Color.Teal;
            button3.Dock = DockStyle.Top;
            button3.FlatAppearance.BorderSize = 0;
            button3.FlatStyle = FlatStyle.Flat;
            button3.Font = new Font("Palatino Linotype", 14.25F);
            button3.ForeColor = SystemColors.ButtonHighlight;
            button3.Image = (Image)resources.GetObject("button3.Image");
            button3.ImageAlign = ContentAlignment.MiddleLeft;
            button3.Location = new Point(0, 367);
            button3.Name = "button3";
            button3.Size = new Size(251, 96);
            button3.TabIndex = 7;
            button3.Text = "Integración Numérica";
            button3.TextAlign = ContentAlignment.MiddleRight;
            button3.TextImageRelation = TextImageRelation.TextBeforeImage;
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // button4
            // 
            button4.BackColor = Color.LightSeaGreen;
            button4.Dock = DockStyle.Top;
            button4.FlatAppearance.BorderSize = 0;
            button4.FlatStyle = FlatStyle.Flat;
            button4.Font = new Font("Palatino Linotype", 14.25F);
            button4.ForeColor = SystemColors.ButtonHighlight;
            button4.Image = (Image)resources.GetObject("button4.Image");
            button4.ImageAlign = ContentAlignment.MiddleLeft;
            button4.Location = new Point(0, 463);
            button4.Name = "button4";
            button4.Size = new Size(251, 96);
            button4.TabIndex = 8;
            button4.Text = "Salir";
            button4.TextAlign = ContentAlignment.MiddleRight;
            button4.TextImageRelation = TextImageRelation.TextBeforeImage;
            button4.UseVisualStyleBackColor = false;
            button4.Click += button4_Click;
            // 
            // panel3
            // 
            this.panel3.BackColor = Color.LightSeaGreen;
            this.panel3.BackgroundImage = (Image)resources.GetObject("panel3.BackgroundImage");
            this.panel3.Dock = DockStyle.Top;
            this.panel3.Location = new Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new Size(251, 79);
            this.panel3.TabIndex = 2;
            // 
            // panel4
            // 
            this.panel4.BackColor = Color.LightSeaGreen;
            this.panel4.BackgroundImage = (Image)resources.GetObject("panel4.BackgroundImage");
            this.panel4.Dock = DockStyle.Top;
            this.panel4.Location = new Point(0, 559);
            this.panel4.Name = "panel4";
            this.panel4.Size = new Size(251, 79);
            this.panel4.TabIndex = 9;
            // 
            // FormPrincipal
            // 
            ClientSize = new Size(1432, 642);
            Controls.Add(panel1);
            Name = "FormPrincipal";
            panel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            ResumeLayout(false);

        }
        #endregion
    }
}