using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmsLaba3.Models
{
    internal class Node<T>
    {
        private T data = default(T);
        public Node<T> Next { get; set; }
        public Node(T data)
        {
            SetData(data);
        }
        public void SetData(T data)
        {
            if (data != null)
            {
                this.data = data;
            }
        }
        public T GetData()
        {
            return data;
        }
    }
}
