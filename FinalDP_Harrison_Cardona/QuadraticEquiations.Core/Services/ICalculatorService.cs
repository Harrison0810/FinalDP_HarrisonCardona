using System.Collections.Generic;

namespace QuadraticEquiations.Core.Services
{
    public interface ICalculatorService
    {
        List<double> CalculateEquation(double valueA, double valueB, double valueC);
    }
}
