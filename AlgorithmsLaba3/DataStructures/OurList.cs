using AlgorithmsLaba3.Models;
using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography;
using System.Xml;

namespace AlgorithmsLaba3.DataStructures
{
    internal class OurList<T> : IEnumerable<T>
    {
        public Node<T> Head { get; private set; }
        public Node<T> Tail { get; private set; }
        public int Count { get; private set; }
        


        public OurList(T[] data)
        {
            AddArray(data);
        }
        public OurList(OurList<T> data)
        {
            AddOurList(data);
        }
        public OurList(T data)
        {
            SetHeadAndTail(data);
        }
        public OurList()
        {
            Clear();
        }



        public void AddLast(T data)
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
        public void AddFirst(T data)
        {
            if (Head == null)
            {
                SetHeadAndTail(data);
                return;
            }
            var item = new Node<T>(data);
            item.Next = Head;
            Head = item;
            Count++;
        }
        public void AddAfter(T after, T data)
        {
            ExceptionIsEmpty();
            var item = new Node<T>(data);
            var current = Head;
            while (current != null)
            {
                if (current.GetData().Equals(after))
                {
                    var next = current.Next;
                    current.Next = item;
                    item.Next = next;
                    Count++; 
                    if (Tail == current)
                    {
                        Tail = item;
                    }
                    return;
                }
                current = current.Next;
            }
            throw new Exception("Элемент не найден");
        }
        public void AddAfter(T after, OurList<T> data)
        {
            ExceptionIsEmpty();
            var current = Head;
            if (data.Equals(this))
            {
                data = new OurList<T>(data);
            }
            while (current != null)
            {
                if (current.GetData().Equals(after))
                {
                    var next = current.Next;
                    current.Next = new Node<T>(data.Head.GetData());
                    var currentTemp = data.Head.Next;
                    while (currentTemp != null)
                    {
                        current = current.Next;
                        current.Next = new Node<T>(currentTemp.GetData());
                        if (currentTemp.Next == null)
                        {
                            current = current.Next;
                            break;
                        }
                        currentTemp = currentTemp.Next;
                    }
                    current.Next = next;
                    Count += data.Count;
                    if (Tail.Next != null)
                    {
                        Tail = next;
                    }
                    return;
                }
                current = current.Next;
            }
            throw new Exception("Элемент не найден");
        }
        public void AddBefore(T before, T data)
        {
            var item = new Node<T>(data);
            ExceptionIsEmpty();
            if (Head.GetData().Equals(before))
            {
                item.Next = Head;
                Head = item;
                Count++;
                return;
            }
            var prev = Head;
            var current = prev.Next;
            while (current != null)
            {
                if (current.GetData().Equals(before))
                {
                    prev.Next = item;
                    item.Next = current;
                    Count++;
                    return;
                }
                prev = current;
                current = prev.Next;
            }
        }
        public void AddAndSort(T data)
        {
            AddLast(data);
            Sort();
        }
        public void AddArray(T[] data)
        {
            for (int i = 0; i < data.Length; i++)
            {
                AddLast(data[i]);
            }
        }
        public void RemoveFirst()
        {
            Head = Head.Next;
        }
        public void Remove(T data)
        {
            ExceptionIsEmpty();
            if (Head.GetData().Equals(data))
            {
                Head = Head.Next;
                Count--;
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
        public void RemoveAllIdentical(T data)
        {
            ExceptionIsEmpty();
            var prev = Head;
            var current = Head.Next;
            while (Head.GetData().Equals(data))
            {
                Head = Head.Next;
                Count--;
                prev = Head;
                current = Head.Next;
            }
            while (current != null)
            {
                if (current.GetData().Equals(data))
                {
                    prev.Next = current.Next;
                    Count--;
                    current = current.Next;
                    continue;
                }
                prev = current;
                current = current.Next;
            }
        }
        public void RemoveTheSecondFound(T data)
        {
            ExceptionIsEmpty();
            int CountOfIdentical = 0;
            if (Head.GetData().Equals(data))
            {
                Head = Head.Next;
                Count--;
                return;
            }
            var prev = Head;
            var current = Head.Next;
            while (current != null)
            {
                if (current.GetData().Equals(data))
                {
                    if (CountOfIdentical == 1)
                    {
                        prev.Next = current.Next;
                        Count--;
                        return;
                    }
                    CountOfIdentical++;
                }
                prev = current;
                current = current.Next;
            }
        }
        public void Clear()
        {
            Head = null;
            Tail = null;
            Count = 0;
        }
        public void Reverse()
        {
            ExceptionIsEmpty();
            if (Count == 0 && Count == 1)
            {
                return;
            }
            var prev = Head;
            var current = Head.Next;
            var next = current.Next;
            Head = Tail;
            Tail = prev;
            prev.Next = null;
            while (true)
            {
                current.Next = prev;
                prev = current;
                current = next;
                if (current == null)
                {
                    Tail.Next = null;
                    return;
                }
                next = current.Next;
            }
        }
        public void FirstToTail()
        {
            ExceptionIsEmpty();
            var current = Head;
            Tail.Next = Head;
            Head = Head.Next;
            current.Next = null;
        }
        public void LastToHead()
        {
            ExceptionIsEmpty();
            var curren = Head;
            var next = curren.Next;
            while (next.Next != null)
            {
                curren = curren.Next;
                next = curren.Next;
            }
            curren.Next = null;
            next.Next = Head;
            Tail = curren;
            Head = next;
        }
        public void Sort()
        {
            ExceptionIsEmpty();
            var arr = GetArrayData();
            Array.Sort(arr);
            Clear();
            AddArray(arr);
        }
        public void AddOurList(OurList<T> data)
        {
            var count = data.Count;
            var current = data.Head;
            for (int i = 0; i < count; i++)
            {
                AddLast(current.GetData());
                current = current.Next;
            }
        }
        public void Print()
        {
            foreach (var item in this)
            {
                Console.WriteLine(item);
            }
        }
        public void DoubleList()
        {
            AddOurList(this);
        }
        public void Swap(T first, T second)
        {
            var current = Head;
            Node<T> current1 = null;
            while (current != null)
            {
                if (current.GetData().Equals(first) || 
                    current.GetData().Equals(second))
                {
                    if (current1 != null)
                    {
                        var temp = current1.GetData();
                        current1.SetData(current.GetData());
                        current.SetData(temp);
                        return;
                    }
                    if (current1 == null)
                    {
                        current1 = current;
                    }
                }
                current = current.Next;
            }
        }



        public bool IsEmpty()
        {
            return Head != null;
        }
        public T FindFirst()
        {
            var data = Head.GetData();
            Head = Head.Next;
            return data;
        }
        public T Find(T data)
        {
            ExceptionIsEmpty();
            var current = Head;
            while (current != null)
            {
                if (current.GetData().Equals(data))
                {
                    return data;
                }
                current = current.Next;
            }
            throw new Exception("Элемент не найден");
        }
        public OurList<T> GiveAPiece(T data)
        {
            OurList<T> result = new OurList<T>();
            if (Head.GetData().Equals(data))
            {
                result.AddOurList(this);
                Clear();
                return result;
            }
            var prev = Head;
            var current = prev.Next;
            while (current != null)
            {
                if (current.GetData().Equals(data))
                {
                    Tail = prev;
                    prev.Next = null;
                    while (current != null)
                    {
                        Count--;
                        result.AddLast(current.GetData());
                        current = current.Next;
                    }
                    return result;
                }
                prev = current;
                current = prev.Next;
            }
            return null;
        }
        public OurList<T> GetUniqueItems()
        {
            ExceptionIsEmpty();
            OurList<T> result = new OurList<T>();
            result.AddLast(Head.GetData());
            var current = Head.Next;
            while (current != null)
            {
                if (!result.Contains(current.GetData()))
                {
                    result.AddLast(current.GetData());
                }
                current = current.Next;
            }
            return result;
        }
        public int GetCuontUniqueItems()
        {
            ExceptionIsEmpty();
            return GetUniqueItems().Count;
        }
        public bool Contains(T data)
        {
            ExceptionIsEmpty();
            if (Head != null)
            {
                var current = Head;
                while (current != null)
                {
                    if (current.GetData().Equals(data))
                    {
                        return true;
                    }
                    current = current.Next;
                }
            }
            return false;
        }
        public T[] GetArrayData()
        {
            ExceptionIsEmpty();
            T[] result = new T[Count];
            var current = Head;
            for (int i = 0; i < result.Length; i++)
            {
                result[i] = current.GetData();
                current = current.Next;
            }
            return result;
        }



        private void ExceptionIsEmpty()
        {
            if (Head == null)
            {
                throw new Exception("Связный список пустой");
            }
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