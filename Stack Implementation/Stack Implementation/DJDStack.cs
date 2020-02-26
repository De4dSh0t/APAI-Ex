using System;
using System.Collections;

namespace Stack_Implementation
{
    public class DJDStack
    {
        //Variável
        private int[] stack;
        private int index;

        //Construtor 1
        public DJDStack()
        {
            stack = new int[6];
        }

        //Construtor 2
        public DJDStack(int size)
        {
            stack = new int[size];
        }

        //Método Push
        public void Push(int val)
        {
            if(index == stack.Length) Console.WriteLine("Stack is full!");
            else
            {
                stack[index] = val;
                index++;
            }
        }
        
        //Método Pop
        public int Pop()
        {
            int currentVal = 0;
            if(index == 0) Console.WriteLine("Stack is empty!");
            else
            {
                index--;
                currentVal = stack[index];
            }
            return currentVal;
        }
        
        //Método Peek
        public void Peek()
        {
            if(index == 0) Console.WriteLine("Stack is empty!");
            else
            {
                Console.WriteLine("Current Values:");
                for (int i = 0; i < stack.Length; i++)
                {
                    Console.WriteLine(stack[i]);
                }
            }
        }
    }
}