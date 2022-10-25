using AlgorithmsLaba3.Models;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmsLaba3.DataStructures
{
    internal class OurStack<T> : IEnumerable<T>
    {
        public Node<T> Head;
        public int Length;
        public void Push(T elem)
        {
            Node<T> element = new Node<T>(elem);
            element.Next = Head;
            Head = element;
            Length++;
        }

        public T Pop()
        {
            if (IsEmpty()) throw new InvalidOperationException("Стек пуст");
            Node<T> temporary = Head;
            Head = Head.Next;
            Length--;
            return temporary.GetData();
        }

        public T Top()
        {
            if (IsEmpty()) throw new InvalidOperationException("Стек пуст");
            return Head.GetData();
        }

        public bool IsEmpty()
        {
            return (Length == 0);
        }

        public void Print()
        {
            if (IsEmpty()) throw new InvalidOperationException("Стек пуст");
            foreach (T elem in this)
            {
                Console.WriteLine(elem);
            }
        }


        IEnumerator<T> IEnumerable<T>.GetEnumerator()
        {
            Node<T> current = Head;
            while (current != null)
            {
                yield return current.GetData();
                current = current.Next;
            }
        }

        IEnumerator IEnumerable.GetEnumerator() => ((IEnumerable)this).GetEnumerator();
    }
}
