using AlgorithmsLaba3.DataStructures;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace AlgorithmsLaba3.Service
{
    internal class MenuListTask
    {
        public void Run()
        {
            string[] options = { 
                "Ревёрснуть список", 
                "В начало последний", 
                "В конец первый",
                "Дать количество различный элементов",
                "Удалить второй из двух одинаковых",
                "Воход самого в себя после X",
                "Вставить в упорядоченный список элемент, чтобы оставалась упорядоченость",
                "Удалить все Х элементы",
                "Вставаить перед X",
                "Функция дописывает к списку L список E",
                "Разбить список на 2 по Х",
                "Удвоение самого себя",
                "Поменять местами два элемента",
                "Назад",
            };
            string contents = "Меню";
            do
            {
                OurList<int> data;
                Console.Clear();
                MenuRendering menu = new MenuRendering(options, contents);
                int selectedIndex = menu.Run();
                switch (selectedIndex)
                {
                    case 0:
                        Console.Clear();
                        data = InputList();
                        data.Reverse();
                        Console.WriteLine("Результат: ");
                        PrintList(data);
                        break;
                    case 1:
                        Console.Clear();
                        data = InputList();
                        data.LastToHead();
                        Console.WriteLine("Результат: ");
                        PrintList(data);
                        break;
                    case 2:
                        Console.Clear();
                        data = InputList();
                        data.FirstToTail();
                        Console.WriteLine("Результат: ");
                        PrintList(data);
                        break;
                    case 3:
                        Console.Clear();
                        data = InputList();
                        Console.WriteLine($"Результат: {data.GetCuontUniqueItems()}");
                        break;
                    case 4:
                        Console.Clear();
                        data = InputList();
                        Console.WriteLine("Введите удаляемый элемент");
                        data.RemoveTheSecondFound(int.Parse(Console.ReadLine()));
                        Console.WriteLine("Результат: ");
                        PrintList(data);
                        break;
                    case 5:
                        Console.Clear();
                        data = InputList();
                        Console.WriteLine("Введите после какого элемента вставить этот список в себя");
                        data.AddAfter(int.Parse(Console.ReadLine()), data);
                        Console.WriteLine("Результат: ");
                        PrintList(data);
                        break;
                    case 6:
                        Console.Clear();
                        data = InputList();
                        Console.WriteLine("Введите добавляемый элемент");
                        data.AddAndSort(int.Parse(Console.ReadLine()));
                        Console.WriteLine("Результат: ");
                        PrintList(data);
                        break;
                    case 7:
                        Console.Clear();
                        data = InputList();
                        Console.WriteLine("Введите удаляемый элемент");
                        data.RemoveAllIdentical(int.Parse(Console.ReadLine()));
                        Console.WriteLine("Результат: ");
                        PrintList(data);
                        break;
                    case 8:
                        Console.Clear();
                        data = InputList();
                        Console.WriteLine("Введите элемент перед который вставить");
                        int beforeData = int.Parse(Console.ReadLine());
                        Console.WriteLine("Введите добавляемый элемент");
                        data.AddBefore(beforeData, int.Parse(Console.ReadLine()));
                        Console.WriteLine("Результат: ");
                        PrintList(data);
                        break;
                    case 9:
                        Console.Clear();
                        data = InputList();
                        Console.WriteLine("Введите добавляемый список");
                        OurList<int> data2 = InputList();
                        data.AddOurList(data2);
                        Console.WriteLine("Результат: ");
                        PrintList(data);
                        break;
                    case 10:
                        Console.Clear();
                        data = InputList();
                        Console.WriteLine("Введите элемент по которому разбиваем");
                        OurList<int> resultPiece = data.GiveAPiece(int.Parse(Console.ReadLine()));
                        Console.WriteLine("Первый лист");
                        PrintList(data);
                        Console.WriteLine("Второй лист");
                        PrintList(resultPiece);
                        break;
                    case 11:
                        Console.Clear();
                        data = InputList();
                        data.AddOurList(data);
                        Console.WriteLine("Результат: ");
                        PrintList(data);
                        break;
                    case 12:
                        Console.Clear();
                        data = InputList(); 
                        Console.WriteLine("Введиет первый элемент");
                        int a = int.Parse(Console.ReadLine());
                        Console.WriteLine("Введиет второй элемент");
                        int b = int.Parse(Console.ReadLine());
                        data.Swap(a, b);
                        Console.WriteLine("Результат: ");
                        PrintList(data);
                        break;
                    case 13:
                        return;
                        break;
                }
            } while (true);
        }
        public OurList<int> InputList()
        {
            OurList<int> data = new OurList<int>();
            data.Clear();
            Console.WriteLine("Введите через пробел элементы массива");
            string[] inputString = Console.ReadLine().Split(" ");
            for (int i = 0; i < inputString.Length; i++)
            {
                data.AddLast(int.Parse(inputString[i]));
            }
            return data;
        }
        public void PrintList(OurList<int> data)
        {
            var tempArr = data.GetArrayData();
            for (int i = 0; i < tempArr.Length; i++)
            {
                Console.Write(tempArr[i] + " ");
            }
            Console.ReadLine();
        }
    }
}
