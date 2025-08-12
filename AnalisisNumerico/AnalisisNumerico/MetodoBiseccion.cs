using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using Calculus;

namespace Unidad1
{
    public class MetodoBiseccion
    {

        public Calculo calculo1 = new Calculo();

        public double MetodosCerrados(double xiCerrado, double xdCerrado, double tol, int maxIter, string funcion)
        {
            double fxi = calculo1.EvaluaFx(xiCerrado);
            double fxd = calculo1.EvaluaFx(xdCerrado);
            int iteraciones = 0;
            if (fxi * fxd  > 0) {
                //devuelve error

            }
            else if (fxi * fxd == 0)
            {
                if (fxi == 0)
                {
                    //explicar que xi es raiz
                    return xiCerrado; //raiz encontrada
                }
                else if (fxd == 0)
                {
                    //explicar que xd es raiz
                    return xdCerrado; //raiz encontrada
                }
            }
            else
            {
                double xrAnterior = 0;
                double xr = 0;
                double error = double.MaxValue;
                for (int i = 0; i < maxIter && error > tol; i++)
                {
                    xr = (xiCerrado + xdCerrado) / 2;
                    double fxr = calculo1.EvaluaFx(xr);
                    if (fxr == 0)
                    {
                        //raiz encontrada
                        return xr;
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
                    error = Math.Abs(xr - xrAnterior);
                    xrAnterior = xr;  
                }
                //supera las iteraciones
                return xr; //retorna la raiz aproximada
            }
            return 0; //retorna 0 si no se encuentra una raiz
        }

        public double CalcularXr(double xi, double xd)
        {
            return (xi + xd) / 2;
        }

    }


}
