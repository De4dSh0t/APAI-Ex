using System;

namespace Stack_Genérica
{
    public class DJDStack<T>
    {
        T[] stack;
        private int index;
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

        public void Push(int n)
        {
            //Aumenta o tamanho da "Stack" para o dobro, caso o index alcançe o fim
            if(index == size)
            {
                Array.Resize(ref stack, 2*size);
                size = 2*size;
            }


        }
    }
}
