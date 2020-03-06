using System;

namespace Queue_Implementation
{
    class Program
    {
        static void Main(string[] args)
        {
            DJDQueue queue = new DJDQueue();
            
            //Programa
            bool flag = false;

            while (!flag)
            {
                ConsoleKeyInfo info = Console.ReadKey(); //Lê o input do user
                
                Console.WriteLine("");
                Console.WriteLine("///////// DJDQueue Implementation /////////");
                Console.WriteLine("");
                Console.WriteLine("(1) Enqueue");
                Console.WriteLine("(2) Dequeue");
                Console.WriteLine("(3) Peek");
                Console.WriteLine("(0) Exit");
                Console.WriteLine("");
                Console.WriteLine("///////////////////////////////////////////");
                if (info.KeyChar == '1')
                {
                    Console.Write("Insert value to enqueue: ");
                    string val = Console.ReadLine();
                    int n;
                    if (int.TryParse(val, out n)) queue.Enqueue(n);
                    else Console.WriteLine("Invalid input!");
                }
                if (info.KeyChar == '2')
                {
                    int dequeueVal = queue.Dequeue();
                    Console.WriteLine($"You removed the value {dequeueVal}");
                }
                if (info.KeyChar == '3')
                {
                    Console.WriteLine(queue.Peek());
                }
                if (info.KeyChar == '0')
                {
                    flag = true;
                }
            }
        }
    }
}
