using System;
using NUnit.Framework;

namespace Queue_Genérica.UnitTests
{
    public class DJDQueueTests
    {
        [Test]
        public void Enqueue_TryAddWhenFull_InvalidOperationException() //Verificar se recebemos a exceção "InvalidOperationException" quando tentamos adicionar valores no limite da 'queue'
        {
            var queue = new DJDQueue<int>();

            for (int i = 0; i < queue.size; i++) //Simulo que a queue está cheia
            {
                 queue.Enqueue(i);
            }

            Assert.Throws<InvalidOperationException>(() => queue.Enqueue(1)); //Tento adicionar mais um valor à 'queue'. Expectativa: Dar a exceção "InvalidOperationException".
        }

        [Test]
        public void Dequeue_TryRemoveWhenEmpty_InvalidOperationException() //Verificar se recebemos a exceção "InvalidOperationException" quando tentamos remover valores numa 'queue' vazia
        {
            var queue = new DJDQueue<int>();

            Assert.Throws<InvalidOperationException>(() => queue.Dequeue()); //Tento remover um valor da 'queue' vazia. Expectativa: Dar a exceção "InvalidOperationException".
        }

        [Test]
        public void Peek_ShowValueBellowIndexZero_InvalidOperationException() //Verificar se recebemos a exceção "InvalidOperationException" quando tentamos ver a 'queue' sem qualquer valor inserido
        {
            var queue = new DJDQueue<int>();

            Assert.Throws<InvalidOperationException>(() => queue.Peek());
        }

        [Test]
        public void Capacity_ShowQueueCapacity_Size() //Verificar se o método "Capacity()" dá o tamanho total da queue
        {
            var queue = new DJDQueue<int>();
            
            Assert.AreEqual(queue.size, queue.Capacity());
        }
    }
}