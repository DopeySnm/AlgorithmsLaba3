using AlgorithmsLaba3.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmsLaba3.DataStructures
{
    internal class OurTree<T> where T : IComparable
    {
        public NodeFree<T> Root { get;private set; }
        public OurTree(T data)
        {
            Root = new NodeFree<T>(data);
        }
        public void Add(T data)
        {
            var item = new NodeFree<T>(data);
            var current = Root;
            while (current.Left != null || current.Right != null)
            {
                if (item.GetHashCode() > current.GetHashCode())
                {
                    if (current.Right == null)
                    {
                        current.Right = item;
                        return;
                    }
                    current = current.Right;
                }
                else if (item.GetHashCode() < current.GetHashCode())
                {
                    if (current.Left == null)
                    {
                        current.Left = item;
                        return;
                    }
                    current = current.Left;
                }
            }
            if (data.GetHashCode() < current.Data.GetHashCode())
            {
                current.Left = item;
            }
            else if (data.GetHashCode() > current.Data.GetHashCode())
            {
                current.Right = item;
            }
        }
        public void Delete(T data)
        {

        }
    }
}
