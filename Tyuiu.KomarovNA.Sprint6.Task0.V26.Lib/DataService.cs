using tyuiu.cources.programming.interfaces.Sprint6;

namespace Tyuiu.KomarovNA.Sprint6.Task0.V26.Lib
{
    public class DataService : ISprint6Task0V26
    {
        public double Calculate(int x)
        {
            x = 3;
            double result = (x * x + 1) / (3 * x + 4);
            return Math.Round(result, 3);
        }
    }
}
