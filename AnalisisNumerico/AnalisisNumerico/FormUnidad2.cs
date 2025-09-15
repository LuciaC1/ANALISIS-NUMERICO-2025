using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace U1
{
    public partial class FormUnidad2 : Form
    {
        private int rowsGlobal;
        private int colsGlobal;
        private int pointX = 40;
        private int pointY = 40;
        private int spaceX = 100;
        private int spaceY = 40;

        public FormUnidad2()
        {
            InitializeComponent();
            panel2.Paint += (s, pe) =>
            {
                if (colsGlobal < 2) return;

                int textBoxWidth = 90;
                int espacioEntreColumnas = spaceX - textBoxWidth;

                // Línea en el medio de la separación
                int secondLastColX = pointX + (colsGlobal - 2) * spaceX + textBoxWidth + espacioEntreColumnas / 2;

                using (Pen pen = new Pen(Color.Black, 3)) // grosor más grande
                {
                    pen.DashStyle = System.Drawing.Drawing2D.DashStyle.Dash; // más visible que Dot

                    int startY = pointY;
                    int endY = pointY + rowsGlobal * spaceY;

                    pe.Graphics.DrawLine(pen, secondLastColX, startY, secondLastColX, endY);
                }
            };
        }

        Panel lineaPunteada = new Panel();
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                rowsGlobal = int.Parse(textBox1.Text);
                colsGlobal = rowsGlobal + 1;

                panel2.Controls.Clear();

                // Crear TextBox
                for (int i = 0; i < rowsGlobal; i++)
                {
                    for (int j = 0; j < colsGlobal; j++)
                    {
                        TextBox a = new TextBox();
                        a.Location = new Point(pointX + j * spaceX, pointY + i * spaceY);
                        a.Size = new Size(90, 20);
                        a.Name = $"TextBox_{i}_{j}";
                        panel2.Controls.Add(a);
                    }
                }

                panel2.AutoScroll = true;
                panel2.AutoScrollMinSize = new Size(colsGlobal * spaceX + pointX, rowsGlobal * spaceY + pointY);

                // Forzar repintado del panel (para que aparezca la línea correcta)
                panel2.Invalidate();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }
        string seleccion = "";
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            seleccion = comboBox1.SelectedItem.ToString();


        }


        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                double errorPermitido = double.Parse(textBoxError.Text);
                int dimension = int.Parse(textBox1.Text);
                double[,] matriz = new double[dimension, dimension + 1];

                for (int i = 0; i < dimension; i++)
                {
                    for (int j = 0; j < dimension + 1; j++)
                    {
                        string textBoxName = $"TextBox_{i}_{j}";
                        TextBox txt = (TextBox)panel2.Controls[textBoxName];
                        matriz[i, j] = double.Parse(txt.Text);
                    }
                }


                if (seleccion == "Gauss Jordan")
                {

                    double[] vectorResultado = GaussJordan(matriz);

                    double[,] matrizIdentidad = new double[dimension, dimension];
                    for (int i = 0; i < dimension; i++)
                    {
                        matrizIdentidad[i, i] = 1.0;
                    }


                    string resultado = "Resultado:\n";


                    for (int i = 0; i < dimension; i++)
                    {

                        for (int j = 0; j < dimension; j++)
                        {
                            resultado += $"{matrizIdentidad[i, j]:0} ";
                        }


                        resultado += " | ";


                        resultado += $"{vectorResultado[i]:F4}\n";
                    }

                    richTextBoxResultado.Text = resultado;
                }
                if (seleccion == "Gauss Seidel")
                {
                    double[] vectorResultado = GaussSeidel(matriz, errorPermitido);
                    string resultado = "";


                    int iteraciones = (int)vectorResultado[vectorResultado.Length - 1];


                    double[] resultados = vectorResultado.Take(vectorResultado.Length - 1).ToArray();


                    bool esDivergente = resultados.All(v => v == 0);

                    if (esDivergente)
                    {
                        resultado += "El método de Gauss-Seidel no ha convergido.\n";
                    }
                    else
                    {
                        resultado += "El método de Gauss-Seidel ha convergido.\n";

                        for (int i = 0; i < resultados.Length; i++)
                        {
                            resultado += $"x{i + 1} = {resultados[i]:F4}\n";
                        }

                        resultado += $"Número de iteraciones: {iteraciones}\n";
                    }


                    richTextBoxResultado.Text = resultado;
                }
            }
            catch (Exception ex)
            {

                richTextBoxResultado.Text = "Error: " + ex.Message;
            }

        }

        private double[] GaussJordan(double[,] matriz)
        {
            int dimension = matriz.GetLength(0);


            for (int rowDiag = 0; rowDiag < dimension; rowDiag++)
            {

                double coeficienteDiagonal = matriz[rowDiag, rowDiag];


                if (coeficienteDiagonal == 0)
                {
                    bool swapped = false;
                    for (int i = rowDiag + 1; i < dimension; i++)
                    {
                        if (matriz[i, rowDiag] != 0)
                        {

                            for (int j = 0; j < dimension + 1; j++)
                            {
                                double temp = matriz[rowDiag, j];
                                matriz[rowDiag, j] = matriz[i, j];
                                matriz[i, j] = temp;
                            }
                            coeficienteDiagonal = matriz[rowDiag, rowDiag];
                            swapped = true;
                            break;
                        }
                    }
                    if (!swapped)
                    {
                        throw new InvalidOperationException("El sistema es incompatible o tiene infinitas soluciones.");
                    }
                }


                for (int col = 0; col < dimension + 1; col++)
                {
                    matriz[rowDiag, col] /= coeficienteDiagonal;
                }


                for (int row = 0; row < dimension; row++)
                {
                    if (row != rowDiag)
                    {

                        double coeficienteCero = matriz[row, rowDiag];

                        for (int col = 0; col < dimension + 1; col++)
                        {
                            matriz[row, col] -= coeficienteCero * matriz[rowDiag, col];
                        }
                    }
                }
            }

            double[] vectorResultado = new double[dimension];
            for (int i = 0; i < dimension; i++)
            {
                vectorResultado[i] = matriz[i, dimension];
            }

            return vectorResultado;
        }
        private static double[] GaussSeidel(double[,] matriz, double tolerancia, int maxIteraciones = 100)
        {
            int dimension = matriz.GetLength(0);
            double[] x = new double[dimension];
            int iteraciones;

            for (iteraciones = 0; iteraciones < maxIteraciones; iteraciones++)
            {
                double[] xAnterior = (double[])x.Clone();


                for (int i = 0; i < dimension; i++)
                {
                    double suma = 0;


                    for (int j = 0; j < dimension; j++)
                    {
                        if (i != j)
                        {
                            suma += matriz[i, j] * x[j];
                        }
                    }


                    x[i] = (matriz[i, dimension] - suma) / matriz[i, i];
                }

                double errorMax = 0;
                for (int i = 0; i < dimension; i++)
                {
                    double error = Math.Abs(x[i] - xAnterior[i]);
                    if (error > errorMax)
                    {
                        errorMax = error;
                    }
                }

                if (errorMax < tolerancia)
                {

                    double[] resultado = new double[dimension + 1];
                    Array.Copy(x, resultado, dimension);
                    resultado[dimension] = iteraciones + 1;
                    return resultado;
                }
            }
            double[] resultadoFinal = new double[dimension + 1];

            resultadoFinal[dimension] = maxIteraciones;
            return resultadoFinal;
        }

        private FormPrincipal _menu;

        public FormUnidad2(FormPrincipal menu)
        {
            InitializeComponent();
            _menu = menu;
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            _menu.Show();
            this.Close();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBoxError_TextChanged(object sender, EventArgs e)
        {

        }

        private void FormUnidad2_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}
