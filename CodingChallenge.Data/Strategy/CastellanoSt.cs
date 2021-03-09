using CodingChallenge.Data.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingChallenge.Data.Strategy
{
    public class CastellanoSt : IStrategy
    {
        public string Area()
        {
            return "Area";
        }

        public string Empty()
        {
            return "<h1>Lista vacía de formas!</h1>";
        }

        public string Header()
        {
            return "<h1>Reporte de Formas</h1>";
        }

        public string Perimeter()
        {
            return "Perimetro";
        }

        public string Shape()
        {
            return "formas";
        }

        public string TraducirForma(FormaGeometrica forma, int cantidad)
        {

            switch (forma.Identification())
            {
                case 1:
                    return cantidad == 1 ? "Cuadrado" : "Cuadrados";
                case 2:
                    return cantidad == 1 ? "Círculo" : "Círculos";
                case 3:
                    return cantidad == 1 ? "Triángulo" : "Triángulos";
            }


            return string.Empty;
            
        }
    }
}
