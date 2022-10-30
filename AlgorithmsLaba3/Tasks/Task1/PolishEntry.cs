using AlgorithmsLaba3.DataStructures;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmsLaba3.Tasks.Task1
{
    internal class PolishEntry
    {
        public void InfixToPostfix(string infix)
        {
            string[] tokens = infix.Split(' ');

            Stack<string> s = new Stack<string>();
            List<string> outputList = new List<string>();
            int n;
            foreach (string c in tokens)
            {
                if (int.TryParse(c.ToString(), out n))
                {
                    outputList.Add(c);
                }
                if (c == "(")
                {
                    s.Push(c);
                }
                if (c == ")")
                {
                    while (s.Count != 0 && s.Peek() != "(")
                    {
                        outputList.Add(s.Pop());
                    }
                    s.Pop();
                }
                if (isOperator(c) == true)
                {
                    while (s.Count != 0 && Priority(s.Peek()) >= Priority(c))
                    {
                        outputList.Add(s.Pop());
                    }
                    s.Push(c);
                }
            }
            while (s.Count != 0)//if any operators remain in the stack, pop all & add to output list until stack is empty 
            {
                outputList.Add(s.Pop());
            }
            string[] osfd = new string[outputList.Count];
            Console.Write("Постфиксная запись формулы: ");
            for (int i = 0; i < outputList.Count; i++)
            {
                osfd[i] += outputList[i];
                Console.Write("{0} ", outputList[i]);
            }
            Console.WriteLine();
            string a = null;
            for (int d = 0; d < outputList.Count; d++)
            {
                a += osfd[d] + " ";
            }
            int x1 = a.Length - 1;
            a = a.Remove(x1);
            CalculatePostfix(a);
        }
        public void CalculatePostfix(string data32)
        {
            try
            {
                string[] data2 = data32.Split(" ");
                OurStack<double> ownStack = new OurStack<double>();
                foreach (var i in data2)
                {
                    if (i[0] >= '0' && i[0] <= '9')
                    {
                        ownStack.Push(double.Parse(i));
                    }
                    else
                    {
                        switch (i)
                        {
                            case "+":
                                ownStack.Push(ownStack.Pop() + ownStack.Pop());
                                break;
                            case "-":
                                {
                                    var a = ownStack.Pop();
                                    var b = ownStack.Pop();
                                    ownStack.Push(b - a);

                                    break;
                                }
                            case "*":
                                ownStack.Push(ownStack.Pop() * ownStack.Pop());
                                break;
                            case "/":
                            case ":":
                                {
                                    var a = ownStack.Pop();
                                    var b = ownStack.Pop();
                                    ownStack.Push(b / a);

                                    break;
                                }
                            case "^":
                                {
                                    var a = ownStack.Pop();
                                    var b = ownStack.Pop();
                                    ownStack.Push(Math.Pow(b, a));

                                    break;
                                }
                            case "ln":
                                {
                                    var a = ownStack.Pop();
                                    ownStack.Push(Math.Log(a));

                                    break;
                                }
                            case "cos":
                                ownStack.Push(Math.Cos(ownStack.Pop()));
                                break;
                            case "sin":
                                ownStack.Push(Math.Sin(ownStack.Pop()));
                                break;
                            case "sqrt":
                                ownStack.Push(Math.Sqrt(ownStack.Pop()));
                                break;
                        }
                    }
                }
                Console.WriteLine($"Ответ: {ownStack.Pop()}");
            }
            catch (IOException ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
        private int Priority(string c)
        {
            if (c == "^")
            {
                return 3;
            }
            else if (c == "*" || c == "/" || c == "ln" || c == "cos" || c == "sin" || c == "sqrt")
            {
                return 2;
            }
            else if (c == "+" || c == "-")
            {
                return 1;
            }
            else
            {
                return 0;
            }
        }
        private bool isOperator(string c)
        {
            if (c == "+" || c == "-" || c == "*" || c == "/" || c == "^" || c == "ln" || c == "cos" || c == "sin" || c == "sqrt")
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
