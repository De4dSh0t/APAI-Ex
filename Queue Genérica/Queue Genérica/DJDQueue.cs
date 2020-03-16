using System;

namespace Queue_Genérica
{
    public class DJDQueue<T>
    {
        private T[] queue;

        public DJDQueue()
        {
            queue = new T[6];
        }

        public DJDQueue(int s)
        {
            queue = new T[s];
        }

        public void Enqueue(int n)
        {
            
        }
    }
}