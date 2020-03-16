using System;

namespace Queue_Implementation
{
    public class DJDQueue
    {
        private int[] queue;
        private int index = 0;
        private int removeI = -1; //Indica o valor da posição da Queue na qual irá remover o primeiro elemento

        //Construtor 1
        public DJDQueue()
        {
            queue = new int[6];
        }

        //Construtor 2
        public DJDQueue(int size)
        {
            queue = new int[size];
        }

        //Método Enqueue()
        public void Enqueue(int n)
        {
            if(index != removeI) //Serve para simular o limite do Queue. Caso o index seja igual ao 'removeI', então o 'Enqueu' para.
            {
                if (index < queue.Length)
                {
                    queue[index++] = n;
                }
                else if(index == queue.Length-1)
                {
                    index = 0;
                }
            }
            else
            {
                Console.WriteLine("Queue is full! Please 'Dequeue' to be able to add more to the queue.");
            }
        }

        //Método Dequeue()
        public int Dequeue()
        {
            if (index >= 0)
            {
                if(removeI != index-1) //Faz com que o "removeI" deixe de "avançar" até que o "index" avançe
                {
                    if(removeI < queue.Length-1)
                    {
                        return queue[++removeI];
                    }
                    else if(removeI > queue.Length-1)
                    {
                        removeI = -1;
                        return queue[++removeI];
                    }
                }
                else
                {
                    Console.WriteLine("Seems like you didn't 'Enqueue' another value!");
                }
            }

            return 0;
        }

        //Método Peek()
        public int Peek()
        {
            int next = removeI + 1;

            if (index > 0)
            {
                return queue[next];
            }

            return 0;
        }
    }
}