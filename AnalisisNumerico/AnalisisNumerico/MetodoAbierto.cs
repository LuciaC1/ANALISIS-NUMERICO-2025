using Calculus;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace U1
{
    public class MetodoAbierto
    {

        Calculo calculo = new Calculo();

        public Respuesta MetodosAbiertos(double xi, double xi1, double tol, int iteraciones, Calculo funcion, string metodo)
        {
            Respuesta res = new Respuesta();

            ControlVariables(xi, tol, iteraciones, funcion, metodo);

            res.Converge = "Converge";
            int iter = 0;
            double x_Anterior = xi;

            double fxi = funcion.EvaluaFx(xi);

            if (metodo == "Secante")
            {
                double x_Actual = xi1;
            }

            if (Math.Abs(fxi) < tol)
            {
                res.raiz = xi;
            }
            else if (fxi == 0)
            {
                res.raiz = xi;
            }
            else
            {
                double xrAnterior = xi;
                double xr = 0;
                double error = double.MaxValue;
                for (int i = 0; i < iteraciones && error > tol; i++)
                {
                    if (metodo == "Secante")
                    {
                        xr = CalcularXr(xrAnterior, funcion, "Secante");
                    }
                    else if (metodo == "Tangente")
                    {
                        xr = CalcularXr(xrAnterior, funcion, "Tangente");
                    }
                    error = Math.Abs((xr - xrAnterior) / xr);
                    xrAnterior = xr;
                    res.iteraciones++;
                }
                if (error > tol)
                {
                    res.Converge = "No Converge";
                }
                res.raiz = xr;
                res.error = error;
            }
            return res;
        }

        public double CalcularXr(double xi, Calculo funcion, string metodo)
        {
            double xr = 0;
            if (metodo == "Secante")
            {

            }
            else if (metodo == "Tangente")
            {
                calculo.Dx(xi);
            }
            return xr;
        }

        public void ControlVariables(double xiAbierto, double tol, double maxIter, Calculo funcion, string metodo)
        {
            Calculo cal = new Calculo();
            if (funcion == null) throw new ArgumentNullException(nameof(funcion));
            if (string.IsNullOrWhiteSpace(metodo)) throw new ArgumentException("El método no puede estar vacío.");
            if (tol <= 0) throw new ArgumentException("La tolerancia debe ser mayor a cero.");
            if (maxIter <= 0) throw new ArgumentException("El número de iteraciones debe ser mayor a cero.");

            string fun = Convert.ToString(funcion);
            if (cal.Sintaxis(fun, 'x')) throw new ArgumentException("La sintaxis de la función es incorrecta.");
        }

        static bool CambioDeSigno(Calculo f, double a, double b)
        {
            double fa = f.EvaluaFx(a);
            double fb = f.EvaluaFx(b);
            return fa * fb < 0;
        }
    }
}
