using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmsLaba3.Models
{
    internal class NodeFree<T>
    {
        public NodeFree<T> Left { get; set; }
        public NodeFree<T> Right { get; set; }
        public T Data { get; set; }
        public NodeFree(T data)
        {
            Data = data;
        }
        public override int GetHashCode()
        {
            return Data.GetHashCode();
        }
    }
}
