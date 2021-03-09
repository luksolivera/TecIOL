using CodingChallenge.Data.Classes;
using CodingChallenge.Data.Strategy;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingChallenge.Data.Decorator
{
    public class ContadorCuadrado : AbstractDecorator
    {
        public ContadorCuadrado(AbstractDecorator decorator) : base(decorator)
        {
        }
        public override void Calcular(FormaGeometrica forma)
        {

            if (forma.GetType() == typeof(Cuadrado))
            {
                Cantidad++;
                Area += forma.CalcularArea();
                Perimetro += forma.CalcularPerimetro();
            }

            base.Calcular(forma);
        }
        public override StringBuilder ObtenerLinea(StringBuilder str, IStrategy idioma)
        {
            if (Cantidad > 0)
                str.Append($"{Cantidad} {idioma.TraducirForma(new Cuadrado(), Cantidad)} | {idioma.Area()} {Area:#.##} | {idioma.Perimeter()} {Perimetro:#.##} <br/>");
            return base.ObtenerLinea(str, idioma);
        }
        public override StringBuilder ObtenerShape(StringBuilder str, IStrategy idioma, int totales = 0, decimal totalPerimetro = 0, decimal totalArea = 0)
        {
            if (Cantidad > 0)
            {
                totales += Cantidad;
                totalPerimetro += Perimetro;
                totalArea += Area;
            }
            return base.ObtenerShape(str, idioma, totales, totalPerimetro, totalArea);
        }

    }
}
