using CodingChallenge.Data.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingChallenge.Data.Strategy
{
    public interface IStrategy
    {
        string Empty();
        string Header();
        string Shape();
        string Perimeter();
        string Area();
        string TraducirForma(FormaGeometrica forma, int cantidad);

    }
}
