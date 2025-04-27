using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace linkedlist
{
    public class Node <T>
    {
        public T Value;
        public Node<T>? Next;
        public Node (T value) {
            this.Value = value;
            this.Next = null;
        }
    }
}
