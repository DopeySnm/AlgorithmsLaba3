using AlgorithmsLaba3.DataStructures;
using AlgorithmsLaba3.Service;
using AlgorithmsLaba3.Tasks.Task1;
using AlgorithmsLaba3.Test;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmsLaba3.Tasks.Task2
{
    internal class TestQueueOp
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
        private OperationFormationOurQueue ourQueue;
        private OperationFormationBaseQueue baseQueue;
        public TestQueueOp()
        {
            push = false;
            pop = false;
            top = false;
            isEmpty = false;
            print = false;
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
        public void TestMenu()
        {
            string[] options = { "BaseQueue", "OurQueue", "Back" };
            string contents = "Меню";
            do
            {
                Console.Clear();
                MenuRendering menu = new MenuRendering(options, contents);
                int selectedIndex = menu.Run();
                switch (selectedIndex)
                {
                    case 0:
                        TestBaseQueue();
                        break;
                    case 1:
                        TestOurQueue();
                        break;
                    case 2:
                        return;
                }
            } while (true);
        }
        private void TestOurQueue()
        {
            ourQueue = new OperationFormationOurQueue();
            string fileName = "";
            double[] result = null;
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
                        fileName = $"OurQueueTestTimeWith{GetNameFile()}";
                        fileHelp.WriteRanodmFileOperation(count, fileName);
                        data = fileHelp.ReadFile(fileName);
                        (resultData, result) = RunTestTimeOurQueue(new TestTime(), count, countPoint);
                        WriteResult.WriteFileResult(fileName, result, resultData);
                        break;
                    case 1:
                        Console.Clear();
                        InputDataConsole();
                        fileName = $"OurQueueTestMemoryWith{GetNameFile()}";
                        fileHelp.WriteRanodmFileOperation(count, fileName);
                        data = fileHelp.ReadFile(fileName);
                        (resultData, result) = RunTestTimeOurQueue(new TestMemory(), count, countPoint);
                        WriteResult.WriteFileResult(fileName, result, resultData);
                        break;
                    case 2:
                        return;
                }
            } while (true);
        }
        private (int[], double[]) RunTestTimeOurQueue(IBaseTest test, int count, int countPoint)
        {
            double[] resultTest = new double[countPoint];
            int[] dataResult = new int[countPoint];
            for (int i = 0; i < countPoint; i++)
            {
                dataResult[i] = (i + 1) * (count / countPoint);
                ourQueue.SetData(GivePartOfTheArray((count / countPoint) * (i + 1), data));
                if (push == false)
                {
                    ourQueue.SetQueue(FillOurQueue((count / countPoint) * (i + 1) * 5));
                }
                resultTest[i] = test.Run(ourQueue);
            }
            return (dataResult, resultTest);
        }
        private void TestBaseQueue()
        {
            baseQueue = new OperationFormationBaseQueue();
            string fileName = "";
            double[] result = null;
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
                        fileName = $"BaseQueueTestTimeWith{GetNameFile()}";
                        fileHelp.WriteRanodmFileOperation(count, fileName);
                        data = fileHelp.ReadFile(fileName);
                        (resultData, result) = RunTestBaseQueue(new TestTime(), count, countPoint);
                        WriteResult.WriteFileResult(fileName, result, resultData);
                        break;
                    case 1:
                        Console.Clear();
                        InputDataConsole();
                        fileName = $"BaseQueueTestMemoryWith{GetNameFile()}";
                        fileHelp.WriteRanodmFileOperation(count, fileName);
                        data = fileHelp.ReadFile(fileName);
                        (resultData, result) = RunTestBaseQueue(new TestMemory(), count, countPoint);
                        WriteResult.WriteFileResult(fileName, result, resultData);
                        break;
                    case 2:
                        return;
                }
            } while (true);
        }
        private (int[], double[]) RunTestBaseQueue(IBaseTest test, int count, int countPoint)
        {
            double[] resultTest = new double[countPoint];
            int[] dataResult = new int[countPoint];
            for (int i = 0; i < countPoint; i++)
            {
                dataResult[i] = (i + 1) * (count / countPoint);
                baseQueue.SetData(GivePartOfTheArray((count / countPoint) * (i + 1), data));
                if (push == false)
                {
                    baseQueue.SetQueue(FillBaseStack((count / countPoint) * (i + 1) * 5));
                }
                resultTest[i] = test.Run(baseQueue);
            }
            return (dataResult, resultTest);
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
        private Queue<string> FillBaseStack(int count)
        {
            Queue<string> stack = new Queue<string>();
            for (int i = 0; i < count; i++)
            {
                stack.Enqueue("data");
            }
            return stack;
        }
        private OurQueue<string> FillOurQueue(int count)
        {
            OurQueue<string> stack = new OurQueue<string>();
            for (int i = 0; i < count; i++)
            {
                stack.AddQueue("data");
            }
            return stack;
        }
        private string[] GivePartOfTheArray(int size, string[] data)
        {
            string[] testData = new string[size];
            for (int j = 0; j < testData.Length; j++)
            {
                testData[j] = data[j];
            }
            return testData;
        }
    }
}
