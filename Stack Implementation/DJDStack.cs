using System;

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
            if(index < stack.Length)
            {
                stack[index] = val;
                index++;
            }
            else
            {
                throw new InvalidOperationException("Stack is full!");
            }
        }
        
        //Método Pop
        public int Pop()
        {
            int currentVal = 0;
            if(index > 0)
            {
                index--;
                currentVal = stack[index];
            }
            else
            {
                throw new InvalidOperationException("Stack is empty!");
            }
            return currentVal;
        }
        
        //Método Peek
        public void Peek()
        {
            if(index > 0)
            {
                Console.WriteLine("Current Values:");
                for (int i = 0; i < stack.Length; i++)
                {
                    Console.WriteLine(stack[i]);
                }
            }
            else
            {
                throw new InvalidOperationException("Empty Stack!");
            }
        }
    }
}