using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace linkedlist 
{
    public class Queue <T>
    {
        private LinkeList<T> list;
        private int Count = 0;
        public Queue() { 
            this.list = new LinkeList<T>();
        }

        public void Enqueue(T value)
        {
            this.list.Add(value);
        }

        public int GetCount()
        {
            return this.list.getCount();
        }

        public void Dequeue()
        {
            this.list.DeleteAtBeginning();
        }

        public T Peek()
        {
            return this.list.SearchByPosition(0);
        }
        public void Show()
        {
            this.list.ShowList();
        }

    }
}
