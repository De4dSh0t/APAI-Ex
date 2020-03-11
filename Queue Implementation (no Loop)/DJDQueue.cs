namespace Queue_Implementation
{
    public class DJDQueue
    {
        private int[] queue;
        private int index = 0;

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
            if (index < queue.Length)
            {
                queue[index++] = n;
            }
        }

        //Método Dequeue()
        public int Dequeue()
        {
            int first = queue[0]; //Indica o valor da primeira posição da Queue
            if (index >= 0)
            {
                //Mover os outros valores de forma a que o "Dequeue()" retire o primeiro valor
                for (int i = 0; i < queue.Length - 1; i++)
                {
                    queue[i] = queue[i + 1];
                }

                --index;
                return first;
            }

            return 0;
        }

        //Método Peek()
        public int Peek()
        {
            if (index > 0)
            {
                return queue[--index];
            }

            return 0;
        }
    }
}