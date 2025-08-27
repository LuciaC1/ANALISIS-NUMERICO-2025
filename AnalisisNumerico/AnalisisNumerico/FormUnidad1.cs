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

namespace U1
{
    public partial class FormUnidad1 : Form
    {
        public FormUnidad1()
        {
            InitializeComponent();

            AplicarBordeNegro(txtXi);
            AplicarBordeNegro(txtXd);
            AplicarBordeNegro(txtIteraciones);
            AplicarBordeNegro(txtTolerancia);
            AplicarBordeNegro(txtFuncion);
            AplicarBordeNegro(txtResFuncion);
            AplicarBordeNegro(txtResMetodo);
            AplicarBordeNegro(txtResIteraciones);
            AplicarBordeNegro(txtResTolerancia);
            AplicarBordeNegro(txtResConverge);
            AplicarBordeNegro(txtResError);
            AplicarBordeNegro(txtResRaiz);

            cmbMetodo.Items.Clear();
            cmbMetodo.Items.Add("Biseccion");
            cmbMetodo.Items.Add("Regla Falsa");
            cmbMetodo.Items.Add("Newton-Raphson");
            cmbMetodo.Items.Add("Secante");
            cmbMetodo.SelectedIndex = 0;

            this.Load += FormUnidad1_Load;
        }
        private void AplicarBordeNegro(TextBox txt)
        {
            Panel p = new Panel();
            p.Size = new Size(txt.Width + 4, txt.Height + 4); // agregar espacio para el borde
            p.Location = new Point(txt.Left - 2, txt.Top - 2); // ajustar posición
            p.BackColor = Color.Black;

            this.Controls.Remove(txt);
            txt.Location = new Point(2, 2); // dejar espacio dentro del panel
            p.Controls.Add(txt);
            this.Controls.Add(p);
        }

        private async void FormUnidad1_Load(object sender, EventArgs e)
        {
            await webview.EnsureCoreWebView2Async(null);
            webview.Source = new Uri("https://www.geogebra.org/graphing");
        }

        private async void button1_Click_1(object sender, EventArgs e)
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
                funcion.Sintaxis(funcionStr, 'x');

                Respuesta resultado = null;

                if (metodo == ("Biseccion") || metodo == ("Regla Falsa"))
                {
                    MetodoCerrado metodoCerrado = new MetodoCerrado();
                    resultado = metodoCerrado.MetodosCerrados(xi, xd, tol, iteraciones, funcion, metodo);
                }
                else if (metodo == ("Newton-Raphson") || metodo == ("Secante"))
                {
                    MetodoAbierto metodoAbierto = new MetodoAbierto();
                    resultado = metodoAbierto.MetodosAbiertos(xi, xd, tol, iteraciones, funcion, metodo);
                }

                txtResFuncion.Text = funcionStr;
                txtResMetodo.Text = metodo;
                txtResIteraciones.Text = resultado.iteraciones.ToString();
                txtResTolerancia.Text = tol.ToString();
                txtResConverge.Text = resultado.Converge;
                txtResRaiz.Text = resultado.raiz.ToString("G10");
                txtResError.Text = resultado.error.ToString("G10");


                if (webview.CoreWebView2 != null)
                {

                    string funcionEscapada = Uri.EscapeDataString(funcionStr);

                    string jsFuncion = $"ggbApplet.evalCommand('f(x) = {funcionStr}');";
                    await webview.CoreWebView2.ExecuteScriptAsync(jsFuncion);

                    string jsRaiz = $"ggbApplet.evalCommand('R = ({resultado.raiz}, 0)');";
                    await webview.CoreWebView2.ExecuteScriptAsync(jsRaiz);

                    string jsZoom = "ggbApplet.setCoordSystem(-10, 10, -10, 10);";
                    await webview.CoreWebView2.ExecuteScriptAsync(jsZoom);
                }
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

        private void label12_Click(object sender, EventArgs e)
        {

        }
    }
}
