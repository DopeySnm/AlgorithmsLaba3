using AlgorithmsLaba3.DataStructures;
using AlgorithmsLaba3.Service;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmsLaba3.Tasks.Task1
{
    internal class OperationFormationOurStack : ITest
    {
        private OurStack<string> stack;
        private string[] data;
        public void SetData(string[] data)
        {
            this.data = data;
        }
        public void SetStack(OurStack<string> stack)
        {
            this.stack = stack;
        }
        public void Formation()
        {
            if (stack == null)
            {
                stack = new OurStack<string>();
            }
            foreach (var item in data)
            {
                if (item[0] == '1')
                {
                    string text = item.Remove(0, 2);
                    stack.Push(text);
                }
                else if (item[0] == '2')
                {
                    try
                    {
                        stack.Pop();
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
                        stack.Top();
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
                        stack.IsEmpty();
                    }
                    catch
                    {
                        //Console.WriteLine($"Элементов нет!");
                    }
                }
                else if (item[0] == '5')
                {
                    foreach (var VARIABL in stack)
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
