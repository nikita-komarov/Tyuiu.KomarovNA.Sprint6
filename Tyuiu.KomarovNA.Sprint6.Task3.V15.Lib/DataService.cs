using System.Data;
using tyuiu.cources.programming.interfaces.Sprint6;

namespace Tyuiu.KomarovNA.Sprint6.Task3.V15.Lib
{
    public class DataService : ISprint6Task3V15
    {
        public static int[] qsort(int[] arr)
        {
            if (arr.Length < 2) { return arr; }
            int indxToDel = 0;
            int support = arr[indxToDel];
            int[] lth_arr = arr.Where((el, indx) => indx != indxToDel && el < support).ToArray();
            int[] bth_arr = arr.Where((el, indx) => indx != indxToDel && el >= support).ToArray();

            return qsort(lth_arr).Concat([support]).Concat(qsort(bth_arr)).ToArray();
        }
        public int[,] Calculate(int[,] matrix)
        {
            int[] thirdCol = new int[matrix.GetLength(0)];
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    if (j==3)
                    {
                        thirdCol[i] = matrix[i, j];
                    }
                }
            }
            thirdCol = qsort(thirdCol);
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    if (j == 3)
                    {
                        matrix[i, j] = thirdCol[i];
                    }
                }
            }
            return matrix;
        }
    }
}
