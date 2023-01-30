using AlgorithmsLaba3.DataStructures;
using AlgorithmsLaba3.Service;
using AlgorithmsLaba3.Tasks.Task1;
using AlgorithmsLaba3.Test;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmsLaba3.Tasks
{
    internal class TestAlgorithm<T>
    {
        private string[] data;
        public TestAlgorithm(string[] data)
        {
            this.data = data;
        }
        public (int[], T[]) Test(ITest algorithm, IBaseTest<T> test, int count, int countPoint)
        {
            T[] resultTest = new T[countPoint];
            int[] dataResult = new int[countPoint];
            for (int i = 0; i < countPoint; i++)
            {
                int part = (i + 1) * (count / countPoint);
                dataResult[i] = part;
                algorithm.SetData(GivePartOfTheArray(part, data));
                algorithm.SetInitialData(FillData(part * 5));
                resultTest[i] = test.Run(algorithm);
            }
            return (dataResult, resultTest);
        }
        private string[] FillData(int count)
        {
            string[] result = new string[count];
            for (int i = 0; i < count; i++)
            {
                result[i] = "data";
            }
            return result;
        }
        private string[] GivePartOfTheArray(int size, string[] data)
        {
            string[] testData = new string[size];
            for (int j = 0; j < testData.Length; j++)
            {
                testData[j] = data[j];
            }
            return testData;
        }
    }
}
