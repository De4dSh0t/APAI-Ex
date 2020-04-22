using System;

namespace Tarefa3
{
    class Program
    {
        static void Main(string[] args)
        {
            WriteTXT.Write(ReadTXT.Read("lines.txt"));
        }
    }
}