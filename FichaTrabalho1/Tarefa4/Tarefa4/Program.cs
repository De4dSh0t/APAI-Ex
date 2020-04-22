using System;

namespace Tarefa4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("First word: ");
            string word1 = Console.ReadLine();
            Console.WriteLine("-------------");
            Console.WriteLine("Second word: ");
            string word2 = Console.ReadLine();
            Console.WriteLine("-------------");
            Console.WriteLine($"Is anagram? {Anagram.IsAnagram(word1, word2)}");
        }
    }
}