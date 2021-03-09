using CodingChallenge.Data.Classes;
using CodingChallenge.Data.Strategy;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingChallenge.Data.Decorator
{
    public abstract class AbstractDecorator
    {
        protected AbstractDecorator _decorator;

        protected decimal Area { get; set; }
        protected int Cantidad { get; set; }
        protected decimal Perimetro { get; set; }

        protected AbstractDecorator(AbstractDecorator decorator)
        {
            _decorator = decorator;
        }

        public virtual void Calcular(FormaGeometrica forma)
        {
            if(_decorator != null)
            {
                _decorator.Calcular(forma);
            }
        }

        public virtual StringBuilder ObtenerLinea(StringBuilder str, IStrategy idioma)
        {
            if (_decorator != null)
            {
                return _decorator.ObtenerLinea(str, idioma);
            }
            return str;
        }

        public virtual StringBuilder ObtenerShape(StringBuilder str, IStrategy idioma, int totales = 0, decimal totalPerimetro = 0, decimal totalArea = 0)
        {
            if (_decorator != null)
            {
                return _decorator.ObtenerShape(str, idioma, totales, totalPerimetro, totalArea);
            }
            else
            {
                str.Append($"{totales} {idioma.Shape()} ");
                str.Append($"{idioma.Perimeter()} {(totalPerimetro).ToString("#.##")} ");
                str.Append($"{idioma.Area()} {(totalArea).ToString("#.##")}");
                return str;
            }
        }
    }
}
