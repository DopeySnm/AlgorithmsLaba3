using AlgorithmsLaba3.DataStructures;

namespace AlgorithmsLaba3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            OurList<int> ints = new OurList<int>();
            ints.AddLast(1);
            ints.AddLast(2);
            ints.AddLast(3);
            ints.AddLast(4);
            ints.AddFirst(0);
            var a = ints.GetArrayData();
            for (int i = 0; i < a.Length; i++)
            {
                Console.WriteLine(a[i]);
            }
            Console.WriteLine();
        }
    }
}