using Calculus;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using U1;

namespace Unidad1
{
    public class MetodoAbierto
    {
        public Calculo calculo1 = new Calculo();

        public Respuesta MetodosAbiertos(double xi, double xd, double tol, int maxIter, Calculo funcion, string metodo)
        {
            Respuesta res = new Respuesta();
            res.Converge = "Converge";

            ControlVariables(xi, xd, tol, maxIter, funcion, metodo);

            double fxi = funcion.EvaluaFx(xi);
            double fxd = (metodo.ToLower() == "secante") ? funcion.EvaluaFx(xd) : 0;

            // Revisar si xi o xd ya son raíz
            if (Math.Abs(fxi) < tol)
            {
                res.raiz = xi;
                return res;
            }

            if (metodo.ToLower() == "secante" && Math.Abs(fxd) < tol)
            {
                res.raiz = xd;
                return res;
            }

            double xrAnterior = 0;
            double xr = 0;
            double error = double.MaxValue;

            for (int i = 0; i < maxIter && error > tol; i++)
            {
                xr = CalcularXr(metodo, xi, xd, funcion, tol, out bool diverge);
                if (diverge || double.IsNaN(xr))
                {
                    res.Converge = "No converge";
                    break;
                }

                double fxr = funcion.EvaluaFx(xr);
                error = (xrAnterior != 0) ? Math.Abs((xr - xrAnterior) / xr) : fxr;

                if (Math.Abs(fxr) < tol || error < tol)
                {
                    res.raiz = xr;
                    res.error = error;
                    res.iteraciones = i + 1;
                    break;
                }

                if (metodo.ToLower() == "tangente")
                {
                    xi = xr;
                }
                else // Secante
                {
                    xi = xd;
                    xd = xr;
                }

                xrAnterior = xr;
                res.error = error;
                res.iteraciones = i + 1;

                if (i == maxIter - 1)
                    res.Converge = "No converge";
            }

            res.raiz = xr;
            return res;
        }

        public double CalcularXr(string metodo, double xi, double xd, Calculo funcion, double tol, out bool diverge)
        {
            diverge = false;

            if (metodo.ToLower() == "tangente")
            {
                double derivada = funcion.Dx(xi); // Suponiendo Calculo.Derivada(x)
                if (double.IsNaN(derivada) || Math.Abs(derivada) < tol)
                {
                    diverge = true;
                    return double.NaN;
                }

                return xi - funcion.EvaluaFx(xi) / derivada;
            }
            else if (metodo.ToLower() == "secante")
            {
                double fxi = funcion.EvaluaFx(xi);
                double fxd = funcion.EvaluaFx(xd);
                double denom = fxd - fxi;

                if (Math.Abs(denom) < 1e-12)
                {
                    diverge = true;
                    return double.NaN;
                }

                return (fxd * xi - fxi * xd) / denom;
            }
            else
            {
                throw new ArgumentException("Método no reconocido. Use 'Tangente' o 'Secante'.");
            }
        }

        public void ControlVariables(double xi, double xd, double tol, int maxIter, Calculo funcion, string metodo)
        {
            if (funcion == null) throw new ArgumentNullException(nameof(funcion));
            if (string.IsNullOrWhiteSpace(metodo)) throw new ArgumentException("El método no puede estar vacío.");
            if (tol <= 0) throw new ArgumentException("La tolerancia debe ser mayor a cero.");
            if (maxIter <= 0) throw new ArgumentException("El número de iteraciones debe ser mayor a cero.");

            Calculo cal = new Calculo();
            string fun = Convert.ToString(funcion);
            if (cal.Sintaxis(fun, 'x')) throw new ArgumentException("La sintaxis de la función es incorrecta.");
        }
    }
}
