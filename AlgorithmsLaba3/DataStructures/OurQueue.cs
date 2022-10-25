using AlgorithmsLaba3.Models;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmsLaba3.DataStructures
{
    internal class OurQueue<T> : IEnumerable<T>
    {
        private Node<T> first;
        private Node<T> last;
        private int count;
        public OurQueue(T date)
        {
            first = new Node<T>(date);
            last = first;
        }
        public OurQueue() { }
        public void AddQueue(T data)
        {
            Node<T> node = new Node<T>(data);
            Node<T> tempNode = last;
            last = node;
            if (count == 0)
                first = last;
            else
                tempNode.Next = last;
            count++;
        }
        public T ElementsQueue()
        {
            if (IsEmpty)
                throw new Exception("Элементов в очереди нет :(");
            return first.GetData();
        }
        public T DeleteQueue()
        {
            if (count == 0)
                throw new InvalidOperationException();
            T output = first.GetData();
            var current = first;
            first = current.Next;
            current = null;
            count--;
            return output;
        }
        public int GetCount()
        {
            return count;
        }
        public int Count { get { return count; } }
        public bool IsEmpty { get { return count == 0; } }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return ((IEnumerable)this).GetEnumerator();
        }

        IEnumerator<T> IEnumerable<T>.GetEnumerator()
        {
            Node<T> current = first;
            while (current != null)
            {
                yield return current.GetData();
                current = current.Next;
            }
        }
    }
}
