using System;

namespace Stack_Genérica
{
    public class DJDStack<T>
    {
        T[] stack;
        private int index = -1;
        private int size;

        public DJDStack()
        {
            size = 6;
            stack = new T[6];
        }

        public DJDStack(int s)
        {
            size = s;
            stack = new T[size];
        }

        public void Push(T n)
        {
            //Aumenta o tamanho da "Stack" para o dobro, caso o index alcançe o fim
            if(index == size)
            {
                Array.Resize(ref stack, 2*size);
                size = 2*size;
            }

            stack[++index] = n;
        }

        public T Pop()
        {
            return stack[index--];
        }

        public T Peek()
        {
            if(index >= 0)
            {
                return stack[index];
            }
            else
            {
                throw new InvalidOperationException();
            }
        }

        public int Lenght()
        {
            return index;
        }

        public int Capacity()
        {
            return size;
        }
    }
}
