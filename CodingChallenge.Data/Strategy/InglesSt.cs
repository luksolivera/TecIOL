using CodingChallenge.Data.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingChallenge.Data.Strategy
{
    public class InglesSt : IStrategy
    {
        public string Area()
        {
            return "Area";
        }

        public string Empty()
        {
            return "<h1>Empty list of shapes!</h1>";
        }

        public string Header()
        {
            return "<h1>Shapes report</h1>";
        }

        public string Perimeter()
        {
            return "Perimeter";
        }

        public string Shape()
        {
            return "shapes";
        }

        public string TraducirForma(FormaGeometrica forma, int cantidad)
        {
            switch (forma.Identification())
            {
                case 1:
                    return cantidad == 1 ? "Square" : "Squares";
                case 2:
                    return cantidad == 1 ? "Circle" : "Circles";
                case 3:
                    return cantidad == 1 ? "Triangle" : "Triangles";
            }
            return string.Empty;
        }
    }
}
