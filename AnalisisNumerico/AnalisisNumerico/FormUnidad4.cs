using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Calculus;

namespace U1
{
    public partial class FormUnidad4 : Form
    {
        public FormUnidad4()
        {
            InitializeComponent();
        }

        string seleccion = "";
        private void comboBoxMetodo_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            seleccion = comboBoxMetodo.SelectedItem.ToString();

        }
        private void buttonCalcular_Click(object sender, EventArgs e)
        {
            double xi = double.Parse(textBoxXi.Text);
            double xd = double.Parse(textBoxXd.Text);
            string funcion = textBoxFuncion.Text;
            int subIntervalos = int.Parse(textBoxSubIntervalos.Text);

            if (seleccion == "Integral Trapecios Simple")
            {
                double resultado = CalcularIntegralTrapeciosSimple(funcion, xi, xd);
                labelArea.Text = $"El área es de {resultado} UA";
            }

            if (seleccion == "Integral Trapecios Multiple")
            {
                double resultado = CalcularIntegralTrapeciosMultiple(funcion, xi, xd, subIntervalos);
                labelArea.Text = $"El área es de {resultado} UA";
            }

            if (seleccion == "Integral Simpson 1/3 Simple")
            {
                double resultado = CalcularIntegralSimpsonTercioSimple(funcion, xi, xd);
                labelArea.Text = $"El área es de {resultado} UA";

            }

            if (seleccion == "Integral Simpson 1/3 Multiple")
            {
                double resultado = CalcularIntegralSimpsonTercioMultiple(funcion, xi, xd, subIntervalos);
                labelArea.Text = $"El área es de {resultado} UA";
            }

            if (seleccion == "Integral Simpson 3/8")
            {
                double resultado = CalcularIntegralSimpsonTresOctavos(funcion, xi, xd);
                labelArea.Text = $"El área es de {resultado} UA";
            }

            if (seleccion == "Simpson 1/3 Multiple y Simpson 3/8 Combinados")
            {
                double resultado = CalcularIntegralSimpsonCombinados(funcion, xi, xd, subIntervalos);
                labelArea.Text = $"El área es de {resultado} UA";
            }

        }

        static double CalcularIntegralTrapeciosSimple(string funcion, double xi, double xd)
        {
            Calculo Función = new Calculo();

            if (Función.Sintaxis(funcion, 'x'))
            {
                double resultado = ((Función.EvaluaFx(xi) + Función.EvaluaFx(xd)) * (xd - xi)) / 2;
                return resultado;
            }
            else
            {
                //er aca lo de la funcion mal ingresda
                return double.NaN;
            }
        }

        static double CalcularIntegralTrapeciosMultiple(string funcion, double xi, double xd, int n)
        {
            Calculo Funcion = new Calculo();

            if (Funcion.Sintaxis(funcion, 'x'))
            {
                double h = (xd - xi) / n;
                double sum = 0;

                for (int i = 1; i < n; i++)
                {
                    sum += Funcion.EvaluaFx(xi + h * i);
                }


                return (h / 2) * (Funcion.EvaluaFx(xi) + 2 * sum + Funcion.EvaluaFx(xd));
            }
            else
            {
                Console.WriteLine("La función está mal ingresada."); // Mensaje de error en caso de sintaxis incorrecta
                return double.NaN;
            }
        }

        static double CalcularIntegralSimpsonTercioSimple(string funcion, double xi, double xd)
        {
            Calculo Funcion = new Calculo();

            if (Funcion.Sintaxis(funcion, 'x'))
            {
                double h = (xd - xi) / 2;

                return (h / 3) * (Funcion.EvaluaFx(xi) + 4 * Funcion.EvaluaFx(xi + h) + Funcion.EvaluaFx(xd));
            }
            else
            {
                Console.WriteLine("La función está mal ingresada.");
                return double.NaN;
            }
        }


        static double CalcularIntegralSimpsonTercioMultiple(string funcion, double xi, double xd, int n)
        {
            Calculo Funcion = new Calculo();

            if (Funcion.Sintaxis(funcion, 'x'))
            {
                double h = (xd - xi) / n;
                double sumPares = 0;
                double sumImpares = 0;


                for (int i = 1; i < n; i++)
                {
                    if (i % 2 == 0)
                    {
                        sumPares += Funcion.EvaluaFx(xi + h * i);
                    }
                    else
                    {
                        sumImpares += Funcion.EvaluaFx(xi + h * i);
                    }
                }


                return (h / 3) * (Funcion.EvaluaFx(xi) + 4 * sumImpares + 2 * sumPares + Funcion.EvaluaFx(xd));
            }
            else
            {
                Console.WriteLine("La función está mal ingresada.");
                return double.NaN;
            }
        }

        static double CalcularIntegralSimpsonTresOctavos(string funcion, double xi, double xd)
        {
            Calculo Funcion = new Calculo();

            if (Funcion.Sintaxis(funcion, 'x'))
            {
                double h = (xd - xi) / 3;


                return (3 * h / 8) * (Funcion.EvaluaFx(xi) + 3 * Funcion.EvaluaFx(xi + h) + 3 * Funcion.EvaluaFx(xi + 2 * h) + Funcion.EvaluaFx(xd));
            }
            else
            {
                Console.WriteLine("La función está mal ingresada.");
                return double.NaN;
            }
        }

        static double CalcularIntegralSimpsonCombinados(string funcion, double xi, double xd, int n)
        {
            Calculo Funcion = new Calculo();

            if (Funcion.Sintaxis(funcion, 'x'))
            {
                double h = (xd - xi) / n;
                double sumPares = 0, sumImpares = 0;
                double resultado = 0;
                bool simpson38Hecho = false;

                for (int i = 1; i < n; i++)
                {
                    if (n % 2 != 0 && !simpson38Hecho)
                    {
                        double nuevoXi = xi + h * (n - 3);
                        resultado += CalcularIntegralSimpsonTresOctavos(funcion, nuevoXi, xd);
                        n -= 3;
                        xd = nuevoXi;
                        simpson38Hecho = true;
                    }
                    if (i % 2 == 0)
                    {
                        sumPares += Funcion.EvaluaFx(xi + h * i);
                    }
                    else
                    {
                        sumImpares += Funcion.EvaluaFx(xi + h * i);
                    }
                }


                resultado += (h / 3) * (Funcion.EvaluaFx(xi) + 4 * sumImpares + 2 * sumPares + Funcion.EvaluaFx(xd));
                return resultado;
            }
            else
            {
                Console.WriteLine("La función está mal ingresada.");
                return double.NaN;
            }
        }
        private void comboBoxMetodo_SelectedIndexChanged(object sender, EventArgs e)
        {
            seleccion = comboBoxMetodo.SelectedItem.ToString();
        }
}
}
