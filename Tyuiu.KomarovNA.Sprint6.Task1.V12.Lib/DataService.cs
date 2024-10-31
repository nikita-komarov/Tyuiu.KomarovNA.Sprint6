using tyuiu.cources.programming.interfaces.Sprint6;

namespace Tyuiu.KomarovNA.Sprint6.Task1.V12.Lib
{
    public class DataService : ISprint6Task1V12
    {
        public double[] GetMassFunction(int startValue, int stopValue)
        {
            List<double> result = new List<double>();
            for (int i = startValue; i<=stopValue; i++ )
            {
                if (i==2) { result.Add(0.0); } else
                {
                    result.Add(Math.Sin(i) + (Math.Cos(i) + 1.0) / (2 - i) + 2 * i);
                }
            }
            return result.ToArray();
        }
    }
}
