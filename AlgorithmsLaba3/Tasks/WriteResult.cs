using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmsLaba3.Tasks
{
    internal static class WriteResult
    {
        public static void WriteFileResult(string nameFile, double[] data)
        {
            string[] writeData = new string[data.Length];
            for (int i = 0; i < writeData.Length; i++)
            {
                writeData[i] = data[i].ToString();
            }
            File.WriteAllLines($"..\\..\\..\\..\\TestResult\\Test{nameFile}.csv", writeData);
        }
    }
}
