using Calculus;
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

namespace AnalisisNumerico
{
    public partial class FormTangente : Form
    {
        public FormTangente()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                double num1 = Convert.ToDouble(textBox1.Text);

                int interacciones = Convert.ToInt32(textBox2.Text);
                double tolerancia = Convert.ToDouble(textBox3.Text);
                string funcion = Convert.ToString(textBox4.Text);
                Calculo calculo = new Calculo();
                calculo.Sintaxis(funcion, 'x');

                Respuesta result = MetodoTangente(num1, calculo, tolerancia, interacciones);

                label1.Text = $"La raíz es: {result.raiz}";
                label2.Text = $"Las iteraciones fueron: {result.iteraciones}";
                label3.Text = $"El error relativo es de: {result.error}";
                label4.Text = $"{result.Converge}";

            }
            catch (FormatException)
            {
                MessageBox.Show("Por favor, ingrese n�meros v�lidos.");
            }
        }

        private static Respuesta MetodoTangente(double xi, Calculo funcion, double tolerancia, int interacciones)
        {
            Respuesta res = new Respuesta();
            res.Converge = "Converge";
            double x = xi;
            int iter = 0;

            while (Math.Abs(funcion.EvaluaFx(x)) > tolerancia && iter < interacciones)
            {
                double fx = funcion.EvaluaFx(x);
                double dfx = funcion.Dx(x);

                if (dfx == 0)
                {
                    res.Converge = "No converge, la derivada es cero.";
                }

                double xAnterior = x;
                x = x - fx / dfx;

                double errorAbsoluto = Math.Abs(x - xAnterior);

                double margenDeErrorRelativo;
                if (Math.Abs(x) == 0)
                {
                    margenDeErrorRelativo = errorAbsoluto; 
                }
                else
                {
                    margenDeErrorRelativo = errorAbsoluto / Math.Abs(x); 
                }

                res.raiz = x;
                res.error = margenDeErrorRelativo; 
                iter++;
                res.iteraciones = iter;

                if (margenDeErrorRelativo < tolerancia)
                {
                    break;
                }
            }

            if (iter >= interacciones)
            {
                res.Converge = "No converge";
            }

            return res;
        }



        private static Respuesta MetodoTangente2(double xi, Calculo funcion, double tolerancia, int interacciones)
        {
            Respuesta res = new Respuesta();
            double x = xi;
            int iter = 0;

            while (Math.Abs(funcion.EvaluaFx(x)) > tolerancia && iter < interacciones)
            {
                double fx = funcion.EvaluaFx(x);
                double dfx = funcion.Dx(x);

                if (dfx == 0)
                {
                    throw new DivideByZeroException("La derivada es cero. No se puede continuar.");
                }
                x = x - fx / dfx;

                res.raiz = x;

                iter++;
                res.iteraciones = iter;
            }

            if (iter >= interacciones)
            {
                throw new Exception("Número máximo de iteraciones alcanzado.");
            }

            return res;
        }

    }
}
