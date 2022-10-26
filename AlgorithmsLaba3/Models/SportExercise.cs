using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmsLaba3.Models
{
    internal class SportExercise
    {
        private string name;
        private int num;
        private int numberOfApproaches;
        public SportExercise(string name, int num, int numberOfApproaches)
        {
            this.name = name;
            this.num = num;
            this.numberOfApproaches = numberOfApproaches;
        }
        public void SetNum(int num)
        {
            this.num = num;
        }
        public int GetNum()
        {
            return num;
        }
        public string GetInfo()
        {
            return $"Название: {name}, номер подхода: {num}, количество похдходов: {numberOfApproaches}";
        }
    }
}
