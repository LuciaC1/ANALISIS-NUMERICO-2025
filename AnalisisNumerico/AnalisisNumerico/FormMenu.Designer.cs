namespace U1
{
    partial class FormMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMenu));
            txtIteraciones = new TextBox();
            label3 = new Label();
            txtTolerancia = new TextBox();
            label4 = new Label();
            label5 = new Label();
            txtXi = new TextBox();
            txtXd = new TextBox();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            label9 = new Label();
            label12 = new Label();
            label13 = new Label();
            label14 = new Label();
            label15 = new Label();
            txtResFuncion = new TextBox();
            label16 = new Label();
            txtResMetodo = new TextBox();
            txtResIteraciones = new TextBox();
            txtResTolerancia = new TextBox();
            txtResConverge = new TextBox();
            label10 = new Label();
            txtResError = new TextBox();
            label11 = new Label();
            label17 = new Label();
            txtFuncion = new TextBox();
            label18 = new Label();
            txtResRaiz = new TextBox();
            button1 = new Button();
            cmbMetodo = new ComboBox();
            SuspendLayout();
            // 
            // txtIteraciones
            // 
            txtIteraciones.BackColor = Color.FromArgb(233, 231, 235);
            txtIteraciones.BorderStyle = BorderStyle.FixedSingle;
            txtIteraciones.Font = new Font("Rockwell", 12F);
            txtIteraciones.Location = new Point(45, 235);
            txtIteraciones.Name = "txtIteraciones";
            txtIteraciones.Size = new Size(237, 26);
            txtIteraciones.TabIndex = 5;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = SystemColors.ActiveCaptionText;
            label3.BorderStyle = BorderStyle.FixedSingle;
            label3.Font = new Font("Rockwell", 12F);
            label3.Location = new Point(107, 209);
            label3.Name = "label3";
            label3.Size = new Size(92, 21);
            label3.TabIndex = 4;
            label3.Text = "Iteraciones";
            // 
            // txtTolerancia
            // 
            txtTolerancia.BackColor = Color.FromArgb(233, 231, 235);
            txtTolerancia.BorderStyle = BorderStyle.FixedSingle;
            txtTolerancia.Font = new Font("Rockwell", 12F);
            txtTolerancia.Location = new Point(45, 291);
            txtTolerancia.Name = "txtTolerancia";
            txtTolerancia.Size = new Size(237, 26);
            txtTolerancia.TabIndex = 7;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = SystemColors.ActiveCaptionText;
            label4.BorderStyle = BorderStyle.FixedSingle;
            label4.Font = new Font("Rockwell", 12F);
            label4.Location = new Point(116, 265);
            label4.Name = "label4";
            label4.Size = new Size(88, 21);
            label4.TabIndex = 6;
            label4.Text = "Tolerancia";
            label4.Click += label4_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = SystemColors.ActiveCaptionText;
            label5.BorderStyle = BorderStyle.FixedSingle;
            label5.Font = new Font("Rockwell", 12F);
            label5.Location = new Point(116, 323);
            label5.Name = "label5";
            label5.Size = new Size(77, 21);
            label5.TabIndex = 8;
            label5.Text = "Intervalo";
            // 
            // txtXi
            // 
            txtXi.BackColor = Color.FromArgb(233, 231, 235);
            txtXi.BorderStyle = BorderStyle.FixedSingle;
            txtXi.Font = new Font("Rockwell", 12F);
            txtXi.Location = new Point(45, 349);
            txtXi.Name = "txtXi";
            txtXi.Size = new Size(105, 26);
            txtXi.TabIndex = 9;
            txtXi.TextChanged += textBox5_TextChanged;
            // 
            // txtXd
            // 
            txtXd.BackColor = Color.FromArgb(233, 231, 235);
            txtXd.BorderStyle = BorderStyle.FixedSingle;
            txtXd.Font = new Font("Rockwell", 12F);
            txtXd.Location = new Point(177, 349);
            txtXd.Name = "txtXd";
            txtXd.Size = new Size(105, 26);
            txtXd.TabIndex = 10;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = SystemColors.ActiveCaptionText;
            label6.BorderStyle = BorderStyle.FixedSingle;
            label6.Font = new Font("Rockwell", 12F);
            label6.Location = new Point(31, 385);
            label6.Name = "label6";
            label6.Size = new Size(89, 21);
            label6.TabIndex = 11;
            label6.Text = "xi , xInicial";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = SystemColors.ActiveCaptionText;
            label7.BorderStyle = BorderStyle.FixedSingle;
            label7.Font = new Font("Rockwell", 12F);
            label7.Location = new Point(211, 382);
            label7.Name = "label7";
            label7.Size = new Size(30, 21);
            label7.TabIndex = 12;
            label7.Text = "xd";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.BackColor = SystemColors.ActiveCaptionText;
            label8.BorderStyle = BorderStyle.FixedSingle;
            label8.Font = new Font("Rockwell", 12F);
            label8.Location = new Point(93, 38);
            label8.Name = "label8";
            label8.Size = new Size(134, 21);
            label8.TabIndex = 13;
            label8.Text = "Ingreso de datos";
            label8.Click += label8_Click;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.BackColor = SystemColors.ActiveCaptionText;
            label9.BorderStyle = BorderStyle.FixedSingle;
            label9.Font = new Font("Rockwell", 12F);
            label9.ForeColor = Color.White;
            label9.Location = new Point(960, 38);
            label9.Name = "label9";
            label9.Size = new Size(90, 21);
            label9.TabIndex = 27;
            label9.Text = "Resultados";
            label9.Click += label9_Click;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.BackColor = SystemColors.ActiveCaptionText;
            label12.BorderStyle = BorderStyle.FixedSingle;
            label12.Font = new Font("Rockwell", 12F);
            label12.ForeColor = Color.White;
            label12.Location = new Point(892, 335);
            label12.Name = "label12";
            label12.Size = new Size(101, 21);
            label12.TabIndex = 22;
            label12.Text = "¿Converge?";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.BackColor = SystemColors.ActiveCaptionText;
            label13.BorderStyle = BorderStyle.FixedSingle;
            label13.Font = new Font("Rockwell", 12F);
            label13.ForeColor = Color.White;
            label13.Location = new Point(970, 265);
            label13.Name = "label13";
            label13.Size = new Size(88, 21);
            label13.TabIndex = 20;
            label13.Text = "Tolerancia";
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.BackColor = SystemColors.ActiveCaptionText;
            label14.BorderStyle = BorderStyle.FixedSingle;
            label14.Font = new Font("Rockwell", 12F);
            label14.ForeColor = Color.White;
            label14.Location = new Point(927, 209);
            label14.Name = "label14";
            label14.Size = new Size(174, 21);
            label14.TabIndex = 18;
            label14.Text = "Iteraciones Realizadas";
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.BackColor = SystemColors.ActiveCaptionText;
            label15.BorderStyle = BorderStyle.FixedSingle;
            label15.Font = new Font("Rockwell", 12F);
            label15.ForeColor = Color.White;
            label15.Location = new Point(997, 148);
            label15.Name = "label15";
            label15.Size = new Size(67, 21);
            label15.TabIndex = 16;
            label15.Text = "Método";
            // 
            // txtResFuncion
            // 
            txtResFuncion.BackColor = Color.FromArgb(233, 231, 235);
            txtResFuncion.BorderStyle = BorderStyle.FixedSingle;
            txtResFuncion.Font = new Font("Rockwell", 12F);
            txtResFuncion.Location = new Point(910, 110);
            txtResFuncion.Name = "txtResFuncion";
            txtResFuncion.Size = new Size(237, 26);
            txtResFuncion.TabIndex = 15;
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.BackColor = SystemColors.ActiveCaptionText;
            label16.BorderStyle = BorderStyle.FixedSingle;
            label16.Font = new Font("Rockwell", 12F);
            label16.ForeColor = Color.White;
            label16.Location = new Point(991, 84);
            label16.Name = "label16";
            label16.Size = new Size(68, 21);
            label16.TabIndex = 14;
            label16.Text = "Función";
            // 
            // txtResMetodo
            // 
            txtResMetodo.BackColor = Color.FromArgb(233, 231, 235);
            txtResMetodo.BorderStyle = BorderStyle.FixedSingle;
            txtResMetodo.Font = new Font("Rockwell", 12F);
            txtResMetodo.Location = new Point(910, 174);
            txtResMetodo.Name = "txtResMetodo";
            txtResMetodo.Size = new Size(237, 26);
            txtResMetodo.TabIndex = 28;
            // 
            // txtResIteraciones
            // 
            txtResIteraciones.BackColor = Color.FromArgb(233, 231, 235);
            txtResIteraciones.BorderStyle = BorderStyle.FixedSingle;
            txtResIteraciones.Font = new Font("Rockwell", 12F);
            txtResIteraciones.Location = new Point(911, 235);
            txtResIteraciones.Name = "txtResIteraciones";
            txtResIteraciones.Size = new Size(237, 26);
            txtResIteraciones.TabIndex = 29;
            // 
            // txtResTolerancia
            // 
            txtResTolerancia.BackColor = Color.FromArgb(233, 231, 235);
            txtResTolerancia.BorderStyle = BorderStyle.FixedSingle;
            txtResTolerancia.Font = new Font("Rockwell", 12F);
            txtResTolerancia.Location = new Point(911, 291);
            txtResTolerancia.Name = "txtResTolerancia";
            txtResTolerancia.Size = new Size(237, 26);
            txtResTolerancia.TabIndex = 30;
            // 
            // txtResConverge
            // 
            txtResConverge.BackColor = Color.FromArgb(233, 231, 235);
            txtResConverge.BorderStyle = BorderStyle.FixedSingle;
            txtResConverge.Font = new Font("Rockwell", 12F);
            txtResConverge.Location = new Point(877, 361);
            txtResConverge.Name = "txtResConverge";
            txtResConverge.Size = new Size(139, 26);
            txtResConverge.TabIndex = 31;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.BackColor = SystemColors.ActiveCaptionText;
            label10.BorderStyle = BorderStyle.FixedSingle;
            label10.Font = new Font("Rockwell", 12F);
            label10.ForeColor = Color.White;
            label10.Location = new Point(1096, 335);
            label10.Name = "label10";
            label10.Size = new Size(41, 21);
            label10.TabIndex = 35;
            label10.Text = "Raíz";
            label10.Click += label10_Click;
            // 
            // txtResError
            // 
            txtResError.BackColor = Color.FromArgb(233, 231, 235);
            txtResError.BorderStyle = BorderStyle.FixedSingle;
            txtResError.Font = new Font("Rockwell", 12F);
            txtResError.Location = new Point(911, 420);
            txtResError.Name = "txtResError";
            txtResError.Size = new Size(237, 26);
            txtResError.TabIndex = 37;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.BackColor = SystemColors.ActiveCaptionText;
            label11.BorderStyle = BorderStyle.FixedSingle;
            label11.Font = new Font("Rockwell", 12F);
            label11.ForeColor = Color.White;
            label11.Location = new Point(998, 395);
            label11.Name = "label11";
            label11.Size = new Size(51, 21);
            label11.TabIndex = 36;
            label11.Text = "Error";
            label11.Click += label11_Click;
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.BackColor = SystemColors.ActiveCaptionText;
            label17.BorderStyle = BorderStyle.FixedSingle;
            label17.Font = new Font("Rockwell", 12F);
            label17.Location = new Point(132, 148);
            label17.Name = "label17";
            label17.Size = new Size(67, 21);
            label17.TabIndex = 40;
            label17.Text = "Método";
            // 
            // txtFuncion
            // 
            txtFuncion.BackColor = Color.FromArgb(233, 231, 235);
            txtFuncion.BorderStyle = BorderStyle.FixedSingle;
            txtFuncion.Font = new Font("Rockwell", 12F);
            txtFuncion.Location = new Point(45, 110);
            txtFuncion.Name = "txtFuncion";
            txtFuncion.Size = new Size(237, 26);
            txtFuncion.TabIndex = 39;
            txtFuncion.TextChanged += textBox15_TextChanged;
            // 
            // label18
            // 
            label18.AutoSize = true;
            label18.BackColor = SystemColors.ActiveCaptionText;
            label18.BorderStyle = BorderStyle.FixedSingle;
            label18.Font = new Font("Rockwell", 12F);
            label18.Location = new Point(126, 84);
            label18.Name = "label18";
            label18.Size = new Size(68, 21);
            label18.TabIndex = 38;
            label18.Text = "Función";
            // 
            // txtResRaiz
            // 
            txtResRaiz.BackColor = Color.FromArgb(233, 231, 235);
            txtResRaiz.BorderStyle = BorderStyle.FixedSingle;
            txtResRaiz.Font = new Font("Rockwell", 12F);
            txtResRaiz.Location = new Point(1049, 361);
            txtResRaiz.Name = "txtResRaiz";
            txtResRaiz.Size = new Size(139, 26);
            txtResRaiz.TabIndex = 42;
            txtResRaiz.TextChanged += textBox1_TextChanged;
            // 
            // button1
            // 
            button1.BackColor = SystemColors.ActiveCaptionText;
            button1.Font = new Font("Rockwell", 12F);
            button1.Location = new Point(116, 420);
            button1.Name = "button1";
            button1.Size = new Size(94, 37);
            button1.TabIndex = 44;
            button1.Text = "CALCULAR";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click_1;
            // 
            // cmbMetodo
            // 
            cmbMetodo.BackColor = Color.FromArgb(233, 231, 235);
            cmbMetodo.Font = new Font("Rockwell", 12F);
            cmbMetodo.FormattingEnabled = true;
            cmbMetodo.Location = new Point(45, 174);
            cmbMetodo.Name = "cmbMetodo";
            cmbMetodo.Size = new Size(237, 27);
            cmbMetodo.TabIndex = 45;
            // 
            // FormMenu
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaptionText;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(1106, 456);
            Controls.Add(cmbMetodo);
            Controls.Add(button1);
            Controls.Add(txtResRaiz);
            Controls.Add(label17);
            Controls.Add(txtFuncion);
            Controls.Add(label18);
            Controls.Add(txtResError);
            Controls.Add(label11);
            Controls.Add(label10);
            Controls.Add(txtResConverge);
            Controls.Add(txtResTolerancia);
            Controls.Add(txtResIteraciones);
            Controls.Add(txtResMetodo);
            Controls.Add(label9);
            Controls.Add(label12);
            Controls.Add(label13);
            Controls.Add(label14);
            Controls.Add(label15);
            Controls.Add(txtResFuncion);
            Controls.Add(label16);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(txtXd);
            Controls.Add(txtXi);
            Controls.Add(label5);
            Controls.Add(txtTolerancia);
            Controls.Add(label4);
            Controls.Add(txtIteraciones);
            Controls.Add(label3);
            ForeColor = Color.White;
            Name = "FormMenu";
            Text = "FormMenu";
            Load += FormMenu_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private TextBox txtIteraciones;
        private Label label3;
        private TextBox txtTolerancia;
        private Label label4;
        private Label label5;
        private TextBox txtXi;
        private TextBox txtXd;
        private Label label6;
        private Label label7;
        private Label label8;
        private Label label9;
        private Label label12;
        private Label label13;
        private Label label14;
        private Label label15;
        private TextBox txtResFuncion;
        private Label label16;
        private TextBox txtResMetodo;
        private TextBox txtResIteraciones;
        private TextBox txtResTolerancia;
        private TextBox txtResConverge;
        private Label label10;
        private TextBox txtResError;
        private Label label11;
        private Label label17;
        private TextBox txtFuncion;
        private Label label18;
        private TextBox txtResRaiz;
        private Button button1;
        private ComboBox cmbMetodo;
    }
}