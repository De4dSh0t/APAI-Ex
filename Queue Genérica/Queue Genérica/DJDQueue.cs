using System;
using System.ComponentModel.DataAnnotations;
using System.Reflection.Metadata.Ecma335;
using System.Transactions;

namespace Queue_Genérica
{
    public class DJDQueue<T>
    {
        private T[] queue;
        private int frontI = -1; //Index da parte frontal da Queue (onde removemos os valores)
        private int rearI = -1; //Index da parte traseira da Queue (onde adicionamos os valores)

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
            if ((frontI == 0 && rearI == queue.Length-1) || frontI == rearI - 1) //Determina se a 'queue' está cheia.
            {
                throw new InvalidOperationException("Queue is full!");
            }
            else
            {
                if (frontI == -1 && rearI == -1) //Caso queiramos colocar um valor, os dois indexs incrementam (quando estão ambos na posição -1).
                {
                    frontI++;
                    rearI++;
                }
                else if(rearI == queue.Length - 1) //Serve para limitar o avanço do 'rearI'. Caso chegue ao limite, a sua posição volta a 0.
                {
                    rearI = 0;
                }
                else //Se nenhuma das condições anteriores forem verdadeiras, o 'rearI' incrementa.
                {
                    rearI++;
                }

                queue[rearI] = n;
            }
        }

        public T Dequeue()
        {
            if (frontI == -1) //Determina se a 'queue' está vazia. Igualo a -1 pois, no 'Enqueue', quando colocamos um valor na 'queue' pela primeira vez, os dois indexs igualam a 0.
            {
                throw new InvalidOperationException("Queue is empty!");
            }

            if (frontI == rearI) //Indica quando removemos o último valor da 'queue'.
            {
                frontI = -1;
                rearI = -1;
            }
            else if (frontI == queue.Length - 1) //Faz com que, caso o 'frontI' chegue ao limite da 'queue', seja reposto para a posição 0.
            {
                frontI = 0;
            }
            else //Caso nenhuma das condições anteriores sejam verdadeiras, faz com que o 'frontI' incremente.
            {
                frontI++;
            }

            return queue[frontI];
        }

        public T Peek()
        {
            if (frontI < 0)
            {
                throw new InvalidOperationException("Queue is empty!");
            }
            
            return queue[rearI];
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