using AlgorithmsLaba3.Tasks.Task1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmsLaba3.Tasks
{
    internal class FileHelp
    {
        private bool push;
        private bool pop;
        private bool top;
        private bool isEmpty;
        private bool print;
        public FileHelp()
        {
            push = true;
            pop = true;
            top = true;
            isEmpty = true;
            print = true;
        }
        public void SetParemetrs(bool push = true, bool pop = true, bool top = true, bool isEmpty = true, bool print = true)
        {
            this.push = push;
            this.pop = pop;
            this.top = top;
            this.isEmpty = isEmpty;
            this.print = print;
        }
        public string[] ReadFile(string fileName)
        {
            string data = File.ReadAllText($"..\\..\\..\\..\\TestOp\\{fileName}.txt");
            return data.Split(' ');
        }
        private int GetRandomOp()
        {
            List<int> op = new List<int>();
            Random random = new Random();
            if (push)
            {
                op.Add(1);
            }
            if (pop)
            {
                op.Add(2);
            }
            if (top)
            {
                op.Add(3);
            }
            if (isEmpty)
            {
                op.Add(4);
            }
            if (print)
            {
                op.Add(5);
            }
            int temp = random.Next(0,op.Count);
            return op[temp];
        }
        public void WriteRanodmFileOperation(int countOp, string fileName)
        {
            Random random = new Random();
            StringBuilder stringBuilder = new StringBuilder();
            for (int i = 0; i < countOp; i++)
            {
                int temp = GetRandomOp();
                if (temp == 1 && push)
                {
                    stringBuilder.Append(1 + ",data ");
                }
                else if (temp == 2 && pop)
                {
                    stringBuilder.Append(temp + " ");
                }
                else if (temp == 3 && top)
                {
                    stringBuilder.Append(temp + " ");
                }
                else if (temp == 4 && isEmpty)
                {
                    stringBuilder.Append(temp + " ");
                }
                else if (temp == 5 && print)
                {
                    stringBuilder.Append(temp + " ");
                }
            }
            stringBuilder.Remove(stringBuilder.Length - 1, 1);
            
            File.WriteAllText($"..\\..\\..\\..\\TestOp\\{fileName}.txt", stringBuilder.ToString());
        }
    }
}
