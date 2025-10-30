namespace U1
{
    partial class FormUnidad4
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormUnidad4));
            panel1 = new Panel();
            webView21 = new Microsoft.Web.WebView2.WinForms.WebView2();
            labelArea = new Label();
            panel2 = new Panel();
            buttonVolverMenu = new Button();
            buttonCalcular = new Button();
            label5 = new Label();
            comboBoxMetodo = new ComboBox();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            textBoxSubIntervalos = new TextBox();
            textBoxXd = new TextBox();
            textBoxXi = new TextBox();
            textBoxFuncion = new TextBox();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)webView21).BeginInit();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.BackgroundImage = (Image)resources.GetObject("panel1.BackgroundImage");
            panel1.Controls.Add(webView21);
            panel1.Controls.Add(labelArea);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1563, 921);
            panel1.TabIndex = 0;
            // 
            // webView21
            // 
            webView21.AllowExternalDrop = true;
            webView21.BackColor = Color.Snow;
            webView21.CreationProperties = null;
            webView21.DefaultBackgroundColor = Color.White;
            webView21.Location = new Point(596, 99);
            webView21.Margin = new Padding(3, 4, 3, 4);
            webView21.Name = "webView21";
            webView21.Size = new Size(955, 789);
            webView21.TabIndex = 8;
            webView21.ZoomFactor = 1D;
            webView21.Click += webView21_Click;
            // 
            // labelArea
            // 
            labelArea.AutoSize = true;
            labelArea.BackColor = Color.Black;
            labelArea.Font = new Font("Rockwell", 15F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelArea.ForeColor = SystemColors.ControlLightLight;
            labelArea.Location = new Point(601, 45);
            labelArea.Name = "labelArea";
            labelArea.Size = new Size(189, 29);
            labelArea.TabIndex = 7;
            labelArea.Text = "Area calculada:";
            labelArea.Click += labelArea_Click;
            // 
            // panel2
            // 
            panel2.BackColor = Color.Black;
            panel2.BackgroundImage = (Image)resources.GetObject("panel2.BackgroundImage");
            panel2.Controls.Add(buttonVolverMenu);
            panel2.Controls.Add(buttonCalcular);
            panel2.Controls.Add(label5);
            panel2.Controls.Add(comboBoxMetodo);
            panel2.Controls.Add(label4);
            panel2.Controls.Add(label3);
            panel2.Controls.Add(label2);
            panel2.Controls.Add(label1);
            panel2.Controls.Add(textBoxSubIntervalos);
            panel2.Controls.Add(textBoxXd);
            panel2.Controls.Add(textBoxXi);
            panel2.Controls.Add(textBoxFuncion);
            panel2.Dock = DockStyle.Left;
            panel2.Font = new Font("Rockwell", 15F);
            panel2.ForeColor = SystemColors.ControlLightLight;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(572, 921);
            panel2.TabIndex = 1;
            // 
            // buttonVolverMenu
            // 
            buttonVolverMenu.BackColor = SystemColors.ActiveCaptionText;
            buttonVolverMenu.Font = new Font("Rockwell", 10F);
            buttonVolverMenu.ForeColor = SystemColors.ControlLightLight;
            buttonVolverMenu.Location = new Point(14, 16);
            buttonVolverMenu.Margin = new Padding(3, 4, 3, 4);
            buttonVolverMenu.Name = "buttonVolverMenu";
            buttonVolverMenu.Size = new Size(143, 45);
            buttonVolverMenu.TabIndex = 46;
            buttonVolverMenu.Text = "Volver al menú";
            buttonVolverMenu.UseVisualStyleBackColor = false;
            buttonVolverMenu.Click += buttonVolverMenu_Click;
            // 
            // buttonCalcular
            // 
            buttonCalcular.BackColor = Color.Black;
            buttonCalcular.Font = new Font("Rockwell", 15F);
            buttonCalcular.ForeColor = SystemColors.ButtonHighlight;
            buttonCalcular.Location = new Point(197, 665);
            buttonCalcular.Name = "buttonCalcular";
            buttonCalcular.Size = new Size(159, 55);
            buttonCalcular.TabIndex = 8;
            buttonCalcular.Text = "Calcular";
            buttonCalcular.UseVisualStyleBackColor = false;
            buttonCalcular.Click += buttonCalcular_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Black;
            label5.Font = new Font("Rockwell", 15F);
            label5.ForeColor = SystemColors.ControlLightLight;
            label5.Location = new Point(229, 549);
            label5.Name = "label5";
            label5.Size = new Size(108, 29);
            label5.TabIndex = 9;
            label5.Text = "Método:";
            // 
            // comboBoxMetodo
            // 
            comboBoxMetodo.BackColor = Color.FromArgb(233, 231, 235);
            comboBoxMetodo.ForeColor = Color.Black;
            comboBoxMetodo.FormattingEnabled = true;
            comboBoxMetodo.Items.AddRange(new object[] { "Regla Trapecio Simple", "Regla Trapecio Multiple", "Regla Simpson 1/3 Simple", "Regla Simpson 1/3 Multiple", "Regla Simpson 3/8", "Regla Simpson 1/3 Multiple y Regla Simpson 3/8 Combinados" });
            comboBoxMetodo.Location = new Point(40, 604);
            comboBoxMetodo.Name = "comboBoxMetodo";
            comboBoxMetodo.Size = new Size(523, 37);
            comboBoxMetodo.TabIndex = 8;
            comboBoxMetodo.SelectedIndexChanged += comboBoxMetodo_SelectedIndexChanged;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Black;
            label4.Font = new Font("Rockwell", 15F);
            label4.ForeColor = SystemColors.ControlLightLight;
            label4.Location = new Point(93, 412);
            label4.Name = "label4";
            label4.Size = new Size(359, 29);
            label4.TabIndex = 6;
            label4.Text = "Cantidad de subintervalos (n):";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Black;
            label3.Font = new Font("Rockwell", 15F);
            label3.ForeColor = SystemColors.ControlLightLight;
            label3.Location = new Point(338, 283);
            label3.Name = "label3";
            label3.Size = new Size(50, 29);
            label3.TabIndex = 5;
            label3.Text = "xd:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Black;
            label2.Font = new Font("Rockwell", 15F);
            label2.ForeColor = SystemColors.ControlLightLight;
            label2.Location = new Point(162, 283);
            label2.Name = "label2";
            label2.Size = new Size(41, 29);
            label2.TabIndex = 4;
            label2.Text = "xi:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Black;
            label1.Font = new Font("Rockwell", 15F);
            label1.ForeColor = SystemColors.ControlLightLight;
            label1.Location = new Point(169, 115);
            label1.Name = "label1";
            label1.Size = new Size(204, 29);
            label1.TabIndex = 0;
            label1.Text = "Ingresar función:";
            // 
            // textBoxSubIntervalos
            // 
            textBoxSubIntervalos.BackColor = Color.FromArgb(233, 231, 235);
            textBoxSubIntervalos.Location = new Point(190, 472);
            textBoxSubIntervalos.Name = "textBoxSubIntervalos";
            textBoxSubIntervalos.Size = new Size(165, 37);
            textBoxSubIntervalos.TabIndex = 3;
            // 
            // textBoxXd
            // 
            textBoxXd.BackColor = Color.FromArgb(233, 231, 235);
            textBoxXd.Location = new Point(301, 340);
            textBoxXd.Name = "textBoxXd";
            textBoxXd.Size = new Size(132, 37);
            textBoxXd.TabIndex = 2;
            // 
            // textBoxXi
            // 
            textBoxXi.BackColor = Color.FromArgb(233, 231, 235);
            textBoxXi.Location = new Point(108, 340);
            textBoxXi.Name = "textBoxXi";
            textBoxXi.Size = new Size(132, 37);
            textBoxXi.TabIndex = 1;
            // 
            // textBoxFuncion
            // 
            textBoxFuncion.BackColor = Color.FromArgb(233, 231, 235);
            textBoxFuncion.Location = new Point(108, 172);
            textBoxFuncion.Name = "textBoxFuncion";
            textBoxFuncion.Size = new Size(315, 37);
            textBoxFuncion.TabIndex = 0;
            // 
            // FormUnidad4
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1563, 921);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "FormUnidad4";
            Text = "Form4";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)webView21).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private Panel panel2;
        private TextBox textBoxSubIntervalos;
        private TextBox textBoxXd;
        private TextBox textBoxXi;
        private TextBox textBoxFuncion;
        private Label label3;
        private Label label2;
        private Label labelArea;
        private Button buttonCalcular;
        private Label label5;
        private ComboBox comboBoxMetodo;
        private Label label4;
        private Button buttonVolverMenu;
        private Microsoft.Web.WebView2.WinForms.WebView2 webView21;
    }
}