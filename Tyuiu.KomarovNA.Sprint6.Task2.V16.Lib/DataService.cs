using tyuiu.cources.programming.interfaces.Sprint6;

namespace Tyuiu.KomarovNA.Sprint6.Task2.V16.Lib
{
    public class DataService : ISprint6Task2V16
    {
        public double[] GetMassFunction(int startValue, int stopValue)
        {
            List<double> result = new List<double>();
            for (int i = startValue; i <= stopValue; i++)
            {
                if (i == 2) { result.Add(0.0); }
                else
                {
                    double res = Math.Cos(i) / (i-0.4) + Math.Sin(i) * 8*i + 2;
                    result.Add(Math.Round(res, 2));
                }
            }
            return result.ToArray();
        }
    }
}
