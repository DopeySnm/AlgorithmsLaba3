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
        public void SetInitialData(string[] data)
        {
            stack = new OurStack<string>();
            for (int i = 0; i < data.Length; i++)
            {
                stack.Push(data[i]);
            }
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
                //if (stack.Length == 0)
                //{
                //    stack.Push("data");
                //}
                else if (item[0] == '2')
                {
                    stack.Pop();
                    //try
                    //{
                    //    stack.Pop();
                    //}
                    //catch
                    //{
                    //    //Console.WriteLine($"Ошибка: элемента нет");
                    //}
                }
                else if (item[0] == '3')
                {
                    stack.Top();
                    //try
                    //{
                    //    stack.Top();
                    //}
                    //catch
                    //{
                    //    //Console.WriteLine($"Ошибка: элемента нет");
                    //}
                }
                else if (item[0] == '4')
                {
                    stack.IsEmpty();
                    //try
                    //{
                    //    stack.IsEmpty();
                    //}
                    //catch
                    //{
                    //    //Console.WriteLine($"Элементов нет!");
                    //}
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
