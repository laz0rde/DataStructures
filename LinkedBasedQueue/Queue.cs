using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedBasedQueue
{

    class QueueNode<T>
    {
        public T entry { get; internal set; }
        public QueueNode<T> next { get; internal set; }
    }
    internal class LinkedQueue<T>
    {
        QueueNode<T> fNode;
        QueueNode<T> rNode;
        int size;

        public LinkedQueue()
        {
            fNode = null;
            rNode = null;
            size = 0;
        }

        public void Append(T el)
        {
            QueueNode<T> helpNode = new QueueNode<T>();
            helpNode.entry = el;
            helpNode.next = null;
            if (rNode == null)
                fNode = helpNode;
            else
                rNode.next = helpNode;
            rNode = helpNode;
            size++;
        }

        public T Serve()
        {
            T el;
            el = fNode.entry;
            fNode = fNode.next;
            if (fNode == null)
                rNode = null;
            size--;
            return el;
        }

        public int Count()
        {
            return size;
        }

        public bool QueueFull()
        {
            return false;
        }

        public bool QueueEmpty()
        {
            return (size == 0) ? true : false;
        }
    }
}
