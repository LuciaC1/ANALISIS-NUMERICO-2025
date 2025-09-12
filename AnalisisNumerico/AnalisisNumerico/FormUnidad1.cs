using Calculus;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;


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
            txtFuncion.Multiline = true;
            txtFuncion.WordWrap = true;
            txtFuncion.ScrollBars = ScrollBars.Vertical;
            txtFuncion.Height = txtFuncion.Height * 2;
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
            cmbMetodo.SelectedIndexChanged += cmbMetodo_SelectedIndexChanged;


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

                int pos = funcionStr.IndexOf("||");

                int firstPos = funcionStr.IndexOf('|');

                if (firstPos != -1)
                {
                    int secondPos = funcionStr.IndexOf('|', firstPos + 1);

                    if (secondPos != -1)
                    {
                        string contenido = funcionStr.Substring(firstPos + 1, secondPos - firstPos - 1);
                        string conteni = "abs(" + contenido + ")";
                        funcionStr = funcionStr.Replace($"|{contenido}|", $"{conteni}");
                    }
                }

                if ((funcionStr.Contains("e")))
                {
                    funcionStr = Regex.Replace(funcionStr, @"e\^\((.*?)\)", "exp($1)");
                }

                string metodo = cmbMetodo.SelectedItem?.ToString();
                if (string.IsNullOrEmpty(metodo))
                {
                    MessageBox.Show("Por favor selecciona un método.");
                    return;
                }

                double xi = double.Parse(txtXi.Text);
                //double xd = double.Parse(txtXd.Text);
                var cul = CultureInfo.CurrentCulture;
                double xd = 0;
                if (metodo == "Biseccion" || metodo == "Regla Falsa" || metodo == "Secante")
                {
                    if (!double.TryParse(txtXd.Text, NumberStyles.Float, cul, out xd) &&
                        !double.TryParse(txtXd.Text, NumberStyles.Float, CultureInfo.InvariantCulture, out xd))
                    {
                        MessageBox.Show("Ingresá un xd válido para el método seleccionado.");
                        txtXd.Focus(); return;
                    }
                }

                int iteraciones = int.Parse(txtIteraciones.Text);
                double tol = double.Parse(txtTolerancia.Text);

                Calculo funcion = new Calculo();
                funcion.Sintaxis(funcionStr, 'x');

                Respuesta resultado = null;
                MetodoCerrado metodoCerrado = new MetodoCerrado();
                MetodoAbierto metodoAbierto = new MetodoAbierto();

                if (ControlVariables(xi, xd, tol, iteraciones, funcionStr))
                {
                    if (metodo == ("Biseccion") || metodo == ("Regla Falsa"))
                    {

                        resultado = metodoCerrado.MetodosCerrados(xi, xd, tol, iteraciones, funcion, metodo);
                    }
                    else if (metodo == ("Secante"))
                    {

                        resultado = metodoAbierto.MetodosAbiertos(xi, xd, tol, iteraciones, funcion, metodo);
                    }
                    else if (metodo == ("Newton-Raphson"))
                    {
                        resultado = metodoAbierto.MetodosAbiertos(xi, 0, tol, iteraciones, funcion, metodo);
                    }

                    txtResFuncion.Text = funcionStr;
                    txtResMetodo.Text = metodo;
                    txtResIteraciones.Text = resultado.iteraciones.ToString();
                    txtResTolerancia.Text = tol.ToString();
                    txtResRaiz.Text = resultado.raiz.ToString("G10");
                    if (resultado.Converge == "Converge")
                    {
                        txtResConverge.Text = "Si";
                    }
                    else
                    {
                        txtResConverge.Text = "No";
                        txtResRaiz.Text = "No hay raíz";
                    }

                    string notacion = resultado.error.ToString("E4");

                    string[] partes = notacion.Split('E');
                    string mantisa = partes[0];
                    int exponente = int.Parse(partes[1]);

                    string error = $"{mantisa} × 10^{exponente}";
                    txtResError.Text = error;
                }

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

        public bool ControlVariables(double xiCerrado, double xdCerrado, double tol, int maxIter, string funcion)
        {

            Calculo cal = new Calculo();
            if (cal.Sintaxis(funcion, 'x') == false)
            {
                MessageBox.Show("Sintaxis de la función incorrecta");
                return false;
            }
            if (xiCerrado == null)
            {
                MessageBox.Show("Se debe ingresar el primer valor para el intervalo");
                return false;
            }
            if (xdCerrado == null)
            {
                MessageBox.Show("Se debe ingresar el segundo valor para el intervalo");
                return false;
            }
            if (tol <= 0)
            {
                MessageBox.Show("La tolerancia debe ser mayor a cero.");
                return false;
            }
            if (maxIter <= 0)
            {
                MessageBox.Show("El número de iteraciones debe ser mayor a cero.");
                return false;
            }

            return true;
        }


        private void cmbMetodo_SelectedIndexChanged(object sender, EventArgs e)
        {
            string metodo = cmbMetodo.SelectedItem.ToString();

            if (metodo == "Newton-Raphson")
            {
                txtXd.Enabled = false;
                txtXd.Text = "";
            }
            else
            {
                txtXd.Enabled = true;
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


        private FormPrincipal _menu;

        public FormUnidad1(FormPrincipal menu)
        {
            InitializeComponent();
            _menu = menu;
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            _menu.Show();
            this.Close();
        }
    }
}
