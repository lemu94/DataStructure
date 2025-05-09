﻿using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace linkedlist
{
    public interface ILinkedList<T>
    {
        int getCount();
        void Add(T value);
        void DeleteAtIndex(int index);
        void AddAtIndex(int index, T value);
        void AddBeginning(T value);
        void DeleteAtBeginning();
        T SearchByPosition(int index);
        void ShowList();
    }

    public class LinkeList<T> : ILinkedList<T>
    {
        private Node<T>? Head = null;
        private int Count { get; set; } = 0;
        public LinkeList() { }

        public int getCount()
        {
            return this.Count ;
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
            }

            this.IncreaseCount();


        }

        public T SearchByPosition(int index)
        {
            this.CheckErrorIndex(index);
            var current = this.Head;

            if (index == 0)
            {
                return current.Value;
            }
            else
            {
                var current_index = 0;
                
                while (current.Next != null)
                {
                    if (index == current_index)
                    {
                        break;
                    }
                    current = current.Next;
                    current_index++;

                }
            }
            return  current.Value;
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
                
            }

            this.DecreaseCount();


        }
        public void AddAtIndex(int index, T value)
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

            }

            this.IncreaseCount();

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
            }

            this.IncreaseCount();

        }
        public void DeleteAtBeginning()
        {
            if(this.Head == null)
            {
                throw new InvalidOperationException(new StackTrace()?.GetFrame(0)?.GetMethod()?.Name);
            }
            else
            {
                var current = this.Head;
                this.Head = current.Next;
                this.DecreaseCount();
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

        private void CheckErrorIndex(int index)
        {
            if(this.Count == 0)
            {
                throw new ArgumentOutOfRangeException("index");
            }
            if (this.Head == null && index != 0)
            {
                throw new ArgumentOutOfRangeException("index");
            }
            if (index < 0 || index > Count)
            {
                throw new IndexOutOfRangeException("index");
            }
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




    }
}
