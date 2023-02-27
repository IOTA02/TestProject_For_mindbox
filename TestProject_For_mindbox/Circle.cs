namespace TestProject_For_mindbox
{
    public class Circle
    {
        double  r = 2;
        public const double MinR = 1e-6;

        public double Calculation (double r)
        {
            double s;

            if (r - MinR < Constants.CalculationAccuracy)
                throw new ArgumentException("Неверно указан радиус круга.", nameof(r));

            s = Math.Pow(r, 2)*Math.PI;

            return s;
        }
        public void Print() => Console.WriteLine($"Name: {Calculation}");
    }
}