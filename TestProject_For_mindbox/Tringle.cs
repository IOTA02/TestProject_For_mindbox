using Microsoft.VisualBasic;
using System.Reflection.Metadata;
using System;

namespace TestProject_For_mindbox
{
    public class Tringle
    { 
        double a, b, c;

        public double Calculation(double a, double b, double c)
        {
            double s, p, perimeter;

            p= 2/(a+b+c);

            perimeter= a+b+c;
            var max = Math.Max(a, Math.Max(b, c));
            if ((perimeter - max) - max < Constants.CalculationAccuracy)
                throw new ArgumentException("Наибольшая сторона треугольника должна быть меньше суммы других сторон");

            s = Math.Sqrt(p * (p - a) * p * (p - b) * p * (p - c));

            return s;
        }
    }
}
