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
using System.Globalization; 
using System.Text; 

namespace U1
{
    public partial class FormUnidad4 : Form
    {

        private string _lastPlottedExpr = null;
        private double? _lastPlottedXi = null;
        private double? _lastPlottedXd = null;

        public FormUnidad4()
        {
            InitializeComponent();
            this.Load += FormUnidad4_Load; 
        }

        string seleccion = "";
        private void comboBoxMetodo_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            seleccion = comboBoxMetodo.SelectedItem.ToString();

        }


        private async void buttonCalcular_Click(object sender, EventArgs e)
        {
    
            string xiText = (textBoxXi.Text ?? string.Empty).Trim().Replace(',', '.');
            string xdText = (textBoxXd.Text ?? string.Empty).Trim().Replace(',', '.');
            string funcionRaw = textBoxFuncion.Text ?? string.Empty;
            string subIntervalosText = (textBoxSubIntervalos.Text ?? string.Empty).Trim();

            if (!double.TryParse(xiText, System.Globalization.NumberStyles.Float, CultureInfo.InvariantCulture, out double xi))
            {
                MessageBox.Show("Valor de Xi inválido. Use formato numérico (ej. 1.5 o 1,5).", "Entrada inválida", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (!double.TryParse(xdText, System.Globalization.NumberStyles.Float, CultureInfo.InvariantCulture, out double xd))
            {
                MessageBox.Show("Valor de Xd inválido. Use formato numérico (ej. 2.5 o 2,5).", "Entrada inválida", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (!int.TryParse(subIntervalosText, out int subIntervalos) || subIntervalos <= 0)
            {
                MessageBox.Show("El número de subintervalos debe ser un entero positivo.", "Entrada inválida", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }


            string funcion = funcionRaw.Replace(',', '.');

            double resultado = double.NaN;

            if (seleccion == "Integral Trapecios Simple")
            {
                resultado = CalcularIntegralTrapeciosSimple(funcion, xi, xd);
                labelArea.Text = $"El área es de {resultado} UA";
            }

            if (seleccion == "Integral Trapecios Multiple")
            {
                resultado = CalcularIntegralTrapeciosMultiple(funcion, xi, xd, subIntervalos);
                labelArea.Text = $"El área es de {resultado} UA";
            }

            if (seleccion == "Integral Simpson 1/3 Simple")
            {
                resultado = CalcularIntegralSimpsonTercioSimple(funcion, xi, xd);
                labelArea.Text = $"El área es de {resultado} UA";
            }

            if (seleccion == "Integral Simpson 1/3 Multiple")
            {
                resultado = CalcularIntegralSimpsonTercioMultiple(funcion, xi, xd, subIntervalos);
                labelArea.Text = $"El área es de {resultado} UA";
            }

            if (seleccion == "Integral Simpson 3/8")
            {
                resultado = CalcularIntegralSimpsonTresOctavos(funcion, xi, xd);
                labelArea.Text = $"El área es de {resultado} UA";
            }

            if (seleccion == "Simpson 1/3 Multiple y Simpson 3/8 Combinados")
            {
                resultado = CalcularIntegralSimpsonCombinados(funcion, xi, xd, subIntervalos);
                labelArea.Text = $"El área es de {resultado} UA";
            }


            try
            {
                await GraficarIntegralEnGeoGebraAsync(funcion, xi, xd);
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se pudo graficar en GeoGebra: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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
                Console.WriteLine("La función está mal ingresada."); 
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

        private void labelArea_Click(object sender, EventArgs e)
        {

        }

        private void buttonVolverMenu_Click(object sender, EventArgs e)
        {
            this.Owner.Show();
            this.Close();
        }

        private void webView21_Click(object sender, EventArgs e)
        {

        }

        private async void FormUnidad4_Load(object? sender, EventArgs e)
        {
            try
            {
                if (webView21 != null)
                {
                    await webView21.EnsureCoreWebView2Async(null);
                    webView21.Source = new Uri("https://www.geogebra.org/graphing");
                }
            }
            catch
            {
                
            }
        }

        private async Task GraficarIntegralEnGeoGebraAsync(string funcion, double xi, double xd)
        {
            string expr = (funcion ?? string.Empty).Trim();
            int eq = expr.IndexOf('=');
            if (eq >= 0) expr = expr.Substring(eq + 1).Trim();

            expr = expr.Replace("'", "\\'").Replace("\"", "\\\"");

            if (string.IsNullOrWhiteSpace(expr)) return;

            if (string.Equals(_lastPlottedExpr, expr, StringComparison.InvariantCulture) && 
                _lastPlottedXi.HasValue && _lastPlottedXd.HasValue &&
                _lastPlottedXi.Value == xi && _lastPlottedXd.Value == xd)
            {
                return;
            }


            if (webView21?.CoreWebView2 == null)
            {
                try
                {
                    await webView21.EnsureCoreWebView2Async(null);
                }
                catch
                {
                    return;
                }
                if (webView21.CoreWebView2 == null) return;
            }


            string xiStr = xi.ToString(CultureInfo.InvariantCulture);
            string xdStr = xd.ToString(CultureInfo.InvariantCulture);

            var sb = new StringBuilder();
            sb.Append("(function waitAndRun(){");
            sb.Append("  if(typeof ggbApplet !== 'undefined' && ggbApplet){");
            sb.Append("    try{");

            sb.Append("      if(ggbApplet.exists('Area')){ ggbApplet.evalCommand('Delete(Area)'); }");
            sb.Append("      if(ggbApplet.exists('A')){ ggbApplet.evalCommand('Delete(A)'); }");
            sb.Append("      if(ggbApplet.exists('B')){ ggbApplet.evalCommand('Delete(B)'); }");

            sb.Append($"      ggbApplet.evalCommand('f(x) = {expr}');");
            // intentamos crear el objeto Area con el comando de integración
            sb.Append($"      try{{ ggbApplet.evalCommand('Area = Integral[f, {xiStr}, {xdStr}]'); }}catch(e){{}};");

            // Ahora hacemos comprobaciones periódicas hasta que GeoGebra cree el objeto 'Area'
            sb.Append("      (function checkArea(tries){");
            sb.Append("        try{");
            sb.Append("          if(ggbApplet.exists('Area')){");
            sb.Append("            try{ ggbApplet.evalCommand('SetFilling(Area, 0.5)'); }catch(e){};");
            sb.Append("            try{ ggbApplet.evalCommand('SetColor(Area, 0, 128, 255)'); }catch(e){};"); // color azul suave
            sb.Append("            try{ ggbApplet.evalCommand('SetLineThickness(Area, 0)'); }catch(e){};");
            sb.Append("            try{ ggbApplet.evalCommand('ShowObject(Area, true)'); }catch(e){};");
            sb.Append("            return;");
            sb.Append("          }");
            sb.Append("        }catch(e){};");
            sb.Append("        if(!tries || tries < 8){ setTimeout(function(){ checkArea((tries||0)+1); }, 250); }");
            sb.Append("      })();");

            sb.Append("      try{ ggbApplet.evalCommand('A = (" + xiStr + ", f(" + xiStr + "))'); }catch(e){};");
            sb.Append("      try{ ggbApplet.evalCommand('B = (" + xdStr + ", f(" + xdStr + "))'); }catch(e){};");

            double marginX = Math.Max(1.0, (xd - xi) * 0.2);
            string minX = (xi - marginX).ToString(CultureInfo.InvariantCulture);
            string maxX = (xd + marginX).ToString(CultureInfo.InvariantCulture);
            sb.Append($"      try{{ ggbApplet.setCoordSystem({minX}, {maxX}, -10, 10); }}catch(e){{}}");
            sb.Append("    }catch(e){ console && console.log && console.log('ggb error', e); }");
            sb.Append("  } else { setTimeout(waitAndRun, 200); }");
            sb.Append("})();");

            try
            {
                await webView21.CoreWebView2.ExecuteScriptAsync(sb.ToString());
                _lastPlottedExpr = expr;
                _lastPlottedXi = xi;
                _lastPlottedXd = xd;
            }
            catch
            {
            }
        }
    }
}
