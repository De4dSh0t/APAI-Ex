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
            else if (addI <= queue.Length-1)
            {
                queue[++addI] = n;
            }
            else if()
            {
                
            }
        }

        public T Dequeue()
        {
            if (removeI <= queue.Length - 1)
            { 
                return queue[removeI++];
            }
            else
            {
                removeI = 0;
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