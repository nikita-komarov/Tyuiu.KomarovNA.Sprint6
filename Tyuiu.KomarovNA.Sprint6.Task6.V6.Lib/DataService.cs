using System.Text;
using tyuiu.cources.programming.interfaces.Sprint6;

namespace Tyuiu.KomarovNA.Sprint6.Task6.V6.Lib
{
    public class DataService : ISprint6Task6V6
    {
        public string CollectTextFromFile(string path)
        {
            string[] lines = File.ReadAllLines(path);
            StringBuilder result = new StringBuilder();
            foreach (string line in lines)
            {
                var words = line.Split(' ', StringSplitOptions.RemoveEmptyEntries).ToList();
                words = words.Select(word => word.Contains('b') ? word: "").ToList();
                foreach (var word in words)
                {
                    if (word.Length > 0 )
                    {
                        result.Append(word + " ");
                    }
                }
            }

            return result.ToString().Trim(); ;
        }
    }
}


//Дан файл InPutFileTask6V6.txt который может находится в любом месте на диске. Загрузить файл в textBoxIn через openFileDialog. 
//Вывести слова в которых встречается b в результирующею строку и вывести ее в textBoxOut.
//Графический интерфейс пользователя оформить по образцу как в лекции