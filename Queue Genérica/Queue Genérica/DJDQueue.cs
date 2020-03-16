using System;
using System.ComponentModel.DataAnnotations;
using System.Reflection.Metadata.Ecma335;

namespace Queue_Genérica
{
    public class DJDQueue<T>
    {
        private T[] queue;
        private int addI = -1; //Index para Adicionar (Enqueue)
        private int removeI = 0; //Index para Remover (Dequeue)

        public DJDQueue()
        {
            queue = new T[6];
        }

        public DJDQueue(int s)
        {
            queue = new T[s];
        }

        public void Enqueue(T n)
        {
            if ((addI == queue.Length-1 && removeI == 0) || addI == removeI)
            {
                throw new InvalidOperationException("Queue is full!");
            }
            
            if(addI == queue.Length - 1)
            {
                addI = 0;
                queue[addI] = n;
            }
            else
            {
                queue[++addI] = n;
            }
        }

        public T Dequeue()
        {
            if (addI < 0)
            {
                throw new InvalidOperationException("Queue is empty!");
            }

            if (removeI == queue.Length - 1)
            {
                removeI = 0;
                return queue[removeI++];
            }
            else
            {
                return queue[removeI++];
            }
        }

        public T Peek()
        {
            return queue[removeI];
        }

        public int Length()
        {
            
        }

        public int Capacity()
        {
            return queue.Length;
        }
    }
}