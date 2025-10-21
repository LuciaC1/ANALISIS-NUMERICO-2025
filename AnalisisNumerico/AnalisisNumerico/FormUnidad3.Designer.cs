namespace U1
{
    partial class FormUnidad3
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
        /*private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Text = "FormUnidad3";
        }*/


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
            panel1.Location = new Point(0, 3);
            panel1.Name = "panel1";
            panel1.Size = new Size(437, 749);
            panel1.TabIndex = 0;
            // 
            // labelGrado
            // 
            labelGrado.AutoSize = true;
            labelGrado.Location = new Point(6, 130);
            labelGrado.Name = "labelGrado";
            labelGrado.Size = new Size(53, 20);
            labelGrado.TabIndex = 11;
            labelGrado.Text = "Grado:";
            // 
            // textBoxGrado
            // 
            textBoxGrado.Location = new Point(114, 129);
            textBoxGrado.Name = "textBoxGrado";
            textBoxGrado.Size = new Size(166, 27);
            textBoxGrado.TabIndex = 10;
            // 
            // labelDatEntrada
            // 
            labelDatEntrada.AutoSize = true;
            labelDatEntrada.BackColor = Color.Transparent;
            labelDatEntrada.Font = new Font("Rockwell", 15F);
            labelDatEntrada.ForeColor = SystemColors.ControlText;
            labelDatEntrada.Location = new Point(11, 0);
            labelDatEntrada.Name = "labelDatEntrada";
            labelDatEntrada.Size = new Size(209, 29);
            labelDatEntrada.TabIndex = 3;
            labelDatEntrada.Text = "Datos de Entrada";
            // 
            // buttonBorrarTodos
            // 
            buttonBorrarTodos.BackColor = Color.DarkGreen;
            buttonBorrarTodos.Font = new Font("Rockwell", 15F);
            buttonBorrarTodos.ForeColor = SystemColors.ButtonHighlight;
            buttonBorrarTodos.Location = new Point(305, 357);
            buttonBorrarTodos.Name = "buttonBorrarTodos";
            buttonBorrarTodos.Size = new Size(121, 51);
            buttonBorrarTodos.TabIndex = 5;
            buttonBorrarTodos.Text = "BORRAR TODOS";
            buttonBorrarTodos.UseVisualStyleBackColor = false;
            buttonBorrarTodos.Click += buttonBorrarTodos_Click;
            // 
            // labelPuntosIngresar
            // 
            labelPuntosIngresar.AutoSize = true;
            labelPuntosIngresar.Location = new Point(6, 249);
            labelPuntosIngresar.Name = "labelPuntosIngresar";
            labelPuntosIngresar.Size = new Size(132, 20);
            labelPuntosIngresar.TabIndex = 9;
            labelPuntosIngresar.Text = "Puntos Ingresados:";
            // 
            // labelMetodo
            // 
            labelMetodo.AutoSize = true;
            labelMetodo.Font = new Font("Rockwell", 15F);
            labelMetodo.Location = new Point(3, 174);
            labelMetodo.Name = "labelMetodo";
            labelMetodo.Size = new Size(108, 29);
            labelMetodo.TabIndex = 8;
            labelMetodo.Text = "Método:";
            // 
            // labelTole
            // 
            labelTole.AutoSize = true;
            labelTole.Font = new Font("Rockwell", 15F);
            labelTole.Location = new Point(3, 85);
            labelTole.Name = "labelTole";
            labelTole.Size = new Size(139, 29);
            labelTole.TabIndex = 7;
            labelTole.Text = "Tolerancia:";
            // 
            // labelPuntos
            // 
            labelPuntos.AutoSize = true;
            labelPuntos.Font = new Font("Rockwell", 15F);
            labelPuntos.Location = new Point(3, 36);
            labelPuntos.Name = "labelPuntos";
            labelPuntos.Size = new Size(95, 29);
            labelPuntos.TabIndex = 6;
            labelPuntos.Text = "Puntos:";
            // 
            // buttonCalcular
            // 
            buttonCalcular.BackColor = Color.DarkGreen;
            buttonCalcular.Font = new Font("Rockwell", 8F);
            buttonCalcular.ForeColor = SystemColors.ButtonHighlight;
            buttonCalcular.Location = new Point(157, 203);
            buttonCalcular.Name = "buttonCalcular";
            buttonCalcular.Size = new Size(99, 36);
            buttonCalcular.TabIndex = 2;
            buttonCalcular.Text = "CALCULAR";
            buttonCalcular.UseVisualStyleBackColor = false;
            buttonCalcular.Click += buttonCalcular_Click;
            // 
            // buttonCargar
            // 
            buttonCargar.BackColor = Color.DarkGreen;
            buttonCargar.Font = new Font("Rockwell", 8.25F);
            buttonCargar.ForeColor = SystemColors.ButtonHighlight;
            buttonCargar.Location = new Point(340, 35);
            buttonCargar.Name = "buttonCargar";
            buttonCargar.Size = new Size(87, 33);
            buttonCargar.TabIndex = 3;
            buttonCargar.Text = "CARGAR";
            buttonCargar.UseVisualStyleBackColor = false;
            buttonCargar.Click += buttonCargar_Click;
            // 
            // buttonBorrarUltimo
            // 
            buttonBorrarUltimo.BackColor = Color.DarkGreen;
            buttonBorrarUltimo.Font = new Font("Rockwell", 8.25F);
            buttonBorrarUltimo.ForeColor = SystemColors.ButtonHighlight;
            buttonBorrarUltimo.Location = new Point(306, 300);
            buttonBorrarUltimo.Name = "buttonBorrarUltimo";
            buttonBorrarUltimo.Size = new Size(121, 51);
            buttonBorrarUltimo.TabIndex = 4;
            buttonBorrarUltimo.Text = "BORRAR ULTIMO";
            buttonBorrarUltimo.UseVisualStyleBackColor = false;
            buttonBorrarUltimo.Click += buttonBorrarUltimo_Click;
            // 
            // comboBox1
            // 
            comboBox1.Font = new Font("Rockwell", 8.25F);
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "Regresión Lineal por Mínimos Cuadrados", "Regresión Polinomial por Mínimos Cuadrados" });
            comboBox1.Location = new Point(121, 172);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(215, 25);
            comboBox1.TabIndex = 2;
            // 
            // textBoxTolerancia
            // 
            textBoxTolerancia.Location = new Point(131, 87);
            textBoxTolerancia.Name = "textBoxTolerancia";
            textBoxTolerancia.Size = new Size(166, 27);
            textBoxTolerancia.TabIndex = 4;
            // 
            // textBoxY
            // 
            textBoxY.Location = new Point(217, 38);
            textBoxY.Name = "textBoxY";
            textBoxY.Size = new Size(110, 27);
            textBoxY.TabIndex = 3;
            textBoxY.TextAlign = HorizontalAlignment.Center;
            // 
            // textBoxX
            // 
            textBoxX.Location = new Point(99, 39);
            textBoxX.Name = "textBoxX";
            textBoxX.Size = new Size(110, 27);
            textBoxX.TabIndex = 2;
            textBoxX.TextAlign = HorizontalAlignment.Center;
            // 
            // panelPuntosIngresados
            // 
            panelPuntosIngresados.BackColor = Color.LightGreen;
            panelPuntosIngresados.BorderStyle = BorderStyle.FixedSingle;
            panelPuntosIngresados.Font = new Font("Rockwell", 6F);
            panelPuntosIngresados.Location = new Point(5, 285);
            panelPuntosIngresados.Name = "panelPuntosIngresados";
            panelPuntosIngresados.Size = new Size(294, 452);
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
            panel2.Location = new Point(452, 3);
            panel2.Name = "panel2";
            panel2.Size = new Size(936, 751);
            panel2.TabIndex = 1;
            // 
            // labelDatSalida
            // 
            labelDatSalida.AutoSize = true;
            labelDatSalida.BackColor = Color.Transparent;
            labelDatSalida.Font = new Font("Rockwell", 9F, FontStyle.Bold);
            labelDatSalida.Location = new Point(26, 0);
            labelDatSalida.Name = "labelDatSalida";
            labelDatSalida.Size = new Size(122, 18);
            labelDatSalida.TabIndex = 6;
            labelDatSalida.Text = "Datos de Salida";
            // 
            // labelEfectividadAjuste
            // 
            labelEfectividadAjuste.AutoSize = true;
            labelEfectividadAjuste.Location = new Point(13, 131);
            labelEfectividadAjuste.Name = "labelEfectividadAjuste";
            labelEfectividadAjuste.Size = new Size(156, 20);
            labelEfectividadAjuste.TabIndex = 9;
            labelEfectividadAjuste.Text = "Efectividad del Ajuste:";
            // 
            // labelCorrelacion
            // 
            labelCorrelacion.AutoSize = true;
            labelCorrelacion.Location = new Point(13, 85);
            labelCorrelacion.Name = "labelCorrelacion";
            labelCorrelacion.Size = new Size(107, 20);
            labelCorrelacion.TabIndex = 8;
            labelCorrelacion.Text = "Correlación (r):";
            // 
            // labelFuncionObtenida
            // 
            labelFuncionObtenida.AutoSize = true;
            labelFuncionObtenida.Location = new Point(13, 36);
            labelFuncionObtenida.Name = "labelFuncionObtenida";
            labelFuncionObtenida.Size = new Size(129, 20);
            labelFuncionObtenida.TabIndex = 7;
            labelFuncionObtenida.Text = "Función Obtenida:";
            // 
            // panelGraficador
            // 
            panelGraficador.BackColor = Color.LightGreen;
            panelGraficador.Controls.Add(webViewUnidad3);
            panelGraficador.Location = new Point(3, 175);
            panelGraficador.Name = "panelGraficador";
            panelGraficador.Size = new Size(784, 573);
            panelGraficador.TabIndex = 1;
            panelGraficador.Paint += PanelGraficador_Paint;
            // 
            // webViewUnidad3
            // 
            webViewUnidad3.AllowExternalDrop = true;
            webViewUnidad3.CreationProperties = null;
            webViewUnidad3.DefaultBackgroundColor = Color.White;
            webViewUnidad3.Location = new Point(3, 3);
            webViewUnidad3.Name = "webViewUnidad3";
            webViewUnidad3.Size = new Size(778, 567);
            webViewUnidad3.TabIndex = 0;
            webViewUnidad3.ZoomFactor = 1D;

            /*buttonVolverMenu.BackColor = SystemColors.ActiveCaptionText;
            buttonVolverMenu.Font = new Font("Rockwell", 10F);
            buttonVolverMenu.Location = new Point(11, 13);
            buttonVolverMenu.Margin = new Padding(3, 4, 3, 4);
            buttonVolverMenu.Name = "buttonVolverMenu";
            buttonVolverMenu.Size = new Size(143, 37);
            buttonVolverMenu.TabIndex = 44;
            buttonVolverMenu.Text = "Volver al menú";
            buttonVolverMenu.UseVisualStyleBackColor = false;
            buttonVolverMenu.Click += btnVolver_Click;*/

            // 
            // FormUnidad3
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1402, 749);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "FormUnidad3";
            Text = "Unidad3";
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
