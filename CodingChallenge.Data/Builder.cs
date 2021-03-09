using CodingChallenge.Data.Decorator;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingChallenge.Data.Strategy
{
    public static class Builder
    {
        public static IStrategy GetStrategy(int idioma)
        {
            switch (idioma)
            {
                case (int)Enums.Idioma.Ingles:
                    return new InglesSt();
                case (int)Enums.Idioma.Castellano:
                default:
                    return new CastellanoSt();
            }
        }
        public static AbstractDecorator BuildDecorator()
        {
            AbstractDecorator decorator = new ContadorTriangulo(null);
            decorator = new ContadorCirculo(decorator);
            decorator = new ContadorCuadrado(decorator);

            return decorator;
        }
    }
}
