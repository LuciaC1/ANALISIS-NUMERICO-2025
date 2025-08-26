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

        private Calculo calculo1 = new Calculo();

        public Respuesta MetodosCerrados(
            double xiCerrado,
            double xdCerrado,
            double tol,
            int maxIter,
            Calculo funcion,
            string metodo)
        {
            // Validación de entradas
            ValidarEntradas(xiCerrado, xdCerrado, tol, maxIter, funcion, metodo);

            double fxi = funcion.EvaluaFx(xiCerrado);
            double fxd = funcion.EvaluaFx(xdCerrado);

            // Verificar raíces exactas antes del bucle
            if (fxi == 0) return new Respuesta { raiz = xiCerrado, Converge = "Converge", iteraciones = 0, error = 0 };
            if (fxd == 0) return new Respuesta { raiz = xdCerrado, Converge = "Converge", iteraciones = 0, error = 0 };
            if (fxi * fxd > 0) throw new ArgumentException("No hay raíz en el intervalo [xi, xd].");

            // Inicialización de variables
            double xrAnterior = xiCerrado;
            double xr = 0;
            double error = double.MaxValue;
            Respuesta res = new Respuesta { Converge = "Converge" };

            for (int i = 0; i < maxIter && error > tol; i++)
            {
                xr = CalcularXr(xiCerrado, xdCerrado, funcion, metodo);
                double fxr = funcion.EvaluaFx(xr);

                // Verificar convergencia absoluta
                if (Math.Abs(fxr) < tol)
                {
                    res.raiz = xr;
                    res.error = error;
                    res.iteraciones = i + 1;
                    return res;
                }

                // Actualizar intervalo
                if (fxi * fxr < 0)
                {
                    xdCerrado = xr;
                    fxd = fxr;
                }
                else
                {
                    xiCerrado = xr;
                    fxi = fxr;
                }

                // Calcular error relativo
                error = Math.Abs((xr - xrAnterior) / xr);
                xrAnterior = xr;

                res.error = error;
                res.iteraciones = i + 1;
            }

            // Si supera iteraciones
            res.raiz = xr;
            res.Converge = "No converge";
            return res;
        }

        private double CalcularXr(double xi, double xd, Calculo funcion, string metodo)
        {
            return metodo switch
            {
                "Biseccion" => (xi + xd) / 2,
                "Regla Falsa" => (xi * funcion.EvaluaFx(xd) - xd * funcion.EvaluaFx(xi)) /
                                 (funcion.EvaluaFx(xd) - funcion.EvaluaFx(xi)),
                _ => throw new ArgumentException("Método no reconocido. Use 'Biseccion' o 'Regla Falsa'.")
            };
        }

        private void ValidarEntradas(double xi, double xd, double tol, int maxIter, Calculo funcion, string metodo)
        {
            if (funcion == null) throw new ArgumentNullException(nameof(funcion), "La función no puede ser nula.");
            if (string.IsNullOrWhiteSpace(metodo)) throw new ArgumentException("El método no puede estar vacío.");
            if (tol <= 0) throw new ArgumentException("La tolerancia debe ser mayor a cero.");
            if (maxIter <= 0) throw new ArgumentException("El número de iteraciones debe ser mayor a cero.");

            if (!calculo1.Sintaxis(funcion.ToString(), 'x'))
                throw new ArgumentException("La sintaxis de la función es incorrecta.");
        }
    }

}
