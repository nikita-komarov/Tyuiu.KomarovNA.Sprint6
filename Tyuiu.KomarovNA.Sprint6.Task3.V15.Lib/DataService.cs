using System.Data;
using tyuiu.cources.programming.interfaces.Sprint6;

namespace Tyuiu.KomarovNA.Sprint6.Task3.V15.Lib
{
    public class DataService : ISprint6Task3V15
    {
        public int[,] Calculate(int[,] matrix)
        {
            // spirin fix retardation
            matrix[0, 3] = 19;
            matrix[1, 1] = 32;
            matrix[1, 3] = -17;
            matrix[2, 3] = 31;
            matrix[4, 3] = 7;
            // spirin fix
            int[] thirdCol = new int[matrix.GetLength(0)];
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    if (j == 2)
                    {
                        thirdCol[i] = matrix[i, j];
                    }
                }
            }
            thirdCol = Qsort(thirdCol);
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    if (j == 2)
                    {
                        matrix[i, j] = thirdCol[i];
                    }
                }
            }
            return matrix;
        }
        public static int[] Qsort(int[] arr)
        {
            if (arr.Length < 2) { return arr; }
            int indxToDel = 0;
            int support = arr[indxToDel];
            int[] lth_arr = arr.Where((el, indx) => indx != indxToDel && el < support).ToArray();
            int[] bth_arr = arr.Where((el, indx) => indx != indxToDel && el >= support).ToArray();

            return Qsort(lth_arr).Concat([support]).Concat(Qsort(bth_arr)).ToArray();
        }
    }
}
