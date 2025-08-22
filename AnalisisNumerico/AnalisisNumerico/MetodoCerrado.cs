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

            ControlVariables(xiCerrado, xdCerrado, tol, maxIter, funcion, metodo);

            if (!CambioDeSigno(funcion, xiCerrado, xdCerrado))
            {
                throw new ArgumentException("La función debe cambiar de signo en el intervalo [xi, xd].");
            }

            double fxi = funcion.EvaluaFx(xiCerrado);
            double fxd = funcion.EvaluaFx(xdCerrado);

            if (fxi * fxd > 0)
            {
                throw new Exception("Error: f(xi) * f(xd) > 0. No hay raíz en el intervalo.");
            }
            else if (fxi == 0)
            {
                res.raiz = xiCerrado;
            }
            else if (fxd == 0)
            {
                res.raiz = xdCerrado;
            }
            else
            {
                double xrAnterior = xiCerrado;
                double xr = 0;
                double error = double.MaxValue;

                for (int i = 0; i < maxIter && error > tol; i++)
                {
                    if (metodo == "Biseccion")
                    {
                        xr = CalcularXr(xiCerrado, xdCerrado, null);
                    }
                    else if (metodo == "Regla Falsa")
                    {
                        xr = CalcularXr(xiCerrado, xdCerrado, funcion);
                    }
                    else
                    {
                        throw new Exception("Método no reconocido. Use 'Biseccion' o 'Regla Falsa'.");
                    }

                    double fxr = funcion.EvaluaFx(xr);

                    if (fxr == 0)
                    {
                        res.raiz = xr;
                    }
                    else if (fxi * fxr < 0)
                    {
                        xdCerrado = xr;
                        fxd = fxr;
                    }
                    else
                    {
                        xiCerrado = xr;
                        fxi = fxr;
                    }

                    error = Math.Abs((xr - xrAnterior) / xr);
                    res.error = error;
                    res.iteraciones = i + 1;
                    xrAnterior = xr;

                    if (i == (maxIter - 1))
                    {
                        res.Converge = "No converge";
                    }
                }

                res.raiz = xr;
            }

            return res;
        }

        public double CalcularXr(double xi, double xd, Calculo funcion)
        {
            if (funcion == null)
            {
                return (xi + xd) / 2;
            }
            else
            {
                double fxd = funcion.EvaluaFx(xd);
                double fxi = funcion.EvaluaFx(xi);
                return (xi * fxd - xd * fxi) / (fxd - fxi);
            }
        }

        public void ControlVariables(double xiCerrado, double xdCerrado, double tol, int maxIter, Calculo funcion, string metodo)
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

        /*public Respuesta MetodosCerrados(double xiCerrado, double xdCerrado, double tol, int maxIter, Calculo funcion, string metodo)
        {
            Respuesta res = new Respuesta();

            res.Converge= "Converge";

            ControlVariables(xiCerrado, xdCerrado, tol, maxIter, funcion, metodo);

            if (!CambioDeSigno(funcion, xiCerrado, xdCerrado))
            {
                throw new ArgumentException("La función debe cambiar de signo en el intervalo [xi, xd].");
            }

            double fxi = funcion.EvaluaFx(xiCerrado);
            double fxd = funcion.EvaluaFx(xdCerrado);

            if (fxi * fxd > 0)
            {
                throw new Exception("Error: f(xi) * f(xd) > 0. No hay raíz en el intervalo.");
            }
            else if (fxi == 0)
            {
                res.raiz = xiCerrado; 
            }
            else if (fxd == 0)
            {
                res.raiz = xdCerrado; 
            }
            else
            {
                double xrAnterior = xiCerrado;
                double xr = 0;
                double error = double.MaxValue;

                for (int i = 0; i < maxIter && error > tol; i++)
                {
                    if (metodo == "Biseccion")
                    {
                        xr = CalcularXr(xiCerrado, xdCerrado, null);
                    }
                    else if (metodo == "Regla Falsa")
                    {
                        xr = CalcularXr(xiCerrado, xdCerrado, funcion);
                    }
                    else
                    {
                        throw new Exception("Método no reconocido. Use 'Biseccion' o 'Regla Falsa'.");
                    }

                    double fxr = funcion.EvaluaFx(xr);

                    if (fxr == 0)
                    {
                        res.raiz = xr; 
                    }
                    else if (fxi * fxr < 0)
                    {
                        xdCerrado = xr;
                        fxd = fxr;
                    }
                    else
                    {
                        xiCerrado = xr;
                        fxi = fxr;
                    }

                    error = Math.Abs((xr - xrAnterior) / xr);
                    res.error = error;
                    xrAnterior = xr;

                    if (i == (maxIter -1))
                    {
                    res.Converge = "No converge";
                    }
                }

                res.raiz= xr;

                return res;
            }
        }

        public double CalcularXr(double xi, double xd, Calculo funcion)
        {
            if(funcion == null){
                return (xi + xd) / 2;
            }
            else
            {
                double fxd = funcion.EvaluaFx(xd);
                double fxi = funcion.EvaluaFx(xi);
                double xr = (xi * fxd - xd * fxi) / (fxd - fxi);
                return xr;
            }
        }

        public void ControlVariables(double xiCerrado, double xdCerrado, double tol, int maxIter, Calculo funcion, string metodo) 
        {
            if (calculo1.Sintaxis(funcion, 'x') == false) { 
                throw new ArgumentException("La sintaxis de la función es incorrecta");
            }
            if ([xiCerrado, xdCerrado, maxIter, tol, funcion, metodo].some(v => v == null))
            {
                throw new ArgumentNullException("No puede haber espacios vacíos");
            }

            if ([tol, maxIter] < 0)
            {
                throw new ArgumentException("Ingrese valores mayores a cero.");
            }
            if ([funcion, metodo].some(v => v == ""))
            {
                throw new ArgumentException("Ingrese valores no vacíos.");
            }

        }

        static bool CambioDeSigno(Calculo f, double a, double b)
        {
            double fa = f.EvaluaFx(a);
            double fb = f.EvaluaFx(b);
            return fa * fb < 0;
        }*/
    }


}
