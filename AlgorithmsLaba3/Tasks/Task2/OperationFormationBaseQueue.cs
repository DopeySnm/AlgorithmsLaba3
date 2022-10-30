using AlgorithmsLaba3.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmsLaba3.Tasks.Task2
{
    internal class OperationFormationBaseQueue : ITest
    {
        private Queue<string> queue;
        private string[] data;
        public void SetData(string[] data)
        {
            this.data = data;
        }
        public void SetQueue(Queue<string> queue)
        {
            this.queue = queue;
        }
        public void Formation()
        {
            if (queue == null)
            {
                queue = new Queue<string>();
            }
            foreach (var item in data)
            {
                if (item[0] == '1')
                {
                    string text = item.Remove(0, 2);
                    queue.Enqueue(text);
                }
                else if (item[0] == '2')
                {
                    try
                    {
                        queue.Dequeue();
                    }
                    catch (Exception ex)
                    {
                        //Console.WriteLine($"Ошибка: {ex.Message}");
                    }
                }
                else if (item[0] == '3')
                {
                    try
                    {
                        queue.Peek();
                    }
                    catch (Exception ex)
                    {
                        //Console.WriteLine($"Ошибка: {ex.Message}");
                    }
                }
                else if (item[0] == '4')
                {
                    try
                    {
                        string temp;
                        queue.TryPeek(out temp);
                    }
                    catch (Exception ex)
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
