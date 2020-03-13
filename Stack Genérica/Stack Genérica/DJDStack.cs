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

        public void Push(T n) //Insere um valor "n" na "Stack"
        {
            //Aumenta o tamanho da "Stack" para o dobro, caso o index alcançe o fim
            if(index == size)
            {
                Array.Resize(ref stack, 2*size);
                size = 2*size;
            }

            stack[++index] = n;
        }

        public T Pop() //Remove o último elemento da "Stack" (LIFO)
        {
            if(index >= 0)
            {
                return stack[index--];
            }
            else
            {
                throw new InvalidOperationException("Stack is empty!");
            }
        }

        public T Peek() //Apresenta o último elemento inserido
        {
            if(index >= 0)
            {
                return stack[index];
            }
            else
            {
                throw new InvalidOperationException("Stack is empty!");
            }
        }

        public int Lenght() //Diz o nº de elementos em uso na "Stack"
        {
            if(index >= 0)
            {
                return index;
            }
            else
            {
                throw new InvalidOperationException("Stack is empty!");
            }
        }

        public int Capacity() //Diz o tamanho total da "Stack"
        {
            return size;
        }
    }
}