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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormUnidad3));
            panel1 = new Panel();
            groupBoxModificacion = new GroupBox();
            labelFuncionModificada = new Label();
            textBoxFuncionModificada = new TextBox();
            buttonCalcularNuevoR = new Button();
            labelEfectividadPorcentaje = new Label();
            textBoxEfectividadPorcentaje = new TextBox();
            labelEfectividadAjusteNuevo = new Label();
            textBoxEfectividadAjusteNuevo = new TextBox();
            buttonVolverMenu = new Button();
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
            labelFuncionObtenida = new Label();
            labelCorrelacion = new Label();
            labelEfectividadAjuste = new Label();
            labelDatSalida = new Label();
            webViewUnidad3 = new Microsoft.Web.WebView2.WinForms.WebView2();
            panel2 = new Panel();
            panel1.SuspendLayout();
            groupBoxModificacion.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)webViewUnidad3).BeginInit();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ActiveCaptionText;
            panel1.BackgroundImage = (Image)resources.GetObject("panel1.BackgroundImage");
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(groupBoxModificacion);
            panel1.Controls.Add(buttonVolverMenu);
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
            panel1.Dock = DockStyle.Left;
            panel1.Font = new Font("Rockwell", 12F);
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(863, 1055);
            panel1.TabIndex = 0;
            panel1.Paint += panel1_Paint;
            // 
            // groupBoxModificacion
            // 
            groupBoxModificacion.BackColor = Color.FromArgb(233, 231, 235);
            groupBoxModificacion.Controls.Add(labelFuncionModificada);
            groupBoxModificacion.Controls.Add(textBoxFuncionModificada);
            groupBoxModificacion.Controls.Add(buttonCalcularNuevoR);
            groupBoxModificacion.Controls.Add(labelEfectividadPorcentaje);
            groupBoxModificacion.Controls.Add(textBoxEfectividadPorcentaje);
            groupBoxModificacion.Controls.Add(labelEfectividadAjusteNuevo);
            groupBoxModificacion.Controls.Add(textBoxEfectividadAjusteNuevo);
            groupBoxModificacion.Font = new Font("Rockwell", 15F);
            groupBoxModificacion.Location = new Point(34, 759);
            groupBoxModificacion.Name = "groupBoxModificacion";
            groupBoxModificacion.Size = new Size(807, 205);
            groupBoxModificacion.TabIndex = 0;
            groupBoxModificacion.TabStop = false;
            groupBoxModificacion.Text = "Modificación de recta";
            groupBoxModificacion.Enter += groupBoxModificacion_Enter;
            // 
            // labelFuncionModificada
            // 
            labelFuncionModificada.AutoSize = true;
            labelFuncionModificada.Font = new Font("Rockwell", 14F);
            labelFuncionModificada.Location = new Point(15, 55);
            labelFuncionModificada.Name = "labelFuncionModificada";
            labelFuncionModificada.Size = new Size(239, 27);
            labelFuncionModificada.TabIndex = 0;
            labelFuncionModificada.Text = "Función modificada:";
            // 
            // textBoxFuncionModificada
            // 
            textBoxFuncionModificada.Font = new Font("Rockwell", 14F);
            textBoxFuncionModificada.Location = new Point(262, 47);
            textBoxFuncionModificada.Name = "textBoxFuncionModificada";
            textBoxFuncionModificada.Size = new Size(270, 35);
            textBoxFuncionModificada.TabIndex = 1;
            // 
            // buttonCalcularNuevoR
            // 
            buttonCalcularNuevoR.BackColor = SystemColors.ActiveCaptionText;
            buttonCalcularNuevoR.Font = new Font("Rockwell", 13F);
            buttonCalcularNuevoR.ForeColor = Color.White;
            buttonCalcularNuevoR.Location = new Point(551, 47);
            buttonCalcularNuevoR.Name = "buttonCalcularNuevoR";
            buttonCalcularNuevoR.Size = new Size(154, 35);
            buttonCalcularNuevoR.TabIndex = 2;
            buttonCalcularNuevoR.Text = "Calcular";
            buttonCalcularNuevoR.UseVisualStyleBackColor = false;
            buttonCalcularNuevoR.Click += buttonCalcularNuevoR_Click;
            // 
            // labelEfectividadPorcentaje
            // 
            labelEfectividadPorcentaje.AutoSize = true;
            labelEfectividadPorcentaje.Font = new Font("Rockwell", 13F);
            labelEfectividadPorcentaje.Location = new Point(15, 111);
            labelEfectividadPorcentaje.Name = "labelEfectividadPorcentaje";
            labelEfectividadPorcentaje.Size = new Size(167, 25);
            labelEfectividadPorcentaje.TabIndex = 3;
            labelEfectividadPorcentaje.Text = "Coeficiente (r):";
            labelEfectividadPorcentaje.Click += labelEfectividadPorcentaje_Click;
            // 
            // textBoxEfectividadPorcentaje
            // 
            textBoxEfectividadPorcentaje.Font = new Font("Rockwell", 13F);
            textBoxEfectividadPorcentaje.Location = new Point(262, 108);
            textBoxEfectividadPorcentaje.Name = "textBoxEfectividadPorcentaje";
            textBoxEfectividadPorcentaje.ReadOnly = true;
            textBoxEfectividadPorcentaje.Size = new Size(120, 33);
            textBoxEfectividadPorcentaje.TabIndex = 4;
            textBoxEfectividadPorcentaje.TextChanged += textBoxEfectividadPorcentaje_TextChanged;
            // 
            // labelEfectividadAjusteNuevo
            // 
            labelEfectividadAjusteNuevo.AutoSize = true;
            labelEfectividadAjusteNuevo.Font = new Font("Rockwell", 13F);
            labelEfectividadAjusteNuevo.Location = new Point(16, 163);
            labelEfectividadAjusteNuevo.Name = "labelEfectividadAjusteNuevo";
            labelEfectividadAjusteNuevo.Size = new Size(238, 25);
            labelEfectividadAjusteNuevo.TabIndex = 5;
            labelEfectividadAjusteNuevo.Text = "Efectividad del ajuste:";
            // 
            // textBoxEfectividadAjusteNuevo
            // 
            textBoxEfectividadAjusteNuevo.Font = new Font("Rockwell", 13F);
            textBoxEfectividadAjusteNuevo.Location = new Point(262, 155);
            textBoxEfectividadAjusteNuevo.Name = "textBoxEfectividadAjusteNuevo";
            textBoxEfectividadAjusteNuevo.ReadOnly = true;
            textBoxEfectividadAjusteNuevo.Size = new Size(150, 33);
            textBoxEfectividadAjusteNuevo.TabIndex = 6;
            // 
            // buttonVolverMenu
            // 
            buttonVolverMenu.BackColor = SystemColors.ActiveCaptionText;
            buttonVolverMenu.Font = new Font("Rockwell", 10F);
            buttonVolverMenu.ForeColor = SystemColors.ControlLightLight;
            buttonVolverMenu.Location = new Point(13, 15);
            buttonVolverMenu.Margin = new Padding(3, 4, 3, 4);
            buttonVolverMenu.Name = "buttonVolverMenu";
            buttonVolverMenu.Size = new Size(143, 45);
            buttonVolverMenu.TabIndex = 45;
            buttonVolverMenu.Text = "Volver al menú";
            buttonVolverMenu.UseVisualStyleBackColor = false;
            buttonVolverMenu.Click += buttonVolverMenu_Click;
            // 
            // labelGrado
            // 
            labelGrado.AutoSize = true;
            labelGrado.BackColor = Color.Black;
            labelGrado.Font = new Font("Rockwell", 15F);
            labelGrado.ForeColor = SystemColors.ControlLightLight;
            labelGrado.Location = new Point(96, 440);
            labelGrado.Name = "labelGrado";
            labelGrado.Size = new Size(93, 29);
            labelGrado.TabIndex = 11;
            labelGrado.Text = "Grado:";
            // 
            // textBoxGrado
            // 
            textBoxGrado.BackColor = Color.FromArgb(233, 231, 235);
            textBoxGrado.Font = new Font("Rockwell", 12F);
            textBoxGrado.Location = new Point(214, 438);
            textBoxGrado.Name = "textBoxGrado";
            textBoxGrado.Size = new Size(166, 31);
            textBoxGrado.TabIndex = 10;
            textBoxGrado.TextChanged += textBoxGrado_TextChanged;
            // 
            // labelDatEntrada
            // 
            labelDatEntrada.AutoSize = true;
            labelDatEntrada.BackColor = Color.Black;
            labelDatEntrada.Font = new Font("Rockwell", 15F);
            labelDatEntrada.ForeColor = SystemColors.ControlLightLight;
            labelDatEntrada.Location = new Point(135, 284);
            labelDatEntrada.Name = "labelDatEntrada";
            labelDatEntrada.Size = new Size(209, 29);
            labelDatEntrada.TabIndex = 3;
            labelDatEntrada.Text = "Datos de Entrada";
            labelDatEntrada.Click += labelDatEntrada_Click_1;
            // 
            // buttonBorrarTodos
            // 
            buttonBorrarTodos.BackColor = SystemColors.ActiveCaptionText;
            buttonBorrarTodos.Font = new Font("Rockwell", 12F);
            buttonBorrarTodos.ForeColor = SystemColors.ButtonHighlight;
            buttonBorrarTodos.Location = new Point(688, 657);
            buttonBorrarTodos.Name = "buttonBorrarTodos";
            buttonBorrarTodos.Size = new Size(153, 53);
            buttonBorrarTodos.TabIndex = 5;
            buttonBorrarTodos.Text = "Borrar todo";
            buttonBorrarTodos.UseVisualStyleBackColor = false;
            buttonBorrarTodos.Click += buttonBorrarTodos_Click;
            // 
            // labelPuntosIngresar
            // 
            labelPuntosIngresar.AutoSize = true;
            labelPuntosIngresar.BackColor = Color.Black;
            labelPuntosIngresar.Font = new Font("Rockwell", 15F);
            labelPuntosIngresar.ForeColor = SystemColors.ControlLightLight;
            labelPuntosIngresar.Location = new Point(557, 75);
            labelPuntosIngresar.Name = "labelPuntosIngresar";
            labelPuntosIngresar.Size = new Size(227, 29);
            labelPuntosIngresar.TabIndex = 9;
            labelPuntosIngresar.Text = "Puntos Ingresados:";
            // 
            // labelMetodo
            // 
            labelMetodo.AutoSize = true;
            labelMetodo.BackColor = Color.Black;
            labelMetodo.Font = new Font("Rockwell", 15F);
            labelMetodo.ForeColor = SystemColors.ControlLightLight;
            labelMetodo.Location = new Point(196, 507);
            labelMetodo.Name = "labelMetodo";
            labelMetodo.Size = new Size(108, 29);
            labelMetodo.TabIndex = 8;
            labelMetodo.Text = "Método:";
            // 
            // labelTole
            // 
            labelTole.AutoSize = true;
            labelTole.BackColor = Color.Black;
            labelTole.Font = new Font("Rockwell", 15F);
            labelTole.ForeColor = SystemColors.ControlLightLight;
            labelTole.Location = new Point(179, 332);
            labelTole.Name = "labelTole";
            labelTole.Size = new Size(139, 29);
            labelTole.TabIndex = 7;
            labelTole.Text = "Tolerancia:";
            // 
            // labelPuntos
            // 
            labelPuntos.AutoSize = true;
            labelPuntos.BackColor = Color.Black;
            labelPuntos.Font = new Font("Rockwell", 15F);
            labelPuntos.ForeColor = SystemColors.ControlLightLight;
            labelPuntos.Location = new Point(37, 152);
            labelPuntos.Name = "labelPuntos";
            labelPuntos.Size = new Size(198, 29);
            labelPuntos.TabIndex = 6;
            labelPuntos.Text = "Ingresar puntos:";
            labelPuntos.Click += labelPuntos_Click;
            // 
            // buttonCalcular
            // 
            buttonCalcular.BackColor = SystemColors.ActiveCaptionText;
            buttonCalcular.Font = new Font("Rockwell", 15F);
            buttonCalcular.ForeColor = SystemColors.ButtonHighlight;
            buttonCalcular.Location = new Point(179, 610);
            buttonCalcular.Name = "buttonCalcular";
            buttonCalcular.Size = new Size(142, 51);
            buttonCalcular.TabIndex = 2;
            buttonCalcular.Text = "Calcular";
            buttonCalcular.UseVisualStyleBackColor = false;
            buttonCalcular.Click += buttonCalcular_Click;
            // 
            // buttonCargar
            // 
            buttonCargar.BackColor = SystemColors.ActiveCaptionText;
            buttonCargar.Font = new Font("Rockwell", 15F);
            buttonCargar.ForeColor = SystemColors.ButtonHighlight;
            buttonCargar.Location = new Point(179, 204);
            buttonCargar.Name = "buttonCargar";
            buttonCargar.Size = new Size(142, 51);
            buttonCargar.TabIndex = 3;
            buttonCargar.Text = "Cargar";
            buttonCargar.UseVisualStyleBackColor = false;
            buttonCargar.Click += buttonCargar_Click;
            // 
            // buttonBorrarUltimo
            // 
            buttonBorrarUltimo.BackColor = SystemColors.ActiveCaptionText;
            buttonBorrarUltimo.Font = new Font("Rockwell", 11F);
            buttonBorrarUltimo.ForeColor = SystemColors.ButtonHighlight;
            buttonBorrarUltimo.Location = new Point(451, 657);
            buttonBorrarUltimo.Name = "buttonBorrarUltimo";
            buttonBorrarUltimo.Size = new Size(231, 53);
            buttonBorrarUltimo.TabIndex = 4;
            buttonBorrarUltimo.Text = "Borrar seleccionado";
            buttonBorrarUltimo.UseVisualStyleBackColor = false;
            buttonBorrarUltimo.Click += buttonBorrarSeleccionado_Click;
            // 
            // comboBox1
            // 
            comboBox1.BackColor = Color.FromArgb(233, 231, 235);
            comboBox1.Font = new Font("Rockwell", 12F);
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "Regresión Lineal por mínimos cuadrados", "Regresión Polinomial por mínimos cuadrados" });
            comboBox1.Location = new Point(49, 544);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(414, 30);
            comboBox1.TabIndex = 2;
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // textBoxTolerancia
            // 
            textBoxTolerancia.BackColor = Color.FromArgb(233, 231, 235);
            textBoxTolerancia.Font = new Font("Rockwell", 12F);
            textBoxTolerancia.Location = new Point(155, 378);
            textBoxTolerancia.Name = "textBoxTolerancia";
            textBoxTolerancia.Size = new Size(166, 31);
            textBoxTolerancia.TabIndex = 4;
            // 
            // textBoxY
            // 
            textBoxY.BackColor = Color.FromArgb(233, 231, 235);
            textBoxY.Font = new Font("Rockwell", 12F);
            textBoxY.Location = new Point(392, 151);
            textBoxY.Name = "textBoxY";
            textBoxY.Size = new Size(110, 31);
            textBoxY.TabIndex = 3;
            textBoxY.TextAlign = HorizontalAlignment.Center;
            // 
            // textBoxX
            // 
            textBoxX.BackColor = Color.FromArgb(233, 231, 235);
            textBoxX.Font = new Font("Rockwell", 12F);
            textBoxX.Location = new Point(256, 151);
            textBoxX.Name = "textBoxX";
            textBoxX.Size = new Size(110, 31);
            textBoxX.TabIndex = 2;
            textBoxX.TextAlign = HorizontalAlignment.Center;
            // 
            // panelPuntosIngresados
            // 
            panelPuntosIngresados.BackColor = Color.FromArgb(233, 231, 235);
            panelPuntosIngresados.BorderStyle = BorderStyle.FixedSingle;
            panelPuntosIngresados.Font = new Font("Rockwell", 6F);
            panelPuntosIngresados.Location = new Point(528, 120);
            panelPuntosIngresados.Name = "panelPuntosIngresados";
            panelPuntosIngresados.Size = new Size(295, 531);
            panelPuntosIngresados.TabIndex = 1;
            panelPuntosIngresados.Paint += PanelPuntosIngresados_Paint;
            // 
            // labelFuncionObtenida
            // 
            labelFuncionObtenida.AutoSize = true;
            labelFuncionObtenida.BackColor = SystemColors.ActiveCaptionText;
            labelFuncionObtenida.Font = new Font("Rockwell", 13F);
            labelFuncionObtenida.ForeColor = SystemColors.ControlLightLight;
            labelFuncionObtenida.Location = new Point(13, 91);
            labelFuncionObtenida.Name = "labelFuncionObtenida";
            labelFuncionObtenida.Size = new Size(201, 25);
            labelFuncionObtenida.TabIndex = 7;
            labelFuncionObtenida.Text = "Función Obtenida:";
            labelFuncionObtenida.Click += labelFuncionObtenida_Click;
            // 
            // labelCorrelacion
            // 
            labelCorrelacion.AutoSize = true;
            labelCorrelacion.BackColor = SystemColors.ActiveCaptionText;
            labelCorrelacion.Font = new Font("Rockwell", 13F);
            labelCorrelacion.ForeColor = SystemColors.ControlLightLight;
            labelCorrelacion.Location = new Point(13, 158);
            labelCorrelacion.Name = "labelCorrelacion";
            labelCorrelacion.Size = new Size(171, 25);
            labelCorrelacion.TabIndex = 8;
            labelCorrelacion.Text = "Correlación (r):";
            labelCorrelacion.Click += labelCorrelacion_Click;
            // 
            // labelEfectividadAjuste
            // 
            labelEfectividadAjuste.AutoSize = true;
            labelEfectividadAjuste.BackColor = SystemColors.ActiveCaptionText;
            labelEfectividadAjuste.Font = new Font("Rockwell", 13F);
            labelEfectividadAjuste.ForeColor = SystemColors.ControlLightLight;
            labelEfectividadAjuste.Location = new Point(13, 224);
            labelEfectividadAjuste.Name = "labelEfectividadAjuste";
            labelEfectividadAjuste.Size = new Size(241, 25);
            labelEfectividadAjuste.TabIndex = 9;
            labelEfectividadAjuste.Text = "Efectividad del Ajuste:";
            labelEfectividadAjuste.Click += labelEfectividadAjuste_Click;
            // 
            // labelDatSalida
            // 
            labelDatSalida.AutoSize = true;
            labelDatSalida.BackColor = SystemColors.ActiveCaptionText;
            labelDatSalida.Font = new Font("Rockwell", 15F);
            labelDatSalida.ForeColor = SystemColors.ControlLightLight;
            labelDatSalida.Location = new Point(335, 12);
            labelDatSalida.Name = "labelDatSalida";
            labelDatSalida.Size = new Size(188, 29);
            labelDatSalida.TabIndex = 6;
            labelDatSalida.Text = "Datos de Salida";
            // 
            // webViewUnidad3
            // 
            webViewUnidad3.AllowExternalDrop = true;
            webViewUnidad3.CreationProperties = null;
            webViewUnidad3.DefaultBackgroundColor = Color.White;
            webViewUnidad3.Location = new Point(13, 284);
            webViewUnidad3.Name = "webViewUnidad3";
            webViewUnidad3.Size = new Size(855, 672);
            webViewUnidad3.TabIndex = 0;
            webViewUnidad3.ZoomFactor = 1D;
            webViewUnidad3.Click += webViewUnidad3_Click;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(233, 231, 235);
            panel2.Controls.Add(webViewUnidad3);
            panel2.Controls.Add(labelDatSalida);
            panel2.Controls.Add(labelEfectividadAjuste);
            panel2.Controls.Add(labelCorrelacion);
            panel2.Controls.Add(labelFuncionObtenida);
            panel2.Dock = DockStyle.Fill;
            panel2.Font = new Font("Rockwell", 12F);
            panel2.Location = new Point(863, 0);
            panel2.Name = "panel2";
            panel2.RightToLeft = RightToLeft.No;
            panel2.Size = new Size(939, 1055);
            panel2.TabIndex = 1;
            panel2.Paint += panel2_Paint;
            // 
            // FormUnidad3
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1802, 1055);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "FormUnidad3";
            Text = "Unidad3";
            Load += FormUnidad3_Load_1;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            groupBoxModificacion.ResumeLayout(false);
            groupBoxModificacion.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)webViewUnidad3).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        private void PanelPuntosIngresados_Paint(object sender, PaintEventArgs e)
        {
            ControlPaint.DrawBorder(e.Graphics, panelPuntosIngresados.ClientRectangle, Color.Black, ButtonBorderStyle.Solid);
        }

       /* private void PanelGraficador_Paint(object sender, PaintEventArgs e)
        {
            ControlPaint.DrawBorder(e.Graphics, panelGraficador.ClientRectangle, Color.Black, ButtonBorderStyle.Solid);
        }*/

        private Button buttonBorrarSeleccionado;

        private Panel panel1;
        private Button buttonCalcular;
        private Button buttonCargar;
        private Button buttonBorrarTodos;
        private Button buttonBorrarUltimo;
        private TextBox textBoxTolerancia;
        private TextBox textBoxY;
        private TextBox textBoxX;
        private Panel panelPuntosIngresados;
        private Label labelPuntos;
        private Label labelDatEntrada;
        private Label labelPuntosIngresar;
        private Label labelMetodo;
        private Label labelTole;
        private ComboBox comboBox1;
        private Label labelGrado;
        private TextBox textBoxGrado;
        private Button buttonVolverMenu;

        #endregion

        private Label labelFuncionObtenida;
        private Label labelCorrelacion;
        private Label labelEfectividadAjuste;
        private Label labelDatSalida;
        private Microsoft.Web.WebView2.WinForms.WebView2 webViewUnidad3;
        private Panel panel2;
        private GroupBox groupBoxModificacion;
        private Label labelFuncionModificada;
        private TextBox textBoxFuncionModificada;
        private Button buttonCalcularNuevoR;
        private Label labelEfectividadPorcentaje;
        private TextBox textBoxEfectividadPorcentaje;
        private Label labelEfectividadAjusteNuevo;
        private TextBox textBoxEfectividadAjusteNuevo;
    }

}
