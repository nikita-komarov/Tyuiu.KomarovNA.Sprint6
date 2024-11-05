using tyuiu.cources.programming.interfaces.Sprint6;

namespace Tyuiu.KomarovNA.Sprint6.Task5.V24.Lib
{
    public class DataService : ISprint6Task5V24
    {
        public double[] LoadFromDataFile(string path)
        {
            string[] lines = File.ReadAllLines(path);
            var numsArray = lines.Select(line => double.Parse(line)).ToArray();
            numsArray = numsArray.Where(val => val == 0).ToArray();
            return numsArray;
        }
    }
}