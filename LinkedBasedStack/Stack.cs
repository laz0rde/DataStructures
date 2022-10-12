using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedBasedArray
{
    class StackNode<T>
    {
        public T entry { get; internal set; }
        public StackNode<T> next { get; set; }
    }
    class LinkedStack<T>
    {
        StackNode<T> node;

        public LinkedStack()
        {
            node = null;
        }
        public void Push(T entry)
        {
            StackNode <T> newnode = new StackNode<T>();
            newnode.entry = entry;
            newnode.next = node;
            node = newnode;
        }

        public T Pop()
        {
            T ele = node.entry;
            node = node.next;
            return ele;
        }

       public T Peek()
        {
            return node.entry;
        }


    }
}
