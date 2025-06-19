using System;

namespace FinancialForecasting
{
    class Program
    {
        static void Main()
        {
            double currentValue = 10000;
            double growthRate = 0.07; // 7%
            int years = 5;

            double recursive = Forecasting.PredictRecursive(currentValue, growthRate, years);
            double iterative = Forecasting.PredictIterative(currentValue, growthRate, years);

            Console.WriteLine($"Recursive Forecast: {recursive:F2}");
            Console.WriteLine($"Iterative Forecast: {iterative:F2}");
        }
    }
}

