using Calculus;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AnalisisNumerico
{
    public partial class FormBiseccion : Form
    {
        public FormBiseccion()
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

                Respuesta result = (num1, calculo, num2, tolerancia, interacciones);

                label6.Text = $"{result.Converge}";
                label1.Text = $"La raíz es: {result.raiz}";
                label2.Text = $"Las iteraciones fueron: {result.iteraciones}";
                label3.Text = $"El error relativo es de: {result.error}";


            }
            catch (FormatException)
            {
                MessageBox.Show("Por favor, ingrese números válidos.");
            }
        }

        private static Respuesta MetodoBiseccion(double xi, Calculo funcion, double xd, double tolerancia, int interacciones)
        {
            Respuesta res = new Respuesta();
            res.Converge = "Converge";

            if (!CambioDeSigno(funcion, xi, xd))
            {
                throw new ArgumentException("La función debe cambiar de signo en el intervalo [xi, xd].");
            }

            double c = xi;
            double cAnterior = xi;
            double margenDeErrorRelativo = double.MaxValue; 

            for (int i = 0; i < interacciones; i++)
            {
                cAnterior = c;
                c = (xi + xd) / 2.0;

                double fC = funcion.EvaluaFx(c);

                double errorAbsoluto = Math.Abs(c - cAnterior);
                if (Math.Abs(c) == 0)
                {
                    margenDeErrorRelativo = errorAbsoluto; 
                }
                else
                {
                    margenDeErrorRelativo = errorAbsoluto / Math.Abs(c); 
                }

                if (Math.Abs(fC) < tolerancia || margenDeErrorRelativo < tolerancia)
                {
                    res.raiz = c;
                    res.error = margenDeErrorRelativo; 
                    res.iteraciones = i + 1;
                    return res;
                }

                if (funcion.EvaluaFx(xi) * fC < 0)
                {
                    xd = c;
                }
                else
                {
                    xi = c;
                }
                if (i == (interacciones - 1))
                {
                    res.Converge = "No converge";
                }
            }
            return res;
        }
        private static Respuesta MetodoBiseccion2(double xi, Calculo funcion, double xd, double tolerancia, int interacciones)
        {
            Respuesta res = new Respuesta();
            if (!CambioDeSigno(funcion, xi, xd))
            {
                throw new ArgumentException("La función debe cambiar de signo en el intervalo [a, b].");
            }

            double c = xi;
            for (int i = 0; i < interacciones; i++)
            {
                c = (xi + xd) / 2.0;

                double fC = funcion.EvaluaFx(c);

                if (Math.Abs(fC) < tolerancia || (xd - xi) / 2.0 < tolerancia)
                {
                    res.raiz = c;
                    res.iteraciones = i + 1;
                    return res;
                }

                if (funcion.EvaluaFx(xi) * fC < 0)
                {
                    xd = c;
                }
                else
                {
                    xi = c;
                }
            }

            throw new Exception("No se encontró la raíz en el número máximo de iteraciones.");
        }
        static bool CambioDeSigno(Calculo f, double a, double b)
        {
            double fa = f.EvaluaFx(a);
            double fb = f.EvaluaFx(b);
            return fa * fb < 0;
        }
    }
}

