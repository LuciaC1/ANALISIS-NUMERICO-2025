using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using Calculus;
using U1;


namespace U1
{
    public class MetodoCerrado
    {

        public Calculo calculo1 = new Calculo();

        public Respuesta MetodosCerrados(double xiCerrado, double xdCerrado, double tol, int maxIter, Calculo funcion, string metodo)
        {
            Respuesta res = new Respuesta();
            res.Converge = "Converge";


            double fxi = funcion.EvaluaFx(xiCerrado);
            double fxd = funcion.EvaluaFx(xdCerrado);

            if (fxi * fxd > 0)
            {
                MessageBox.Show("Error: f(xi) * f(xd) > 0. No hay raíz en el intervalo. Vuelva a ingresar el intervalo");
            }
            else if (fxi * fxd == 0)
            {
                if (fxi == 0) res.raiz = xiCerrado;
                else if (fxd == 0) res.raiz = xdCerrado;
            }
            else
            {
                double xrAnterior = xiCerrado;
                double xr = 0;
                double error = 0;

                for (int i = 0; i < maxIter; i++)
                {
                    if (metodo == "Biseccion")
                    {
                        xr = CalcularXr(xiCerrado, xdCerrado, null);
                    }
                    else if (metodo == "Regla falsa")
                    {
                        xr = CalcularXr(xiCerrado, xdCerrado, funcion);
                    }
                    else
                    {
                        throw new FormatException("Método no reconocido. Use 'Biseccion' o 'Regla Falsa'.");
                    }

                    double fxr = funcion.EvaluaFx(xr);

                    error = Math.Abs((xr - xrAnterior) / xr);

                    if (Math.Abs(fxr) < tol || error < tol)
                    {
                        res.raiz = xr;
                        res.error = error;
                        res.iteraciones = i + 1;
                        break;
                    }

                    else if ((fxi * fxr) > 0)
                    {
                        xiCerrado = xr;

                    }
                    else
                    {
                        xdCerrado = xr;

                    }

                    res.error = error;
                    res.iteraciones = i + 1;
                    xrAnterior = xr;

                }

                res.raiz = xr;
            }

            return res;
        }

        public double CalcularXr(double xi, double xd, Calculo funcion)
        {
            if (funcion == null)
            {
                return ((xi + xd) / 2);
            }
            else
            {
                double fxd = funcion.EvaluaFx(xd);
                double fxi = funcion.EvaluaFx(xi);
                return ((xi * fxd - xd * fxi) / (fxd - fxi));
            }
        }

        /*public void ControlVariables(double xiCerrado, double xdCerrado, double tol, int maxIter, Calculo funcion, string metodo)
        {
            Calculo cal = new Calculo();
            if (funcion == null) throw new FormatException(nameof(funcion));
            if (string.IsNullOrWhiteSpace(metodo)) throw new FormatException("El método no puede estar vacío.");
            if (tol <= 0) throw new FormatException("La tolerancia debe ser mayor a cero.");
            if (maxIter <= 0) throw new FormatException("El número de iteraciones debe ser mayor a cero.");

            string fun = Convert.ToString(funcion);
            if (cal.Sintaxis(fun, 'x')) throw new FormatException("La sintaxis de la función es incorrecta.");
        }*/

        static bool CambioDeSigno(Calculo f, double a, double b)
        {
            double fa = f.EvaluaFx(a);
            double fb = f.EvaluaFx(b);
            return fa * fb < 0;
        }




    }
}
