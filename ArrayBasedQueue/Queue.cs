using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayQueue
{
    internal class Queue<T>
    {
        private int front;
        private int rear;
        private int MAXQUEUE;
        private int size;
        T[] QueueEntry;

        public Queue(int MAXSTACK)
        {
            front = 0;
            rear = -1;
            this.MAXQUEUE = MAXSTACK;
            this.size = 0;
            QueueEntry = new T[MAXSTACK];
        }

        public void Append(T entry)
        {
            rear = (rear + 1)% MAXQUEUE;
            QueueEntry[rear] = entry;
            size++;
        }

        public T Serve()
        {
            T holder;
            holder = QueueEntry[front];
            front = (front + 1) % MAXQUEUE;
            size--;
            return holder;
        }

        public int Count()
        {
            return size;
        }

        public bool QueueFull()
        {
            return (size == MAXQUEUE) ? true : false;
        }

        public bool QueueEmpty()
        {
            return (size == 0) ? true : false;
        }
    }
}
