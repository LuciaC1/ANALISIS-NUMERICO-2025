namespace U1
{
    partial class FormUnidad3
    {
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


        private void InitializeComponent()
        {
            panel1 = new Panel();
            labelGrado = new Label();
            textBoxGrado = new TextBox();
            labelDatEntrada = new Label();
            buttonBorrarTodos = new Button();
            labelPuntosIngresar = new Label();
            labelMetodo = new Label();
            labelTole = new Label();
            labelPuntos = new Label();
            buttonCalcular = new Button();
            buttonCargar = new Button();
            buttonBorrarUltimo = new Button();
            comboBox1 = new ComboBox();
            textBoxTolerancia = new TextBox();
            textBoxY = new TextBox();
            textBoxX = new TextBox();
            panelPuntosIngresados = new Panel();
            panel2 = new Panel();
            labelDatSalida = new Label();
            labelEfectividadAjuste = new Label();
            labelCorrelacion = new Label();
            labelFuncionObtenida = new Label();
            panelGraficador = new Panel();
            webViewUnidad3 = new Microsoft.Web.WebView2.WinForms.WebView2();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            panelGraficador.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)webViewUnidad3).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.MediumAquamarine;
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(labelGrado);
            panel1.Controls.Add(textBoxGrado);
            panel1.Controls.Add(labelDatEntrada);
            panel1.Controls.Add(buttonBorrarTodos);
            panel1.Controls.Add(labelPuntosIngresar);
            panel1.Controls.Add(labelMetodo);
            panel1.Controls.Add(labelTole);
            panel1.Controls.Add(labelPuntos);
            panel1.Controls.Add(buttonCalcular);
            panel1.Controls.Add(buttonCargar);
            panel1.Controls.Add(buttonBorrarUltimo);
            panel1.Controls.Add(comboBox1);
            panel1.Controls.Add(textBoxTolerancia);
            panel1.Controls.Add(textBoxY);
            panel1.Controls.Add(textBoxX);
            panel1.Controls.Add(panelPuntosIngresados);
            panel1.Location = new Point(0, 2);
            panel1.Margin = new Padding(3, 2, 3, 2);
            panel1.Name = "panel1";
            panel1.Size = new Size(383, 627);
            panel1.TabIndex = 0;
            panel1.Paint += panel1_Paint;
            // 
            // labelGrado
            // 
            labelGrado.AutoSize = true;
            labelGrado.Font = new Font("Rockwell", 15F);
            labelGrado.Location = new Point(5, 105);
            labelGrado.Name = "labelGrado";
            labelGrado.Size = new Size(75, 22);
            labelGrado.TabIndex = 11;
            labelGrado.Text = "Grado:";
            // 
            // textBoxGrado
            // 
            textBoxGrado.Location = new Point(100, 104);
            textBoxGrado.Margin = new Padding(3, 2, 3, 2);
            textBoxGrado.Name = "textBoxGrado";
            textBoxGrado.Size = new Size(146, 23);
            textBoxGrado.TabIndex = 10;
            // 
            // labelDatEntrada
            // 
            labelDatEntrada.AutoSize = true;
            labelDatEntrada.BackColor = Color.Transparent;
            labelDatEntrada.Font = new Font("Rockwell", 15F);
            labelDatEntrada.ForeColor = SystemColors.ControlText;
            labelDatEntrada.Location = new Point(5, 4);
            labelDatEntrada.Name = "labelDatEntrada";
            labelDatEntrada.Size = new Size(169, 22);
            labelDatEntrada.TabIndex = 3;
            labelDatEntrada.Text = "Datos de Entrada";
            labelDatEntrada.Click += labelDatEntrada_Click_1;
            // 
            // buttonBorrarTodos
            // 
            buttonBorrarTodos.BackColor = Color.DarkGreen;
            buttonBorrarTodos.Font = new Font("Rockwell", 8.25F);
            buttonBorrarTodos.ForeColor = SystemColors.ButtonHighlight;
            buttonBorrarTodos.Location = new Point(267, 274);
            buttonBorrarTodos.Margin = new Padding(3, 2, 3, 2);
            buttonBorrarTodos.Name = "buttonBorrarTodos";
            buttonBorrarTodos.Size = new Size(106, 38);
            buttonBorrarTodos.TabIndex = 5;
            buttonBorrarTodos.Text = "Borrar todos los puntos";
            buttonBorrarTodos.UseVisualStyleBackColor = false;
            buttonBorrarTodos.Click += buttonBorrarTodos_Click;
            // 
            // labelPuntosIngresar
            // 
            labelPuntosIngresar.AutoSize = true;
            labelPuntosIngresar.Location = new Point(5, 187);
            labelPuntosIngresar.Name = "labelPuntosIngresar";
            labelPuntosIngresar.Size = new Size(107, 15);
            labelPuntosIngresar.TabIndex = 9;
            labelPuntosIngresar.Text = "Puntos Ingresados:";
            // 
            // labelMetodo
            // 
            labelMetodo.AutoSize = true;
            labelMetodo.Font = new Font("Rockwell", 15F);
            labelMetodo.Location = new Point(3, 138);
            labelMetodo.Name = "labelMetodo";
            labelMetodo.Size = new Size(86, 22);
            labelMetodo.TabIndex = 8;
            labelMetodo.Text = "Método:";
            // 
            // labelTole
            // 
            labelTole.AutoSize = true;
            labelTole.Font = new Font("Rockwell", 15F);
            labelTole.Location = new Point(3, 71);
            labelTole.Name = "labelTole";
            labelTole.Size = new Size(112, 22);
            labelTole.TabIndex = 7;
            labelTole.Text = "Tolerancia:";
            // 
            // labelPuntos
            // 
            labelPuntos.AutoSize = true;
            labelPuntos.Font = new Font("Rockwell", 15F);
            labelPuntos.Location = new Point(3, 34);
            labelPuntos.Name = "labelPuntos";
            labelPuntos.Size = new Size(75, 22);
            labelPuntos.TabIndex = 6;
            labelPuntos.Text = "Puntos:";
            // 
            // buttonCalcular
            // 
            buttonCalcular.BackColor = Color.DarkGreen;
            buttonCalcular.Font = new Font("Rockwell", 12F);
            buttonCalcular.ForeColor = SystemColors.ButtonHighlight;
            buttonCalcular.Location = new Point(137, 160);
            buttonCalcular.Margin = new Padding(3, 2, 3, 2);
            buttonCalcular.Name = "buttonCalcular";
            buttonCalcular.Size = new Size(87, 27);
            buttonCalcular.TabIndex = 2;
            buttonCalcular.Text = "Calcular";
            buttonCalcular.UseVisualStyleBackColor = false;
            buttonCalcular.Click += buttonCalcular_Click;
            // 
            // buttonCargar
            // 
            buttonCargar.BackColor = Color.DarkGreen;
            buttonCargar.Font = new Font("Rockwell", 10F);
            buttonCargar.ForeColor = SystemColors.ButtonHighlight;
            buttonCargar.Location = new Point(298, 34);
            buttonCargar.Margin = new Padding(3, 2, 3, 2);
            buttonCargar.Name = "buttonCargar";
            buttonCargar.Size = new Size(76, 25);
            buttonCargar.TabIndex = 3;
            buttonCargar.Text = "Cargar";
            buttonCargar.UseVisualStyleBackColor = false;
            buttonCargar.Click += buttonCargar_Click;
            // 
            // buttonBorrarUltimo
            // 
            buttonBorrarUltimo.BackColor = Color.DarkGreen;
            buttonBorrarUltimo.Font = new Font("Rockwell", 8.25F);
            buttonBorrarUltimo.ForeColor = SystemColors.ButtonHighlight;
            buttonBorrarUltimo.Location = new Point(268, 225);
            buttonBorrarUltimo.Margin = new Padding(3, 2, 3, 2);
            buttonBorrarUltimo.Name = "buttonBorrarUltimo";
            buttonBorrarUltimo.Size = new Size(106, 38);
            buttonBorrarUltimo.TabIndex = 4;
            buttonBorrarUltimo.Text = "Borrar último punto";
            buttonBorrarUltimo.UseVisualStyleBackColor = false;
            buttonBorrarUltimo.Click += buttonBorrarUltimo_Click;
            // 
            // comboBox1
            // 
            comboBox1.Font = new Font("Rockwell", 8.25F);
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "Regresión Lineal por mínimos cuadrados", "Regresión Polinomial por mínimos cuadrados" });
            comboBox1.Location = new Point(106, 136);
            comboBox1.Margin = new Padding(3, 2, 3, 2);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(255, 21);
            comboBox1.TabIndex = 2;
            // 
            // textBoxTolerancia
            // 
            textBoxTolerancia.Location = new Point(115, 73);
            textBoxTolerancia.Margin = new Padding(3, 2, 3, 2);
            textBoxTolerancia.Name = "textBoxTolerancia";
            textBoxTolerancia.Size = new Size(146, 23);
            textBoxTolerancia.TabIndex = 4;
            // 
            // textBoxY
            // 
            textBoxY.Location = new Point(190, 36);
            textBoxY.Margin = new Padding(3, 2, 3, 2);
            textBoxY.Name = "textBoxY";
            textBoxY.Size = new Size(97, 23);
            textBoxY.TabIndex = 3;
            textBoxY.TextAlign = HorizontalAlignment.Center;
            // 
            // textBoxX
            // 
            textBoxX.Location = new Point(87, 37);
            textBoxX.Margin = new Padding(3, 2, 3, 2);
            textBoxX.Name = "textBoxX";
            textBoxX.Size = new Size(97, 23);
            textBoxX.TabIndex = 2;
            textBoxX.TextAlign = HorizontalAlignment.Center;
            // 
            // panelPuntosIngresados
            // 
            panelPuntosIngresados.BackColor = Color.LightGreen;
            panelPuntosIngresados.BorderStyle = BorderStyle.FixedSingle;
            panelPuntosIngresados.Font = new Font("Rockwell", 6F);
            panelPuntosIngresados.Location = new Point(4, 214);
            panelPuntosIngresados.Margin = new Padding(3, 2, 3, 2);
            panelPuntosIngresados.Name = "panelPuntosIngresados";
            panelPuntosIngresados.Size = new Size(258, 399);
            panelPuntosIngresados.TabIndex = 1;
            panelPuntosIngresados.Paint += PanelPuntosIngresados_Paint;
            // 
            // panel2
            // 
            panel2.BackColor = Color.MediumAquamarine;
            panel2.Controls.Add(labelDatSalida);
            panel2.Controls.Add(labelEfectividadAjuste);
            panel2.Controls.Add(labelCorrelacion);
            panel2.Controls.Add(labelFuncionObtenida);
            panel2.Controls.Add(panelGraficador);
            panel2.Location = new Point(396, 2);
            panel2.Margin = new Padding(3, 2, 3, 2);
            panel2.Name = "panel2";
            panel2.Size = new Size(1037, 693);
            panel2.TabIndex = 1;
            // 
            // labelDatSalida
            // 
            labelDatSalida.AutoSize = true;
            labelDatSalida.BackColor = Color.Transparent;
            labelDatSalida.Font = new Font("Rockwell", 9F, FontStyle.Bold);
            labelDatSalida.Location = new Point(11, 4);
            labelDatSalida.Name = "labelDatSalida";
            labelDatSalida.Size = new Size(98, 14);
            labelDatSalida.TabIndex = 6;
            labelDatSalida.Text = "Datos de Salida";
            // 
            // labelEfectividadAjuste
            // 
            labelEfectividadAjuste.AutoSize = true;
            labelEfectividadAjuste.Location = new Point(11, 98);
            labelEfectividadAjuste.Name = "labelEfectividadAjuste";
            labelEfectividadAjuste.Size = new Size(123, 15);
            labelEfectividadAjuste.TabIndex = 9;
            labelEfectividadAjuste.Text = "Efectividad del Ajuste:";
            // 
            // labelCorrelacion
            // 
            labelCorrelacion.AutoSize = true;
            labelCorrelacion.Location = new Point(11, 64);
            labelCorrelacion.Name = "labelCorrelacion";
            labelCorrelacion.Size = new Size(86, 15);
            labelCorrelacion.TabIndex = 8;
            labelCorrelacion.Text = "Correlación (r):";
            // 
            // labelFuncionObtenida
            // 
            labelFuncionObtenida.AutoSize = true;
            labelFuncionObtenida.Location = new Point(11, 27);
            labelFuncionObtenida.Name = "labelFuncionObtenida";
            labelFuncionObtenida.Size = new Size(105, 15);
            labelFuncionObtenida.TabIndex = 7;
            labelFuncionObtenida.Text = "Función Obtenida:";
            // 
            // panelGraficador
            // 
            panelGraficador.BackColor = Color.LightGreen;
            panelGraficador.Controls.Add(webViewUnidad3);
            panelGraficador.Location = new Point(3, 131);
            panelGraficador.Margin = new Padding(3, 2, 3, 2);
            panelGraficador.Name = "panelGraficador";
            panelGraficador.Size = new Size(686, 430);
            panelGraficador.TabIndex = 1;
            panelGraficador.Paint += PanelGraficador_Paint;
            // 
            // webViewUnidad3
            // 
            webViewUnidad3.AllowExternalDrop = true;
            webViewUnidad3.CreationProperties = null;
            webViewUnidad3.DefaultBackgroundColor = Color.White;
            webViewUnidad3.Location = new Point(3, 2);
            webViewUnidad3.Margin = new Padding(3, 2, 3, 2);
            webViewUnidad3.Name = "webViewUnidad3";
            webViewUnidad3.Size = new Size(799, 479);
            webViewUnidad3.TabIndex = 0;
            webViewUnidad3.ZoomFactor = 1D;
            webViewUnidad3.Click += webViewUnidad3_Click;
            // 
            // FormUnidad3
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1435, 693);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Margin = new Padding(3, 2, 3, 2);
            Name = "FormUnidad3";
            Text = "Unidad3";
            Load += FormUnidad3_Load_1;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panelGraficador.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)webViewUnidad3).EndInit();
            ResumeLayout(false);
        }

        private void PanelPuntosIngresados_Paint(object sender, PaintEventArgs e)
        {
            ControlPaint.DrawBorder(e.Graphics, panelPuntosIngresados.ClientRectangle, Color.Black, ButtonBorderStyle.Solid);
        }

        private void PanelGraficador_Paint(object sender, PaintEventArgs e)
        {
            ControlPaint.DrawBorder(e.Graphics, panelGraficador.ClientRectangle, Color.Black, ButtonBorderStyle.Solid);
        }



        private Panel panel1;
        private Button buttonCalcular;
        private Button buttonCargar;
        private Button buttonBorrarTodos;
        private Button buttonBorrarUltimo;
        private TextBox textBoxTolerancia;
        private TextBox textBoxY;
        private TextBox textBoxX;
        private Panel panelPuntosIngresados;
        private Panel panel2;
        private Panel panelGraficador;
        private Label labelPuntos;
        private Label labelDatEntrada;
        private Label labelDatSalida;
        private Label labelPuntosIngresar;
        private Label labelMetodo;
        private Label labelTole;
        private Label labelFuncionObtenida;
        private Label labelEfectividadAjuste;
        private Label labelCorrelacion;
        private ComboBox comboBox1;
        private Label labelGrado;
        private TextBox textBoxGrado;
        private Button buttonVolverMenu;
        #endregion

        private Microsoft.Web.WebView2.WinForms.WebView2 webViewUnidad3;
    }

}
