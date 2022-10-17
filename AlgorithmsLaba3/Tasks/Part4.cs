using AlgorithmsLaba3.DataStructures;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmsLaba3.Tasks
{
    internal class Part4
    {
        private OurList<int> first;
        private OurList<int> second;
        private OurList<int> random;
        public Part4()
        {
            GetData();
        }
        public void Go()
        {
            Task1();
            Console.WriteLine();
            Task2();
            Console.WriteLine();
            Task3();
            Console.WriteLine();
            Task4();
            Console.WriteLine();
            Task5();
            Console.WriteLine();
            Task6();
            Console.WriteLine();
            Task7();
            Console.WriteLine();
            Task8();
            Console.WriteLine();
            Task9();
            Console.WriteLine();
            Task10();
            Console.WriteLine();
            Task11();
            Console.WriteLine();
            Task12();
            Console.WriteLine();
        }
        private void Task12()
        {
            GetData();
            Console.WriteLine("Задание 12");
            Console.WriteLine("Поменять местами два элемента");
            var before = first.GetArrayData();
            var resultList = first;
            resultList.Swap(1,8);
            var result = resultList.GetArrayData();
            for (int i = 0; i < before.Length; i++)
            {
                Console.Write(before[i] + " ");
            }
            Console.WriteLine("\nМеняем 1 и 8");
            for (int i = 0; i < result.Length; i++)
            {
                Console.Write(result[i] + " ");
            }
        }
        private void Task11()
        {
            GetData();
            Console.WriteLine("Задание 11");
            Console.WriteLine("Удвоение самого себя");
            var before = first.GetArrayData();
            var resultList = first;
            resultList.DoubleList();
            var result = resultList.GetArrayData();
            for (int i = 0; i < before.Length; i++)
            {
                Console.Write(before[i] + " ");
            }
            Console.WriteLine("\nУдвоили");
            for (int i = 0; i < result.Length; i++)
            {
                Console.Write(result[i] + " ");
            }
        }
        private void Task10()
        {
            GetData();
            Console.WriteLine("Задание 10");
            Console.WriteLine("Разбить список на 2 по Х");
            var before = first.GetArrayData();
            var resultList = first;
            Console.WriteLine("Начальный лист");
            for (int i = 0; i < before.Length; i++)
            {
                Console.Write(before[i] + " ");
            }
            var aPieceList = resultList.GiveAPiece(5);
            Console.WriteLine("\nРазбили на 2 по 5");
            Console.WriteLine("Начальный лист");
            var result = resultList.GetArrayData();
            for (int i = 0; i < result.Length; i++)
            {
                Console.Write(result[i] + " ");
            }
            Console.WriteLine("\nПолученный лист");
            var result2 = aPieceList.GetArrayData();
            for (int i = 0; i < result2.Length; i++)
            {
                Console.Write(result2[i] + " ");
            }
        }
        private void Task9()
        {
            GetData();
            Console.WriteLine("Задание 9");
            Console.WriteLine("Добавить второй к первому");
            var before = first.GetArrayData();
            var before2 = second.GetArrayData();
            var resultList = first;
            resultList.AddOurList(second);
            var result = resultList.GetArrayData();
            Console.WriteLine("Первый лист");
            for (int i = 0; i < before.Length; i++)
            {
                Console.Write(before[i] + " ");
            }
            Console.WriteLine("\nВторой лист");
            for (int i = 0; i < before2.Length; i++)
            {
                Console.Write(before2[i] + " ");
            }
            Console.WriteLine("\nДобавили второй к первому");
            for (int i = 0; i < result.Length; i++)
            {
                Console.Write(result[i] + " ");
            }
        }
        private void Task8()
        {
            GetData();
            Console.WriteLine("Задание 8");
            Console.WriteLine("Вставаить перед X");
            var before = random.GetArrayData();
            var resultList = random;
            resultList.AddBefore(4,5);
            var result = resultList.GetArrayData();
            for (int i = 0; i < before.Length; i++)
            {
                Console.Write(before[i] + " ");
            }
            Console.WriteLine("\nВставили 5 перед первой 4");
            for (int i = 0; i < result.Length; i++)
            {
                Console.Write(result[i] + " ");
            }
        }
        private void Task7()
        {
            GetData();
            Console.WriteLine("Задание 7");
            Console.WriteLine("Удалить все Х элементы");
            var before = random.GetArrayData();
            var resultList = random;
            resultList.RemoveAllIdentical(4);
            var result = resultList.GetArrayData();
            for (int i = 0; i < before.Length; i++)
            {
                Console.Write(before[i] + " ");
            }
            Console.WriteLine("\nУбрали все 4");
            for (int i = 0; i < result.Length; i++)
            {
                Console.Write(result[i] + " ");
            }
        }
        private void Task6()
        {
            GetData();
            Console.WriteLine("Задание 6");
            Console.WriteLine("Вставить в упорядоченный список элемент, чтобы оставалась упорядоченость");
            var before = first.GetArrayData();
            var resultList = first;
            resultList.AddAndSort(4);
            var result = resultList.GetArrayData();
            for (int i = 0; i < before.Length; i++)
            {
                Console.Write(before[i] + " ");
            }
            Console.WriteLine("\nВставили 4 результат");
            for (int i = 0; i < result.Length; i++)
            {
                Console.Write(result[i] + " ");
            }
        }
        private void Task5()
        {
            GetData();
            Console.WriteLine("Задание 5");
            Console.WriteLine("Воход самого в себя после первоой 5");
            var before = first.GetArrayData();
            var resultList = first;
            resultList.AddAfter(5, resultList);
            var result = resultList.GetArrayData();
            for (int i = 0; i < before.Length; i++)
            {
                Console.Write(before[i] + " ");
            }
            Console.WriteLine("\nРезультат");
            for (int i = 0; i < result.Length; i++)
            {
                Console.Write(result[i] + " ");
            }
        }
        private void Task4()
        {
            GetData();
            Console.WriteLine("Задание 4");
            Console.WriteLine("Удалить второй из двух одинаковых");
            var before = random.GetArrayData();
            var resultList = random;
            resultList.RemoveTheSecondFound(3);
            var result = resultList.GetArrayData();
            for (int i = 0; i < before.Length; i++)
            {
                Console.Write(before[i] + " ");
            }
            Console.WriteLine("\nРезультат");
            for (int i = 0; i < result.Length; i++)
            {
                Console.Write(result[i] + " ");
            }
        }
        private void Task3()
        {
            GetData();
            Console.WriteLine("Задание 3");
            Console.WriteLine("Дать количество различный элементов");
            var before = random.GetArrayData();
            var resultList = random;
            var result = resultList.GetCuontUniqueItems();
            for (int i = 0; i < before.Length; i++)
            {
                Console.Write(before[i] + " ");
            }
            Console.WriteLine($"\nОтвет {result}");
        }
        private void Task2()
        {
            GetData();
            Console.WriteLine("Задание 2");
            var before = first.GetArrayData();
            var resultList = first;
            resultList.LastToHead();
            var result1 = resultList.GetArrayData();
            resultList.FirstToTail();
            var result2 = resultList.GetArrayData();
            for (int i = 0; i < before.Length; i++)
            {
                Console.Write(before[i] + " ");               
            }
            Console.WriteLine("\nПеренести в начало последний");
            for (int i = 0; i < result1.Length; i++)
            {
                Console.Write(result1[i] + " ");
            }
            Console.WriteLine("\nПеренести в конец первый");
            for (int i = 0; i < result2.Length; i++)
            {
                Console.Write(result2[i] + " ");
            }
            Console.WriteLine();
        }
        private void Task1()
        {
            GetData();
            Console.WriteLine("Задание 1");
            Console.WriteLine("Ревёрснуть список");
            var before = first.GetArrayData();
            var resultList = first;
            resultList.Reverse();
            var result = resultList.GetArrayData();
            for (int i = 0; i < before.Length; i++)
            {
                Console.Write(before[i] + " ");
            }
            Console.WriteLine();
            for (int i = 0; i < result.Length; i++)
            {
                Console.Write(result[i] + " ");
            }
            Console.WriteLine();
        }
        private void GetData()
        {
            first = new OurList<int>();
            second = new OurList<int>();
            random = new OurList<int>();
            Random genRandom = new Random();
            for (int i = 0; i < 10; i++)
            {
                random.AddLast(genRandom.Next(0, 5));
            }
            random.AddFirst(4);
            random.AddFirst(4);
            for (int i = 0; i < 10; i++)
            {
                first.AddLast(i);
            }
            for (int i = 10; i < 20; i++)
            {
                second.AddLast(i);
            }
        }
    }
}
