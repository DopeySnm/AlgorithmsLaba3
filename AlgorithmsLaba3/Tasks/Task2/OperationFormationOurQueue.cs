using AlgorithmsLaba3.DataStructures;
using AlgorithmsLaba3.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmsLaba3.Tasks.Task2
{
    internal class OperationFormationOurQueue : ITest
    {
        private OurQueue<string> queue;
        private string[] data;
        public void SetData(string[] data)
        {
            this.data = data;
        }
        public void SetQueue(OurQueue<string> stack)
        {
            this.queue = stack;
        }
        public void Formation()
        {
            if (queue == null)
            {
                queue = new OurQueue<string>();
            }
            foreach (var item in data)
            {
                if (item[0] == '1')
                {
                    string text = item.Remove(0, 2);
                    queue.AddQueue(text);
                }
                else if (item[0] == '2')
                {
                    try
                    {
                        queue.DeleteQueue();
                    }
                    catch
                    {
                        //Console.WriteLine($"Ошибка: элемента нет");
                    }
                }
                else if (item[0] == '3')
                {
                    try
                    {
                        queue.ElementsQueue();
                    }
                    catch
                    {
                        //Console.WriteLine($"Ошибка: элемента нет");
                    }
                }
                else if (item[0] == '4')
                {
                    try
                    {
                        var temp = queue.IsEmpty;
                    }
                    catch
                    {
                        //Console.WriteLine($"Элементов нет!");
                    }
                }
                else if (item[0] == '5')
                {
                    foreach (var VARIABL in queue)
                    {
                        //Console.WriteLine(VARIABL);
                        string temp = VARIABL;
                    }
                }
            }
        }
        public void Test()
        {
            Formation();
        }
    }
}
