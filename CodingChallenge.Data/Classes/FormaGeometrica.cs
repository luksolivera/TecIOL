/*
 * Refactorear la clase para respetar principios de programación orientada a objetos. Qué pasa si debemos soportar un nuevo idioma para los reportes, o
 * agregar más formas geométricas?
 *
 * Se puede hacer cualquier cambio que se crea necesario tanto en el código como en los tests. La única condición es que los tests pasen OK.
 *
 * TODO: Implementar Trapecio/Rectangulo, agregar otro idioma a reporting.
 * */

using CodingChallenge.Data.Decorator;
using CodingChallenge.Data.Strategy;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CodingChallenge.Data.Classes
{
    public abstract class FormaGeometrica
    {
        protected readonly decimal _lado;
        protected FormaGeometrica(decimal ancho)
        {
            _lado = ancho;
        }

        public static string Imprimir(List<FormaGeometrica> formas, int idioma)
        {
            var sb = new StringBuilder();
            var idiomaStrategy = Builder.GetStrategy(idioma);
            if (!formas.Any())
            {
                sb.Append(idiomaStrategy.Empty());
            }
            else
            {
                // Hay por lo menos una forma
                // HEADER
                sb.Append(idiomaStrategy.Header());
                var decorator = Builder.BuildDecorator();

                foreach(var forma in formas)
                {
                    decorator.Calcular(forma);
                }
                sb = decorator.ObtenerLinea(sb, idiomaStrategy);
                // FOOTER
                sb.Append("TOTAL:<br/>");
                
                sb = decorator.ObtenerShape(sb, idiomaStrategy);
            }

            return sb.ToString();
        }
        public abstract decimal CalcularArea();
        public abstract decimal CalcularPerimetro();
        public abstract int Identification();

    }
}
