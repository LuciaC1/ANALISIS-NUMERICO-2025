using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using Calculus;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

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

        string seleccion = "";

        private async void FormUnidad3_Load(object sender, EventArgs e)
        {
            await webViewUnidad3.EnsureCoreWebView2Async(null);
            webViewUnidad3.Source = new Uri("https://www.geogebra.org/graphing");
        }


        public void buttonCargar_Click(object sender, EventArgs e)
        {
            if (textBoxX.Text != "" && textBoxY.Text != "")
            {
                CargarPunto(double.Parse(textBoxX.Text), double.Parse(textBoxY.Text));

                Label puntoIngresado = new Label();
                puntoIngresado.Text = $"({textBoxX.Text} " + "," + $" {textBoxY.Text})";
                int cantElementos = PuntosCargados.Count();
                int puntoY = (cantElementos - 1) * 17;
                puntoIngresado.TextAlign = ContentAlignment.MiddleCenter;
                panelPuntosIngresados.BorderStyle = BorderStyle.None;
                puntoIngresado.Location = new Point(0, puntoY);
                puntoIngresado.Size = new Size(251, 20);
                puntoIngresado.Font = new Font("Arial", 11);
                panelPuntosIngresados.Controls.Add(puntoIngresado);
                panelPuntosIngresados.Show();
                textBoxX.Clear();
                textBoxY.Clear();
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

            result.Funcion = $"{a1}*x+{a0}";

            result.Correlacion = r;

            double tolerancia = 80;
            if (r > tolerancia)
            {
                result.Efectividad = "Es efectivo.";
            }
            else
            {
                result.Efectividad = "No es efectivo.";
            }
            return result;
        }

        private void buttonCalcular_Click(object sender, EventArgs e)
        {
            if (seleccion == "Regresión Lineal por Mínimos Cuadrados")
            {
                RespuestaU3 res = MetodoRegresionLineal_MinimosCuadrados();

                labelFuncionObtenida.Text = $"Función obtenida: {res.Funcion}";
                labelCorrelacion.Text = $"Correlación (r): {res.Correlacion}";
                labelEfectividadAjuste.Text = $"Efectividad del ajuste: {res.Efectividad}";
                //Graficar(res.Función);
            }
            if (seleccion == "Regresión Polinomial por Mínimos Cuadrados")
            {
                double tole = Convert.ToDouble(textBoxTolerancia.Text);
                int grado = Convert.ToInt32(textBoxGrado.Text);

                double[,] func1 = GenerarMatrizPolinomial(grado, PuntosCargados);
                double[] func2 = ResolverGaussJordan(func1);
                //DatoSalida datoSalida = CalcularAjustePolinomial(tole, func2, grado);
                double c = CalcularCorrelacion(func2);


                /*labelFuncionObtenida.Text = $"Función obtenida: {datoSalida.Funcion}";
                labelCorrelacion.Text = $"Correlación (r):{c}";
                labelEfectividadAjuste.Text = $"Efectividad del ajuste: {datoSalida.EfectividadAjuste}";
                Graficar(datoSalida.Funcion);*/
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
            if (r < tolerancia * 100)
            {
                resultado3.Efectividad = "El ajuste no es aceptable";
            }
            else
            {
                resultado3.Efectividad = "El ajuste es aceptable";
            }
            return resultado3;
        }

        private void webView21_Click(object sender, EventArgs e)
        {

        }
    }
}
