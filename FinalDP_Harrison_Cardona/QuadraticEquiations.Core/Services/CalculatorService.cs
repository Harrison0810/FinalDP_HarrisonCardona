using System;
using System.Collections.Generic;

namespace QuadraticEquiations.Core.Services
{
    public class CalculatorService : ICalculatorService
    {
        public List<double> CalculateEquation(double valueA, double valueB, double valueC)
        {
            List<double> lsResult = new List<double>();

            double square = Math.Sqrt((Math.Pow(valueB, 2) - 4 * valueA * valueC));

            double x1 = (-valueB + square) / (2 * valueA);
            lsResult.Add(x1);

            double x2 = (-valueB - square) / (2 * valueA);
            lsResult.Add(x2);

            return lsResult;
        }
    }
}
