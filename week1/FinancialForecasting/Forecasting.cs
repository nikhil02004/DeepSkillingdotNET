namespace FinancialForecasting
{
    public class Forecasting
    {
        public static double PredictRecursive(double currentValue, double growthRate, int years)
        {
            if (years == 0)
                return currentValue;

            return PredictRecursive(currentValue * (1 + growthRate), growthRate, years - 1);
        }

        public static double PredictIterative(double currentValue, double growthRate, int years)
        {
            for (int i = 0; i < years; i++)
                currentValue *= (1 + growthRate);

            return currentValue;
        }
    }
}

