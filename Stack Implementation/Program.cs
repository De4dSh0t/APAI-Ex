using System;

namespace Stack_Implementation
{
    class Program
    {
        static void Main(string[] args)
        {
            //Inicializar:
            //Caso não seja definido previamente um tamanho, a "DJDStack" irá iniciar com um tamanho 6.
            DJDStack stack = new DJDStack(10);
            
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
                    try
                    {
                        if (int.TryParse(val, out n)) stack.Push(n);
                    }
                    catch (InvalidOperationException e)
                    {
                        Console.WriteLine(e.Message);
                    }
                    //else Console.WriteLine("Invalid input!");
                }
                if (info.KeyChar == '2')
                {
                    try
                    {
                        int popVal = stack.Pop();
                        Console.WriteLine("You removed the value " + popVal);
                    }
                    catch (InvalidOperationException e)
                    {
                        Console.WriteLine(e.Message);
                    }
                }
                if (info.KeyChar == '3')
                {
                    try
                    {
                        stack.Peek();
                    }
                    catch (InvalidOperationException e)
                    {
                        Console.WriteLine(e.Message);
                    }
                }
                if (info.KeyChar == '0')
                {
                    flag = true;
                }
            }
        }
    }
}
