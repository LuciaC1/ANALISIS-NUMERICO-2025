using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using Calculus;
usign Respuesta;


namespace Unidad1
{
    public class MetodoCerrado
    {

        public Calculo calculo1 = new Calculo();

        public Respuesta MetodoCerrado(double xiCerrado, double xdCerrado, double tol, int maxIter, Calculo funcion, string metodo)
        {
            Respuesta res = new Respuesta();
            ControlVariables(xiCerrado, xdCerrado, tol, maxIter, funcion, metodo);
            double fxi = calculo1.EvaluaFx(funcion, xiCerrado);
            double fxd = calculo1.EvaluaFx(funcion, xdCerrado);

            if (fxi * fxd > 0)
            {
                throw new Exception("Error: f(xi) * f(xd) > 0. No hay raíz en el intervalo.");
            }
            else if (fxi == 0)
            {
                return xiCerrado; // xi es raíz exacta
            }
            else if (fxd == 0)
            {
                return xdCerrado; // xd es raíz exacta
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
                        throw new Exception("Método no reconocido. Use 'Falsa Posición' o 'Regla Falsa'.");
                    }

                    double fxr = calculo1.EvaluaFx(funcion, xr);

                    if (fxr == 0)
                    {
                        return xr; // raíz exacta
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

                    error = Math.Abs((xr - xrAnterior) / xr); // error relativo
                    xrAnterior = xr;
                }
                if (i == (interacciones - 1))
                {
                    res.Converge = "No converge";
                }

                return xr; // raíz aproximada
            }
        }

        public double CalcularXr(double xi, double xd, Calculo funcion)
        {
            if(funcion == null){
                return (xi + xd) / 2;
            }
            else
            {
                double fxd = calculo1.EvaluaFx(funcion, xd);
                double fxi = calculo1.EvaluaFx(funcion, xi);
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


    }


}
