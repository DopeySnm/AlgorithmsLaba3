using AlgorithmsLaba3.DataStructures;

namespace AlgorithmsLaba3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            LinkedList<string> list = new LinkedList<string>();
            List<string> list2 = new List<string>();
            OurList<string> list3 = new OurList<string>();
            list.AddLast("1");
            list.AddLast("2");
            list.AddLast("3");
            list.AddLast("4");

            list2.Add("1");
            list2.Add("2");
            list2.Add("3");
            list2.Add("4");

            list3.Add("1");
            list3.Add("2");
            list3.Add("3");
            list3.Add("4");

            foreach (var item in list3)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine();
        }
    }
}