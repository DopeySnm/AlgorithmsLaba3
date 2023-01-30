using AlgorithmsLaba3.DataStructures;
using AlgorithmsLaba3.Service;
using AlgorithmsLaba3.Test;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmsLaba3.Tasks.Task1
{
    internal class TestStackMenu
    {
        private int count;
        private int countPoint;
        private string parametr;
        private string[] data;
        private bool push;
        private bool pop;
        private bool top;
        private bool isEmpty;
        private bool print;
        private FileHelp fileHelp;
        public TestStackMenu()
        {
            push = false;
            pop = false;
            top = false;
            isEmpty = false;
            print = false;
        }
        public void MainMenu()
        {
            string[] options = { "BaseStack", "OurStack", "Back" };
            string contents = "Меню";
            do
            {
                Console.Clear();
                MenuRendering menu = new MenuRendering(options, contents);
                int selectedIndex = menu.Run();
                switch (selectedIndex)
                {
                    case 0:
                        TestBaseStack();
                        break;
                    case 1:
                        TestOurStack();
                        break;
                    case 2:
                        return;
                }
            } while (true);
        }
        private void TestBaseStack()
        {
            OperationFormationBaseStack baseStack = new OperationFormationBaseStack();
            string fileName = "";
            double[] resultTime = null;
            long[] resultMemory = null;
            int[] resultData;
            string[] options = { "TestTime", "TestMemory", "Back" };
            string contents = "Меню";
            do
            {
                Console.Clear();
                MenuRendering menu = new MenuRendering(options, contents);
                int selectedIndex = menu.Run();
                switch (selectedIndex)
                {
                    case 0:
                        Console.Clear();
                        InputDataConsole();
                        fileName = $"BaseStackTestTimeWith{GetNameFile()}";
                        fileHelp.WriteRanodmFileOperation(count, fileName);
                        data = fileHelp.ReadFile(fileName);
                        TestAlgorithm<double> testTime = new TestAlgorithm<double>(data);
                        (resultData, resultTime) = testTime.Test(baseStack, new TestTime(), count, countPoint);
                        WriteResult<double>.WriteFileResult(fileName, resultTime, resultData);
                        break;
                    case 1:
                        Console.Clear();
                        InputDataConsole();
                        fileName = $"BaseStackTestMemoryWith{GetNameFile()}";
                        fileHelp.WriteRanodmFileOperation(count, fileName);
                        data = fileHelp.ReadFile(fileName);
                        TestAlgorithm<long> testMemory = new TestAlgorithm<long>(data);
                        (resultData, resultMemory) = testMemory.Test(baseStack, new TestMemory(), count, countPoint);
                        WriteResult<long>.WriteFileResult(fileName, resultMemory, resultData);
                        break;
                    case 2:
                        return;
                }
            } while (true);
        }
        private void TestOurStack()
        {
            OperationFormationOurStack ourStack = new OperationFormationOurStack();
            string fileName = "";
            double[] resultTime = null;
            long[] resultMemory = null;
            int[] resultData;
            string[] options = { "TestTime", "TestMemory", "Back" };
            string contents = "Меню";
            do
            {
                Console.Clear();
                MenuRendering menu = new MenuRendering(options, contents);
                int selectedIndex = menu.Run();
                switch (selectedIndex)
                {
                    case 0:
                        Console.Clear();
                        InputDataConsole();
                        fileName = $"OurStackTestTimeWith{GetNameFile()}";
                        fileHelp.WriteRanodmFileOperation(count, fileName);
                        data = fileHelp.ReadFile(fileName);
                        TestAlgorithm<double> testTime = new TestAlgorithm<double>(data);
                        (resultData, resultTime) = testTime.Test(ourStack, new TestTime(), count, countPoint);
                        WriteResult<double>.WriteFileResult(fileName, resultTime, resultData);
                        break;
                    case 1:
                        Console.Clear();
                        InputDataConsole();
                        fileName = $"OurStackTestMemoryWith{GetNameFile()}";
                        fileHelp.WriteRanodmFileOperation(count, fileName);
                        data = fileHelp.ReadFile(fileName);
                        TestAlgorithm<long> testMemory = new TestAlgorithm<long>(data);
                        (resultData, resultMemory) = testMemory.Test(ourStack, new TestMemory(), count, countPoint);
                        WriteResult<long>.WriteFileResult(fileName, resultMemory, resultData);
                        break;
                    case 2:
                        return;
                }
            } while (true);
        }
        private void SetPar(string par)
        {
            string[] parArr = par.Split(" ");
            for (int i = 0; i < parArr.Length; i++)
            {
                switch (parArr[i])
                {
                    case "1":
                        push = true;
                        break;
                    case "2":
                        pop = true;
                        break;
                    case "3":
                        top = true;
                        break;
                    case "4":
                        isEmpty = true;
                        break;
                    case "5":
                        print = true;
                        break;
                }
            }
        }
        private string GetNameFile()
        {
            StringBuilder result = new StringBuilder();
            if (push)
            {
                result.Append("Push");
            }
            if (pop)
            {
                result.Append("Pop");
            }
            if (top)
            {
                result.Append("Top");
            }
            if (isEmpty)
            {
                result.Append("IsEmpty");
            }
            if (print)
            {
                result.Append("Print");
            }
            return result.ToString();
        }
        private void InputDataConsole()
        {
            Console.WriteLine("Ведите количесво тестируемых данных");
            count = int.Parse(Console.ReadLine());
            Console.WriteLine("Ведите количество точек");
            countPoint = int.Parse(Console.ReadLine());
            Console.WriteLine("Ведите параметры которые хотите протестить через пробел, можно выбирать несклько параметров");
            Console.WriteLine("1 - push, 2 - pop, 3 - top, 4 - isEmpty, 5 - print");
            parametr = Console.ReadLine();
            fileHelp = new FileHelp();
            SetPar(parametr);
            fileHelp.SetParemetrs(push, pop, top, isEmpty, print);
        }
    }
}
