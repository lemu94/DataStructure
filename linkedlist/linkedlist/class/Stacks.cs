using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace linkedlist
{
    public class Stacks<T>
    {
        private LinkeList<T> list;
        public Stacks() { 

            this.list = new LinkeList<T>();
        }
        public void Push(T item)
        {
            this.list.Add(item);
        }
        public void Pop()
        {
            this.list.DeleteAtIndex(this.GetCount() - 1);
        }

        public T Peek()
        {
            return this.list.SearchByPosition(this.GetCount() - 1);
        }

        public void Show()
        {
           this.list.ShowList();
        }
        public int GetCount()
        {
           return  this.list.getCount();
        }



    }
}
