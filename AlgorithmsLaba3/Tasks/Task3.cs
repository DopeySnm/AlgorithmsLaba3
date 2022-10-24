using AlgorithmsLaba3.DataStructures;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmsLaba3.Tasks
{
    internal class Task3
    {
        public Task3()
        {

        }
        private void ListTask()
        {
            Random random = new Random();
            OurList<int> list = new OurList<int>();
            for (int i = 1; i < 15; i++)
            {
                list.AddLast(random.Next(1,20));
            }
            InsertionSort(list);
        }
        private void InsertionSort(OurList<int> list)
        {
            
        }
    }
}
