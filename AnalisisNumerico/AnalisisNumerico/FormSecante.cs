using Calculus;
using System;
using System.Windows.Forms;

namespace AnalisisNumerico
{
    public partial class FormSecante : Form
    {
        public FormSecante()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                double num1 = Convert.ToDouble(textBox1.Text);
                double num2 = Convert.ToDouble(textBox2.Text);

                int interacciones = Convert.ToInt32(textBox3.Text);
                double tolerancia = Convert.ToDouble(textBox4.Text);
                string funcion = Convert.ToString(textBox5.Text);
                Calculo calculo = new Calculo();
                calculo.Sintaxis(funcion, 'x');

                Respuesta result = MetodoSecante(num1, num2, calculo, tolerancia, interacciones);

                label1.Text = $"La raíz es: {result.raiz}";
                label2.Text = $"Las iteraciones fueron: {result.iteraciones}";
                label3.Text = $"El error relativo es de: {result.error}";
                label4.Text = $"{result.Converge}";
            }
            catch (FormatException)
            {
                MessageBox.Show("Por favor, ingrese números válidos.");
            }
        }

        private static Respuesta MetodoSecante(double xi, double xi_1, Calculo funcion, double tolerancia, int interacciones)
        {
            Respuesta res = new Respuesta();
            res.Converge = "Converge";
            int iter = 0;
            double x_Anterior = xi;
            double x_Actual = xi_1;
            double margenDeErrorRelativo = double.MaxValue;

            while (iter < interacciones)
            {
                try
                {
                    double fx_Anterior = funcion.EvaluaFx(x_Anterior);
                    double fx_Actual = funcion.EvaluaFx(x_Actual);

                    if (Math.Abs(fx_Actual - fx_Anterior) < 1e-10)
                    {
                        res.Converge = "No converge, la diferencia en la función es casi cero";
                        break;
                    }

                    double x_Proxima = x_Actual - fx_Actual * (x_Actual - x_Anterior) / (fx_Actual - fx_Anterior);

                    double errorAbsoluto = Math.Abs(x_Proxima - x_Actual);
                    margenDeErrorRelativo = (Math.Abs(x_Proxima) == 0) ? errorAbsoluto : errorAbsoluto / Math.Abs(x_Proxima);

                    x_Anterior = x_Actual;
                    x_Actual = x_Proxima;
                    iter++;

                    res.iteraciones = iter;
                    res.raiz = x_Actual;
                    res.error = margenDeErrorRelativo;

                    if (margenDeErrorRelativo < tolerancia)
                    {
                        break;
                    }

                    if (double.IsNaN(fx_Actual) || double.IsInfinity(fx_Actual))
                    {
                        res.Converge = "No converge, valores fuera del dominio real";
                        break;
                    }
                }
                catch (Exception ex)
                {
                    res.Converge = "No converge, error en la evaluación: " + ex.Message;
                    break;
                }
            }

            if (iter >= interacciones)
            {
                res.Converge = "No converge, se excedió el número de iteraciones";
            }

            return res;
        }
    }

    public class Respuesta
    {
        public double raiz { get; set; }
        public int iteraciones { get; set; }
        public double error { get; set; }
        public string Converge { get; set; }
    }
}