using AlgorithmsLaba3.DataStructures;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmsLaba3.Tasks
{
    internal class Task1
    {
        static void Part1()
        {
            string CURRENTPATH = Environment.CurrentDirectory;
            CURRENTPATH += "\\Test.txt";
            string data = File.ReadAllText(CURRENTPATH);
            string[] elem = data.Split(' ');
            OurStack<string> dat1 = new OurStack<string>();
            foreach (var VARIABLE in elem)
            {
                switch (VARIABLE[0])
                {
                    case '1': //1 - вставка
                        string text = VARIABLE.Remove(0, 2);
                        dat1.Push(text);
                        break;
                    case '2': //2 - удаление
                        dat1.Pop();
                        break;
                    case '3': //3 – просмотр начала очереди
                        try
                        {
                            Console.WriteLine($"1ый элемент: {dat1.Top()}");
                        }
                        catch (Exception ex)
                        {
                            //Console.WriteLine($"Ошибка: {ex.Message}");
                        }
                        break;
                    case '4': //4 – проверка на пустоту
                        try
                        {
                            dat1.IsEmpty();
                            //Console.WriteLine($"Элементы есть!");
                        }
                        catch (Exception ex)
                        {
                            //Console.WriteLine($"Элементов нет!");
                        }
                        break;
                    case '5': //5 - печать
                        foreach (var VARIABL in dat1)
                        {
                            Console.WriteLine(VARIABL);
                        }
                        break;
                }
            }
        }
    }
}
