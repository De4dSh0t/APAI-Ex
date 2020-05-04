using System;
using System.Runtime.ExceptionServices;
using NUnit.Framework;
using Stack_Genérica;

namespace Stack_Genérica.UnitTests
{
    public class DJDStackTests
    {
        [Test]
        public void Push_ResizeStack_SizeDoubles() //Verificar se a "Stack" duplica quando chegamos ao limite
        {
            //Arrange (Inicializamos os nossos objetos)
            var stack = new DJDStack<int>();
            
            //Act (Simulamos o input)
            for (int i = 0; i < 7; i++)
            {
                stack.Push(i);
            }
            
            //Assert (Verifica se o resultado foi correto)
            Assert.AreEqual(12, stack.size);
        }

        [Test]
        public void Pop_RemoveValueBelowIndexZero_InvalidOperationException() //Verificar se a exceção ocorre quando tentamos dar "Pop" com index < 0
        {
            //Arrange
            var stack = new DJDStack<int>();
            
            //Assert
            Assert.Throws<InvalidOperationException>(() => stack.Pop());
        }

        [Test]
        public void Peek_ShowValueBelowIndexZero_InvalidOperationException() //Verificar se a exceção ocorre quando tentamos dar "Peek" com index < 0
        {
            //Arrange
            var stack = new DJDStack<int>();
            
            //Assert
            Assert.Throws<InvalidOperationException>(() => stack.Peek());
        }

        [Test]
        public void Length_ShowLengthBelowIndexZero_InvalidOperationException() //Verificar se a exceção ocorre quando tentamos saber qual o tamanho em uso com index < 0
        {
            //Arrange
            var stack = new DJDStack<int>();
            
            //Assert
            Assert.Throws<InvalidOperationException>(() => stack.Lenght());
        }

        [Test]
        public void Length_ShowLengthAboveIndexZero_UsedStackLength() //Verificar se o método "Length()" dá o tamanho em uso da stack
        {
            //Arrange
            var stack = new DJDStack<int>();
            
            //Act
            stack.Push(5);
            
            //Assert
            Assert.AreEqual(1, stack.Lenght());
        }

        [Test]
        public void Capacity_ShowStackCapacity_Size() //Verificar se o método "Capacity()" dá o tamanho total da stack
        {
            //Arrange
            var stack = new DJDStack<int>();
            
            //Assert
            Assert.AreEqual(stack.size, stack.Capacity());
        }
    }
}