using tyuiu.cources.programming.interfaces.Sprint6;

namespace Tyuiu.KomarovNA.Sprint6.Task4.V3.Lib
{
    public class DataService : ISprint6Task4V3
    {
        public double[] GetMassFunction(int startValue, int stopValue)
        {
            List<double> result = new List<double>();
            for (int i = startValue; i <= stopValue; i++)
            {
                if (Math.Sin(i) - 3 + i == 0) { result.Add(0.0); }
                else
                {
                    double res = (3*i - 1.5) / (Math.Sin(i) - 3 + i) + 2;
                    result.Add(Math.Round(res, 2));
                }
            }
            return result.ToArray();
        }
    }
}
