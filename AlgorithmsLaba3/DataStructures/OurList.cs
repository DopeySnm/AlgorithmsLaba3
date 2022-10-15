using AlgorithmsLaba3.Models;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmsLaba3.DataStructures
{
    internal class OurList<T> : IEnumerable<T>
    {
        public Node<T> Head { get; private set; }
        public Node<T> Tail { get; private set; }
        public int Count { get; private set; }
        public OurList(T data)
        {
            SetHeadAndTail(data);
        }
        public OurList()
        {
            Clear();
        }
        public void Add(T data)
        {
            if (Head == null)
            {
                SetHeadAndTail(data);
                return;
            }
            var item = new Node<T>(data);
            Tail.Next = item;
            Tail = item;
            Count++;
        }
        public void Delete(T data)
        {
            if (Head != null)
            {
                if (Head.GetData().Equals(data))
                {
                    Head = Head.Next;
                    return;
                }
                var prev = Head;
                var current = Head.Next;
                while (current != null)
                {
                    if (current.GetData().Equals(data))
                    {
                        prev.Next = current.Next;
                        Count--;
                        return;
                    }
                    prev = current;
                    current = current.Next;
                }
            }
            else
            {
                SetHeadAndTail(data);
            }
        }
        public void Clear()
        {
            Head = null;
            Tail = null;
            Count = 0;
        }
        private void SetHeadAndTail(T data)
        {
            var item = new Node<T>(data);
            Head = item;
            Tail = item;
            Count = 1;
        }
        public IEnumerator<T> GetEnumerator()
        {
            var current = Head;
            while (current != null)
            {
                yield return current.GetData();
                current = current.Next;
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            throw new NotImplementedException();
        }
    }
}
