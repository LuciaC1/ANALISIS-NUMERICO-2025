using Calculus;
using System;
using System;
using System.Collections.Generic;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using static System.Runtime.InteropServices.JavaScript.JSType;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace U1
{
    public partial class FormUnidad3 : Form
    {
        public FormUnidad3()
        {
            InitializeComponent();

            this.Load += FormUnidad3_Load;
        }

        public List<double[]> PuntosCargados { get; set; } = new List<double[]>();
        public void CargarPunto(double x, double y)
        {
            double[] punto = new double[2] { x, y };
            PuntosCargados.Add(punto);
        }


        private async void FormUnidad3_Load(object sender, EventArgs e)
        {
            await webViewUnidad3.EnsureCoreWebView2Async(null);
            webViewUnidad3.Source = new Uri("https://www.geogebra.org/graphing");
        }


        private int selectedPointIndex = -1;


        public void buttonCargar_Click(object sender, EventArgs e)
        {
            if (textBoxX.Text != "" && textBoxY.Text != "")
            {
                double xVal = double.Parse(textBoxX.Text, CultureInfo.InvariantCulture);
                double yVal = double.Parse(textBoxY.Text, CultureInfo.InvariantCulture);

                double[] punto = new double[2] { xVal, yVal };
                PuntosCargados.Add(punto);

                int cantElementos = PuntosCargados.Count;
                int puntoY = (cantElementos - 1) * 22;


                Panel puntoContainer = new Panel();
                puntoContainer.Size = new Size(panelPuntosIngresados.Width - 4, 20);
                puntoContainer.Location = new Point(0, puntoY);
                puntoContainer.Tag = punto;
                puntoContainer.BorderStyle = BorderStyle.None;

                Label puntoIngresado = new Label();
                puntoIngresado.Text = $"({textBoxX.Text} , {textBoxY.Text})";
                puntoIngresado.TextAlign = ContentAlignment.MiddleCenter;
                puntoIngresado.Location = new Point(0, 0);
                puntoIngresado.Size = new Size(230, 20);
                puntoIngresado.Font = new Font("Rockwell", 11);

                CheckBox cbSeleccion = new CheckBox();
                cbSeleccion.Location = new Point(235, 0);
                cbSeleccion.Size = new Size(20, 20);
                cbSeleccion.Anchor = AnchorStyles.Right;
                cbSeleccion.Checked = false;

                puntoContainer.Controls.Add(puntoIngresado);
                puntoContainer.Controls.Add(cbSeleccion);

                panelPuntosIngresados.Controls.Add(puntoContainer);
                panelPuntosIngresados.Show();

                textBoxX.Clear();
                textBoxY.Clear();
            }
        }


        private void PuntoIngresado_Click(object? sender, EventArgs e)
        {
            if (sender is Label lbl)
            {

                foreach (Control c in panelPuntosIngresados.Controls)
                {
                    if (c is Label l)
                    {
                        l.BackColor = Color.Transparent;
                        l.ForeColor = Color.Black;
                    }
                }

                if (lbl.Tag is int idx)
                {
                    selectedPointIndex = idx;
                }
                else
                {
                    selectedPointIndex = panelPuntosIngresados.Controls.IndexOf(lbl);
                    lbl.Tag = selectedPointIndex;
                }

                lbl.BackColor = Color.LightBlue;
                lbl.ForeColor = Color.Black;
            }
        }
        private void buttonBorrarSeleccionado_Click(object sender, EventArgs e)
        {
            var containers = panelPuntosIngresados.Controls.OfType<Panel>().ToList();
            var seleccionados = containers
                                .Where(c => c.Controls.OfType<CheckBox>().FirstOrDefault()?.Checked == true)
                                .ToList();

            if (seleccionados.Count == 0)
            {
                MessageBox.Show("No hay puntos seleccionados para borrar.");
                return;
            }

            foreach (var cont in seleccionados)
            {
                var tag = cont.Tag as double[];
                if (tag != null)
                {
                    var match = PuntosCargados.FirstOrDefault(p => p[0] == tag[0] && p[1] == tag[1]);
                    if (match != null)
                    {
                        PuntosCargados.Remove(match);
                    }
                }
                panelPuntosIngresados.Controls.Remove(cont);
            }


            int idx = 0;
            foreach (Panel cont in panelPuntosIngresados.Controls.OfType<Panel>().OrderBy(p => p.Top))
            {
                cont.Location = new Point(0, idx * 22);
                idx++;
            }
        }

        public RespuestaU3 MetodoRegresionLineal_MinimosCuadrados()
        {
            RespuestaU3 result = new RespuestaU3();

            int n = PuntosCargados.Count;

            double sumX = 0;
            foreach (var punto in PuntosCargados)
            {
                sumX += punto[0];
            }

            double sumY = 0;
            foreach (var punto in PuntosCargados)
            {
                sumY += punto[1];
            }

            double sumXY = 0;
            foreach (var punto in PuntosCargados)
            {
                sumXY += punto[0] * punto[1];
            }

            double sumX2 = 0;
            foreach (var punto in PuntosCargados)
            {
                sumX2 += punto[0] * punto[0];
            }

            double a1 = (n * sumXY - sumX * sumY) / (n * sumX2 - sumX * sumX);

            double a0 = (sumY / n) - a1 * (sumX / n);

            double sr = 0, st = 0;
            foreach (var punto in PuntosCargados)
            {
                st += Math.Pow(punto[1] - (sumY / n), 2);
                sr += Math.Pow((a1 * punto[0] + a0) - punto[1], 2);
            }

            double r = Math.Sqrt((st - sr) / st) * 100;


            string signo = a0 >= 0 ? "+" : "-";
            result.Funcion = $"y = {a1:F4}x {signo} {Math.Abs(a0):F4}";

            result.Correlacion = r;

            double tolerancia = 80;
            if (r > tolerancia)
            {
                result.Efectividad = "El ajuste es aceptable.";
            }
            else
            {
                result.Efectividad = "El ajuste no es aceptable.";
            }
            return result;
        }

        private void buttonCalcular_Click(object sender, EventArgs e)
        {

            string seleccion = comboBox1.SelectedItem?.ToString();

            if (seleccion == null)
            {
                MessageBox.Show("Por favor, seleccioná un método antes de continuar.");
                return;
            }

            if (seleccion == "Regresión Lineal por mínimos cuadrados")
            {
                RespuestaU3 res = MetodoRegresionLineal_MinimosCuadrados();

                labelFuncionObtenida.Text = $"Función obtenida: {res.Funcion}";
                labelCorrelacion.Text = $"Correlación (r): {Convert.ToDouble(res.Correlacion):F4}";
                labelEfectividadAjuste.Text = $"Efectividad del ajuste: {res.Efectividad}";
                GraficarResultados(res.Funcion, null);
            }
            if (seleccion == "Regresión Polinomial por mínimos cuadrados")
            {
                double tole = Convert.ToDouble(textBoxTolerancia.Text);
                int grado = Convert.ToInt32(textBoxGrado.Text);

                double[,] func1 = GenerarMatrizPolinomial(grado, PuntosCargados);
                double[] func2 = ResolverGaussJordan(func1);

                RespuestaU3 res = CalcularAjustePolinomial(tole, func2, grado);
                double c = CalcularCorrelacion(func2);


                labelFuncionObtenida.Text = $"Función obtenida: {res.Funcion}";
                labelCorrelacion.Text = $"Correlación (r):{Convert.ToDouble(c):F4}";
                labelEfectividadAjuste.Text = $"Efectividad del ajuste: {res.Efectividad}";
                string funcion = res.Funcion.ToString();
                GraficarResultados(funcion, null);
            }
        }

        public void GraficarResultados(string funcion, double? raiz = null)
        {
            try
            {
                if (webViewUnidad3?.CoreWebView2 == null) return;
                string expr = (funcion ?? string.Empty).Trim();
                if (!string.IsNullOrEmpty(expr))
                {
                    int eq = expr.IndexOf('=');
                    if (eq >= 0)
                    {
                        expr = expr.Substring(eq + 1).Trim();
                    }
                }

                string funcionEsc = expr.Replace(",", ".").Replace("'", "\\'").Replace("\"", "\\\"");

                var sb = new System.Text.StringBuilder();

                // Intentamos actualizar la función y los puntos (si ggbApplet está disponible en la página)
                sb.Append("try{");
                sb.Append("if(typeof ggbApplet !== 'undefined') {");

                // Reemplaza o crea la función f(x)
                sb.Append($"ggbApplet.evalCommand('f(x) = {funcionEsc}');");

                // Añadir / actualizar puntos P1, P2, ...
                for (int i = 0; i < PuntosCargados.Count; i++)
                {
                    string x = PuntosCargados[i][0].ToString(System.Globalization.CultureInfo.InvariantCulture);
                    string y = PuntosCargados[i][1].ToString(System.Globalization.CultureInfo.InvariantCulture);
                    string nombre = $"P{i + 1}";
                    sb.Append($"ggbApplet.evalCommand('{nombre}=({x},{y})');");
                }

                // Si se pasó una raíz, dibujar el punto R en (raiz,0)
                if (raiz.HasValue)
                {
                    string r = raiz.Value.ToString(System.Globalization.CultureInfo.InvariantCulture);
                    sb.Append($"ggbApplet.evalCommand('R=({r},0)');");
                }

                // Ajuste de ventana de coordenadas (opcional)
                sb.Append("ggbApplet.setCoordSystem(-10, 10, -10, 10);");

                sb.Append("} }catch(e){}");

                webViewUnidad3.CoreWebView2.ExecuteScriptAsync(sb.ToString());
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error al graficar en GeoGebra: " + ex.Message);
            }
        }

        private void buttonBorrarUltimo_Click(object sender, EventArgs e)
        {
            PuntosCargados.RemoveAt(PuntosCargados.Count - 1);
            panelPuntosIngresados.Controls.RemoveAt(panelPuntosIngresados.Controls.Count - 1);
        }

        private void buttonBorrarTodos_Click(object sender, EventArgs e)
        {
            PuntosCargados.Clear();
            panelPuntosIngresados.Controls.Clear();
        }

        public double[,] GenerarMatrizPolinomial(int grado, List<double[]> puntosCargados)
        {

            int dimension = grado + 1;
            double[,] matriz = new double[dimension, dimension + 1];


            foreach (var punto in puntosCargados)
            {
                double x = punto[0];
                double y = punto[1];

                for (int fila = 0; fila < dimension; fila++)
                {
                    for (int col = 0; col < dimension; col++)
                    {
                        matriz[fila, col] += Math.Pow(x, fila + col);
                    }
                    matriz[fila, dimension] += y * Math.Pow(x, fila);
                }
            }

            return matriz;
        }
        public double CalcularCorrelacion(double[] vectorResultado)
        {
            double sr = 0;
            double st = 0;
            double sumY = PuntosCargados.Sum(p => p[1]);
            double n = PuntosCargados.Count;
            double mediaY = sumY / n;

            foreach (var punto in PuntosCargados)
            {
                double x = punto[0];
                double y = punto[1];
                double suma = 0;

                for (int i = 0; i < vectorResultado.Count(); i++)
                {
                    suma += vectorResultado[i] * Math.Pow(x, i);
                }

                sr += Math.Pow(suma - y, 2);
                st += Math.Pow(mediaY - y, 2);

            }
            return Math.Sqrt((st - sr) / st) * 100;
        }


        public double[,] GenerarMatrizPolinomial(int grado)
        {
            int dimension = grado + 1;
            double[,] matriz = new double[dimension, dimension + 1];
            foreach (double[] punto in PuntosCargados)
            {
                double x = punto[0];
                double y = punto[1];
                for (int row = 0; row < dimension; row++)
                {
                    for (int col = 0; col < dimension; col++)
                    {
                        matriz[row, col] += Math.Pow(x, row + col);
                    }
                    matriz[row, dimension] += y * Math.Pow(x, row);
                }
            }
            return matriz;
        }

        public static double[] ResolverGaussJordan(double[,] matriz)
        {
            int n = matriz.GetLength(0);
            double[] resultado = new double[n];

            for (int i = 0; i < n; i++)
            {

                double pivote = matriz[i, i];
                for (int j = 0; j <= n; j++)
                {
                    matriz[i, j] /= pivote;
                }

                for (int k = 0; k < n; k++)
                {
                    if (k != i)
                    {
                        double factor = matriz[k, i];
                        for (int j = 0; j <= n; j++)
                        {
                            matriz[k, j] -= factor * matriz[i, j];
                        }
                    }
                }
            }

            for (int i = 0; i < n; i++)
            {
                resultado[i] = matriz[i, n];
            }

            return resultado;
        }

        public RespuestaU3 CalcularAjustePolinomial(double tolerancia, double[] vector, int grado)
        {
            RespuestaU3 resultado3 = new RespuestaU3();
            string funcion = " ";
            string signo = string.Empty;
            for (int i = 0; i < vector.Count(); i++)
            {
                double ai = Math.Round(vector[i], 4);
                if (i == 0 && ai != 0)
                {
                    funcion = $"{ai}";
                }
                else if (i == 1 && ai != 0)
                {
                    funcion = $"{ai}x {signo}" + funcion;
                }
                else
                {
                    if (ai != 0)
                    {
                        funcion = $"{ai}x^{i} {signo}" + funcion;
                    }
                }
                signo = ai > 0 ? "+" : string.Empty;
            }

            funcion = "y = " + funcion;

            double r = CalcularCorrelacion(vector);
            resultado3.Funcion = funcion;
            if (r < tolerancia)
            {
                resultado3.Efectividad = "El ajuste no es aceptable.";
            }
            else
            {
                resultado3.Efectividad = "El ajuste es aceptable.";
            }
            return resultado3;
        }

        //Método para obtener coeficientes:
        private Tuple<double, double> ObtenerCoeficientesFuncion(string funcion)
        {
            if (string.IsNullOrWhiteSpace(funcion))
                throw new ArgumentException("La función no puede estar vacía.");

            var regex = new Regex(@"y\s*=\s*([+-]?\d+(?:[.,]\d+)?)x\s*([+-]\s*\d+(?:[.,]\d+)?)");
            var match = regex.Match(funcion);

            if (!match.Success)
                throw new FormatException("Formato inválido. Ejemplo esperado: y = 2.5x - 1.3");

            string a1Str = match.Groups[1].Value.Replace(',', '.');
            string a0Str = match.Groups[2].Value.Replace(',', '.').Replace(" ", "");

            double a1 = double.Parse(a1Str, CultureInfo.InvariantCulture);
            double a0 = double.Parse(a0Str, CultureInfo.InvariantCulture);

            return Tuple.Create(a1, a0);
        }

        public double CalcularCorrelacionRectaModificada(string funcion)
        {
            if (PuntosCargados == null || PuntosCargados.Count == 0)
                throw new InvalidOperationException("No hay puntos cargados para calcular la correlación.");

            double sumY = 0;
            foreach (double[] punto in PuntosCargados)
            {
                sumY += punto[1];
            }

            var coeficientes = ObtenerCoeficientesFuncion(funcion);
            double a1 = coeficientes.Item1;
            double a0 = coeficientes.Item2;

            double st = 0;
            double sr = 0;
            double mediaY = sumY / PuntosCargados.Count;

            foreach (double[] punto in PuntosCargados)
            {
                st += Math.Pow(mediaY - punto[1], 2);
                sr += Math.Pow((a1 * punto[0] + a0) - punto[1], 2);
            }

            double r = Math.Sqrt((st - sr) / st) * 100;

            return r;
        }

        private void buttonCalcularNuevoR_Click(object sender, EventArgs e)
        {
            try
            {
                // Obtener los controles del GroupBox de modificación
                System.Windows.Forms.TextBox textBoxFuncionModificada = groupBoxModificacion.Controls["textBoxFuncionModificada"] as System.Windows.Forms.TextBox;
                System.Windows.Forms.TextBox textBoxEfectividadPorcentaje = groupBoxModificacion.Controls["textBoxEfectividadPorcentaje"] as System.Windows.Forms.TextBox;
                System.Windows.Forms.TextBox textBoxEfectividadAjusteNuevo = groupBoxModificacion.Controls["textBoxEfectividadAjusteNuevo"] as System.Windows.Forms.TextBox;

                if (textBoxFuncionModificada == null)
                {
                    MessageBox.Show("No se encontró el campo de función modificada.",
                                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                string funcion = textBoxFuncionModificada.Text.Trim();

                if (string.IsNullOrWhiteSpace(funcion))
                {
                    MessageBox.Show("Por favor, ingrese una función modificada (por ejemplo: y = 1x - 3).",
                                    "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Calcular el nuevo coeficiente de correlación r
                double nuevoR = CalcularCorrelacionRectaModificada(funcion);

                // Obtener la tolerancia (por defecto 80)
                double tolerancia = 80;
                if (!string.IsNullOrWhiteSpace(textBoxTolerancia.Text))
                    double.TryParse(textBoxTolerancia.Text, NumberStyles.Any, CultureInfo.InvariantCulture, out tolerancia);

                // Mostrar resultados en los TextBox del grupo "Modificación de recta"
                textBoxEfectividadPorcentaje.Text = $"{nuevoR:F5}";
                textBoxEfectividadAjusteNuevo.Text = (nuevoR >= tolerancia) ? "Aceptable" : "No aceptable";

                // Mensaje opcional de confirmación
                MessageBox.Show(
                    $"Coeficiente de correlación recalculado correctamente.\n\nr = {nuevoR:F4}%\nEfectividad: {(nuevoR >= tolerancia ? "Aceptable" : "No aceptable")}",
                    "Cálculo exitoso",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information
                );
            }
            catch (FormatException ex)
            {
                MessageBox.Show("Error en el formato de la función. Asegúrese de que tenga el formato: y = a1x + a0.\n\n" + ex.Message,
                                "Error de formato", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocurrió un error al calcular el nuevo coeficiente de correlación:\n\n" + ex.Message,
                                "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }




        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Owner.Show();
            this.Close();
        }

        private void FormUnidad3_Load_1(object sender, EventArgs e)
        {

        }

        private void labelDatEntrada_Click(object sender, EventArgs e)
        {

        }

        private void labelPuntosIngresar_Click(object sender, EventArgs e)
        {

        }

        private void webViewUnidad3_Click(object sender, EventArgs e)
        {

        }

        private void labelDatEntrada_Click_1(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void textBoxGrado_TextChanged(object sender, EventArgs e)
        {

        }

        private void labelPuntos_Click(object sender, EventArgs e)
        {

        }

        private void buttonVolverMenu_Click(object sender, EventArgs e)
        {
            this.Owner.Show();
            this.Close();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        private void labelFuncionObtenida_Click(object sender, EventArgs e)
        {

        }
        private void labelCorrelacion_Click(object sender, EventArgs e)
        {
        }
        private void labelEfectividadAjuste_Click(object sender, EventArgs e)
        {
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void labelEfectividadPorcentaje_Click(object sender, EventArgs e)
        {

        }

        private void groupBoxModificacion_Enter(object sender, EventArgs e)
        {

        }

        private void textBoxEfectividadPorcentaje_TextChanged(object sender, EventArgs e)
        {

        }

    }
}
