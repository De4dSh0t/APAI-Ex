using System;
using System.Collections.Specialized;

namespace Stack_Implementation
{
    class Program
    {
        static void Main(string[] args)
        {
            //Inicializar:
            //Caso não seja definido previamente um tamanho, a "DJDStack" irá iniciar com um tamanho 6.
            DJDStack stack = new DJDStack();
            
            //Programa
            bool flag = false;

            while (!flag)
            {
                ConsoleKeyInfo info = Console.ReadKey(); //Lê o input do user
                
                Console.WriteLine("");
                Console.WriteLine("///////// DJDStack Implementation /////////");
                Console.WriteLine("");
                Console.WriteLine("(1) Push");
                Console.WriteLine("(2) Pop");
                Console.WriteLine("(3) Peek");
                Console.WriteLine("(0) Exit");
                Console.WriteLine("");
                Console.WriteLine("///////////////////////////////////////////");
                if (info.KeyChar == '1')
                {
                    Console.Write("Insert value to push: ");
                    string val = Console.ReadLine();
                    int n;
                    if (int.TryParse(val, out n)) stack.Push(n);
                    else Console.WriteLine("Invalid input!");
                }
                if (info.KeyChar == '2')
                {
                    int popVal = stack.Pop();
                    Console.WriteLine("You removed the value " + popVal);
                }
                if (info.KeyChar == '3')
                {
                    stack.Peek();
                }
                if (info.KeyChar == '0')
                {
                    flag = true;
                }
            }
        }
    }
}