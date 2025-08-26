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
using System.Windows.Forms.DataVisualization.Charting;
using Unidad1;

namespace U1
{
    public partial class FormMenu : Form
    {
        private Chart chartFuncion;

        public FormMenu()
        {
            InitializeComponent();
            chartFuncion = new Chart();
            chartFuncion.Size = new Size(500, 300);
            chartFuncion.Location = new Point(344, 110);
            this.Controls.Add(chartFuncion);

            chartFuncion.ChartAreas.Add(new ChartArea("MainArea"));
            chartFuncion.Series.Add("Funcion");
            chartFuncion.Series["Funcion"].ChartType = SeriesChartType.Line;
            chartFuncion.Series.Add("Raiz");
            chartFuncion.Series["Raiz"].ChartType = SeriesChartType.Point;
            chartFuncion.Series["Raiz"].MarkerSize = 10;
            chartFuncion.Series["Raiz"].Color = Color.Red;
            cmbMetodo.Items.Clear();
            cmbMetodo.Items.Add("Biseccion (cerrado)");
            cmbMetodo.Items.Add("Regla Falsa (cerrado)");
            cmbMetodo.Items.Add("Tangente (abierto)");
            cmbMetodo.Items.Add("Secante (abierto)");
            cmbMetodo.SelectedIndex = 0;
        }
        private void button1_Click_1(object sender, EventArgs e)
        {
            try
            {
                string funcionStr = txtFuncion.Text;
                string metodo = cmbMetodo.SelectedItem?.ToString();
                if (string.IsNullOrEmpty(metodo))
                {
                    MessageBox.Show("Por favor selecciona un método.");
                    return;
                }

                double xi = double.Parse(txtXi.Text);
                double xd = double.Parse(txtXd.Text);
                int iteraciones = int.Parse(txtIteraciones.Text);
                double tol = double.Parse(txtTolerancia.Text);

                Calculo funcion = new Calculo();
                MetodoAbierto metodoAbierto = new MetodoAbierto();
                Respuesta resultado = metodoAbierto.MetodosAbiertos(xi, xd, tol, iteraciones, funcion, metodo);

                // Mostrar resultados
                txtResFuncion.Text = funcionStr;
                txtResMetodo.Text = metodo;
                txtResIteraciones.Text = resultado.iteraciones.ToString();
                txtResTolerancia.Text = tol.ToString();
                txtResConverge.Text = resultado.Converge;
                txtResRaiz.Text = resultado.raiz.ToString("G10");
                txtResError.Text = resultado.error.ToString("G10");

                chartFuncion.Series["Funcion"].Points.Clear();
                chartFuncion.Series["Raiz"].Points.Clear();

                // Graficar la función
                int puntos = 100;
                double paso = (xd - xi) / puntos;
                for (int i = 0; i <= puntos; i++)
                {
                    double x = xi + i * paso;
                    double y = funcion.EvaluaFx(x);
                    chartFuncion.Series["Funcion"].Points.AddXY(x, y);
                }

                // Graficar la raíz
                chartFuncion.Series["Raiz"].Points.AddXY(resultado.raiz, 0);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void FormMenu_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void textBox15_TextChanged(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void chart1_Click(object sender, EventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }
    }
}
