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
            panel1 = new Panel();
            labelArea = new Label();
            panel2 = new Panel();
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
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.Coral;
            panel1.Controls.Add(labelArea);
            panel1.Location = new Point(408, 2);
            panel1.Name = "panel1";
            panel1.Size = new Size(391, 445);
            panel1.TabIndex = 0;
            // 
            // labelArea
            // 
            labelArea.AutoSize = true;
            labelArea.Location = new Point(18, 36);
            labelArea.Name = "labelArea";
            labelArea.Size = new Size(43, 20);
            labelArea.TabIndex = 7;
            labelArea.Text = "Area:";
            // 
            // panel2
            // 
            panel2.BackColor = Color.Coral;
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
            panel2.Location = new Point(1, 2);
            panel2.Name = "panel2";
            panel2.Size = new Size(401, 445);
            panel2.TabIndex = 1;
            // 
            // buttonCalcular
            // 
            buttonCalcular.BackColor = Color.DarkOrange;
            buttonCalcular.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            buttonCalcular.ForeColor = SystemColors.ButtonHighlight;
            buttonCalcular.Location = new Point(155, 279);
            buttonCalcular.Name = "buttonCalcular";
            buttonCalcular.Size = new Size(159, 37);
            buttonCalcular.TabIndex = 8;
            buttonCalcular.Text = "Calcular";
            buttonCalcular.UseVisualStyleBackColor = false;
            buttonCalcular.Click += buttonCalcular_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(11, 220);
            label5.Name = "label5";
            label5.Size = new Size(65, 20);
            label5.TabIndex = 9;
            label5.Text = "Método:";
            // 
            // comboBoxMetodo
            // 
            comboBoxMetodo.ForeColor = Color.Black;
            comboBoxMetodo.FormattingEnabled = true;
            comboBoxMetodo.Items.AddRange(new object[] { "Integral Trapecios Simple", "Integral Trapecios Multiple", "Integral Simpson 1/3 Simple", "Integral Simpson 1/3 Multiple", "Integral Simpson 3/8", "Simpson 1/3 Multiple y Simpson 3/8 Combinados" });
            comboBoxMetodo.Location = new Point(82, 217);
            comboBoxMetodo.Name = "comboBoxMetodo";
            comboBoxMetodo.Size = new Size(306, 28);
            comboBoxMetodo.TabIndex = 8;
            comboBoxMetodo.SelectedIndexChanged += comboBoxMetodo_SelectedIndexChanged;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(11, 148);
            label4.Name = "label4";
            label4.Size = new Size(206, 20);
            label4.TabIndex = 6;
            label4.Text = "Cantidad de subintervalos (n):";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(220, 78);
            label3.Name = "label3";
            label3.Size = new Size(30, 20);
            label3.TabIndex = 5;
            label3.Text = "Xd:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(11, 78);
            label2.Name = "label2";
            label2.Size = new Size(25, 20);
            label2.TabIndex = 4;
            label2.Text = "Xi:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(11, 36);
            label1.Name = "label1";
            label1.Size = new Size(36, 20);
            label1.TabIndex = 0;
            label1.Text = "F(x):";
            // 
            // textBoxSubIntervalos
            // 
            textBoxSubIntervalos.Location = new Point(223, 145);
            textBoxSubIntervalos.Name = "textBoxSubIntervalos";
            textBoxSubIntervalos.Size = new Size(165, 27);
            textBoxSubIntervalos.TabIndex = 3;
            // 
            // textBoxXd
            // 
            textBoxXd.Location = new Point(256, 71);
            textBoxXd.Name = "textBoxXd";
            textBoxXd.Size = new Size(132, 27);
            textBoxXd.TabIndex = 2;
            // 
            // textBoxXi
            // 
            textBoxXi.Location = new Point(73, 71);
            textBoxXi.Name = "textBoxXi";
            textBoxXi.Size = new Size(132, 27);
            textBoxXi.TabIndex = 1;
            // 
            // textBoxFuncion
            // 
            textBoxFuncion.Location = new Point(73, 29);
            textBoxFuncion.Name = "textBoxFuncion";
            textBoxFuncion.Size = new Size(315, 27);
            textBoxFuncion.TabIndex = 0;
            // 
            // Form4
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "Form4";
            Text = "Form4";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
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
    }
}