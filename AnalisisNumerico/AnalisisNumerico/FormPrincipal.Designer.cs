namespace U1
{
    partial class FormPrincipal
    {
        private Panel panel1;
        private Button buttonUnidad1;
        private Panel panel2;
        private Button buttonUnidad4;
        private Button buttonUnidad3;
        private Button buttonUnidad2;
        private Button buttonSalir;
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
            panel4 = new Panel();
            buttonSalir = new Button();
            buttonUnidad4 = new Button();
            buttonUnidad3 = new Button();
            buttonUnidad2 = new Button();
            buttonUnidad1 = new Button();
            panel2 = new Panel();
            panel3 = new Panel();
            label9 = new Label();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(233, 231, 235);
            panel1.Controls.Add(panel4);
            panel1.Controls.Add(buttonSalir);
            panel1.Controls.Add(buttonUnidad4);
            panel1.Controls.Add(buttonUnidad3);
            panel1.Controls.Add(buttonUnidad2);
            panel1.Controls.Add(buttonUnidad1);
            panel1.Controls.Add(panel2);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(867, 642);
            panel1.TabIndex = 0;
            // 
            // panel4
            // 
            panel4.BackColor = Color.LightSeaGreen;
            panel4.BackgroundImage = (Image)resources.GetObject("panel4.BackgroundImage");
            panel4.Dock = DockStyle.Top;
            panel4.Location = new Point(0, 559);
            panel4.Name = "panel4";
            panel4.Size = new Size(867, 79);
            panel4.TabIndex = 9;
            panel4.Paint += panel4_Paint;
            // 
            // buttonSalir
            // 
            buttonSalir.BackColor = Color.FromArgb(233, 231, 235);
            buttonSalir.Dock = DockStyle.Top;
            buttonSalir.FlatAppearance.BorderSize = 0;
            buttonSalir.FlatStyle = FlatStyle.Flat;
            buttonSalir.Font = new Font("Palatino Linotype", 20F);
            buttonSalir.ForeColor = SystemColors.ActiveCaptionText;
            buttonSalir.Image = (Image)resources.GetObject("buttonSalir.Image");
            buttonSalir.ImageAlign = ContentAlignment.MiddleLeft;
            buttonSalir.Location = new Point(0, 463);
            buttonSalir.Name = "buttonSalir";
            buttonSalir.Size = new Size(867, 96);
            buttonSalir.TabIndex = 8;
            buttonSalir.Text = "Salir";
            buttonSalir.TextAlign = ContentAlignment.MiddleRight;
            buttonSalir.TextImageRelation = TextImageRelation.TextBeforeImage;
            buttonSalir.UseVisualStyleBackColor = false;
            buttonSalir.Click += buttonSalir_Click;
            // 
            // buttonUnidad4
            // 
            buttonUnidad4.BackColor = Color.Thistle;
            buttonUnidad4.Dock = DockStyle.Top;
            buttonUnidad4.FlatAppearance.BorderSize = 0;
            buttonUnidad4.FlatStyle = FlatStyle.Flat;
            buttonUnidad4.Font = new Font("Palatino Linotype", 20F);
            buttonUnidad4.ForeColor = SystemColors.ActiveCaptionText;
            buttonUnidad4.Image = (Image)resources.GetObject("buttonUnidad4.Image");
            buttonUnidad4.ImageAlign = ContentAlignment.MiddleLeft;
            buttonUnidad4.Location = new Point(0, 367);
            buttonUnidad4.Name = "buttonUnidad4";
            buttonUnidad4.Size = new Size(867, 96);
            buttonUnidad4.TabIndex = 7;
            buttonUnidad4.Text = "Integración Numérica";
            buttonUnidad4.TextAlign = ContentAlignment.MiddleRight;
            buttonUnidad4.TextImageRelation = TextImageRelation.TextBeforeImage;
            buttonUnidad4.UseVisualStyleBackColor = false;
            //buttonUnidad4.Click += buttonUnidad4_Click;
            // 
            // buttonUnidad3
            // 
            buttonUnidad3.BackColor = Color.FromArgb(233, 231, 235);
            buttonUnidad3.Dock = DockStyle.Top;
            buttonUnidad3.FlatAppearance.BorderSize = 0;
            buttonUnidad3.FlatStyle = FlatStyle.Flat;
            buttonUnidad3.Font = new Font("Palatino Linotype", 20F);
            buttonUnidad3.ForeColor = SystemColors.ActiveCaptionText;
            buttonUnidad3.Image = (Image)resources.GetObject("buttonUnidad3.Image");
            buttonUnidad3.ImageAlign = ContentAlignment.MiddleLeft;
            buttonUnidad3.Location = new Point(0, 271);
            buttonUnidad3.Name = "buttonUnidad3";
            buttonUnidad3.Size = new Size(867, 96);
            buttonUnidad3.TabIndex = 6;
            buttonUnidad3.Text = "Regresión Polinomial";
            buttonUnidad3.TextAlign = ContentAlignment.MiddleRight;
            buttonUnidad3.TextImageRelation = TextImageRelation.TextBeforeImage;
            buttonUnidad3.UseVisualStyleBackColor = false;
            buttonUnidad3.Click += buttonUnidad3_Click;
            // 
            // buttonUnidad2
            // 
            buttonUnidad2.BackColor = Color.Thistle;
            buttonUnidad2.Dock = DockStyle.Top;
            buttonUnidad2.FlatAppearance.BorderColor = Color.White;
            buttonUnidad2.FlatAppearance.BorderSize = 0;
            buttonUnidad2.FlatStyle = FlatStyle.Flat;
            buttonUnidad2.Font = new Font("Palatino Linotype", 20F);
            buttonUnidad2.ForeColor = SystemColors.ActiveCaptionText;
            buttonUnidad2.Image = (Image)resources.GetObject("buttonUnidad2.Image");
            buttonUnidad2.ImageAlign = ContentAlignment.MiddleLeft;
            buttonUnidad2.Location = new Point(0, 175);
            buttonUnidad2.Name = "buttonUnidad2";
            buttonUnidad2.Size = new Size(867, 96);
            buttonUnidad2.TabIndex = 5;
            buttonUnidad2.Text = "Sistema de ecuaciones";
            buttonUnidad2.TextAlign = ContentAlignment.MiddleRight;
            buttonUnidad2.TextImageRelation = TextImageRelation.TextBeforeImage;
            buttonUnidad2.UseVisualStyleBackColor = false;
            buttonUnidad2.Click += buttonUnidad2_Click;
            // 
            // buttonUnidad1
            // 
            buttonUnidad1.BackColor = Color.FromArgb(233, 231, 235);
            buttonUnidad1.Dock = DockStyle.Top;
            buttonUnidad1.FlatAppearance.BorderColor = Color.White;
            buttonUnidad1.FlatAppearance.BorderSize = 0;
            buttonUnidad1.FlatStyle = FlatStyle.Flat;
            buttonUnidad1.Font = new Font("Palatino Linotype", 20F);
            buttonUnidad1.ForeColor = SystemColors.ActiveCaptionText;
            buttonUnidad1.Image = (Image)resources.GetObject("buttonUnidad1.Image");
            buttonUnidad1.ImageAlign = ContentAlignment.MiddleLeft;
            buttonUnidad1.Location = new Point(0, 79);
            buttonUnidad1.Name = "buttonUnidad1";
            buttonUnidad1.Size = new Size(867, 96);
            buttonUnidad1.TabIndex = 0;
            buttonUnidad1.Text = "Raíces de funciones\r\n";
            buttonUnidad1.TextAlign = ContentAlignment.MiddleRight;
            buttonUnidad1.TextImageRelation = TextImageRelation.TextBeforeImage;
            buttonUnidad1.UseVisualStyleBackColor = false;
            buttonUnidad1.Click += buttonUnidad1_Click;
            // 
            // panel2
            // 
            panel2.BackColor = Color.LightSeaGreen;
            panel2.BackgroundImage = (Image)resources.GetObject("panel2.BackgroundImage");
            panel2.Controls.Add(panel3);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(867, 79);
            panel2.TabIndex = 1;
            panel2.Paint += panel2_Paint;
            // 
            // panel3
            // 
            panel3.BackColor = Color.LightSeaGreen;
            panel3.BackgroundImage = (Image)resources.GetObject("panel3.BackgroundImage");
            panel3.Controls.Add(label9);
            panel3.Dock = DockStyle.Top;
            panel3.Location = new Point(0, 0);
            panel3.Name = "panel3";
            panel3.Size = new Size(867, 79);
            panel3.TabIndex = 2;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.BackColor = SystemColors.ActiveCaptionText;
            label9.BorderStyle = BorderStyle.FixedSingle;
            label9.Font = new Font("Rockwell", 18F);
            label9.ForeColor = Color.White;
            label9.Location = new Point(384, 18);
            label9.Name = "label9";
            label9.Size = new Size(106, 40);
            label9.TabIndex = 28;
            label9.Text = "Menú";
            label9.Click += label9_Click;
            // 
            // FormPrincipal
            // 
            ClientSize = new Size(866, 642);
            Controls.Add(panel1);
            Name = "FormPrincipal";
            panel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ResumeLayout(false);

        }
        #endregion

        private Label label9;
    }
}