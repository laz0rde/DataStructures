using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stack
{
    class ArrayStack<T>
    {
        private int top;
        private int MAXSTACK;
        private T[] stackEntry;

        public ArrayStack(int MAXSTACK)
        {
            this.MAXSTACK = MAXSTACK;
            this.top = 0;
            stackEntry = new T[MAXSTACK];
        }

        public void Push(T entry)
        {
            stackEntry[top++] = entry;
        }

        public T Pop()
        {
            return stackEntry[--top];
        }

        public int StackFull()
        {
            return (top == MAXSTACK) ? 1 : 0;
        }

        public int StackEmpty()
        {
            return (top == 0) ? 1 : 0;
        }

        public int StackSize()
        {
            return top;
        }

        public T StackTop()
        {
            return stackEntry[top-1];
        }

        public void ClearStack()
        {
            top = 0;
        }
    }
}
