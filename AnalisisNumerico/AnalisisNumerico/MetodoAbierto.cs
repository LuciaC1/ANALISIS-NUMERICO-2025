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

        public Respuesta MetodosAbiertos(double xi, double xi1, double tolerancia, int iteraciones, Calculo funcion, string metodo)
        {
            Respuesta res = new Respuesta();
            res.Converge = "Converge";
            int iter = 0;
            
            if(metodo == "Newton-Raphson")
            {
                double xr = xi;
                double derivadafx = funcion.Dx(xi);

                while (Math.Abs(funcion.EvaluaFx(xr)) > tolerancia && iter < iteraciones)
                {
                    double fx = funcion.EvaluaFx(xr);
                    derivadafx = funcion.Dx(xr);

                    if (/*derivadafx < tolerancia || */derivadafx == 0)
                    {
                        res.Converge = "No converge, la derivada es cero.";
                        break;
                    }

                    double xAnterior = xr;
                    xr = xr - (fx / derivadafx);

                    double errorAbsoluto = Math.Abs((xr - xAnterior) / xr);

                    double margenErrorRelativo;
                    if (Math.Abs(xr) == 0)
                    {
                        margenErrorRelativo = errorAbsoluto;
                    }
                    else
                    {
                        margenErrorRelativo = errorAbsoluto / Math.Abs(xr);
                    }

                    res.raiz = xr;
                    res.error = margenErrorRelativo;
                    iter++;
                    res.iteraciones = iter;

                    if (margenErrorRelativo < tolerancia || Math.Abs(fx) < tolerancia)
                    {
                        break;
                    }
                }

            }
            else if(metodo == "Secante")
            {
                double xAnt = xi;
                double xAct = xi1;
                double margenDeErrorRelativo = double.MaxValue;

                while (iter < iteraciones)
                {
                    try
                    {
                        double fxAnt = funcion.EvaluaFx(xAnt);
                        double fxAct = funcion.EvaluaFx(xAct);

                        if (Math.Abs(fxAct - fxAnt) < 1e-10)
                        {
                            res.Converge = "No converge, la diferencia en la función es casi cero";
                            break;
                        }

                        double xProx = xAct - fxAct * (xAct - xAnt) / (fxAct - fxAnt);

                        double errorAbsoluto = Math.Abs(xProx - xAct);
                        margenDeErrorRelativo = (Math.Abs(xProx) == 0) ? errorAbsoluto : errorAbsoluto / Math.Abs(xProx);

                        xAnt = xAct;
                        xAct = xProx;
                        iter++;

                        res.iteraciones = iter;
                        res.raiz = xAct;
                        res.error = margenDeErrorRelativo;

                        if (margenDeErrorRelativo < tolerancia)
                        {
                            break;
                        }

                        if (double.IsNaN(fxAct) || double.IsInfinity(fxAct))
                        {
                            res.Converge = "No converge, valores fuera del dominio real";
                            break;
                        }
                    }
                    catch (Exception ex)
                    {
                        res.Converge = "No converge, error en la evaluación: " + ex.Message;
                        break;
                    }
                }

            }

            /*double x_Anterior = xi;

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
            }*/

            if (iter >= iteraciones)
            {
                res.Converge = "No converge, se excedió el número de iteraciones";
            }
            return res;
        }

        /*public double CalcularXr(double xi, Calculo funcion, string metodo)
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
        }*/

        /*public void ControlVariables(double xiAbierto, double tol, double maxIter, Calculo funcion, string metodo)
        {
            Calculo cal = new Calculo();
            if (funcion == null) throw new ArgumentNullException(nameof(funcion));
            if (string.IsNullOrWhiteSpace(metodo)) throw new ArgumentException("El método no puede estar vacío.");
            if (tol <= 0) throw new ArgumentException("La tolerancia debe ser mayor a cero.");
            if (maxIter <= 0) throw new ArgumentException("El número de iteraciones debe ser mayor a cero.");

            string fun = Convert.ToString(funcion);
            if (cal.Sintaxis(fun, 'x')) throw new ArgumentException("La sintaxis de la función es incorrecta.");
        }*/

        /*static bool CambioDeSigno(Calculo f, double a, double b)
        {
            double fa = f.EvaluaFx(a);
            double fb = f.EvaluaFx(b);
            return fa * fb < 0;
        }*/
    }
}
