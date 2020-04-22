using System;
using System.Collections.Generic;

namespace Tarefa1
{
    class Program
    {
        static void Main(string[] args)
        {
            ReadText rT = new ReadText("lyrics.txt");
            string[] lyrics = rT.Read().Split(" ", StringSplitOptions.RemoveEmptyEntries);

            Dictionary<string, int> wordCount = new Dictionary<string, int>();
            for (int i = 0; i < lyrics.Length; i++)
            {
                if (wordCount.ContainsKey(lyrics[i])) //Verifica se uma das Keys tem um nome igual ao que vai ser inserido "lyrics[i]"
                {
                    wordCount[lyrics[i]] += 1;
                }
                else //Caso não tenha um nome igual, então adiciona a "lyrics[i]" como Key no dicionário
                {
                    wordCount.Add(lyrics[i], 1);
                }
            }

            Console.WriteLine("----------------------");
            Console.WriteLine("      Word Count      ");
            Console.WriteLine("----------------------");
            foreach (KeyValuePair<string, int> wC in wordCount)
            {
                Console.WriteLine($"{wC.Key}: {wC.Value}");
            }
            Console.WriteLine("----------------------");
            Console.WriteLine("    Repeated Words    ");
            Console.WriteLine("----------------------");
            foreach (var wC in wordCount)
            {
                if (wC.Value > 1)
                {
                    Console.WriteLine($"{wC.Key} as repeated {wC.Value} times.");
                }
            }
        }
    }
}