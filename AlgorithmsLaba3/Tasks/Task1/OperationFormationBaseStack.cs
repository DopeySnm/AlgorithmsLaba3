using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AlgorithmsLaba3.DataStructures;
using AlgorithmsLaba3.Service;

namespace AlgorithmsLaba3.Tasks.Task1
{
    internal class OperationFormationBaseStack : ITest
    {
        private Stack<string> stack;
        private string[] data;
        public void SetData(string[] data)
        {
            this.data = data;
        }
        public void SetStack(Stack<string> stack)
        {
            this.stack = stack;
        }
        public void Formation()
        {
            if (stack == null)
            {
                stack = new Stack<string>();
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
                    catch (Exception ex)
                    {
                        //Console.WriteLine($"Ошибка: {ex.Message}");
                    }
                }
                else if (item[0] == '3')
                {
                    try
                    {
                        stack.Peek();
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
                        stack.TryPeek(out temp);
                    }
                    catch (Exception ex)
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
