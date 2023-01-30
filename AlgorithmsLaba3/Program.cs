using AlgorithmsLaba3.Service;
using AlgorithmsLaba3.Tasks.Task2;
using AlgorithmsLaba3.Tasks.Task1;

namespace AlgorithmsLaba3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            MainMenu();
        }
        public static void MainMenu()
        {
            string[] options = { "InfixToPostfix", "CalculatePostfix", "MenuListTask", "TestStack", "TestQueue" };
            string contents = "Меню";
            do
            {
                PolishEntry polishEntry = new PolishEntry();
                Console.Clear();
                MenuRendering menu = new MenuRendering(options, contents);
                int selectedIndex = menu.Run();
                switch (selectedIndex)
                {
                    case 0:
                        Console.Clear();
                        Console.Write("Введите свою формулу: ");
                        string infix = Console.ReadLine();
                        polishEntry.InfixToPostfix(infix);
                        Console.ReadLine();
                        break;
                    case 1:
                        Console.Clear();
                        Console.Write("Введите свою формулу: ");
                        string Postfix = Console.ReadLine();
                        polishEntry.CalculatePostfix(Postfix);
                        Console.ReadLine();
                        break;
                    case 2:
                        Console.Clear();
                        MenuListTask menuListTask = new MenuListTask();
                        menuListTask.Run();
                        break;
                    case 3:
                        TestStackMenu testStackOp = new TestStackMenu();
                        testStackOp.MainMenu();
                        break;
                    case 4:
                        TestQueueMenu testQueueOp = new TestQueueMenu();
                        testQueueOp.MainMenu();
                        break;
                }
            } while (true);
        }
    }
}