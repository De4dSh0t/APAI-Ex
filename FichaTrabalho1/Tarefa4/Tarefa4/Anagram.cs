using System;

namespace Tarefa4
{
    public class Anagram
    {
        public static bool IsAnagram(string s1, string s2)
        {
            //Se existir alguma diferença entre o tamanho das strings, então não é um anagrama
            if (s1.Length < s2.Length)
            {
                return false;
            }
            
            char[] c1 = s1.ToLower().ToCharArray();
            char[] c2 = s2.ToLower().ToCharArray();
            
            //Ordena alfabeticamente o array de char
            Array.Sort(c1);
            Array.Sort(c2);
            
            //Como uma string é um array de chars, "s1" e "s2" tornam-se uma nova string dos respetivos arrays de char
            s1 = new string(c1);
            s2 = new string(c2);

            return s1 == s2;
        }
    }
}