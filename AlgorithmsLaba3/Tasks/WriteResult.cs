using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmsLaba3.Tasks
{
    internal static class WriteResult<T>
    {
        public static void WriteFileResult(string nameFile, T[] data, int[] dataResult)
        {
            string[] writeData = new string[data.Length];
            for (int i = 0; i < writeData.Length; i++)
            {
                writeData[i] = $"{dataResult[i]}_{data[i]}";
            }
            File.WriteAllLines($"..\\..\\..\\..\\TestResult\\Test{nameFile}.csv", writeData);
        }
    }
}
