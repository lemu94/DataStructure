using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace linkedlist
{
    public class LinkeList<T>
    {
        private Node<T>? Head = null;
        private int Count { get; set; } = 0;
        public LinkeList() { 

        
        }

        public void Add(T value)
        {
            
            if(this.Head == null)
            {
                this.Head = this.Create(value);
            }
            else
            {
                var current = this.Head;

                while(current.Next != null)
                {
                    current = current.Next;
                }

                current.Next = this.Create(value);
                this.IncreaseCount();
            }

        }

        
        public void DeleteAtIndex(int index)
        {
            this.CheckErrorIndex(index);

            if (index == 0)
            {
                this.Head = null;
            }
            else
            {
                var current = this.Head;
                var current_index = 0;

                while (current?.Next != null &&  current_index < index -1 )
                {
                    current = current.Next;
                    current_index++;
                }

                current!.Next = current?.Next?.Next;

                this.DecreaseCount();
                
            }

        }

        public void addIndex(int index, T value)
        {
            this.CheckErrorIndex(index);
            var nodes = this.Head;
            var newNode = this.Create(value);
            if(index == 0)
            {
                newNode.Next = nodes;
            }
            else
            {
                var current_index = 0;
                while (nodes?.Next != null && current_index < index -1 )
                {
                    nodes = nodes.Next;
                    current_index++;
                }

                newNode.Next = nodes?.Next;
                nodes!.Next = newNode;
                this.IncreaseCount();

            }


        }

        private void CheckErrorIndex(int index)
        {
            if (this.Head == null && index != 0)
            {
                throw new ArgumentOutOfRangeException("index");
            }
            if (index < 0 || index >= Count)
            {
                throw new IndexOutOfRangeException("index");
            }
        }


        public void AddBeginning(T value)
        {
            if( this.Head == null)
            {
                this.Head = this.Create(value);
            }
            else
            {
                var oldCurrent = this.Head;
                var current = this.Create(value);
                current.Next = oldCurrent;
                this.Head = current;
                this.IncreaseCount();
            }
        }


        public void ShowList()
        {
            var nodeToWhow = "";
            var current = this.Head;

            while(current != null)
            {
                nodeToWhow = nodeToWhow + " -> " + current.Value;
                current = current.Next;
            }

            Console.WriteLine(nodeToWhow);
        }

        private Node<T> Create(T value)
        {
            return new Node<T>(value);
        }

        private int DecreaseCount(){
            return this.Count--;
        }
        private int IncreaseCount(){
            return this.Count++;
        }

        public int getCount(){
            return this.Count +1;
        }


    }
}
